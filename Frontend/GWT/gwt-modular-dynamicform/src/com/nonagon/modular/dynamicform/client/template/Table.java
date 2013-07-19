package com.nonagon.modular.dynamicform.client.template;

import com.google.gwt.core.client.JavaScriptObject;

public class Table extends FormElementGroup {
	
	public static Table create() {
		
		Table instance = ((Table)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.Template.Table, Nonagon.Modular.DynamicForm";
	}-*/;

	protected Table() {}
	
	public final native boolean getHasBorders()/*-{ return this.HasBorders; }-*/;
	public final native void sethasBorders(boolean value)/*-{ this.HasBorders = value; }-*/;
	
	public final native int getColumnCount()/*-{ return this.ColumnCount; }-*/;
	public final native void setColumnCount(int value)/*-{ this.ColumnCount = value; }-*/;
}
