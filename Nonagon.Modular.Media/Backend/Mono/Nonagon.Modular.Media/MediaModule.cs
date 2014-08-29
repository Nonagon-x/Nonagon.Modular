using System;
using System.Linq;
using System.Data;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Media
{
	/// <summary>
	/// The entry point of Media module.
	/// </summary>
	public class MediaModule : DataModuleBase<MediaInterface>
	{
		protected MediaModule(IDbConnectionFactory dbConnectionFactory) : base(dbConnectionFactory) {}

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
					db.TableExists(typeof(Media).Name);
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
				db.CreateTableIfNotExists<Media>();

				/*
				db.Insert(new MediaSchema.Media() {
					NameKey = "Something",
					Reference = Guid.NewGuid().ToString(),
					Status = MediaStatus.Active,
					CreatedDate = DateTime.Now,
					LastUpdatedDate = DateTime.Now,
				});

				Int64 id = db.GetLastInsertId();
				
				db.Insert(new MediaSchema.MediaVersion() {
					CreatedDate = DateTime.Now,
					LastUpdatedDate = DateTime.Now,
					Status = MediaStatus.Active,
					MediaId = id,
					Version = 1,
					Template = new MediaTemplate() {
						Children = new IMediaElement [] {
							new PlainText() {
								Text = "Something Yes No OK"
							},
							
							new Table() {
								
							}
						}
					}
				});

				id = db.GetLastInsertId();

				db.Insert(new MediaSchema.MediaField() {
					MediaVersionId = id,
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
				
				MediaSchema.MediaField field = 
					db.Select<MediaSchema.MediaField>(q => q.Id == id).First();
				
				MediaSchema.MediaField x = field;
				*/
			}
		}
	}
}