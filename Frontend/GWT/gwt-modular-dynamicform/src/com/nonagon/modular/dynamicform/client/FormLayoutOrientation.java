package com.nonagon.modular.dynamicform.client;

public enum FormLayoutOrientation {

	Horizontal,
	Vertical;
	
	public static FormLayoutOrientation fromString(String value) {

		if(value == null)
			return Horizontal;
		
		return Enum.valueOf(FormLayoutOrientation.class, value);
	}
	
	public static String fromEnum(FormLayoutOrientation formLayoutOrientation) {
		
		return formLayoutOrientation.toString();
	}
}
