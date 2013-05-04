package com.nonagon.modular.dynamicform.client.template;

import com.nonagon.modular.dynamicform.client.FormLayoutOrientation;
import com.nonagon.modular.dynamicform.client.FormLayoutType;

public abstract class FormElementGroup extends FormElement {

	protected FormElementGroup() {}
	
	public final FormLayoutType getLayout() {
		
		String formLayoutType = jsniGetLayout();
		return FormLayoutType.fromString(formLayoutType);
	}
	
	public final void setLayout(FormLayoutType formLayoutType) {
		
		String value = FormLayoutType.fromEnum(formLayoutType);
		jsniSetLayout(value);
	}
	
	private final native String jsniGetLayout()/*-{ return this.Layout; }-*/;
	private final native void jsniSetLayout(String value)/*-{ this.Layout = value; }-*/;
	
	
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
