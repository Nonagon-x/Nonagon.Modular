package com.nonagon.modular.dynamicform.client;

import com.google.gwt.core.client.JavaScriptObject;

public class SelectableItem extends JavaScriptObject {

	public static SelectableItem create() {
		
		SelectableItem instance = ((SelectableItem)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.SelectableItem, Nonagon.Modular.DynamicForm";
	}-*/;

	protected SelectableItem() {}
	
	public final native String getName()/*-{ return this.Name; }-*/;
	public final native void setName(String value)/*-{ this.Name = value; }-*/;
	
	public final native String getValue()/*-{ return this.Value; }-*/;
	public final native void setValue(String value)/*-{ this.Value = value; }-*/;
}
