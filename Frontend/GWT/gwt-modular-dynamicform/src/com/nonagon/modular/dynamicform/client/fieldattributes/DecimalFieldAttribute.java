package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FieldAttribute;

public class DecimalFieldAttribute extends FieldAttribute {

	public static DecimalFieldAttribute create() {
		
		DecimalFieldAttribute instance = ((DecimalFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.DecimalFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected DecimalFieldAttribute() {}
	
	public final native double getMinValue()/*-{ return this.MinValue; }-*/;
	public final native void setMinValue(double value)/*-{ this.MinValue = value; }-*/;
	
	public final native double getMaxValue()/*-{ return this.MaxValue; }-*/;
	public final native void setMaxValue(double value)/*-{ this.MaxValue = value; }-*/;
	
	public final native boolean getEnableMinRange()/*-{ return this.EnableMinRange; }-*/;
	public final native void setEnableMinRange(boolean value)/*-{ this.EnableMinRange = value; }-*/;
	
	public final native boolean getEnableMaxRange()/*-{ return this.EnableMaxRange; }-*/;
	public final native void setEnableMaxRange(boolean value)/*-{ this.EnableMaxRange = value; }-*/;
}
