﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Data {
	
	
	/// <summary>
	/// Responseを受信しデータを処理するクラスの基底です。
	/// </summary>
	public abstract class ResponseWrapper {

		/// <summary>
		/// 生の受信データ(api_data)
		/// </summary>
		protected dynamic RawData { get; set; }

		/// <summary>
		/// Responseを読み込みます。
		/// </summary>
		/// <param name="apiname">読み込むAPIの名前。</param>
		/// <param name="data">受信したデータ。</param>
		public void LoadFromResponse( string apiname, dynamic data ) {
			if ( data.api_result != 1 )
				throw new ArgumentException();
			RawData = data.api_data;
		}

		/// <summary>
		/// 現在のデータが有効かを取得します。
		/// </summary>
		public bool IsAvailable {
			get { return RawData != null; }
		}

		public ResponseWrapper() {
			RawData = null;
		}
	
	}

}
