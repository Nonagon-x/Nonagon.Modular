package com.nonagon.modular.dynamicform.client.template;

import com.google.gwt.core.client.JavaScriptObject;

public class PlainText extends FormElement {

	public static PlainText create() {
		
		PlainText instance = ((PlainText)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.Template.PlainText, Nonagon.Modular.DynamicForm";
	}-*/;

	protected PlainText() {}
	
	public final native String getText()/*-{ return this.Text; }-*/;
	public final native void setText(String value)/*-{ this.Text = value; }-*/;
}
