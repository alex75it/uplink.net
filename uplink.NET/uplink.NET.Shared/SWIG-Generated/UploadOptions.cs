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

internal class UploadOptions : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UploadOptions(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UploadOptions obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UploadOptions() {
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
          storj_uplinkPINVOKE.delete_UploadOptions(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string content_type {
    set {
      storj_uplinkPINVOKE.UploadOptions_content_type_set(swigCPtr, value);
    } 
    get {
      string ret = storj_uplinkPINVOKE.UploadOptions_content_type_get(swigCPtr);
      return ret;
    } 
  }

  public long expires {
    set {
      storj_uplinkPINVOKE.UploadOptions_expires_set(swigCPtr, value);
    } 
    get {
      long ret = storj_uplinkPINVOKE.UploadOptions_expires_get(swigCPtr);
      return ret;
    } 
  }

  public UploadOptions() : this(storj_uplinkPINVOKE.new_UploadOptions(), true) {
  }

}

}
