using System;
using System.Collections;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /https/certificate/list 接口的响应。</para>
    /// </summary>
    public class QueryHttpsCertificatesResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Result : IDictionary<string, Result.Types.Certificate>
            {
                private readonly IDictionary<string, Types.Certificate> _innerDictionary = new Dictionary<string, Types.Certificate>();

                public static class Types
                {
                    public class Pagination
                    {
                        /// <summary>
                        /// 获取或设置分页 `since` 值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("since")]
                        [System.Text.Json.Serialization.JsonPropertyName("since")]
                        public int? Since { get; set; }

                        /// <summary>
                        /// 获取或设置分页 `max` 值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max")]
                        [System.Text.Json.Serialization.JsonPropertyName("max")]
                        public int? Max { get; set; }

                        /// <summary>
                        /// 获取或设置每次最大的请求条数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("limit")]
                        public int Limit { get; set; }
                    }

                    public class DefaultDomain
                    {
                        /// <summary>
                        /// 获取或设置默认域名绑定存储桶数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("config_domain")]
                        [System.Text.Json.Serialization.JsonPropertyName("config_domain")]
                        public int BucketCount { get; set; }
                    }

                    public class Certificate
                    {
                        public static class Types
                        {
                            public class ValidityPeriod
                            {
                                /// <summary>
                                /// 获取或设置域名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.UnixMillisecondsDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("start")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.UnixMillisecondsDateTimeOffsetConverter))]
                                public DateTimeOffset StartTime { get; set; }

                                /// <summary>
                                /// 获取或设置域名类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.UnixMillisecondsDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("end")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.UnixMillisecondsDateTimeOffsetConverter))]
                                public DateTimeOffset EndTime { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置证书颁发对象。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commonName")]
                        [System.Text.Json.Serialization.JsonPropertyName("commonName")]
                        public string? CommonName { get; set; }

                        /// <summary>
                        /// 获取或设置证书颁布组织。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("organization")]
                        [System.Text.Json.Serialization.JsonPropertyName("organization")]
                        public string Organization { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证书颁布组织。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("organizationUnit")]
                        [System.Text.Json.Serialization.JsonPropertyName("organizationUnit")]
                        public string OrganizationUnit { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证书类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("crt_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("crt_type")]
                        public string CertificateType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置有效期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("validity")]
                        [System.Text.Json.Serialization.JsonPropertyName("validity")]
                        public Types.ValidityPeriod ValidityPeriod { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("created_at")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.UnixTimestampDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("created_at")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.UnixTimestampDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置域名类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("domain_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("domain_type")]
                        public string DomainType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置付费类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_type")]
                        public string? PaymentType { get; set; }

                        /// <summary>
                        /// 获取或设置证书品牌。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand")]
                        public string? BrandName { get; set; }

                        /// <summary>
                        /// 获取或设置证书品牌类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("crt_type_pay")]
                        [System.Text.Json.Serialization.JsonPropertyName("crt_type_pay")]
                        public string? BrandType { get; set; }

                        /// <summary>
                        /// 获取或设置是否是专业版。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pro")]
                        [System.Text.Json.Serialization.JsonPropertyName("pro")]
                        public bool? IsProfessional { get; set; }

                        /// <summary>
                        /// 获取或设置域名绑定存储桶数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("config_domain")]
                        [System.Text.Json.Serialization.JsonPropertyName("config_domain")]
                        public int BucketCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pager")]
                [System.Text.Json.Serialization.JsonPropertyName("pager")]
                public Types.Pagination Pagination { get; set; } = default!;

                /// <summary>
                /// 获取或设置默认域名信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default")]
                [System.Text.Json.Serialization.JsonPropertyName("default")]
                public Types.DefaultDomain DefaultDomain { get; set; } = default!;

                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                ICollection<string> IDictionary<string, Types.Certificate>.Keys
                {
                    get { return _innerDictionary.Keys; }
                }

                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                ICollection<Types.Certificate> IDictionary<string, Types.Certificate>.Values
                {
                    get { return _innerDictionary.Values; }
                }

                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                int ICollection<KeyValuePair<string, Types.Certificate>>.Count
                {
                    get { return _innerDictionary.Count; }
                }

                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                bool ICollection<KeyValuePair<string, Types.Certificate>>.IsReadOnly
                {
                    get { return _innerDictionary.IsReadOnly; }
                }

                [Newtonsoft.Json.JsonExtensionData]
                [System.Text.Json.Serialization.JsonExtensionData]
                public Types.Certificate this[string key]
                {
                    get
                    {
                        if ("default".Equals(key))
                            return default!;
                        if ("pager".Equals(key))
                            return default!;

                        return _innerDictionary[key];
                    }
                    set
                    {
                        if ("default".Equals(key))
                            return;
                        if ("pager".Equals(key))
                            return;

                        _innerDictionary[key] = value;
                    }
                }

                bool IDictionary<string, Types.Certificate>.ContainsKey(string key)
                {
                    return _innerDictionary.ContainsKey(key);
                }

                void IDictionary<string, Types.Certificate>.Add(string key, Types.Certificate value)
                {
                    _innerDictionary.Add(key, value);
                }

                bool IDictionary<string, Types.Certificate>.Remove(string key)
                {
                    return _innerDictionary.Remove(key);
                }

                bool IDictionary<string, Types.Certificate>.TryGetValue(string key, out Types.Certificate value)
                {
                    return _innerDictionary.TryGetValue(key, out value!);
                }

                void ICollection<KeyValuePair<string, Types.Certificate>>.Add(KeyValuePair<string, Types.Certificate> item)
                {
                    _innerDictionary.Add(item);
                }

                void ICollection<KeyValuePair<string, Types.Certificate>>.Clear()
                {
                    _innerDictionary.Clear();
                }

                bool ICollection<KeyValuePair<string, Types.Certificate>>.Contains(KeyValuePair<string, Types.Certificate> item)
                {
                    return _innerDictionary.Contains(item);
                }

                void ICollection<KeyValuePair<string, Types.Certificate>>.CopyTo(KeyValuePair<string, Types.Certificate>[] array, int arrayIndex)
                {
                    _innerDictionary.CopyTo(array, arrayIndex);
                }

                bool ICollection<KeyValuePair<string, Types.Certificate>>.Remove(KeyValuePair<string, Types.Certificate> item)
                {
                    return _innerDictionary.Remove(item);
                }

                IEnumerator<KeyValuePair<string, Types.Certificate>> IEnumerable<KeyValuePair<string, Types.Certificate>>.GetEnumerator()
                {
                    return _innerDictionary.GetEnumerator();
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return ((IEnumerable)_innerDictionary).GetEnumerator();
                }
            }
        }

        /// <summary>
        /// 获取或设置查询状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置返回结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result Result { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Status == 0;
        }
    }
}
