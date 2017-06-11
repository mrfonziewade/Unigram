// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockPhoto : TLPageBlockBase 
	{
		public Int64 PhotoId { get; set; }
		public TLRichTextBase Caption { get; set; }

		public TLPageBlockPhoto() { }
		public TLPageBlockPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			PhotoId = from.ReadInt64();
			Caption = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt64(PhotoId);
			to.WriteObject(Caption);
		}
	}
}