package com.nonagon.modular.dynamicform.client.template;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.dynamicform.client.FormLayoutHeight;
import com.nonagon.modular.dynamicform.client.FormLayoutThickness;
import com.nonagon.modular.dynamicform.client.FormLayoutWidth;

public abstract class FormElement extends JavaScriptObject {
	
	protected FormElement() {}
	
	public final native FormLayoutThickness getMargin()/*-{ return this.Margin; }-*/;
	public final native void setMargin(FormLayoutThickness value)/*-{ this.Margin = value; }-*/;

	public final native FormLayoutThickness getPadding()/*-{ return this.Padding; }-*/;
	public final native void getPadding(FormLayoutThickness value)/*-{ this.Padding = value; }-*/;

	public final FormLayoutWidth getFieldLayoutWidth() {
		
		String fieldLayoutWidth = jsniGetFieldLayoutWidth();
		return FormLayoutWidth.fromString(fieldLayoutWidth);
	}
	
	public final void setFieldLayoutWidth(FormLayoutWidth width) {
		
		String fieldLayoutWidth = FormLayoutWidth.fromEnum(width);
		jsniSetFieldLayoutWidth(fieldLayoutWidth);
	}
	
	private final native String jsniGetFieldLayoutWidth()/*-{ return this.FieldLayoutWidth; }-*/;
	private final native void jsniSetFieldLayoutWidth(String value)/*-{ this.FieldLayoutWidth = value; }-*/;
	
	public final FormLayoutHeight getFieldLayoutHeight() {
		
		String fieldLayoutHeight = jsniGetFieldLayoutHeight();
		return FormLayoutHeight.fromString(fieldLayoutHeight);
	}
	
	public final void setFieldLayoutHeight(FormLayoutHeight height) {
		
		String fieldLayoutHeight = FormLayoutHeight.fromEnum(height);
		jsniSetFieldLayoutHeight(fieldLayoutHeight);
	}
	
	private final native String jsniGetFieldLayoutHeight()/*-{ return this.FieldLayoutHeight; }-*/;
	private final native void jsniSetFieldLayoutHeight(String value)/*-{ this.FieldLayoutHeight = value; }-*/;
}
