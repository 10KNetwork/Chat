﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONObjects
{

    public class Prefs
    {

        [JsonProperty("highlight_words")]
        public string HighlightWords { get; set; }

        [JsonProperty("user_colors")]
        public string UserColors { get; set; }

        [JsonProperty("color_names_in_list")]
        public bool ColorNamesInList { get; set; }

        [JsonProperty("growls_enabled")]
        public bool GrowlsEnabled { get; set; }

        [JsonProperty("tz")]
        public string Tz { get; set; }

        [JsonProperty("push_dm_alert")]
        public bool PushDmAlert { get; set; }

        [JsonProperty("push_mention_alert")]
        public bool PushMentionAlert { get; set; }

        [JsonProperty("msg_replies")]
        public string MsgReplies { get; set; }

        [JsonProperty("push_everything")]
        public bool PushEverything { get; set; }

        [JsonProperty("push_idle_wait")]
        public int PushIdleWait { get; set; }

        [JsonProperty("push_sound")]
        public string PushSound { get; set; }

        [JsonProperty("push_loud_channels")]
        public string PushLoudChannels { get; set; }

        [JsonProperty("push_mention_channels")]
        public string PushMentionChannels { get; set; }

        [JsonProperty("push_loud_channels_set")]
        public string PushLoudChannelsSet { get; set; }

        [JsonProperty("email_alerts")]
        public string EmailAlerts { get; set; }

        [JsonProperty("email_alerts_sleep_until")]
        public int EmailAlertsSleepUntil { get; set; }

        [JsonProperty("email_misc")]
        public bool EmailMisc { get; set; }

        [JsonProperty("email_weekly")]
        public bool EmailWeekly { get; set; }

        [JsonProperty("welcome_message_hidden")]
        public bool WelcomeMessageHidden { get; set; }

        [JsonProperty("all_channels_loud")]
        public bool AllChannelsLoud { get; set; }

        [JsonProperty("loud_channels")]
        public string LoudChannels { get; set; }

        [JsonProperty("never_channels")]
        public string NeverChannels { get; set; }

        [JsonProperty("loud_channels_set")]
        public string LoudChannelsSet { get; set; }

        [JsonProperty("show_member_presence")]
        public bool ShowMemberPresence { get; set; }

        [JsonProperty("search_sort")]
        public string SearchSort { get; set; }

        [JsonProperty("expand_inline_imgs")]
        public bool ExpandInlineImgs { get; set; }

        [JsonProperty("expand_internal_inline_imgs")]
        public bool ExpandInternalInlineImgs { get; set; }

        [JsonProperty("expand_snippets")]
        public bool ExpandSnippets { get; set; }

        [JsonProperty("posts_formatting_guide")]
        public bool PostsFormattingGuide { get; set; }

        [JsonProperty("seen_welcome_2")]
        public bool SeenWelcome2 { get; set; }

        [JsonProperty("seen_ssb_prompt")]
        public bool SeenSsbPrompt { get; set; }

        [JsonProperty("spaces_new_xp_banner_dismissed")]
        public bool SpacesNewXpBannerDismissed { get; set; }

        [JsonProperty("search_only_my_channels")]
        public bool SearchOnlyMyChannels { get; set; }

        [JsonProperty("search_only_current_team")]
        public bool SearchOnlyCurrentTeam { get; set; }

        [JsonProperty("emoji_mode")]
        public string EmojiMode { get; set; }

        [JsonProperty("emoji_use")]
        public string EmojiUse { get; set; }

        [JsonProperty("has_invited")]
        public bool HasInvited { get; set; }

        [JsonProperty("has_uploaded")]
        public bool HasUploaded { get; set; }

        [JsonProperty("has_created_channel")]
        public bool HasCreatedChannel { get; set; }

        [JsonProperty("search_exclude_channels")]
        public string SearchExcludeChannels { get; set; }

        [JsonProperty("messages_theme")]
        public string MessagesTheme { get; set; }

        [JsonProperty("webapp_spellcheck")]
        public bool WebappSpellcheck { get; set; }

        [JsonProperty("no_joined_overlays")]
        public bool NoJoinedOverlays { get; set; }

        [JsonProperty("no_created_overlays")]
        public bool NoCreatedOverlays { get; set; }

        [JsonProperty("dropbox_enabled")]
        public bool DropboxEnabled { get; set; }

        [JsonProperty("seen_domain_invite_reminder")]
        public bool SeenDomainInviteReminder { get; set; }

        [JsonProperty("seen_member_invite_reminder")]
        public bool SeenMemberInviteReminder { get; set; }

        [JsonProperty("mute_sounds")]
        public bool MuteSounds { get; set; }

        [JsonProperty("arrow_history")]
        public bool ArrowHistory { get; set; }

        [JsonProperty("tab_ui_return_selects")]
        public bool TabUiReturnSelects { get; set; }

        [JsonProperty("obey_inline_img_limit")]
        public bool ObeyInlineImgLimit { get; set; }

        [JsonProperty("new_msg_snd")]
        public string NewMsgSnd { get; set; }

        [JsonProperty("require_at")]
        public bool RequireAt { get; set; }

        [JsonProperty("ssb_space_window")]
        public string SsbSpaceWindow { get; set; }

        [JsonProperty("mac_ssb_bounce")]
        public string MacSsbBounce { get; set; }

        [JsonProperty("mac_ssb_bullet")]
        public bool MacSsbBullet { get; set; }

        [JsonProperty("expand_non_media_attachments")]
        public bool ExpandNonMediaAttachments { get; set; }

        [JsonProperty("show_typing")]
        public bool ShowTyping { get; set; }

        [JsonProperty("pagekeys_handled")]
        public bool PagekeysHandled { get; set; }

        [JsonProperty("last_snippet_type")]
        public string LastSnippetType { get; set; }

        [JsonProperty("display_real_names_override")]
        public int DisplayRealNamesOverride { get; set; }

        [JsonProperty("display_preferred_names")]
        public bool DisplayPreferredNames { get; set; }

        [JsonProperty("time24")]
        public bool Time24 { get; set; }

        [JsonProperty("enter_is_special_in_tbt")]
        public bool EnterIsSpecialInTbt { get; set; }

        [JsonProperty("graphic_emoticons")]
        public bool GraphicEmoticons { get; set; }

        [JsonProperty("convert_emoticons")]
        public bool ConvertEmoticons { get; set; }

        [JsonProperty("ss_emojis")]
        public bool SsEmojis { get; set; }

        [JsonProperty("sidebar_behavior")]
        public string SidebarBehavior { get; set; }

        [JsonProperty("seen_onboarding_start")]
        public bool SeenOnboardingStart { get; set; }

        [JsonProperty("onboarding_cancelled")]
        public bool OnboardingCancelled { get; set; }

        [JsonProperty("seen_onboarding_slackbot_conversation")]
        public bool SeenOnboardingSlackbotConversation { get; set; }

        [JsonProperty("seen_onboarding_channels")]
        public bool SeenOnboardingChannels { get; set; }

        [JsonProperty("seen_onboarding_direct_messages")]
        public bool SeenOnboardingDirectMessages { get; set; }

        [JsonProperty("seen_onboarding_invites")]
        public bool SeenOnboardingInvites { get; set; }

        [JsonProperty("seen_onboarding_search")]
        public bool SeenOnboardingSearch { get; set; }

        [JsonProperty("seen_onboarding_recent_mentions")]
        public bool SeenOnboardingRecentMentions { get; set; }

        [JsonProperty("seen_onboarding_starred_items")]
        public bool SeenOnboardingStarredItems { get; set; }

        [JsonProperty("seen_onboarding_private_groups")]
        public bool SeenOnboardingPrivateGroups { get; set; }

        [JsonProperty("onboarding_slackbot_conversation_step")]
        public int OnboardingSlackbotConversationStep { get; set; }

        [JsonProperty("dnd_enabled")]
        public bool DndEnabled { get; set; }

        [JsonProperty("dnd_start_hour")]
        public string DndStartHour { get; set; }

        [JsonProperty("dnd_end_hour")]
        public string DndEndHour { get; set; }

        [JsonProperty("mark_msgs_read_immediately")]
        public bool MarkMsgsReadImmediately { get; set; }

        [JsonProperty("start_scroll_at_oldest")]
        public bool StartScrollAtOldest { get; set; }

        [JsonProperty("snippet_editor_wrap_long_lines")]
        public bool SnippetEditorWrapLongLines { get; set; }

        [JsonProperty("ls_disabled")]
        public bool LsDisabled { get; set; }

        [JsonProperty("sidebar_theme")]
        public string SidebarTheme { get; set; }

        [JsonProperty("sidebar_theme_custom_values")]
        public string SidebarThemeCustomValues { get; set; }

        [JsonProperty("f_key_search")]
        public bool FKeySearch { get; set; }

        [JsonProperty("k_key_omnibox")]
        public bool KKeyOmnibox { get; set; }

        [JsonProperty("speak_growls")]
        public bool SpeakGrowls { get; set; }

        [JsonProperty("mac_speak_voice")]
        public string MacSpeakVoice { get; set; }

        [JsonProperty("mac_speak_speed")]
        public int MacSpeakSpeed { get; set; }

        [JsonProperty("comma_key_prefs")]
        public bool CommaKeyPrefs { get; set; }

        [JsonProperty("at_channel_suppressed_channels")]
        public string AtChannelSuppressedChannels { get; set; }

        [JsonProperty("push_at_channel_suppressed_channels")]
        public string PushAtChannelSuppressedChannels { get; set; }

        [JsonProperty("prompted_for_email_disabling")]
        public bool PromptedForEmailDisabling { get; set; }

        [JsonProperty("full_text_extracts")]
        public bool FullTextExtracts { get; set; }

        [JsonProperty("no_text_in_notifications")]
        public bool NoTextInNotifications { get; set; }

        [JsonProperty("muted_channels")]
        public string MutedChannels { get; set; }

        [JsonProperty("no_macssb1_banner")]
        public bool NoMacssb1Banner { get; set; }

        [JsonProperty("no_macssb2_banner")]
        public bool NoMacssb2Banner { get; set; }

        [JsonProperty("no_winssb1_banner")]
        public bool NoWinssb1Banner { get; set; }

        [JsonProperty("no_omnibox_in_channels")]
        public bool NoOmniboxInChannels { get; set; }

        [JsonProperty("k_key_omnibox_auto_hide_count")]
        public int KKeyOmniboxAutoHideCount { get; set; }

        [JsonProperty("hide_user_group_info_pane")]
        public bool HideUserGroupInfoPane { get; set; }

        [JsonProperty("mentions_exclude_at_user_groups")]
        public bool MentionsExcludeAtUserGroups { get; set; }

        [JsonProperty("privacy_policy_seen")]
        public bool PrivacyPolicySeen { get; set; }

        [JsonProperty("search_exclude_bots")]
        public bool SearchExcludeBots { get; set; }

        [JsonProperty("load_lato_2")]
        public bool LoadLato2 { get; set; }

        [JsonProperty("fuller_timestamps")]
        public bool FullerTimestamps { get; set; }

        [JsonProperty("last_seen_at_channel_warning")]
        public int LastSeenAtChannelWarning { get; set; }

        [JsonProperty("flex_resize_window")]
        public bool FlexResizeWindow { get; set; }

        [JsonProperty("msg_preview")]
        public bool MsgPreview { get; set; }

        [JsonProperty("msg_preview_displaces")]
        public bool MsgPreviewDisplaces { get; set; }

        [JsonProperty("msg_preview_persistent")]
        public bool MsgPreviewPersistent { get; set; }

        [JsonProperty("emoji_autocomplete_big")]
        public bool EmojiAutocompleteBig { get; set; }

        [JsonProperty("winssb_run_from_tray")]
        public bool WinssbRunFromTray { get; set; }

        [JsonProperty("winssb_window_flash_behavior")]
        public string WinssbWindowFlashBehavior { get; set; }

        [JsonProperty("two_factor_auth_enabled")]
        public bool TwoFactorAuthEnabled { get; set; }

        [JsonProperty("two_factor_type")]
        public object TwoFactorType { get; set; }

        [JsonProperty("two_factor_backup_type")]
        public object TwoFactorBackupType { get; set; }

        [JsonProperty("enhanced_debugging")]
        public bool EnhancedDebugging { get; set; }

        [JsonProperty("mentions_exclude_at_channels")]
        public bool MentionsExcludeAtChannels { get; set; }

        [JsonProperty("confirm_clear_all_unreads")]
        public bool ConfirmClearAllUnreads { get; set; }

        [JsonProperty("confirm_user_marked_away")]
        public bool ConfirmUserMarkedAway { get; set; }

        [JsonProperty("box_enabled")]
        public bool BoxEnabled { get; set; }

        [JsonProperty("seen_single_emoji_msg")]
        public bool SeenSingleEmojiMsg { get; set; }

        [JsonProperty("confirm_sh_call_start")]
        public bool ConfirmShCallStart { get; set; }

        [JsonProperty("preferred_skin_tone")]
        public string PreferredSkinTone { get; set; }

        [JsonProperty("show_all_skin_tones")]
        public bool ShowAllSkinTones { get; set; }

        [JsonProperty("separate_private_channels")]
        public bool SeparatePrivateChannels { get; set; }

        [JsonProperty("whats_new_read")]
        public int WhatsNewRead { get; set; }

        [JsonProperty("hotness")]
        public bool Hotness { get; set; }

        [JsonProperty("frecency_jumper")]
        public string FrecencyJumper { get; set; }

        [JsonProperty("jumbomoji")]
        public bool Jumbomoji { get; set; }

        [JsonProperty("no_flex_in_history")]
        public bool NoFlexInHistory { get; set; }

        [JsonProperty("newxp_seen_last_message")]
        public string NewxpSeenLastMessage { get; set; }

        [JsonProperty("attachments_with_borders")]
        public bool AttachmentsWithBorders { get; set; }

        [JsonProperty("show_memory_instrument")]
        public bool ShowMemoryInstrument { get; set; }

        [JsonProperty("channel_sort")]
        public string ChannelSort { get; set; }

        [JsonProperty("a11y_font_size")]
        public string A11yFontSize { get; set; }
    }

}