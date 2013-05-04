package com.nonagon.modular.dynamicform.client;

import com.google.gwt.core.client.JavaScriptObject;

public class FormLayoutThickness extends JavaScriptObject {
	
	public static FormLayoutThickness create() {
		
		FormLayoutThickness instance = ((FormLayoutThickness)JavaScriptObject.createObject());
		instance.init();
		
		return instance;
	}
	
	protected final native void init()/*-{
		
		this.__type = "Nonagon.Modular.DynamicForm.FormLayoutThickness, Nonagon.Modular.DynamicForm";
	}-*/;

	protected FormLayoutThickness() {}

	public final native int getLeft()/*-{ return this.Left; }-*/;
	public final native void setLeft(int value)/*-{ this.Left = value; }-*/;
	
	public final native int getTop()/*-{ return this.Top; }-*/;
	public final native void setTop(int value)/*-{ this.Top = value; }-*/;
	
	public final native int getRight()/*-{ return this.Right; }-*/;
	public final native void setRight(int value)/*-{ this.Right = value; }-*/;
	
	public final native int getBottom()/*-{ return this.Bottom; }-*/;
	public final native void setBottom(int value)/*-{ this.Bottom = value; }-*/;
}
