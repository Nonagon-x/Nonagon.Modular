package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FieldAttribute;

public class MultilineTextFieldAttribute extends FieldAttribute {

	public static MultilineTextFieldAttribute create() {
		
		MultilineTextFieldAttribute instance = ((MultilineTextFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.MultilineTextFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected MultilineTextFieldAttribute() {}
	
	public final native void getMaxLines()/*-{ return this.MaxLines; }-*/;
	public final native void setMaxLines(int value)/*-{ this.MaxLines = value; }-*/;
	
	public final native int getMaxLength()/*-{ return this.MaxLength; }-*/;
	public final native void setMaxLength(int value)/*-{ this.MaxLength = value; }-*/;
}
