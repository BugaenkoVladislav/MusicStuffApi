// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/playlist.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PlaylistService {

  /// <summary>Holder for reflection information generated from Protos/playlist.proto</summary>
  public static partial class PlaylistReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/playlist.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlaylistReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvcGxheWxpc3QucHJvdG8iUQoLTmV3UGxheWxpc3QSDwoHand0",
            "VXNlchgBIAEoCRIMCgRuYW1lGAIgASgJEhEKCXBob3RvcGF0aBgDIAEoCRIQ",
            "Cghpc1B1YmxpYxgEIAEoCCIpCgpJZFBsYXlsaXN0Eg8KB2p3dFVzZXIYASAB",
            "KAkSCgoCaWQYAiABKAMiPQoFVHJhY2sSDwoHand0VXNlchgBIAEoCRIPCgdp",
            "ZFRyYWNrGAIgASgDEhIKCmlkUGxheWxpc3QYAyABKAMiPQoJUGxheWxpc3Rz",
            "Eg8KB2p3dFVzZXIYASABKAkSHwoJcGxheWxpc3RzGAIgAygLMgwuTmV3UGxh",
            "eWxpc3Qy1QEKCFBsYXlsaXN0EiwKDkNyZWF0ZVBsYXlsaXN0EgwuTmV3UGxh",
            "eWxpc3QaDC5OZXdQbGF5bGlzdBIqCg5EZWxldGVQbGF5bGlzdBILLklkUGxh",
            "eWxpc3QaCy5JZFBsYXlsaXN0Eh8KDUFkZEluUGxheWxpc3QSBi5UcmFjaxoG",
            "LlRyYWNrEiQKEkRlbGV0ZUZyb21QbGF5bGlzdBIGLlRyYWNrGgYuVHJhY2sS",
            "KAoOR2V0TXlQbGF5bGlzdHMSCi5QbGF5bGlzdHMaCi5QbGF5bGlzdHNCEqoC",
            "D1BsYXlsaXN0U2VydmljZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PlaylistService.NewPlaylist), global::PlaylistService.NewPlaylist.Parser, new[]{ "JwtUser", "Name", "Photopath", "IsPublic" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PlaylistService.IdPlaylist), global::PlaylistService.IdPlaylist.Parser, new[]{ "JwtUser", "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PlaylistService.Track), global::PlaylistService.Track.Parser, new[]{ "JwtUser", "IdTrack", "IdPlaylist" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PlaylistService.Playlists), global::PlaylistService.Playlists.Parser, new[]{ "JwtUser", "Playlists_" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NewPlaylist : pb::IMessage<NewPlaylist>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NewPlaylist> _parser = new pb::MessageParser<NewPlaylist>(() => new NewPlaylist());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NewPlaylist> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PlaylistService.PlaylistReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NewPlaylist() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NewPlaylist(NewPlaylist other) : this() {
      jwtUser_ = other.jwtUser_;
      name_ = other.name_;
      photopath_ = other.photopath_;
      isPublic_ = other.isPublic_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NewPlaylist Clone() {
      return new NewPlaylist(this);
    }

    /// <summary>Field number for the "jwtUser" field.</summary>
    public const int JwtUserFieldNumber = 1;
    private string jwtUser_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JwtUser {
      get { return jwtUser_; }
      set {
        jwtUser_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "photopath" field.</summary>
    public const int PhotopathFieldNumber = 3;
    private string photopath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Photopath {
      get { return photopath_; }
      set {
        photopath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "isPublic" field.</summary>
    public const int IsPublicFieldNumber = 4;
    private bool isPublic_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPublic {
      get { return isPublic_; }
      set {
        isPublic_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NewPlaylist);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NewPlaylist other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JwtUser != other.JwtUser) return false;
      if (Name != other.Name) return false;
      if (Photopath != other.Photopath) return false;
      if (IsPublic != other.IsPublic) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JwtUser.Length != 0) hash ^= JwtUser.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Photopath.Length != 0) hash ^= Photopath.GetHashCode();
      if (IsPublic != false) hash ^= IsPublic.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (JwtUser.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JwtUser);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Photopath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Photopath);
      }
      if (IsPublic != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsPublic);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (JwtUser.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JwtUser);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Photopath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Photopath);
      }
      if (IsPublic != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsPublic);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (JwtUser.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JwtUser);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Photopath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Photopath);
      }
      if (IsPublic != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NewPlaylist other) {
      if (other == null) {
        return;
      }
      if (other.JwtUser.Length != 0) {
        JwtUser = other.JwtUser;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Photopath.Length != 0) {
        Photopath = other.Photopath;
      }
      if (other.IsPublic != false) {
        IsPublic = other.IsPublic;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            JwtUser = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Photopath = input.ReadString();
            break;
          }
          case 32: {
            IsPublic = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            JwtUser = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Photopath = input.ReadString();
            break;
          }
          case 32: {
            IsPublic = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class IdPlaylist : pb::IMessage<IdPlaylist>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IdPlaylist> _parser = new pb::MessageParser<IdPlaylist>(() => new IdPlaylist());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IdPlaylist> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PlaylistService.PlaylistReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IdPlaylist() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IdPlaylist(IdPlaylist other) : this() {
      jwtUser_ = other.jwtUser_;
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IdPlaylist Clone() {
      return new IdPlaylist(this);
    }

    /// <summary>Field number for the "jwtUser" field.</summary>
    public const int JwtUserFieldNumber = 1;
    private string jwtUser_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JwtUser {
      get { return jwtUser_; }
      set {
        jwtUser_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private long id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IdPlaylist);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IdPlaylist other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JwtUser != other.JwtUser) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JwtUser.Length != 0) hash ^= JwtUser.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (JwtUser.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JwtUser);
      }
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (JwtUser.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JwtUser);
      }
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (JwtUser.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JwtUser);
      }
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IdPlaylist other) {
      if (other == null) {
        return;
      }
      if (other.JwtUser.Length != 0) {
        JwtUser = other.JwtUser;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            JwtUser = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            JwtUser = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Track : pb::IMessage<Track>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Track> _parser = new pb::MessageParser<Track>(() => new Track());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Track> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PlaylistService.PlaylistReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Track() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Track(Track other) : this() {
      jwtUser_ = other.jwtUser_;
      idTrack_ = other.idTrack_;
      idPlaylist_ = other.idPlaylist_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Track Clone() {
      return new Track(this);
    }

    /// <summary>Field number for the "jwtUser" field.</summary>
    public const int JwtUserFieldNumber = 1;
    private string jwtUser_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JwtUser {
      get { return jwtUser_; }
      set {
        jwtUser_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "idTrack" field.</summary>
    public const int IdTrackFieldNumber = 2;
    private long idTrack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long IdTrack {
      get { return idTrack_; }
      set {
        idTrack_ = value;
      }
    }

    /// <summary>Field number for the "idPlaylist" field.</summary>
    public const int IdPlaylistFieldNumber = 3;
    private long idPlaylist_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long IdPlaylist {
      get { return idPlaylist_; }
      set {
        idPlaylist_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Track);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Track other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JwtUser != other.JwtUser) return false;
      if (IdTrack != other.IdTrack) return false;
      if (IdPlaylist != other.IdPlaylist) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JwtUser.Length != 0) hash ^= JwtUser.GetHashCode();
      if (IdTrack != 0L) hash ^= IdTrack.GetHashCode();
      if (IdPlaylist != 0L) hash ^= IdPlaylist.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (JwtUser.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JwtUser);
      }
      if (IdTrack != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(IdTrack);
      }
      if (IdPlaylist != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(IdPlaylist);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (JwtUser.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JwtUser);
      }
      if (IdTrack != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(IdTrack);
      }
      if (IdPlaylist != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(IdPlaylist);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (JwtUser.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JwtUser);
      }
      if (IdTrack != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdTrack);
      }
      if (IdPlaylist != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdPlaylist);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Track other) {
      if (other == null) {
        return;
      }
      if (other.JwtUser.Length != 0) {
        JwtUser = other.JwtUser;
      }
      if (other.IdTrack != 0L) {
        IdTrack = other.IdTrack;
      }
      if (other.IdPlaylist != 0L) {
        IdPlaylist = other.IdPlaylist;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            JwtUser = input.ReadString();
            break;
          }
          case 16: {
            IdTrack = input.ReadInt64();
            break;
          }
          case 24: {
            IdPlaylist = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            JwtUser = input.ReadString();
            break;
          }
          case 16: {
            IdTrack = input.ReadInt64();
            break;
          }
          case 24: {
            IdPlaylist = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Playlists : pb::IMessage<Playlists>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Playlists> _parser = new pb::MessageParser<Playlists>(() => new Playlists());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Playlists> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PlaylistService.PlaylistReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Playlists() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Playlists(Playlists other) : this() {
      jwtUser_ = other.jwtUser_;
      playlists_ = other.playlists_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Playlists Clone() {
      return new Playlists(this);
    }

    /// <summary>Field number for the "jwtUser" field.</summary>
    public const int JwtUserFieldNumber = 1;
    private string jwtUser_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JwtUser {
      get { return jwtUser_; }
      set {
        jwtUser_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "playlists" field.</summary>
    public const int Playlists_FieldNumber = 2;
    private static readonly pb::FieldCodec<global::PlaylistService.NewPlaylist> _repeated_playlists_codec
        = pb::FieldCodec.ForMessage(18, global::PlaylistService.NewPlaylist.Parser);
    private readonly pbc::RepeatedField<global::PlaylistService.NewPlaylist> playlists_ = new pbc::RepeatedField<global::PlaylistService.NewPlaylist>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::PlaylistService.NewPlaylist> Playlists_ {
      get { return playlists_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Playlists);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Playlists other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JwtUser != other.JwtUser) return false;
      if(!playlists_.Equals(other.playlists_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JwtUser.Length != 0) hash ^= JwtUser.GetHashCode();
      hash ^= playlists_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (JwtUser.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JwtUser);
      }
      playlists_.WriteTo(output, _repeated_playlists_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (JwtUser.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JwtUser);
      }
      playlists_.WriteTo(ref output, _repeated_playlists_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (JwtUser.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JwtUser);
      }
      size += playlists_.CalculateSize(_repeated_playlists_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Playlists other) {
      if (other == null) {
        return;
      }
      if (other.JwtUser.Length != 0) {
        JwtUser = other.JwtUser;
      }
      playlists_.Add(other.playlists_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            JwtUser = input.ReadString();
            break;
          }
          case 18: {
            playlists_.AddEntriesFrom(input, _repeated_playlists_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            JwtUser = input.ReadString();
            break;
          }
          case 18: {
            playlists_.AddEntriesFrom(ref input, _repeated_playlists_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
