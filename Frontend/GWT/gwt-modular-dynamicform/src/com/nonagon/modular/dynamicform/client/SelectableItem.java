package com.nonagon.modular.dynamicform.client;

import com.google.gwt.core.client.JavaScriptObject;

public class SelectableItem extends JavaScriptObject {

	protected SelectableItem() {}
	
	public final native String getName()/*-{ return this.Name; }-*/;
	public final native void SetName(String value)/*-{ this.Name = value; }-*/;
	
	public final native String getValue()/*-{ return this.Value; }-*/;
	public final native void SetValue(String value)/*-{ this.Value = value; }-*/;
}
