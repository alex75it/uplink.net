//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace uplink.SWIG {

public class _GoString_ : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal _GoString_(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(_GoString_ obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~_GoString_() {
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
          storj_uplinkPINVOKE.delete__GoString_(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string p {
    set {
      storj_uplinkPINVOKE._GoString__p_set(swigCPtr, value);
    } 
    get {
      string ret = storj_uplinkPINVOKE._GoString__p_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_ptrdiff_t n {
    set {
      storj_uplinkPINVOKE._GoString__n_set(swigCPtr, SWIGTYPE_p_ptrdiff_t.getCPtr(value));
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_ptrdiff_t ret = new SWIGTYPE_p_ptrdiff_t(storj_uplinkPINVOKE._GoString__n_get(swigCPtr), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public _GoString_() : this(storj_uplinkPINVOKE.new__GoString_(), true) {
  }

}

}
