package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FieldAttribute;

public class SingleCheckFieldAttribute extends FieldAttribute {

	public static SingleCheckFieldAttribute create() {
		
		SingleCheckFieldAttribute instance = ((SingleCheckFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.SingleCheckFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected SingleCheckFieldAttribute() {}
	
	public final native String getFieldValue()/*-{ return this.FieldValue; }-*/;
	public final native void setFieldValue(String value)/*-{ this.FieldValue = value; }-*/;
	
	public final native String getGroupName()/*-{ return this.GroupName; }-*/;
	public final native void setGroupName(String value)/*-{ this.GroupName = value; }-*/;
}
