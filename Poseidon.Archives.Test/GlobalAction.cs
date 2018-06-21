using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Test
{
    using Poseidon.Base.System;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Common;

    public static class GlobalAction
    {
        #region Field
        /// <summary>
        /// 当前登录用户
        /// </summary>
        public static LoginUser CurrentUser = null;
        #endregion //Field

        #region Constructor

        #endregion //Constructor

        #region Method
        /// <summary>
        /// 全局初始化
        /// </summary>
        public static void Initialize()
        {
            try
            {
                // 设置连接字符串
                string source = AppConfig.GetAppSetting("ConnectionSource");
                if (string.IsNullOrEmpty(source))
                {
                    Logger.Instance.Error("连接源未确定");
                    throw new PoseidonException(ErrorCode.DatabaseConnectionNotFound);
                }

                string connection = "";
                if (source == "dbconfig")
                {
                    string name = AppConfig.GetAppSetting("DbConnection");
                    connection = ConfigUtility.GetConnectionString(name);
                }
                else if (source == "appconfig")
                {
                    connection = AppConfig.GetConnectionString();
                }

                if (string.IsNullOrEmpty(connection))
                {
                    Logger.Instance.Error("连接字符串未找到");
                    throw new PoseidonException(ErrorCode.DatabaseConnectionNotFound);
                }

                Cache.Instance.Add("ConnectionString", connection);
                Logger.Instance.Debug("连接字符串已设置");

                // 设置数据库类型
                string dalPrefix = AppConfig.GetAppSetting("DALPrefix");
                Cache.Instance.Add("DALPrefix", dalPrefix);
                Logger.Instance.Debug("数据库类型已设置");

                // 设置服务访问类型
                string callerType = AppConfig.GetAppSetting("CallerType");
                Cache.Instance.Add("CallerType", callerType);
                Logger.Instance.Debug("服务访问类型已设置");

                // 设置远程API地址
                string apiHost = AppConfig.GetAppSetting("ApiHost");
                Cache.Instance.Add("ApiHost", apiHost);
                Logger.Instance.Debug("API主机已设置");
            }
            catch (Exception e)
            {
                Logger.Instance.Exception("初始化失败", e);
                throw new PoseidonException(ErrorCode.Error);
            }
        }

        /// <summary>
        /// 设置登录用户
        /// </summary>
        /// <param name="user">用户信息</param>
        public static LoginUser ConvertToLoginUser(User user)
        {
            LoginUser lu = new LoginUser
            {
                Id = user.Id,
                UserName = user.UserName,
                IsRoot = true,
                Name = user.Name,
                LastLoginTime = user.LastLoginTime,
                CurrentLoginTime = user.CurrentLoginTime,
                Remark = user.Remark,
                Status = user.Status
            };

            return lu;
        }
        #endregion //Method
    }
}
