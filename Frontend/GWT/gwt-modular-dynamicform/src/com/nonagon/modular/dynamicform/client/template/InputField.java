package com.nonagon.modular.dynamicform.client.template;

import com.google.gwt.core.client.JavaScriptObject;

public class InputField extends FormElement {

	public static InputField create() {
		
		InputField instance = ((InputField)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.Template.InputField, Nonagon.Modular.DynamicForm";
	}-*/;

	protected InputField() {}
	
	public final native String getFieldCode()/*-{ return this.FieldCode; }-*/;
	public final native void setFieldCode(String value)/*-{ this.FieldCode = value; }-*/;
}
