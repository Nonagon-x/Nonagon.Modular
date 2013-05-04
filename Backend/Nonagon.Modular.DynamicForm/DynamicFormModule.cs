using System;
using System.Linq;
using System.Data;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// The entry point of Dynamic Form module.
	/// </summary>
	public class DynamicFormModule : DataModuleBase<DynamicFormInterface>
	{
		protected DynamicFormModule(IDbConnectionFactory dbConnectionFactory) : base(dbConnectionFactory) {}

		/// <summary>
		/// Determines whether this instance is initialized.
		/// </summary>
		/// <returns><c>true</c> if this instance is initialized; otherwise, <c>false</c>.</returns>
		public override Boolean IsInitialized()
		{
			Boolean isInitialized;

			using (IDbConnection db = DbConnectionFactory.OpenDbConnection())
			{
				isInitialized = 
					db.TableExists(typeof(Form).Name) &&
					db.TableExists(typeof(FormRevision).Name) &&
					db.TableExists(typeof(FormField).Name) &&
					db.TableExists(typeof(FormInstance).Name) &&
					db.TableExists(typeof(FormInstanceValue).Name);
			}

			return isInitialized;
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public override void Initialize()
		{
			using (IDbConnection db = DbConnectionFactory.OpenDbConnection())
			{
				db.CreateTableIfNotExists<Form>();
				db.CreateTableIfNotExists<FormRevision>();
				db.CreateTableIfNotExists<FormField>();
				db.CreateTableIfNotExists<FormInstance>();
				db.CreateTableIfNotExists<FormInstanceValue>();

				/*
				db.Insert(new DynamicFormSchema.Form() {
					NameKey = "Something",
					Reference = Guid.NewGuid().ToString(),
					Status = FormStatus.Active,
					CreatedDate = DateTime.Now,
					LastUpdatedDate = DateTime.Now,
				});

				Int64 id = db.GetLastInsertId();
				
				db.Insert(new DynamicFormSchema.FormVersion() {
					CreatedDate = DateTime.Now,
					LastUpdatedDate = DateTime.Now,
					Status = FormStatus.Active,
					FormId = id,
					Version = 1,
					Template = new FormTemplate() {
						Children = new IFormElement [] {
							new PlainText() {
								Text = "Something Yes No OK"
							},
							
							new Table() {
								
							}
						}
					}
				});

				id = db.GetLastInsertId();

				db.Insert(new DynamicFormSchema.FormField() {
					FormVersionId = id,
					FieldCode = "TestCode",
					NameKey = "FieldNameKey",
					FieldType = FieldType.DatePicker,
					FieldInfo = new FieldInfo { 
						FieldAttribute = new DateRangeFieldAttribute() {
							MinDate = DateTimeOffset.MinValue,
							MaxDate = DateTimeOffset.MaxValue
						},

						IsRequired = true,
						DefaultValue = DateTime.Now
					}});

				id = db.GetLastInsertId();
				
				DynamicFormSchema.FormField field = 
					db.Select<DynamicFormSchema.FormField>(q => q.Id == id).First();
				
				DynamicFormSchema.FormField x = field;
				*/
			}
		}
	}
}