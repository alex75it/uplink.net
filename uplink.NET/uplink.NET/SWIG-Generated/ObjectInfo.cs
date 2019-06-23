//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ObjectInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ObjectInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ObjectInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ObjectInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          storj_uplinkPINVOKE.delete_ObjectInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_uint32_t version {
    set {
      storj_uplinkPINVOKE.ObjectInfo_version_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(storj_uplinkPINVOKE.ObjectInfo_version_get(swigCPtr), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public BucketInfo bucket {
    set {
      storj_uplinkPINVOKE.ObjectInfo_bucket_set(swigCPtr, BucketInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = storj_uplinkPINVOKE.ObjectInfo_bucket_get(swigCPtr);
      BucketInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new BucketInfo(cPtr, false);
      return ret;
    } 
  }

  public string path {
    set {
      storj_uplinkPINVOKE.ObjectInfo_path_set(swigCPtr, value);
    } 
    get {
      string ret = storj_uplinkPINVOKE.ObjectInfo_path_get(swigCPtr);
      return ret;
    } 
  }

  public bool is_prefix {
    set {
      storj_uplinkPINVOKE.ObjectInfo_is_prefix_set(swigCPtr, value);
    } 
    get {
      bool ret = storj_uplinkPINVOKE.ObjectInfo_is_prefix_get(swigCPtr);
      return ret;
    } 
  }

  public MapRef metadata {
    set {
      storj_uplinkPINVOKE.ObjectInfo_metadata_set(swigCPtr, MapRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = storj_uplinkPINVOKE.ObjectInfo_metadata_get(swigCPtr);
      MapRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new MapRef(cPtr, false);
      return ret;
    } 
  }

  public string content_type {
    set {
      storj_uplinkPINVOKE.ObjectInfo_content_type_set(swigCPtr, value);
    } 
    get {
      string ret = storj_uplinkPINVOKE.ObjectInfo_content_type_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int64_t created {
    set {
      storj_uplinkPINVOKE.ObjectInfo_created_set(swigCPtr, SWIGTYPE_p_int64_t.getCPtr(value));
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_int64_t ret = new SWIGTYPE_p_int64_t(storj_uplinkPINVOKE.ObjectInfo_created_get(swigCPtr), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_int64_t modified {
    set {
      storj_uplinkPINVOKE.ObjectInfo_modified_set(swigCPtr, SWIGTYPE_p_int64_t.getCPtr(value));
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_int64_t ret = new SWIGTYPE_p_int64_t(storj_uplinkPINVOKE.ObjectInfo_modified_get(swigCPtr), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_int64_t expires {
    set {
      storj_uplinkPINVOKE.ObjectInfo_expires_set(swigCPtr, SWIGTYPE_p_int64_t.getCPtr(value));
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_int64_t ret = new SWIGTYPE_p_int64_t(storj_uplinkPINVOKE.ObjectInfo_expires_get(swigCPtr), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ObjectInfo() : this(storj_uplinkPINVOKE.new_ObjectInfo(), true) {
  }

}
