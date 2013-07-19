package com.nonagon.modular.dynamicform.client.template;

import com.google.gwt.core.client.JsArray;
import com.nonagon.modular.dynamicform.client.FormLayoutOrientation;
import com.nonagon.modular.dynamicform.client.FormLayoutType;

public abstract class FormElementGroup extends FormElement {

	protected FormElementGroup() {}
	
	public final FormLayoutType getLayoutType() {
		
		String formLayoutType = jsniGetLayoutType();
		return FormLayoutType.fromString(formLayoutType);
	}
	
	public final void setLayoutType(FormLayoutType formLayoutType) {
		
		String value = FormLayoutType.fromEnum(formLayoutType);
		jsniSetLayoutType(value);
	}
	
	private final native String jsniGetLayoutType()/*-{ return this.LayoutType; }-*/;
	private final native void jsniSetLayoutType(String value)/*-{ this.LayoutType = value; }-*/;
	
	
	public final FormLayoutOrientation getOrientation() {
		
		String formLayoutOrientation = jsniGetOrientation();
		return FormLayoutOrientation.fromString(formLayoutOrientation);
	}
	
	public final void setOrientation(FormLayoutOrientation formLayoutOrientation) {
		
		String value = FormLayoutOrientation.fromEnum(formLayoutOrientation);
		jsniSetOrientation(value);
	}
	
	private final native String jsniGetOrientation()/*-{ return this.Orientation; }-*/;
	private final native void jsniSetOrientation(String value)/*-{ this.Orientation = value; }-*/;
	
	public final native JsArray<FormElement> getChildren()/*-{ return this.Children; }-*/;
	public final native void setChildren(JsArray<FormElement> value)/*-{ this.Children = value; }-*/;
	
	public final native void addChild(FormElement element)/*-{
		
		if(!this.Children)
			this.Children = [];
		
		this.Children.push(element);
		
	}-*/;
	
	public final native void removeChild(FormElement element)/*-{
		
		if(!this.Children) return;
		
		var index = this.Children.indexOf(element);
		if(index >= 0)
			this.Children.splice(index, 1);
		
	}-*/;
}
