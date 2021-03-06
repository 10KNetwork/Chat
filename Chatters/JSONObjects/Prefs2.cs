﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONObjects
{

    public class Prefs2
    {

        [JsonProperty("invites_only_admins")]
        public bool InvitesOnlyAdmins { get; set; }

        [JsonProperty("default_channels")]
        public string[] DefaultChannels { get; set; }

        [JsonProperty("who_can_at_everyone")]
        public string WhoCanAtEveryone { get; set; }

        [JsonProperty("who_can_at_channel")]
        public string WhoCanAtChannel { get; set; }

        [JsonProperty("who_can_post_general")]
        public string WhoCanPostGeneral { get; set; }

        [JsonProperty("warn_before_at_channel")]
        public string WarnBeforeAtChannel { get; set; }

        [JsonProperty("who_can_create_channels")]
        public string WhoCanCreateChannels { get; set; }

        [JsonProperty("who_can_archive_channels")]
        public string WhoCanArchiveChannels { get; set; }

        [JsonProperty("who_can_create_groups")]
        public string WhoCanCreateGroups { get; set; }

        [JsonProperty("who_can_kick_channels")]
        public string WhoCanKickChannels { get; set; }

        [JsonProperty("who_can_kick_groups")]
        public string WhoCanKickGroups { get; set; }

        [JsonProperty("who_can_manage_integrations")]
        public WhoCanManageIntegrations WhoCanManageIntegrations { get; set; }

        [JsonProperty("commands_only_regular")]
        public bool CommandsOnlyRegular { get; set; }

        [JsonProperty("gateway_allow_xmpp_ssl")]
        public bool GatewayAllowXmppSsl { get; set; }

        [JsonProperty("gateway_allow_irc_ssl")]
        public bool GatewayAllowIrcSsl { get; set; }

        [JsonProperty("gateway_allow_irc_plain")]
        public bool GatewayAllowIrcPlain { get; set; }

        [JsonProperty("allow_calls")]
        public bool AllowCalls { get; set; }

        [JsonProperty("hide_referers")]
        public bool HideReferers { get; set; }

        [JsonProperty("msg_edit_window_mins")]
        public int MsgEditWindowMins { get; set; }

        [JsonProperty("allow_message_deletion")]
        public bool AllowMessageDeletion { get; set; }

        [JsonProperty("display_real_names")]
        public bool DisplayRealNames { get; set; }

        [JsonProperty("retention_type")]
        public int RetentionType { get; set; }

        [JsonProperty("retention_duration")]
        public int RetentionDuration { get; set; }

        [JsonProperty("group_retention_type")]
        public int GroupRetentionType { get; set; }

        [JsonProperty("group_retention_duration")]
        public int GroupRetentionDuration { get; set; }

        [JsonProperty("dm_retention_type")]
        public int DmRetentionType { get; set; }

        [JsonProperty("dm_retention_duration")]
        public int DmRetentionDuration { get; set; }

        [JsonProperty("file_retention_duration")]
        public int FileRetentionDuration { get; set; }

        [JsonProperty("file_retention_type")]
        public int FileRetentionType { get; set; }

        [JsonProperty("allow_retention_override")]
        public bool AllowRetentionOverride { get; set; }

        [JsonProperty("require_at_for_mention")]
        public bool RequireAtForMention { get; set; }

        [JsonProperty("default_rxns")]
        public string[] DefaultRxns { get; set; }

        [JsonProperty("team_handy_rxns")]
        public TeamHandyRxns TeamHandyRxns { get; set; }

        [JsonProperty("channel_handy_rxns")]
        public object ChannelHandyRxns { get; set; }

        [JsonProperty("compliance_export_start")]
        public int ComplianceExportStart { get; set; }

        [JsonProperty("disallow_public_file_urls")]
        public bool DisallowPublicFileUrls { get; set; }

        [JsonProperty("who_can_create_delete_user_groups")]
        public string WhoCanCreateDeleteUserGroups { get; set; }

        [JsonProperty("who_can_edit_user_groups")]
        public string WhoCanEditUserGroups { get; set; }

        [JsonProperty("who_can_change_team_profile")]
        public string WhoCanChangeTeamProfile { get; set; }

        [JsonProperty("allow_shared_channels")]
        public bool AllowSharedChannels { get; set; }

        [JsonProperty("who_has_team_visibility")]
        public string WhoHasTeamVisibility { get; set; }

        [JsonProperty("disable_file_uploads")]
        public string DisableFileUploads { get; set; }

        [JsonProperty("who_can_create_shared_channels")]
        public string WhoCanCreateSharedChannels { get; set; }

        [JsonProperty("who_can_manage_shared_channels")]
        public WhoCanManageSharedChannels WhoCanManageSharedChannels { get; set; }

        [JsonProperty("who_can_post_in_shared_channels")]
        public WhoCanPostInSharedChannels WhoCanPostInSharedChannels { get; set; }

        [JsonProperty("allow_shared_channel_perms_override")]
        public bool AllowSharedChannelPermsOverride { get; set; }

        [JsonProperty("dnd_enabled")]
        public bool DndEnabled { get; set; }

        [JsonProperty("dnd_start_hour")]
        public string DndStartHour { get; set; }

        [JsonProperty("dnd_end_hour")]
        public string DndEndHour { get; set; }

        [JsonProperty("auth_mode")]
        public string AuthMode { get; set; }

        [JsonProperty("invites_limit")]
        public bool InvitesLimit { get; set; }
    }

}
