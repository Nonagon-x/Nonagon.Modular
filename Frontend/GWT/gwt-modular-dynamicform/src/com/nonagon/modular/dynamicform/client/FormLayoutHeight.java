package com.nonagon.modular.dynamicform.client;

public enum FormLayoutHeight {

	WrapContent,
	FixHeight;
	
	public static FormLayoutHeight fromString(String value) {

		if(value == null)
			return WrapContent;
		
		return Enum.valueOf(FormLayoutHeight.class, value);
	}
	
	public static String fromEnum(FormLayoutHeight formLayoutHeight) {
		
		return formLayoutHeight.toString();
	}

}
