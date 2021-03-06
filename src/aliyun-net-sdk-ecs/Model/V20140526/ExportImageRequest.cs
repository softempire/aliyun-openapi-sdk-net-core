/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ExportImageRequest : RpcAcsRequest<ExportImageResponse>
    {
        public ExportImageRequest()
            : base("Ecs", "2014-05-26", "ExportImage")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _imageId;

		private string _oSsBucket;

		private string _oSsPrefix;

		private string _imageFormat;

		private string _roleName;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ImageId
		{
			get
			{
				return _imageId;
			}
			set	
			{
				_imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public string OssBucket
		{
			get
			{
				return _oSsBucket;
			}
			set	
			{
				_oSsBucket = value;
				DictionaryUtil.Add(QueryParameters, "OSSBucket", value);
			}
		}

		public string OssPrefix
		{
			get
			{
				return _oSsPrefix;
			}
			set	
			{
				_oSsPrefix = value;
				DictionaryUtil.Add(QueryParameters, "OSSPrefix", value);
			}
		}

		public string ImageFormat
		{
			get
			{
				return _imageFormat;
			}
			set	
			{
				_imageFormat = value;
				DictionaryUtil.Add(QueryParameters, "ImageFormat", value);
			}
		}

		public string RoleName
		{
			get
			{
				return _roleName;
			}
			set	
			{
				_roleName = value;
				DictionaryUtil.Add(QueryParameters, "RoleName", value);
			}
		}

        public override ExportImageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ExportImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}