package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FieldAttribute;

public class UrlFieldAttribute extends FieldAttribute {

	public static UrlFieldAttribute create() {
		
		UrlFieldAttribute instance = ((UrlFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.UrlFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected UrlFieldAttribute() {}
}
