package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FieldAttribute;

public class TimePickerFieldAttribute extends FieldAttribute {

	public static TimePickerFieldAttribute create() {
		
		TimePickerFieldAttribute instance = ((TimePickerFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.TimePickerFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected TimePickerFieldAttribute() {}
	
	public final native double getMinTime()/*-{ return this.MinTime; }-*/;
	public final native void setMinTime(double value)/*-{ this.MinTime = value; }-*/;
	
	public final native double getMaxTime()/*-{ return this.MaxTime; }-*/;
	public final native void setMaxTime(double value)/*-{ this.MaxTime = value; }-*/;
	
	public final native boolean getEnableMinRange()/*-{ return this.EnableMinRange; }-*/;
	public final native void setEnableMinRange(boolean value)/*-{ this.EnableMinRange = value; }-*/;
	
	public final native boolean getEnableMaxRange()/*-{ return this.EnableMaxRange; }-*/;
	public final native void setEnableMaxRange(boolean value)/*-{ this.EnableMaxRange = value; }-*/;
}
