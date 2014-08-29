using System;
using System.Data;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Content
{
	/// <summary>
	/// The entry point of Content module.
	/// </summary>
	public class ContentModule : DataModuleBase<ContentInterface>
	{
		protected ContentModule(IDbConnectionFactory dbConnectionFactory) : base(dbConnectionFactory) {}
		
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
					db.TableExists(typeof(Content).Name) &&
					db.TableExists(typeof(ContentRevision).Name);
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
				db.CreateTableIfNotExists<Content>();
				db.CreateTableIfNotExists<ContentRevision>();

				/*
				db.Insert(new CmsSchema.Content() {
					NameKey = \"Something\",
					Reference = Guid.NewGuid().ToString(),
					Status = ContentStatus.Active,
					CreatedDate = DateTime.Now,
					LastUpdatedDate = DateTime.Now,
				});

				Int64 id = db.GetLastInsertId();
				
				db.Insert(new CmsSchema.ContentVersion() {
					CreatedDate = DateTime.Now,
					LastUpdatedDate = DateTime.Now,
					Status = ContentStatus.Active,
					ContentId = id,
					Version = 1,
					Template = new ContentTemplate() {
						Children = new IContentElement [] {
							new PlainText() {
								Text = \"Something Yes No OK\"
							},
							
							new Table() {
								
							}
						}
					}
				});

				id = db.GetLastInsertId();

				db.Insert(new CmsSchema.ContentField() {
					ContentVersionId = id,
					FieldCode = \"TestCode\",
					NameKey = \"FieldNameKey\",
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
				
				CmsSchema.ContentField field = 
					db.Select<CmsSchema.ContentField>(q => q.Id == id).First();
				
				CmsSchema.ContentField x = field;
				*/
			}
		}
	}
}

