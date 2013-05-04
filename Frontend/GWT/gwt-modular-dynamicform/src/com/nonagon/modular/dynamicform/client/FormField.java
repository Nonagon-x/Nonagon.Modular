package com.nonagon.modular.dynamicform.client;


import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.client.strings.LocalizedString;

public class FormField extends JavaScriptObject {

	public static FormField create() {
		
		FormField instance = ((FormField)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FormField, Nonagon.Modular.DynamicForm";
	}-*/;

	protected FormField() {}

	public final native Long getId()/*-{ return this.Id; }-*/;

	public final native Long getFormRevisionId()/*-{ return this.FormRevisionId; }-*/;
	public final native void setFormRevisionId(Long value)/*-{ this.FormRevisionId = value; }-*/;
	
	public final native String getFieldCode()/*-{ return this.FieldCode; }-*/;
	public final native void setFieldCode(String value)/*-{ this.FieldCode = value; }-*/;
	
	public final native LocalizedString getName()/*-{ return this.Name; }-*/;
	public final native void setName(LocalizedString value)/*-{ this.Name = value; }-*/;
	
	public final native FieldInfo getFieldInfo()/*-{ return this.FieldInfo; }-*/;
	public final native void setFieldInfo(FieldInfo value)/*-{ this.FieldInfo = value; }-*/;
	
	public final FieldType getFieldType() {

		String fieldType = jsniGetFieldType();
		return FieldType.fromString(fieldType);
	}
	
	public final void setFieldType(FieldType value) {
		
		String fieldType = FieldType.fromEnum(value);
		jsniSetFieldType(fieldType);
	}
	
	private final native String jsniGetFieldType()/*-{ return this.FieldType; }-*/;
	private final native void jsniSetFieldType(String value)/*-{ this.FieldType = value; }-*/;

}
