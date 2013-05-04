package com.nonagon.modular.dynamicform.client;

public enum FieldType {

	FreeText,
	MultilineText,
	Email,
	PhoneNumber,
	Decimal,
	Digits,
	Url,
	Choices,
	SingleCheck,
	MultiChecks,
	DatePicker,
	TimePicker,
	DateTimePicker;
	
	public static FieldType fromString(String value) {

		return Enum.valueOf(FieldType.class, value);
	}
	
	public static String fromEnum(FieldType fieldType) {
		
		return fieldType.toString();
	}
}
