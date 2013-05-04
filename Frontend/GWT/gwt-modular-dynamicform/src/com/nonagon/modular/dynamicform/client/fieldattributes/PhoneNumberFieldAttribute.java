package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FieldAttribute;

public class PhoneNumberFieldAttribute extends FieldAttribute {

	public static PhoneNumberFieldAttribute create() {
		
		PhoneNumberFieldAttribute instance = ((PhoneNumberFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.PhoneNumberFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected PhoneNumberFieldAttribute() {}
}
