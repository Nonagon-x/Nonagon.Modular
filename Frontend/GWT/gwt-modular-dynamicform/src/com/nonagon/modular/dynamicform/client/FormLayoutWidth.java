package com.nonagon.modular.dynamicform.client;

public enum FormLayoutWidth {

	WrapContent,
	MatchParent,
	Average;
	
	public static FormLayoutWidth fromString(String value) {

		if(value == null)
			return MatchParent;
			
		return Enum.valueOf(FormLayoutWidth.class, value);
	}
	
	public static String fromEnum(FormLayoutWidth formLayoutWidth) {
		
		return formLayoutWidth.toString();
	}
}
