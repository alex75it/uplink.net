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

internal class SharePrefix : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SharePrefix(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SharePrefix obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SharePrefix() {
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
          storj_uplinkPINVOKE.delete_SharePrefix(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string bucket {
    set {
      storj_uplinkPINVOKE.SharePrefix_bucket_set(swigCPtr, value);
    } 
    get {
      string ret = storj_uplinkPINVOKE.SharePrefix_bucket_get(swigCPtr);
      return ret;
    } 
  }

  public string prefix {
    set {
      storj_uplinkPINVOKE.SharePrefix_prefix_set(swigCPtr, value);
    } 
    get {
      string ret = storj_uplinkPINVOKE.SharePrefix_prefix_get(swigCPtr);
      return ret;
    } 
  }

  public SharePrefix() : this(storj_uplinkPINVOKE.new_SharePrefix(), true) {
  }

}

}
