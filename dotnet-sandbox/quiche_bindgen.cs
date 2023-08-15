// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
#pragma warning disable CS8500
#pragma warning disable CS8981
using System;
using System.Runtime.InteropServices;


namespace CsBindgen
{
    internal static unsafe partial class LibQuiche
    {
        const string __DllName = "libquiche";



        [DllImport(__DllName, EntryPoint = "quiche_version", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern byte* quiche_version();

        [DllImport(__DllName, EntryPoint = "quiche_enable_debug_logging", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_enable_debug_logging(delegate* unmanaged[Cdecl]<byte*, void*, void> cb, void* argp);

        [DllImport(__DllName, EntryPoint = "quiche_config_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern quiche_config* quiche_config_new(uint version);

        [DllImport(__DllName, EntryPoint = "quiche_config_load_cert_chain_from_pem_file", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_config_load_cert_chain_from_pem_file(quiche_config* config, byte* path);

        [DllImport(__DllName, EntryPoint = "quiche_config_load_priv_key_from_pem_file", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_config_load_priv_key_from_pem_file(quiche_config* config, byte* path);

        [DllImport(__DllName, EntryPoint = "quiche_config_load_verify_locations_from_file", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_config_load_verify_locations_from_file(quiche_config* config, byte* path);

        [DllImport(__DllName, EntryPoint = "quiche_config_load_verify_locations_from_directory", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_config_load_verify_locations_from_directory(quiche_config* config, byte* path);

        [DllImport(__DllName, EntryPoint = "quiche_config_verify_peer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_verify_peer(quiche_config* config, [MarshalAs(UnmanagedType.U1)] bool v);

        [DllImport(__DllName, EntryPoint = "quiche_config_grease", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_grease(quiche_config* config, [MarshalAs(UnmanagedType.U1)] bool v);

        [DllImport(__DllName, EntryPoint = "quiche_config_log_keys", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_log_keys(quiche_config* config);

        [DllImport(__DllName, EntryPoint = "quiche_config_enable_early_data", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_enable_early_data(quiche_config* config);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_application_protos", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_config_set_application_protos(quiche_config* config, byte* protos, nuint protos_len);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_max_idle_timeout", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_max_idle_timeout(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_max_recv_udp_payload_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_max_recv_udp_payload_size(quiche_config* config, nuint v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_max_send_udp_payload_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_max_send_udp_payload_size(quiche_config* config, nuint v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_initial_max_data", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_initial_max_data(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_initial_max_stream_data_bidi_local", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_initial_max_stream_data_bidi_local(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_initial_max_stream_data_bidi_remote", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_initial_max_stream_data_bidi_remote(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_initial_max_stream_data_uni", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_initial_max_stream_data_uni(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_initial_max_streams_bidi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_initial_max_streams_bidi(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_initial_max_streams_uni", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_initial_max_streams_uni(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_ack_delay_exponent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_ack_delay_exponent(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_max_ack_delay", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_max_ack_delay(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_disable_active_migration", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_disable_active_migration(quiche_config* config, [MarshalAs(UnmanagedType.U1)] bool v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_cc_algorithm", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_cc_algorithm(quiche_config* config, int algo);

        [DllImport(__DllName, EntryPoint = "quiche_config_enable_hystart", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_enable_hystart(quiche_config* config, [MarshalAs(UnmanagedType.U1)] bool v);

        [DllImport(__DllName, EntryPoint = "quiche_config_enable_pacing", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_enable_pacing(quiche_config* config, [MarshalAs(UnmanagedType.U1)] bool v);

        [DllImport(__DllName, EntryPoint = "quiche_config_enable_dgram", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_enable_dgram(quiche_config* config, [MarshalAs(UnmanagedType.U1)] bool enabled, nuint recv_queue_len, nuint send_queue_len);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_max_connection_window", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_max_connection_window(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_max_stream_window", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_max_stream_window(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_active_connection_id_limit", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_active_connection_id_limit(quiche_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_config_set_stateless_reset_token", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_set_stateless_reset_token(quiche_config* config, byte* v);

        [DllImport(__DllName, EntryPoint = "quiche_config_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_config_free(quiche_config* config);

        [DllImport(__DllName, EntryPoint = "quiche_header_info", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_header_info(byte* buf, nuint buf_len, nuint dcil, uint* version, byte* type_, byte* scid, nuint* scid_len, byte* dcid, nuint* dcid_len, byte* token, nuint* token_len);

        [DllImport(__DllName, EntryPoint = "quiche_accept", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern quiche_conn* quiche_accept(byte* scid, nuint scid_len, byte* odcid, nuint odcid_len, sockaddr* local, nuint local_len, sockaddr* peer, nuint peer_len, quiche_config* config);

        [DllImport(__DllName, EntryPoint = "quiche_connect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern quiche_conn* quiche_connect(byte* server_name, byte* scid, nuint scid_len, sockaddr* local, nuint local_len, sockaddr* peer, nuint peer_len, quiche_config* config);

        [DllImport(__DllName, EntryPoint = "quiche_negotiate_version", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_negotiate_version(byte* scid, nuint scid_len, byte* dcid, nuint dcid_len, byte* @out, nuint out_len);

        [DllImport(__DllName, EntryPoint = "quiche_retry", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_retry(byte* scid, nuint scid_len, byte* dcid, nuint dcid_len, byte* new_scid, nuint new_scid_len, byte* token, nuint token_len, uint version, byte* @out, nuint out_len);

        [DllImport(__DllName, EntryPoint = "quiche_version_is_supported", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_version_is_supported(uint version);

        [DllImport(__DllName, EntryPoint = "quiche_conn_new_with_tls", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern quiche_conn* quiche_conn_new_with_tls(byte* scid, nuint scid_len, byte* odcid, nuint odcid_len, sockaddr* local, nuint local_len, sockaddr* peer, nuint peer_len, quiche_config* config, void* ssl, [MarshalAs(UnmanagedType.U1)] bool is_server);

        [DllImport(__DllName, EntryPoint = "quiche_conn_set_keylog_path", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_set_keylog_path(quiche_conn* conn, byte* path);

        [DllImport(__DllName, EntryPoint = "quiche_conn_set_keylog_fd", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_set_keylog_fd(quiche_conn* conn, int fd);

        [DllImport(__DllName, EntryPoint = "quiche_conn_set_qlog_path", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_set_qlog_path(quiche_conn* conn, byte* path, byte* log_title, byte* log_desc);

        [DllImport(__DllName, EntryPoint = "quiche_conn_set_qlog_fd", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_set_qlog_fd(quiche_conn* conn, int fd, byte* log_title, byte* log_desc);

        [DllImport(__DllName, EntryPoint = "quiche_conn_set_session", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_conn_set_session(quiche_conn* conn, byte* buf, nuint buf_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_recv", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_recv(quiche_conn* conn, byte* buf, nuint buf_len, quiche_recv_info* info);

        [DllImport(__DllName, EntryPoint = "quiche_conn_send", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_send(quiche_conn* conn, byte* @out, nuint out_len, quiche_send_info* out_info);

        [DllImport(__DllName, EntryPoint = "quiche_conn_send_quantum", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint quiche_conn_send_quantum(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_recv", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_stream_recv(quiche_conn* conn, ulong stream_id, byte* @out, nuint buf_len, bool* fin);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_send", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_stream_send(quiche_conn* conn, ulong stream_id, byte* buf, nuint buf_len, [MarshalAs(UnmanagedType.U1)] bool fin);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_priority", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_conn_stream_priority(quiche_conn* conn, ulong stream_id, byte urgency, [MarshalAs(UnmanagedType.U1)] bool incremental);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_shutdown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_conn_stream_shutdown(quiche_conn* conn, ulong stream_id, int direction, ulong err);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_capacity", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_stream_capacity(quiche_conn* conn, ulong stream_id);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_readable", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_stream_readable(quiche_conn* conn, ulong stream_id);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_readable_next", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_stream_readable_next(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_writable", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_conn_stream_writable(quiche_conn* conn, ulong stream_id, nuint len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_writable_next", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_stream_writable_next(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_finished", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_stream_finished(quiche_conn* conn, ulong stream_id);

        [DllImport(__DllName, EntryPoint = "quiche_conn_readable", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern quiche_stream_iter* quiche_conn_readable(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_writable", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern quiche_stream_iter* quiche_conn_writable(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_max_send_udp_payload_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint quiche_conn_max_send_udp_payload_size(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_timeout_as_nanos", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong quiche_conn_timeout_as_nanos(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_timeout_as_millis", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong quiche_conn_timeout_as_millis(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_on_timeout", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_on_timeout(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_close", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_conn_close(quiche_conn* conn, [MarshalAs(UnmanagedType.U1)] bool app, ulong err, byte* reason, nuint reason_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_trace_id", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_trace_id(quiche_conn* conn, byte** @out, nuint* out_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_source_id", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_source_id(quiche_conn* conn, byte** @out, nuint* out_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_destination_id", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_destination_id(quiche_conn* conn, byte** @out, nuint* out_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_application_proto", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_application_proto(quiche_conn* conn, byte** @out, nuint* out_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_peer_cert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_peer_cert(quiche_conn* conn, byte** @out, nuint* out_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_session", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_session(quiche_conn* conn, byte** @out, nuint* out_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_is_established", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_is_established(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_is_in_early_data", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_is_in_early_data(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_is_readable", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_is_readable(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_is_draining", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_is_draining(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_peer_streams_left_bidi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong quiche_conn_peer_streams_left_bidi(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_peer_streams_left_uni", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong quiche_conn_peer_streams_left_uni(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_is_closed", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_is_closed(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_is_timed_out", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_is_timed_out(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_peer_error", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_peer_error(quiche_conn* conn, bool* is_app, ulong* error_code, byte** reason, nuint* reason_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_local_error", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_conn_local_error(quiche_conn* conn, bool* is_app, ulong* error_code, byte** reason, nuint* reason_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_init_application_data", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_conn_stream_init_application_data(quiche_conn* conn, ulong stream_id, void* data);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stream_application_data", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* quiche_conn_stream_application_data(quiche_conn* conn, ulong stream_id);

        [DllImport(__DllName, EntryPoint = "quiche_stream_iter_next", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_stream_iter_next(quiche_stream_iter* iter, ulong* stream_id);

        [DllImport(__DllName, EntryPoint = "quiche_stream_iter_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_stream_iter_free(quiche_stream_iter* iter);

        [DllImport(__DllName, EntryPoint = "quiche_conn_stats", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_stats(quiche_conn* conn, quiche_stats* @out);

        [DllImport(__DllName, EntryPoint = "quiche_conn_path_stats", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_conn_path_stats(quiche_conn* conn, nuint idx, quiche_path_stats* @out);

        [DllImport(__DllName, EntryPoint = "quiche_conn_dgram_max_writable_len", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_dgram_max_writable_len(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_dgram_recv_front_len", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_dgram_recv_front_len(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_dgram_recv_queue_len", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_dgram_recv_queue_len(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_dgram_recv_queue_byte_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_dgram_recv_queue_byte_size(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_dgram_send_queue_len", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_dgram_send_queue_len(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_dgram_send_queue_byte_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_dgram_send_queue_byte_size(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_dgram_recv", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_dgram_recv(quiche_conn* conn, byte* buf, nuint buf_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_dgram_send", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_dgram_send(quiche_conn* conn, byte* buf, nuint buf_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_dgram_purge_outgoing", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_dgram_purge_outgoing(quiche_conn* conn, delegate* unmanaged[Cdecl]<byte*, nuint, bool> f);

        [DllImport(__DllName, EntryPoint = "quiche_conn_send_ack_eliciting", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_send_ack_eliciting(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_conn_send_ack_eliciting_on_path", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_conn_send_ack_eliciting_on_path(quiche_conn* conn, sockaddr* local, nuint local_len, sockaddr* peer, nuint peer_len);

        [DllImport(__DllName, EntryPoint = "quiche_conn_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_conn_free(quiche_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_h3_config_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern quiche_h3_config* quiche_h3_config_new();

        [DllImport(__DllName, EntryPoint = "quiche_h3_config_set_max_field_section_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_h3_config_set_max_field_section_size(quiche_h3_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_h3_config_set_qpack_max_table_capacity", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_h3_config_set_qpack_max_table_capacity(quiche_h3_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_h3_config_set_qpack_blocked_streams", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_h3_config_set_qpack_blocked_streams(quiche_h3_config* config, ulong v);

        [DllImport(__DllName, EntryPoint = "quiche_h3_config_enable_extended_connect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_h3_config_enable_extended_connect(quiche_h3_config* config, [MarshalAs(UnmanagedType.U1)] bool enabled);

        [DllImport(__DllName, EntryPoint = "quiche_h3_config_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_h3_config_free(quiche_h3_config* config);

        [DllImport(__DllName, EntryPoint = "quiche_h3_accept", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern quiche_h3_conn* quiche_h3_accept(quiche_conn* quiche_conn, quiche_h3_config* config);

        [DllImport(__DllName, EntryPoint = "quiche_h3_conn_new_with_transport", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern quiche_h3_conn* quiche_h3_conn_new_with_transport(quiche_conn* quiche_conn, quiche_h3_config* config);

        [DllImport(__DllName, EntryPoint = "quiche_h3_conn_poll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_h3_conn_poll(quiche_h3_conn* conn, quiche_conn* quic_conn, quiche_h3_event** ev);

        [DllImport(__DllName, EntryPoint = "quiche_h3_event_type", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_h3_event_type(quiche_h3_event* ev);

        [DllImport(__DllName, EntryPoint = "quiche_h3_event_for_each_header", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_h3_event_for_each_header(quiche_h3_event* ev, delegate* unmanaged[Cdecl]<byte*, nuint, byte*, nuint, void*, int> cb, void* argp);

        [DllImport(__DllName, EntryPoint = "quiche_h3_for_each_setting", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_h3_for_each_setting(quiche_h3_conn* conn, delegate* unmanaged[Cdecl]<ulong, ulong, void*, int> cb, void* argp);

        [DllImport(__DllName, EntryPoint = "quiche_h3_event_headers_has_body", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_h3_event_headers_has_body(quiche_h3_event* ev);

        [DllImport(__DllName, EntryPoint = "quiche_h3_extended_connect_enabled_by_peer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_h3_extended_connect_enabled_by_peer(quiche_h3_conn* conn);

        [DllImport(__DllName, EntryPoint = "quiche_h3_event_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_h3_event_free(quiche_h3_event* ev);

        [DllImport(__DllName, EntryPoint = "quiche_h3_send_request", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_h3_send_request(quiche_h3_conn* conn, quiche_conn* quic_conn, quiche_h3_header* headers, nuint headers_len, [MarshalAs(UnmanagedType.U1)] bool fin);

        [DllImport(__DllName, EntryPoint = "quiche_h3_send_response", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_h3_send_response(quiche_h3_conn* conn, quiche_conn* quic_conn, ulong stream_id, quiche_h3_header* headers, nuint headers_len, [MarshalAs(UnmanagedType.U1)] bool fin);

        [DllImport(__DllName, EntryPoint = "quiche_h3_send_response_with_priority", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_h3_send_response_with_priority(quiche_h3_conn* conn, quiche_conn* quic_conn, ulong stream_id, quiche_h3_header* headers, nuint headers_len, quiche_h3_priority* priority, [MarshalAs(UnmanagedType.U1)] bool fin);

        [DllImport(__DllName, EntryPoint = "quiche_h3_send_body", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_h3_send_body(quiche_h3_conn* conn, quiche_conn* quic_conn, ulong stream_id, byte* body, nuint body_len, [MarshalAs(UnmanagedType.U1)] bool fin);

        [DllImport(__DllName, EntryPoint = "quiche_h3_recv_body", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_h3_recv_body(quiche_h3_conn* conn, quiche_conn* quic_conn, ulong stream_id, byte* @out, nuint out_len);

        [DllImport(__DllName, EntryPoint = "quiche_h3_parse_extensible_priority", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_h3_parse_extensible_priority(byte* priority, nuint priority_len, quiche_h3_priority* parsed);

        /// <summary>Sends a PRIORITY_UPDATE frame on the control stream with specified request stream ID and priority.</summary>
        [DllImport(__DllName, EntryPoint = "quiche_h3_send_priority_update_for_request", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_h3_send_priority_update_for_request(quiche_h3_conn* conn, quiche_conn* quic_conn, ulong stream_id, quiche_h3_priority* priority);

        [DllImport(__DllName, EntryPoint = "quiche_h3_take_last_priority_update", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int quiche_h3_take_last_priority_update(quiche_h3_conn* conn, ulong prioritized_element_id, delegate* unmanaged[Cdecl]<byte*, ulong, void*, int> cb, void* argp);

        [DllImport(__DllName, EntryPoint = "quiche_h3_dgram_enabled_by_peer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool quiche_h3_dgram_enabled_by_peer(quiche_h3_conn* conn, quiche_conn* quic_conn);

        [DllImport(__DllName, EntryPoint = "quiche_h3_send_dgram", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_h3_send_dgram(quiche_h3_conn* conn, quiche_conn* quic_conn, ulong flow_id, byte* data, nuint data_len);

        [DllImport(__DllName, EntryPoint = "quiche_h3_recv_dgram", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long quiche_h3_recv_dgram(quiche_h3_conn* conn, quiche_conn* quic_conn, ulong* flow_id, nuint* flow_id_len, byte* @out, nuint out_len);

        [DllImport(__DllName, EntryPoint = "quiche_h3_conn_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void quiche_h3_conn_free(quiche_h3_conn* conn);


    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct sockaddr
    {
        public ushort sa_family;
        public fixed byte sa_data[14];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct sockaddr_storage
    {
        public ushort ss_family;
        public fixed byte __ss_pad1[6];
        public long __ss_align;
        public fixed byte __ss_pad2[112];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct timespec
    {
        public long tv_sec;
        public CLong tv_nsec;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_config
    {
        public fixed byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_conn
    {
        public fixed byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_recv_info
    {
        public sockaddr* from;
        public int from_len;
        public sockaddr* to;
        public int to_len;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_send_info
    {
        public sockaddr_storage from;
        public int from_len;
        public sockaddr_storage to;
        public int to_len;
        public timespec at;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_stream_iter
    {
        public fixed byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_stats
    {
        public nuint recv;
        public nuint sent;
        public nuint lost;
        public nuint retrans;
        public ulong sent_bytes;
        public ulong recv_bytes;
        public ulong lost_bytes;
        public ulong stream_retrans_bytes;
        public nuint paths_count;
        public ulong peer_max_idle_timeout;
        public ulong peer_max_udp_payload_size;
        public ulong peer_initial_max_data;
        public ulong peer_initial_max_stream_data_bidi_local;
        public ulong peer_initial_max_stream_data_bidi_remote;
        public ulong peer_initial_max_stream_data_uni;
        public ulong peer_initial_max_streams_bidi;
        public ulong peer_initial_max_streams_uni;
        public ulong peer_ack_delay_exponent;
        public ulong peer_max_ack_delay;
        [MarshalAs(UnmanagedType.U1)] public bool peer_disable_active_migration;
        public ulong peer_active_conn_id_limit;
        public long peer_max_datagram_frame_size;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_path_stats
    {
        public sockaddr_storage local_addr;
        public int local_addr_len;
        public sockaddr_storage peer_addr;
        public int peer_addr_len;
        public long validation_state;
        [MarshalAs(UnmanagedType.U1)] public bool active;
        public nuint recv;
        public nuint sent;
        public nuint lost;
        public nuint retrans;
        public ulong rtt;
        public nuint cwnd;
        public ulong sent_bytes;
        public ulong recv_bytes;
        public ulong lost_bytes;
        public ulong stream_retrans_bytes;
        public nuint pmtu;
        public ulong delivery_rate;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_h3_config
    {
        public fixed byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_h3_conn
    {
        public fixed byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_h3_event
    {
        public fixed byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_h3_header
    {
        public byte* name;
        public nuint name_len;
        public byte* value;
        public nuint value_len;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct quiche_h3_priority
    {
        public byte urgency;
        [MarshalAs(UnmanagedType.U1)] public bool incremental;
    }



}
    