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

	public final FormLayoutWidth getWidth() {
		
		String fieldLayoutWidth = jsniGetWidth();
		return FormLayoutWidth.fromString(fieldLayoutWidth);
	}
	
	public final void setWidth(FormLayoutWidth width) {
		
		String fieldLayoutWidth = FormLayoutWidth.fromEnum(width);
		jsniSetWidth(fieldLayoutWidth);
	}
	
	private final native String jsniGetWidth()/*-{ return this.Width; }-*/;
	private final native void jsniSetWidth(String value)/*-{ this.Width = value; }-*/;
	
	public final FormLayoutHeight getHeight() {
		
		String fieldLayoutHeight = jsniGetHeight();
		return FormLayoutHeight.fromString(fieldLayoutHeight);
	}
	
	public final void setHeight(FormLayoutHeight height) {
		
		String fieldLayoutHeight = FormLayoutHeight.fromEnum(height);
		jsniSetHeight(fieldLayoutHeight);
	}
	
	private final native String jsniGetHeight()/*-{ return this.Height; }-*/;
	private final native void jsniSetHeight(String value)/*-{ this.Height = value; }-*/;
}
