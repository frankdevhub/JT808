﻿using System.Text.Json;

using JT808.Protocol.Extensions;
using JT808.Protocol.Formatters;
using JT808.Protocol.Interfaces;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 超速持续时间，单位为秒（s）
    /// </summary>
    public class JT808_0x8103_0x0056 : JT808_0x8103_BodyBase, IJT808MessagePackFormatter<JT808_0x8103_0x0056>, IJT808Analyze
    {
        /// <summary>
        /// 0x0056
        /// </summary>
        public override uint ParamId { get; set; } = 0x0056;
        /// <summary>
        /// 数据长度
        /// 4 byte
        /// </summary>
        public override byte ParamLength { get; set; } = 4;
        /// <summary>
        /// 超速持续时间，单位为秒（s）
        /// </summary>
        public uint ParamValue { get; set; }
        /// <summary>
        /// 超速持续时间
        /// </summary>
        public override string Description => "超速持续时间";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="writer"></param>
        /// <param name="config"></param>
        public void Analyze(ref JT808MessagePackReader reader, Utf8JsonWriter writer, IJT808Config config)
        {
            JT808_0x8103_0x0056 jT808_0x8103_0x0056 = new JT808_0x8103_0x0056();
            jT808_0x8103_0x0056.ParamId = reader.ReadUInt32();
            jT808_0x8103_0x0056.ParamLength = reader.ReadByte();
            jT808_0x8103_0x0056.ParamValue = reader.ReadUInt32();
            writer.WriteNumber($"[{ jT808_0x8103_0x0056.ParamId.ReadNumber()}]参数ID", jT808_0x8103_0x0056.ParamId);
            writer.WriteNumber($"[{jT808_0x8103_0x0056.ParamLength.ReadNumber()}]参数长度", jT808_0x8103_0x0056.ParamLength);
            writer.WriteNumber($"[{ jT808_0x8103_0x0056.ParamValue.ReadNumber()}]参数值[超速持续时间s]", jT808_0x8103_0x0056.ParamValue);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public JT808_0x8103_0x0056 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8103_0x0056 jT808_0x8103_0x0056 = new JT808_0x8103_0x0056();
            jT808_0x8103_0x0056.ParamId = reader.ReadUInt32();
            jT808_0x8103_0x0056.ParamLength = reader.ReadByte();
            jT808_0x8103_0x0056.ParamValue = reader.ReadUInt32();
            return jT808_0x8103_0x0056;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="config"></param>
        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x8103_0x0056 value, IJT808Config config)
        {
            writer.WriteUInt32(value.ParamId);
            writer.WriteByte(value.ParamLength);
            writer.WriteUInt32(value.ParamValue);
        }
    }
}
