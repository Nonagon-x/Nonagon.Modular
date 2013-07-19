package com.nonagon.modular.dynamicform.client;

import java.util.Date;

import com.google.gwt.core.client.JavaScriptObject;
import com.google.gwt.core.client.JsArray;

public class FormRevision extends JavaScriptObject {
	
	public static FormRevision create() {
		
		FormRevision instance = ((FormRevision)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FormRevision, Nonagon.Modular.DynamicForm";
	}-*/;

	protected FormRevision() {}

	public final native Long getId()/*-{ return this.Id; }-*/;
	public final native Long getFormId()/*-{ return this.FormId; }-*/;
	
	public final native int getVersion()/*-{ return this.Version; }-*/;
	public final native void setVersion(int value)/*-{ this.Version = value; }-*/;
	
	public final native String getOutput()/*-{ return this.Output; }-*/;
	public final native void setOutput(String value)/*-{ this.Output = value; }-*/;
	
	public final native FormTemplate getTemplate()/*-{ return this.Template; }-*/;
	public final native void setTemplate(FormTemplate value)/*-{ this.Template = value; }-*/;

	public final native JsArray<FormField> getFields()/*-{ return this.Fields; }-*/;
	public final native void setFields(JsArray<FormField> value)/*-{ this.Fields = value; }-*/;
	
	public final FormStatus getFormStatus() {
		
		String formStatus = jsniGetFormStatus();
		return FormStatus.fromString(formStatus);
	}
	
	public final void setFormStatus(FormStatus value) {
		
		String formStatus = FormStatus.fromEnum(value);
		jsniSetFormStatus(formStatus);
	}

	public final Date getCreatedDate() { return new Date((long)jsniGetCreatedDate()); } 
	public final Date getLastUpdatedDate() { return new Date((long)jsniGetLastUpdatedDate()); }

	private final native String jsniGetFormStatus()/*-{ return this.Status; }-*/;
	private final native void jsniSetFormStatus(String value)/*-{ this.Status = value; }-*/;
	
	private final native double jsniGetCreatedDate() /*-{ return Date.parse(this.CreatedDate); }-*/;
	private final native double jsniGetLastUpdatedDate() /*-{ return Date.parse(this.LastUpdatedDate); }-*/;
}
