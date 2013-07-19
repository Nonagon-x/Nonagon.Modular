package com.nonagon.modular.dynamicform.client.template;

import com.google.gwt.core.client.JavaScriptObject;
import com.nonagon.modular.client.strings.LocalizedString;

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
	
	public final native LocalizedString getTitle()/*-{ return this.Title; }-*/;
	public final native void setTitle(LocalizedString value)/*-{ this.Title = value; }-*/;
}
