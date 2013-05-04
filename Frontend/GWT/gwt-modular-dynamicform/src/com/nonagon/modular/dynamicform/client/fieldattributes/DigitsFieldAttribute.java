package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FieldAttribute;

public class DigitsFieldAttribute extends FieldAttribute {

	public static DigitsFieldAttribute create() {
		
		DigitsFieldAttribute instance = ((DigitsFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.DigitsFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected DigitsFieldAttribute() {}
	
	public final native Long getMinValue()/*-{ return this.MinValue; }-*/;
	public final native void setMinValue(Long value)/*-{ this.MinValue = value; }-*/;
	
	public final native Long getMaxValue()/*-{ return this.MaxValue; }-*/;
	public final native void setMaxValue(Long value)/*-{ this.MaxValue = value; }-*/;
	
	public final native boolean getEnableMinRange()/*-{ return this.EnableMinRange; }-*/;
	public final native void setEnableMinRange(boolean value)/*-{ this.EnableMinRange = value; }-*/;
	
	public final native boolean getEnableMaxRange()/*-{ return this.EnableMaxRange; }-*/;
	public final native void setEnableMaxRange(boolean value)/*-{ this.EnableMaxRange = value; }-*/;
}
