package com.nonagon.modular.dynamicform.client;

import com.google.gwt.core.client.JavaScriptObject;

public class FieldInfo extends JavaScriptObject {
	
	public static FieldInfo create() {
		
		FieldInfo instance = ((FieldInfo)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldInfo, Nonagon.Modular.DynamicForm";
	}-*/;

	protected FieldInfo() {}

	public final native Object getDefaultValue()/*-{ return this.DefaultValue; }-*/;
	public final native void setDefaultValue(Object value)/*-{ this.DefaultValue = value; }-*/;
	
	public final native boolean getIsRequired()/*-{ return this.IsRequired; }-*/;
	public final native void setIsRequired(boolean value)/*-{ this.IsRequired = value; }-*/;
	
	public final native FieldAttribute getFieldAttribute()/*-{ return this.FieldAttribute; }-*/;
	public final native void setFieldAttribute(FieldAttribute value)/*-{ this.FieldAttribute = value; }-*/;
}
