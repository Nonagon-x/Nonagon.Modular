package com.nonagon.modular.dynamicform.client;

public enum FormStatus {

	Active,
	Inactive,
	Deleted;
	
	public static FormStatus fromString(String value) {

		return Enum.valueOf(FormStatus.class, value);
	}
	
	public static String fromEnum(FormStatus formStatus) {
		
		return formStatus.toString();
	}
}
