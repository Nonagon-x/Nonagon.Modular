package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FieldAttribute;

public class MultiChecksFieldAttribute extends FieldAttribute {

	public static MultiChecksFieldAttribute create() {
		
		MultiChecksFieldAttribute instance = ((MultiChecksFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.MultiChecksFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected MultiChecksFieldAttribute() {}
	
	public final native String getFieldValue()/*-{ return this.FieldValue; }-*/;
	public final native void setFieldValue(String value)/*-{ this.FieldValue = value; }-*/;
}
