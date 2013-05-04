package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FieldAttribute;

public class FreeTextFieldAttribute extends FieldAttribute  {

	public static FreeTextFieldAttribute create() {
		
		FreeTextFieldAttribute instance = ((FreeTextFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.FreeTextFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected FreeTextFieldAttribute() {}
	
	public final native int getMaxLength()/*-{ return this.MaxLength; }-*/;
	public final native void setMaxLength(int value)/*-{ this.MaxLength = value; }-*/;
}
