package com.nonagon.modular.dynamicform.client;

import com.google.gwt.core.client.JavaScriptObject;
import com.google.gwt.core.client.JsArray;
import com.nonagon.modular.dynamicform.client.template.FormElement;

public class FormTemplate extends JavaScriptObject {

	public static FormTemplate create() {
		
		FormTemplate instance = ((FormTemplate)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FormTemplate, Nonagon.Modular.DynamicForm";
	}-*/;

	protected FormTemplate() {}
	
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
