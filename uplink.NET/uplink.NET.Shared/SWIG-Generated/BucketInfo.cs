//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace uplink.SWIG {

internal class BucketInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BucketInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BucketInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BucketInfo() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          storj_uplinkPINVOKE.delete_BucketInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string name {
    set {
      storj_uplinkPINVOKE.BucketInfo_name_set(swigCPtr, value);
    } 
    get {
      string ret = storj_uplinkPINVOKE.BucketInfo_name_get(swigCPtr);
      return ret;
    } 
  }

  public long created {
    set {
      storj_uplinkPINVOKE.BucketInfo_created_set(swigCPtr, value);
    } 
    get {
      long ret = storj_uplinkPINVOKE.BucketInfo_created_get(swigCPtr);
      return ret;
    } 
  }

  public CipherSuite path_cipher {
    set {
      storj_uplinkPINVOKE.BucketInfo_path_cipher_set(swigCPtr, (int)value);
    } 
    get {
      CipherSuite ret = (CipherSuite)storj_uplinkPINVOKE.BucketInfo_path_cipher_get(swigCPtr);
      return ret;
    } 
  }

  public ulong segment_size {
    set {
      storj_uplinkPINVOKE.BucketInfo_segment_size_set(swigCPtr, value);
    } 
    get {
      ulong ret = storj_uplinkPINVOKE.BucketInfo_segment_size_get(swigCPtr);
      return ret;
    } 
  }

  public EncryptionParameters encryption_parameters {
    set {
      storj_uplinkPINVOKE.BucketInfo_encryption_parameters_set(swigCPtr, EncryptionParameters.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = storj_uplinkPINVOKE.BucketInfo_encryption_parameters_get(swigCPtr);
      EncryptionParameters ret = (cPtr == global::System.IntPtr.Zero) ? null : new EncryptionParameters(cPtr, false);
      return ret;
    } 
  }

  public RedundancyScheme redundancy_scheme {
    set {
      storj_uplinkPINVOKE.BucketInfo_redundancy_scheme_set(swigCPtr, RedundancyScheme.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = storj_uplinkPINVOKE.BucketInfo_redundancy_scheme_get(swigCPtr);
      RedundancyScheme ret = (cPtr == global::System.IntPtr.Zero) ? null : new RedundancyScheme(cPtr, false);
      return ret;
    } 
  }

  public BucketInfo() : this(storj_uplinkPINVOKE.new_BucketInfo(), true) {
  }

}

}
