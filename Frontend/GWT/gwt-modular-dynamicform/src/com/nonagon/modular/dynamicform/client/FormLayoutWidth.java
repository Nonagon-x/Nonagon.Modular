package com.nonagon.modular.dynamicform.client;

public enum FormLayoutWidth {

	WrapContent,
	FillParent,
	Average;
	
	public static FormLayoutWidth fromString(String value) {

		return Enum.valueOf(FormLayoutWidth.class, value);
	}
	
	public static String fromEnum(FormLayoutWidth formLayoutWidth) {
		
		return formLayoutWidth.toString();
	}
}
