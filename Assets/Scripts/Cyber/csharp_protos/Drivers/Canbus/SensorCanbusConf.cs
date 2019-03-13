// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/drivers/canbus/proto/sensor_canbus_conf.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Drivers.Canbus {

  /// <summary>Holder for reflection information generated from modules/drivers/canbus/proto/sensor_canbus_conf.proto</summary>
  public static partial class SensorCanbusConfReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/drivers/canbus/proto/sensor_canbus_conf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SensorCanbusConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVtb2R1bGVzL2RyaXZlcnMvY2FuYnVzL3Byb3RvL3NlbnNvcl9jYW5idXNf",
            "Y29uZi5wcm90bxIVYXBvbGxvLmRyaXZlcnMuY2FuYnVzGjVtb2R1bGVzL2Ry",
            "aXZlcnMvY2FuYnVzL3Byb3RvL2Nhbl9jYXJkX3BhcmFtZXRlci5wcm90byKP",
            "AQoQU2Vuc29yQ2FuYnVzQ29uZhJDChJjYW5fY2FyZF9wYXJhbWV0ZXIYASAB",
            "KAsyJy5hcG9sbG8uZHJpdmVycy5jYW5idXMuQ0FOQ2FyZFBhcmFtZXRlchIZ",
            "ChFlbmFibGVfZGVidWdfbW9kZRgCIAEoCBIbChNlbmFibGVfcmVjZWl2ZXJf",
            "bG9nGAMgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Drivers.Canbus.CanCardParameterReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Drivers.Canbus.SensorCanbusConf), global::Apollo.Drivers.Canbus.SensorCanbusConf.Parser, new[]{ "CanCardParameter", "EnableDebugMode", "EnableReceiverLog" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SensorCanbusConf : pb::IMessage<SensorCanbusConf> {
    private static readonly pb::MessageParser<SensorCanbusConf> _parser = new pb::MessageParser<SensorCanbusConf>(() => new SensorCanbusConf());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SensorCanbusConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Drivers.Canbus.SensorCanbusConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorCanbusConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorCanbusConf(SensorCanbusConf other) : this() {
      CanCardParameter = other.canCardParameter_ != null ? other.CanCardParameter.Clone() : null;
      enableDebugMode_ = other.enableDebugMode_;
      enableReceiverLog_ = other.enableReceiverLog_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorCanbusConf Clone() {
      return new SensorCanbusConf(this);
    }

    /// <summary>Field number for the "can_card_parameter" field.</summary>
    public const int CanCardParameterFieldNumber = 1;
    private global::Apollo.Drivers.Canbus.CANCardParameter canCardParameter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Drivers.Canbus.CANCardParameter CanCardParameter {
      get { return canCardParameter_; }
      set {
        canCardParameter_ = value;
      }
    }

    /// <summary>Field number for the "enable_debug_mode" field.</summary>
    public const int EnableDebugModeFieldNumber = 2;
    private bool enableDebugMode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableDebugMode {
      get { return enableDebugMode_; }
      set {
        enableDebugMode_ = value;
      }
    }

    /// <summary>Field number for the "enable_receiver_log" field.</summary>
    public const int EnableReceiverLogFieldNumber = 3;
    private bool enableReceiverLog_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableReceiverLog {
      get { return enableReceiverLog_; }
      set {
        enableReceiverLog_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SensorCanbusConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SensorCanbusConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CanCardParameter, other.CanCardParameter)) return false;
      if (EnableDebugMode != other.EnableDebugMode) return false;
      if (EnableReceiverLog != other.EnableReceiverLog) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (canCardParameter_ != null) hash ^= CanCardParameter.GetHashCode();
      if (EnableDebugMode != false) hash ^= EnableDebugMode.GetHashCode();
      if (EnableReceiverLog != false) hash ^= EnableReceiverLog.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (canCardParameter_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CanCardParameter);
      }
      if (EnableDebugMode != false) {
        output.WriteRawTag(16);
        output.WriteBool(EnableDebugMode);
      }
      if (EnableReceiverLog != false) {
        output.WriteRawTag(24);
        output.WriteBool(EnableReceiverLog);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (canCardParameter_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CanCardParameter);
      }
      if (EnableDebugMode != false) {
        size += 1 + 1;
      }
      if (EnableReceiverLog != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SensorCanbusConf other) {
      if (other == null) {
        return;
      }
      if (other.canCardParameter_ != null) {
        if (canCardParameter_ == null) {
          canCardParameter_ = new global::Apollo.Drivers.Canbus.CANCardParameter();
        }
        CanCardParameter.MergeFrom(other.CanCardParameter);
      }
      if (other.EnableDebugMode != false) {
        EnableDebugMode = other.EnableDebugMode;
      }
      if (other.EnableReceiverLog != false) {
        EnableReceiverLog = other.EnableReceiverLog;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (canCardParameter_ == null) {
              canCardParameter_ = new global::Apollo.Drivers.Canbus.CANCardParameter();
            }
            input.ReadMessage(canCardParameter_);
            break;
          }
          case 16: {
            EnableDebugMode = input.ReadBool();
            break;
          }
          case 24: {
            EnableReceiverLog = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code