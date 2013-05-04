package com.nonagon.modular.dynamicform.client.fieldattributes;

import com.google.gwt.core.client.JavaScriptObject;
import com.google.gwt.core.client.JsArray;
import com.nonagon.modular.dynamicform.client.FieldAttribute;
import com.nonagon.modular.dynamicform.client.SelectableItem;

public class ChoicesFieldAttribute extends FieldAttribute {

	public static ChoicesFieldAttribute create() {
		
		ChoicesFieldAttribute instance = ((ChoicesFieldAttribute)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FieldAttributes.ChoicesFieldAttribute, Nonagon.Modular.DynamicForm";
	}-*/;

	protected ChoicesFieldAttribute() {}
	
	public final native JsArray<SelectableItem> getSelectableItems()/*-{ return this.SelectableItems; }-*/;
	public final native void setSelectableItems(JsArray<SelectableItem> value)/*-{ this.SelectableItems = value; }-*/;
}
