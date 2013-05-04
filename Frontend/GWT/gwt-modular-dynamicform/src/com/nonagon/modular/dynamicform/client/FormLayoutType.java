package com.nonagon.modular.dynamicform.client;

public enum FormLayoutType {

	LinearLayout,
	WrapLayout;
	
	public static FormLayoutType fromString(String value) {

		return Enum.valueOf(FormLayoutType.class, value);
	}
	
	public static String fromEnum(FormLayoutType formLayoutType) {
		
		return formLayoutType.toString();
	}
}
