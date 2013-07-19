package com.nonagon.modular.dynamicform.client;

import java.util.Date;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.client.strings.LocalizedString;

public class Form extends JavaScriptObject {
	
	public static Form create() {
		
		Form instance = ((Form)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.Form, Nonagon.Modular.DynamicForm";
	}-*/;

	protected Form() {}
	
	public final native int getId()/*-{ return this.Id; }-*/;
	
	public final native String getReference()/*-{ return this.Reference; }-*/;
	public final native void setReference(String value)/*-{ this.Reference = value; }-*/;
	
	public final native String getCode()/*-{ return this.Code; }-*/;
	public final native void setCode(String value)/*-{ this.Code = value; }-*/;
	
	public final native LocalizedString getName()/*-{ return this.Name; }-*/;
	public final native void setName(LocalizedString value)/*-{ this.Name = value; }-*/;
	
	public final native FormRevision getRevision()/*-{ return this.Revision; }-*/;
	public final native void setRevision(FormRevision value)/*-{ this.Revision = value; }-*/;
	
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
