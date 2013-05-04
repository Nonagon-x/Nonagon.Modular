package com.nonagon.modular.dynamicform.client.template;

import com.google.gwt.core.client.JavaScriptObject;
import com.google.gwt.core.client.JsArray;

public class TableCell extends FormElementGroup {
	
	public static TableCell create() {
		
		TableCell instance = ((TableCell)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.Template.TableCell, Nonagon.Modular.DynamicForm";
	}-*/;

	protected TableCell() {}
	
	public final native JsArray<FormElement> getChildren()/*-{ return this.Children; }-*/;
	public final native void setChildren(JsArray<FormElement> value)/*-{ this.Children = value; }-*/;
}
