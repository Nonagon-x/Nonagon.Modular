package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FieldAttribute;

public class EmailFieldAttribute extends FieldAttribute {

	public static EmailFieldAttribute create() {
		
		EmailFieldAttribute instance = ((EmailFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.EmailFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected EmailFieldAttribute() {}
}
