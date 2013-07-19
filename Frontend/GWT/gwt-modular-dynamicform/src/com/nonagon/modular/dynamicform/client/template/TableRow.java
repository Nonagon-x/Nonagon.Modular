package com.nonagon.modular.dynamicform.client.template;

import com.google.gwt.core.client.JavaScriptObject;

public class TableRow extends FormElementGroup {
	
	public static TableRow create() {
		
		TableRow instance = ((TableRow)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.Template.TableRow, Nonagon.Modular.DynamicForm";
	}-*/;

	protected TableRow() {}
}
