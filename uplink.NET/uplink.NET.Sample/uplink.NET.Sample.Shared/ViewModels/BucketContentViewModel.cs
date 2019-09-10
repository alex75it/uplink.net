﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using uplink.NET.Interfaces;
using uplink.NET.Models;
using uplink.NET.Sample.Shared.Interfaces;
using System.Linq;
using System.Windows.Input;
using uplink.NET.Sample.Shared.Commands;

namespace uplink.NET.Sample.Shared.ViewModels
{
    public class BucketContentViewModel : BaseViewModel
    {
        public static Dictionary<string, List<UploadOperation>> ActiveUploadOperations = new Dictionary<string, List<UploadOperation>>();
        public ObservableCollection<BucketEntryViewModel> Entries { get; set; }
        public string BucketName { get; set; }
        public ICommand GoBackCommand { get; set; }
        public ICommand UploadFileCommand { get; set; }

        IObjectService _objectService;
        IBucketService _bucketService;
        IStorjService _storjService;
        ILoginService _loginService;

        public BucketContentViewModel(IObjectService objectService, IBucketService bucketService, IStorjService storjService, ILoginService loginService, string bucketName)
        {
            Entries = new ObservableCollection<BucketEntryViewModel>();

            _objectService = objectService;
            _bucketService = bucketService;
            _storjService = storjService;
            _loginService = loginService;
            BucketName = bucketName;

            GoBackCommand = new GoBackCommand();
            UploadFileCommand = new UploadFileCommand(this, objectService, bucketService, storjService, loginService, BucketName);

            InitAsync();
        }

        public async Task Refresh()
        {
            Entries.Clear();
            await InitAsync();
        }

        private async Task InitAsync()
        {
            StartLoading();

            //Load all options
            try
            {
                var bucket = await _bucketService.OpenBucketAsync(_storjService.Project, BucketName, EncryptionAccess.FromPassphrase(_storjService.Project, _loginService.GetLoginData().Secret));
                var listOptions = new ListOptions();
                listOptions.Direction = ListDirection.STORJ_FORWARD;
                var objects = await _objectService.ListObjectsAsync(bucket, listOptions);
                foreach (var obj in objects.Items)
                {
                    var entry = new BucketEntryViewModel(this);
                    entry.IsObject = true;
                    entry.ObjectInfo = obj;
                    Entries.Add(entry);
                }
            }
            catch(Exception ex)
            {
                Windows.UI.Popups.MessageDialog dialog = new Windows.UI.Popups.MessageDialog("Could not open bucket - " + ex.Message);
                await dialog.ShowAsync();
            }

            //Fetch all UploadOperations
            var uploadOperations = (ActiveUploadOperations.Where(u => u.Key == BucketName)).FirstOrDefault();
            if (uploadOperations.Value != null)
            {
                foreach (var uploadOperation in uploadOperations.Value)
                {
                    var entry = new BucketEntryViewModel(this);
                    entry.IsUploadOperation = true;
                    entry.UploadOperation = uploadOperation;
                    entry.InitUploadOperation();
                    Entries.Add(entry);
                }
            }

            DoneLoading();
        }
    }
}
