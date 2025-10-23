using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Infrastructure.Configurations
{
    public class BaseModelConfig
    {
        #region "Common"

        public const string TableNamePrefix = "mms";
        public const string UniquePrefix = "Unq";
        public const string IndexPrefix = "ix";
        public const string ConstraintPrefix = "fk";

        #endregion "Common"

        #region "Column Data Type and Default Value"

        public const string DefaultBlob = "LONGBLOB";
        public const string DefaultBlobLong = "MEDIUMBLOB";
        public const string DefaultBlobMedium = "BLOB";
        public const string DefaultBlobTiny = "TINYBLOB";
        public const string DefaultDateNow = "NOW()";
        public const string DefaultInt = "INT(11)";
        public const string DefaultTinyInt = "TINYINT(1)";
        public const string DefaultDecimal = "DECIMAL(14,4)";
        public const string DefaultCurrency = "DECIMAL(14,4)";
        public const string DefaultDateTime = "DATETIME";
        public const string DefaultText = "TEXT";
        public const string DefaultTextLong = "LONGTEXT";
        public const string DefaultTextMedium = "MEDIUMTEXT";
        public const string DefaultTimestamp = "TIMESTAMP";
        public const string TimestampValue = "CURRENT_TIMESTAMP";
        public const string TimestampOnUpdateValue = "CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP";

        public string TableShortName = "";
        public string TableName = "";

        public enum EnumColumnLength
        {
            VARCHARDEFAULT = 25,
            VARCHAR_STANDARDENTRIES_DESCRIPTION = 60,
            VARCHAR75 = 75,
            VARCHAR_BUSINESS_PARTNER_NAME = 200,
            VARCHAR_ITEMDESCRIPTION = 500,
            VARCHAR767 = 767,
            VARCHAR200 = 200,
            VARCHAR100 = 100,
            VARCHAR300 = 300
        }

        #endregion "Column Data Type and Default Value"
    }
}