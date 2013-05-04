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
	
	public final native Integer getVersion()/*-{ return this.Version; }-*/;
	public final native void setVersion(Integer value)/*-{ this.Version = value; }-*/;
	
	public final native String getOutputTemplate()/*-{ return this.OutputTemplate; }-*/;
	public final native void setOutputTemplate(String value)/*-{ this.OutputTemplate = value; }-*/;
	
	public final native FormTemplate getTemplate()/*-{ return this.Template; }-*/;
	public final native void setFormTemplate(FormTemplate value)/*-{ this.Template = value; }-*/;
	
	public final native Date getCreatedDate()/*-{ return this.CreatedDate; }-*/;
	public final native Date getLastUpdatedDate()/*-{ return this.LastUpdatedDate; }-*/;

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
	
	private final native String jsniGetFormStatus()/*-{ return this.FormStatus; }-*/;
	private final native void jsniSetFormStatus(String value)/*-{ this.FormStatus = value; }-*/;
}
