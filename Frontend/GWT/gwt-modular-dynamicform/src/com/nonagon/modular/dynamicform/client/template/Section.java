package com.nonagon.modular.dynamicform.client.template;

import com.google.gwt.core.client.JavaScriptObject;
import com.google.gwt.core.client.JsArray;

public class Section extends FormElementGroup {
	
	public static Section create() {
		
		Section instance = ((Section)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.Template.Section, Nonagon.Modular.DynamicForm";
	}-*/;

	protected Section() {}
	
	public final native JsArray<FormElement> getChildren()/*-{ return this.Children; }-*/;
	public final native void setChildren(JsArray<FormElement> value)/*-{ this.Children = value; }-*/;
}
