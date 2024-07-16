using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class GLEX
	{
		public static bool IsExtensionFunctionSupported(string extensionFunctionName)
		{
			return Native.GetProcAddress(extensionFunctionName) != 0;
		}
		
		#region Constants
		
		public const uint GL_MULTISAMPLE_3DFX = 0x86B2;
		public const uint GL_SAMPLE_BUFFERS_3DFX = 0x86B3;
		public const uint GL_SAMPLES_3DFX = 0x86B4;
		public const uint GL_MULTISAMPLE_BIT_3DFX = 0x20000000;
		public const uint GL_COMPRESSED_RGB_FXT1_3DFX = 0x86B0;
		public const uint GL_COMPRESSED_RGBA_FXT1_3DFX = 0x86B1;
		public const uint GL_FACTOR_MIN_AMD = 0x901C;
		public const uint GL_FACTOR_MAX_AMD = 0x901D;
		public const uint GL_3DC_X_AMD = 0x87F9;
		public const uint GL_3DC_XY_AMD = 0x87FA;
		public const uint GL_ATC_RGB_AMD = 0x8C92;
		public const uint GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93;
		public const uint GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE;
		public const uint GL_MAX_DEBUG_MESSAGE_LENGTH_AMD = 0x9143;
		public const uint GL_MAX_DEBUG_LOGGED_MESSAGES_AMD = 0x9144;
		public const uint GL_DEBUG_LOGGED_MESSAGES_AMD = 0x9145;
		public const uint GL_DEBUG_SEVERITY_HIGH_AMD = 0x9146;
		public const uint GL_DEBUG_SEVERITY_MEDIUM_AMD = 0x9147;
		public const uint GL_DEBUG_SEVERITY_LOW_AMD = 0x9148;
		public const uint GL_DEBUG_CATEGORY_API_ERROR_AMD = 0x9149;
		public const uint GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMD = 0x914A;
		public const uint GL_DEBUG_CATEGORY_DEPRECATION_AMD = 0x914B;
		public const uint GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD = 0x914C;
		public const uint GL_DEBUG_CATEGORY_PERFORMANCE_AMD = 0x914D;
		public const uint GL_DEBUG_CATEGORY_SHADER_COMPILER_AMD = 0x914E;
		public const uint GL_DEBUG_CATEGORY_APPLICATION_AMD = 0x914F;
		public const uint GL_DEBUG_CATEGORY_OTHER_AMD = 0x9150;
		public const uint GL_DEPTH_CLAMP_NEAR_AMD = 0x901E;
		public const uint GL_DEPTH_CLAMP_FAR_AMD = 0x901F;
		public const uint GL_INT64_NV = 0x140E;
		public const uint GL_UNSIGNED_INT64_NV = 0x140F;
		public const uint GL_INT8_NV = 0x8FE0;
		public const uint GL_INT8_VEC2_NV = 0x8FE1;
		public const uint GL_INT8_VEC3_NV = 0x8FE2;
		public const uint GL_INT8_VEC4_NV = 0x8FE3;
		public const uint GL_INT16_NV = 0x8FE4;
		public const uint GL_INT16_VEC2_NV = 0x8FE5;
		public const uint GL_INT16_VEC3_NV = 0x8FE6;
		public const uint GL_INT16_VEC4_NV = 0x8FE7;
		public const uint GL_INT64_VEC2_NV = 0x8FE9;
		public const uint GL_INT64_VEC3_NV = 0x8FEA;
		public const uint GL_INT64_VEC4_NV = 0x8FEB;
		public const uint GL_UNSIGNED_INT8_NV = 0x8FEC;
		public const uint GL_UNSIGNED_INT8_VEC2_NV = 0x8FED;
		public const uint GL_UNSIGNED_INT8_VEC3_NV = 0x8FEE;
		public const uint GL_UNSIGNED_INT8_VEC4_NV = 0x8FEF;
		public const uint GL_UNSIGNED_INT16_NV = 0x8FF0;
		public const uint GL_UNSIGNED_INT16_VEC2_NV = 0x8FF1;
		public const uint GL_UNSIGNED_INT16_VEC3_NV = 0x8FF2;
		public const uint GL_UNSIGNED_INT16_VEC4_NV = 0x8FF3;
		public const uint GL_UNSIGNED_INT64_VEC2_NV = 0x8FF5;
		public const uint GL_UNSIGNED_INT64_VEC3_NV = 0x8FF6;
		public const uint GL_UNSIGNED_INT64_VEC4_NV = 0x8FF7;
		public const uint GL_FLOAT16_NV = 0x8FF8;
		public const uint GL_FLOAT16_VEC2_NV = 0x8FF9;
		public const uint GL_FLOAT16_VEC3_NV = 0x8FFA;
		public const uint GL_FLOAT16_VEC4_NV = 0x8FFB;
		public const uint GL_VERTEX_ELEMENT_SWIZZLE_AMD = 0x91A4;
		public const uint GL_VERTEX_ID_SWIZZLE_AMD = 0x91A5;
		public const uint GL_RED = 0x1903;
		public const uint GL_GREEN = 0x1904;
		public const uint GL_BLUE = 0x1905;
		public const uint GL_ALPHA = 0x1906;
		public const uint GL_RG8UI = 0x8238;
		public const uint GL_RG16UI = 0x823A;
		public const uint GL_RGBA8UI = 0x8D7C;
		public const uint GL_DATA_BUFFER_AMD = 0x9151;
		public const uint GL_PERFORMANCE_MONITOR_AMD = 0x9152;
		public const uint GL_QUERY_OBJECT_AMD = 0x9153;
		public const uint GL_VERTEX_ARRAY_OBJECT_AMD = 0x9154;
		public const uint GL_SAMPLER_OBJECT_AMD = 0x9155;
		public const uint GL_OCCLUSION_QUERY_EVENT_MASK_AMD = 0x874F;
		public const uint GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001;
		public const uint GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002;
		public const uint GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004;
		public const uint GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008;
		public const uint GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF;
		public const uint GL_COUNTER_TYPE_AMD = 0x8BC0;
		public const uint GL_COUNTER_RANGE_AMD = 0x8BC1;
		public const uint GL_UNSIGNED_INT64_AMD = 0x8BC2;
		public const uint GL_PERCENTAGE_AMD = 0x8BC3;
		public const uint GL_PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4;
		public const uint GL_PERFMON_RESULT_SIZE_AMD = 0x8BC5;
		public const uint GL_PERFMON_RESULT_AMD = 0x8BC6;
		public const uint GL_EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD = 0x9160;
		public const uint GL_Z400_BINARY_AMD = 0x8740;
		public const uint GL_QUERY_BUFFER_AMD = 0x9192;
		public const uint GL_QUERY_BUFFER_BINDING_AMD = 0x9193;
		public const uint GL_QUERY_RESULT_NO_WAIT_AMD = 0x9194;
		public const uint GL_SUBSAMPLE_DISTANCE_AMD = 0x883F;
		public const uint GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
		public const uint GL_VIRTUAL_PAGE_SIZE_X_AMD = 0x9195;
		public const uint GL_VIRTUAL_PAGE_SIZE_Y_AMD = 0x9196;
		public const uint GL_VIRTUAL_PAGE_SIZE_Z_AMD = 0x9197;
		public const uint GL_MAX_SPARSE_TEXTURE_SIZE_AMD = 0x9198;
		public const uint GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD = 0x9199;
		public const uint GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS = 0x919A;
		public const uint GL_MIN_SPARSE_LEVEL_AMD = 0x919B;
		public const uint GL_MIN_LOD_WARNING_AMD = 0x919C;
		public const uint GL_TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001;
		public const uint GL_SET_AMD = 0x874A;
		public const uint GL_REPLACE_VALUE_AMD = 0x874B;
		public const uint GL_STENCIL_OP_VALUE_AMD = 0x874C;
		public const uint GL_STENCIL_BACK_OP_VALUE_AMD = 0x874D;
		public const uint GL_STREAM_RASTERIZATION_AMD = 0x91A0;
		public const uint GL_SAMPLER_BUFFER_AMD = 0x9001;
		public const uint GL_INT_SAMPLER_BUFFER_AMD = 0x9002;
		public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003;
		public const uint GL_TESSELLATION_MODE_AMD = 0x9004;
		public const uint GL_TESSELLATION_FACTOR_AMD = 0x9005;
		public const uint GL_DISCRETE_AMD = 0x9006;
		public const uint GL_CONTINUOUS_AMD = 0x9007;
		public const uint GL_DEPTH_COMPONENT = 0x1902;
		public const uint GL_DEPTH_STENCIL_OES = 0x84F9;
		public const uint GL_UNSIGNED_SHORT = 0x1403;
		public const uint GL_UNSIGNED_INT = 0x1405;
		public const uint GL_UNSIGNED_INT_24_8_OES = 0x84FA;
		public const uint GL_DEPTH_COMPONENT16 = 0x81A5;
		public const uint GL_DEPTH_COMPONENT32_OES = 0x81A7;
		public const uint GL_DEPTH24_STENCIL8_OES = 0x88F0;
		public const uint GL_READ_FRAMEBUFFER_ANGLE = 0x8CA8;
		public const uint GL_DRAW_FRAMEBUFFER_ANGLE = 0x8CA9;
		public const uint GL_DRAW_FRAMEBUFFER_BINDING_ANGLE = 0x8CA6;
		public const uint GL_READ_FRAMEBUFFER_BINDING_ANGLE = 0x8CAA;
		public const uint GL_RENDERBUFFER_SAMPLES_ANGLE = 0x8CAB;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE = 0x8D56;
		public const uint GL_MAX_SAMPLES_ANGLE = 0x8D57;
		public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE = 0x88FE;
		public const uint GL_PACK_REVERSE_ROW_ORDER_ANGLE = 0x93A4;
		public const uint GL_PROGRAM_BINARY_ANGLE = 0x93A6;
		public const uint GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE = 0x83F2;
		public const uint GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE = 0x83F3;
		public const uint GL_TEXTURE_USAGE_ANGLE = 0x93A2;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_ANGLE = 0x93A3;
		public const uint GL_TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE = 0x93A0;
		public const uint GL_AUX_DEPTH_STENCIL_APPLE = 0x8A14;
		public const uint GL_UNPACK_CLIENT_STORAGE_APPLE = 0x85B2;
		public const uint GL_MAX_CLIP_DISTANCES_APPLE = 0x0D32;
		public const uint GL_CLIP_DISTANCE0_APPLE = 0x3000;
		public const uint GL_CLIP_DISTANCE1_APPLE = 0x3001;
		public const uint GL_CLIP_DISTANCE2_APPLE = 0x3002;
		public const uint GL_CLIP_DISTANCE3_APPLE = 0x3003;
		public const uint GL_CLIP_DISTANCE4_APPLE = 0x3004;
		public const uint GL_CLIP_DISTANCE5_APPLE = 0x3005;
		public const uint GL_CLIP_DISTANCE6_APPLE = 0x3006;
		public const uint GL_CLIP_DISTANCE7_APPLE = 0x3007;
		public const uint GL_ELEMENT_ARRAY_APPLE = 0x8A0C;
		public const uint GL_ELEMENT_ARRAY_TYPE_APPLE = 0x8A0D;
		public const uint GL_ELEMENT_ARRAY_POINTER_APPLE = 0x8A0E;
		public const uint GL_DRAW_PIXELS_APPLE = 0x8A0A;
		public const uint GL_FENCE_APPLE = 0x8A0B;
		public const uint GL_HALF_APPLE = 0x140B;
		public const uint GL_RGBA_FLOAT32_APPLE = 0x8814;
		public const uint GL_RGB_FLOAT32_APPLE = 0x8815;
		public const uint GL_ALPHA_FLOAT32_APPLE = 0x8816;
		public const uint GL_INTENSITY_FLOAT32_APPLE = 0x8817;
		public const uint GL_LUMINANCE_FLOAT32_APPLE = 0x8818;
		public const uint GL_LUMINANCE_ALPHA_FLOAT32_APPLE = 0x8819;
		public const uint GL_RGBA_FLOAT16_APPLE = 0x881A;
		public const uint GL_RGB_FLOAT16_APPLE = 0x881B;
		public const uint GL_ALPHA_FLOAT16_APPLE = 0x881C;
		public const uint GL_INTENSITY_FLOAT16_APPLE = 0x881D;
		public const uint GL_LUMINANCE_FLOAT16_APPLE = 0x881E;
		public const uint GL_LUMINANCE_ALPHA_FLOAT16_APPLE = 0x881F;
		public const uint GL_COLOR_FLOAT_APPLE = 0x8A0F;
		public const uint GL_BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12;
		public const uint GL_BUFFER_FLUSHING_UNMAP_APPLE = 0x8A13;
		public const uint GL_RENDERBUFFER_SAMPLES_APPLE = 0x8CAB;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56;
		public const uint GL_MAX_SAMPLES_APPLE = 0x8D57;
		public const uint GL_READ_FRAMEBUFFER_APPLE = 0x8CA8;
		public const uint GL_DRAW_FRAMEBUFFER_APPLE = 0x8CA9;
		public const uint GL_DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6;
		public const uint GL_READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA;
		public const uint GL_BUFFER_OBJECT_APPLE = 0x85B3;
		public const uint GL_RELEASED_APPLE = 0x8A19;
		public const uint GL_VOLATILE_APPLE = 0x8A1A;
		public const uint GL_RETAINED_APPLE = 0x8A1B;
		public const uint GL_UNDEFINED_APPLE = 0x8A1C;
		public const uint GL_PURGEABLE_APPLE = 0x8A1D;
		public const uint GL_RGB_422_APPLE = 0x8A1F;
		public const uint GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA;
		public const uint GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB;
		public const uint GL_RGB_RAW_422_APPLE = 0x8A51;
		public const uint GL_PACK_ROW_BYTES_APPLE = 0x8A15;
		public const uint GL_UNPACK_ROW_BYTES_APPLE = 0x8A16;
		public const uint GL_LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0;
		public const uint GL_SYNC_OBJECT_APPLE = 0x8A53;
		public const uint GL_MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111;
		public const uint GL_OBJECT_TYPE_APPLE = 0x9112;
		public const uint GL_SYNC_CONDITION_APPLE = 0x9113;
		public const uint GL_SYNC_STATUS_APPLE = 0x9114;
		public const uint GL_SYNC_FLAGS_APPLE = 0x9115;
		public const uint GL_SYNC_FENCE_APPLE = 0x9116;
		public const uint GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117;
		public const uint GL_UNSIGNALED_APPLE = 0x9118;
		public const uint GL_SIGNALED_APPLE = 0x9119;
		public const uint GL_ALREADY_SIGNALED_APPLE = 0x911A;
		public const uint GL_TIMEOUT_EXPIRED_APPLE = 0x911B;
		public const uint GL_CONDITION_SATISFIED_APPLE = 0x911C;
		public const uint GL_WAIT_FAILED_APPLE = 0x911D;
		public const uint GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001;
		public const uint GL_TIMEOUT_IGNORED_APPLE = 0xFFFFFFFF;
		public const uint GL_BGRA_EXT = 0x80E1;
		public const uint GL_BGRA8_EXT = 0x93A1;
		public const uint GL_TEXTURE_MAX_LEVEL_APPLE = 0x813D;
		public const uint GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE = 0x8C3B;
		public const uint GL_UNSIGNED_INT_5_9_9_9_REV_APPLE = 0x8C3E;
		public const uint GL_R11F_G11F_B10F_APPLE = 0x8C3A;
		public const uint GL_RGB9_E5_APPLE = 0x8C3D;
		public const uint GL_TEXTURE_RANGE_LENGTH_APPLE = 0x85B7;
		public const uint GL_TEXTURE_RANGE_POINTER_APPLE = 0x85B8;
		public const uint GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC;
		public const uint GL_STORAGE_PRIVATE_APPLE = 0x85BD;
		public const uint GL_STORAGE_CACHED_APPLE = 0x85BE;
		public const uint GL_STORAGE_SHARED_APPLE = 0x85BF;
		public const uint GL_TRANSFORM_HINT_APPLE = 0x85B1;
		public const uint GL_VERTEX_ARRAY_BINDING_APPLE = 0x85B5;
		public const uint GL_VERTEX_ARRAY_RANGE_APPLE = 0x851D;
		public const uint GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E;
		public const uint GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F;
		public const uint GL_VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521;
		public const uint GL_STORAGE_CLIENT_APPLE = 0x85B4;
		public const uint GL_VERTEX_ATTRIB_MAP1_APPLE = 0x8A00;
		public const uint GL_VERTEX_ATTRIB_MAP2_APPLE = 0x8A01;
		public const uint GL_VERTEX_ATTRIB_MAP1_SIZE_APPLE = 0x8A02;
		public const uint GL_VERTEX_ATTRIB_MAP1_COEFF_APPLE = 0x8A03;
		public const uint GL_VERTEX_ATTRIB_MAP1_ORDER_APPLE = 0x8A04;
		public const uint GL_VERTEX_ATTRIB_MAP1_DOMAIN_APPLE = 0x8A05;
		public const uint GL_VERTEX_ATTRIB_MAP2_SIZE_APPLE = 0x8A06;
		public const uint GL_VERTEX_ATTRIB_MAP2_COEFF_APPLE = 0x8A07;
		public const uint GL_VERTEX_ATTRIB_MAP2_ORDER_APPLE = 0x8A08;
		public const uint GL_VERTEX_ATTRIB_MAP2_DOMAIN_APPLE = 0x8A09;
		public const uint GL_YCBCR_422_APPLE = 0x85B9;
		public const uint GL_FIXED = 0x140C;
		public const uint GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
		public const uint GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
		public const uint GL_LOW_FLOAT = 0x8DF0;
		public const uint GL_MEDIUM_FLOAT = 0x8DF1;
		public const uint GL_HIGH_FLOAT = 0x8DF2;
		public const uint GL_LOW_INT = 0x8DF3;
		public const uint GL_MEDIUM_INT = 0x8DF4;
		public const uint GL_HIGH_INT = 0x8DF5;
		public const uint GL_SHADER_COMPILER = 0x8DFA;
		public const uint GL_SHADER_BINARY_FORMATS = 0x8DF8;
		public const uint GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
		public const uint GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		public const uint GL_MAX_VARYING_VECTORS = 0x8DFC;
		public const uint GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
		public const uint GL_RGB565 = 0x8D62;
		public const uint GL_BACK = 0x0405;
		public const uint GL_PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE;
		public const uint GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381;
		public const uint GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382;
		public const uint GL_COMPRESSED_RGB8_ETC2 = 0x9274;
		public const uint GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
		public const uint GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
		public const uint GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
		public const uint GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
		public const uint GL_COMPRESSED_R11_EAC = 0x9270;
		public const uint GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
		public const uint GL_COMPRESSED_RG11_EAC = 0x9272;
		public const uint GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
		public const uint GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
		public const uint GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
		public const uint GL_MAX_ELEMENT_INDEX = 0x8D6B;
		public const uint GL_UNSIGNED_INT64_ARB = 0x140F;
		public const uint GL_SRC1_COLOR = 0x88F9;
		public const uint GL_SRC1_ALPHA = 0x8589;
		public const uint GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
		public const uint GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
		public const uint GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
		public const uint GL_MAP_READ_BIT = 0x0001;
		public const uint GL_MAP_WRITE_BIT = 0x0002;
		public const uint GL_MAP_PERSISTENT_BIT = 0x0040;
		public const uint GL_MAP_COHERENT_BIT = 0x0080;
		public const uint GL_DYNAMIC_STORAGE_BIT = 0x0100;
		public const uint GL_CLIENT_STORAGE_BIT = 0x0200;
		public const uint GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
		public const uint GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
		public const uint GL_BUFFER_STORAGE_FLAGS = 0x8220;
		public const uint GL_SYNC_CL_EVENT_ARB = 0x8240;
		public const uint GL_SYNC_CL_EVENT_COMPLETE_ARB = 0x8241;
		public const uint GL_CLEAR_TEXTURE = 0x9365;
		public const uint GL_LOWER_LEFT = 0x8CA1;
		public const uint GL_UPPER_LEFT = 0x8CA2;
		public const uint GL_NEGATIVE_ONE_TO_ONE = 0x935E;
		public const uint GL_ZERO_TO_ONE = 0x935F;
		public const uint GL_CLIP_ORIGIN = 0x935C;
		public const uint GL_CLIP_DEPTH_MODE = 0x935D;
		public const uint GL_RGBA_FLOAT_MODE_ARB = 0x8820;
		public const uint GL_CLAMP_VERTEX_COLOR_ARB = 0x891A;
		public const uint GL_CLAMP_FRAGMENT_COLOR_ARB = 0x891B;
		public const uint GL_CLAMP_READ_COLOR_ARB = 0x891C;
		public const uint GL_FIXED_ONLY_ARB = 0x891D;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
		public const uint GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
		public const uint GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
		public const uint GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
		public const uint GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
		public const uint GL_COMPUTE_SHADER = 0x91B9;
		public const uint GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
		public const uint GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
		public const uint GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
		public const uint GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
		public const uint GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
		public const uint GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
		public const uint GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
		public const uint GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
		public const uint GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
		public const uint GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
		public const uint GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
		public const uint GL_COMPUTE_SHADER_BIT = 0x00000020;
		public const uint GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344;
		public const uint GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB;
		public const uint GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345;
		public const uint GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF;
		public const uint GL_QUERY_WAIT_INVERTED = 0x8E17;
		public const uint GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
		public const uint GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
		public const uint GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
		public const uint GL_COPY_READ_BUFFER = 0x8F36;
		public const uint GL_COPY_WRITE_BUFFER = 0x8F37;
		public const uint GL_MAX_CULL_DISTANCES = 0x82F9;
		public const uint GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
		public const uint GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242;
		public const uint GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243;
		public const uint GL_DEBUG_CALLBACK_FUNCTION_ARB = 0x8244;
		public const uint GL_DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245;
		public const uint GL_DEBUG_SOURCE_API_ARB = 0x8246;
		public const uint GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247;
		public const uint GL_DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248;
		public const uint GL_DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249;
		public const uint GL_DEBUG_SOURCE_APPLICATION_ARB = 0x824A;
		public const uint GL_DEBUG_SOURCE_OTHER_ARB = 0x824B;
		public const uint GL_DEBUG_TYPE_ERROR_ARB = 0x824C;
		public const uint GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D;
		public const uint GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E;
		public const uint GL_DEBUG_TYPE_PORTABILITY_ARB = 0x824F;
		public const uint GL_DEBUG_TYPE_PERFORMANCE_ARB = 0x8250;
		public const uint GL_DEBUG_TYPE_OTHER_ARB = 0x8251;
		public const uint GL_MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143;
		public const uint GL_MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144;
		public const uint GL_DEBUG_LOGGED_MESSAGES_ARB = 0x9145;
		public const uint GL_DEBUG_SEVERITY_HIGH_ARB = 0x9146;
		public const uint GL_DEBUG_SEVERITY_MEDIUM_ARB = 0x9147;
		public const uint GL_DEBUG_SEVERITY_LOW_ARB = 0x9148;
		public const uint GL_DEPTH_COMPONENT32F = 0x8CAC;
		public const uint GL_DEPTH32F_STENCIL8 = 0x8CAD;
		public const uint GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
		public const uint GL_DEPTH_CLAMP = 0x864F;
		public const uint GL_DEPTH_COMPONENT16_ARB = 0x81A5;
		public const uint GL_DEPTH_COMPONENT24_ARB = 0x81A6;
		public const uint GL_DEPTH_COMPONENT32_ARB = 0x81A7;
		public const uint GL_TEXTURE_DEPTH_SIZE_ARB = 0x884A;
		public const uint GL_DEPTH_TEXTURE_MODE_ARB = 0x884B;
		public const uint GL_TEXTURE_TARGET = 0x1006;
		public const uint GL_QUERY_TARGET = 0x82EA;
		public const uint GL_TEXTURE_BINDING_1D = 0x8068;
		public const uint GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
		public const uint GL_TEXTURE_BINDING_2D = 0x8069;
		public const uint GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
		public const uint GL_TEXTURE_BINDING_3D = 0x806A;
		public const uint GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
		public const uint GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
		public const uint GL_MAX_DRAW_BUFFERS_ARB = 0x8824;
		public const uint GL_DRAW_BUFFER0_ARB = 0x8825;
		public const uint GL_DRAW_BUFFER1_ARB = 0x8826;
		public const uint GL_DRAW_BUFFER2_ARB = 0x8827;
		public const uint GL_DRAW_BUFFER3_ARB = 0x8828;
		public const uint GL_DRAW_BUFFER4_ARB = 0x8829;
		public const uint GL_DRAW_BUFFER5_ARB = 0x882A;
		public const uint GL_DRAW_BUFFER6_ARB = 0x882B;
		public const uint GL_DRAW_BUFFER7_ARB = 0x882C;
		public const uint GL_DRAW_BUFFER8_ARB = 0x882D;
		public const uint GL_DRAW_BUFFER9_ARB = 0x882E;
		public const uint GL_DRAW_BUFFER10_ARB = 0x882F;
		public const uint GL_DRAW_BUFFER11_ARB = 0x8830;
		public const uint GL_DRAW_BUFFER12_ARB = 0x8831;
		public const uint GL_DRAW_BUFFER13_ARB = 0x8832;
		public const uint GL_DRAW_BUFFER14_ARB = 0x8833;
		public const uint GL_DRAW_BUFFER15_ARB = 0x8834;
		public const uint GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
		public const uint GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
		public const uint GL_LOCATION_COMPONENT = 0x934A;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
		public const uint GL_MAX_UNIFORM_LOCATIONS = 0x826E;
		public const uint GL_FRAGMENT_PROGRAM_ARB = 0x8804;
		public const uint GL_PROGRAM_FORMAT_ASCII_ARB = 0x8875;
		public const uint GL_PROGRAM_LENGTH_ARB = 0x8627;
		public const uint GL_PROGRAM_FORMAT_ARB = 0x8876;
		public const uint GL_PROGRAM_BINDING_ARB = 0x8677;
		public const uint GL_PROGRAM_INSTRUCTIONS_ARB = 0x88A0;
		public const uint GL_MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1;
		public const uint GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2;
		public const uint GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3;
		public const uint GL_PROGRAM_TEMPORARIES_ARB = 0x88A4;
		public const uint GL_MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5;
		public const uint GL_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6;
		public const uint GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7;
		public const uint GL_PROGRAM_PARAMETERS_ARB = 0x88A8;
		public const uint GL_MAX_PROGRAM_PARAMETERS_ARB = 0x88A9;
		public const uint GL_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA;
		public const uint GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB;
		public const uint GL_PROGRAM_ATTRIBS_ARB = 0x88AC;
		public const uint GL_MAX_PROGRAM_ATTRIBS_ARB = 0x88AD;
		public const uint GL_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE;
		public const uint GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF;
		public const uint GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;
		public const uint GL_MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;
		public const uint GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;
		public const uint GL_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805;
		public const uint GL_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806;
		public const uint GL_PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807;
		public const uint GL_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808;
		public const uint GL_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809;
		public const uint GL_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A;
		public const uint GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B;
		public const uint GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C;
		public const uint GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D;
		public const uint GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E;
		public const uint GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F;
		public const uint GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810;
		public const uint GL_PROGRAM_STRING_ARB = 0x8628;
		public const uint GL_PROGRAM_ERROR_POSITION_ARB = 0x864B;
		public const uint GL_CURRENT_MATRIX_ARB = 0x8641;
		public const uint GL_TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;
		public const uint GL_CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;
		public const uint GL_MAX_PROGRAM_MATRICES_ARB = 0x862F;
		public const uint GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;
		public const uint GL_MAX_TEXTURE_COORDS_ARB = 0x8871;
		public const uint GL_MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872;
		public const uint GL_PROGRAM_ERROR_STRING_ARB = 0x8874;
		public const uint GL_MATRIX0_ARB = 0x88C0;
		public const uint GL_MATRIX1_ARB = 0x88C1;
		public const uint GL_MATRIX2_ARB = 0x88C2;
		public const uint GL_MATRIX3_ARB = 0x88C3;
		public const uint GL_MATRIX4_ARB = 0x88C4;
		public const uint GL_MATRIX5_ARB = 0x88C5;
		public const uint GL_MATRIX6_ARB = 0x88C6;
		public const uint GL_MATRIX7_ARB = 0x88C7;
		public const uint GL_MATRIX8_ARB = 0x88C8;
		public const uint GL_MATRIX9_ARB = 0x88C9;
		public const uint GL_MATRIX10_ARB = 0x88CA;
		public const uint GL_MATRIX11_ARB = 0x88CB;
		public const uint GL_MATRIX12_ARB = 0x88CC;
		public const uint GL_MATRIX13_ARB = 0x88CD;
		public const uint GL_MATRIX14_ARB = 0x88CE;
		public const uint GL_MATRIX15_ARB = 0x88CF;
		public const uint GL_MATRIX16_ARB = 0x88D0;
		public const uint GL_MATRIX17_ARB = 0x88D1;
		public const uint GL_MATRIX18_ARB = 0x88D2;
		public const uint GL_MATRIX19_ARB = 0x88D3;
		public const uint GL_MATRIX20_ARB = 0x88D4;
		public const uint GL_MATRIX21_ARB = 0x88D5;
		public const uint GL_MATRIX22_ARB = 0x88D6;
		public const uint GL_MATRIX23_ARB = 0x88D7;
		public const uint GL_MATRIX24_ARB = 0x88D8;
		public const uint GL_MATRIX25_ARB = 0x88D9;
		public const uint GL_MATRIX26_ARB = 0x88DA;
		public const uint GL_MATRIX27_ARB = 0x88DB;
		public const uint GL_MATRIX28_ARB = 0x88DC;
		public const uint GL_MATRIX29_ARB = 0x88DD;
		public const uint GL_MATRIX30_ARB = 0x88DE;
		public const uint GL_MATRIX31_ARB = 0x88DF;
		public const uint GL_FRAGMENT_SHADER_ARB = 0x8B30;
		public const uint GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB = 0x8B49;
		public const uint GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B;
		public const uint GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
		public const uint GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
		public const uint GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
		public const uint GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
		public const uint GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
		public const uint GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
		public const uint GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
		public const uint GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
		public const uint GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
		public const uint GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
		public const uint GL_FRAMEBUFFER_DEFAULT = 0x8218;
		public const uint GL_FRAMEBUFFER_UNDEFINED = 0x8219;
		public const uint GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
		public const uint GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
		public const uint GL_DEPTH_STENCIL = 0x84F9;
		public const uint GL_UNSIGNED_INT_24_8 = 0x84FA;
		public const uint GL_DEPTH24_STENCIL8 = 0x88F0;
		public const uint GL_TEXTURE_STENCIL_SIZE = 0x88F1;
		public const uint GL_UNSIGNED_NORMALIZED = 0x8C17;
		public const uint GL_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint GL_RENDERBUFFER_BINDING = 0x8CA7;
		public const uint GL_READ_FRAMEBUFFER = 0x8CA8;
		public const uint GL_DRAW_FRAMEBUFFER = 0x8CA9;
		public const uint GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
		public const uint GL_RENDERBUFFER_SAMPLES = 0x8CAB;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
		public const uint GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
		public const uint GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		public const uint GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
		public const uint GL_COLOR_ATTACHMENT0 = 0x8CE0;
		public const uint GL_COLOR_ATTACHMENT1 = 0x8CE1;
		public const uint GL_COLOR_ATTACHMENT2 = 0x8CE2;
		public const uint GL_COLOR_ATTACHMENT3 = 0x8CE3;
		public const uint GL_COLOR_ATTACHMENT4 = 0x8CE4;
		public const uint GL_COLOR_ATTACHMENT5 = 0x8CE5;
		public const uint GL_COLOR_ATTACHMENT6 = 0x8CE6;
		public const uint GL_COLOR_ATTACHMENT7 = 0x8CE7;
		public const uint GL_COLOR_ATTACHMENT8 = 0x8CE8;
		public const uint GL_COLOR_ATTACHMENT9 = 0x8CE9;
		public const uint GL_COLOR_ATTACHMENT10 = 0x8CEA;
		public const uint GL_COLOR_ATTACHMENT11 = 0x8CEB;
		public const uint GL_COLOR_ATTACHMENT12 = 0x8CEC;
		public const uint GL_COLOR_ATTACHMENT13 = 0x8CED;
		public const uint GL_COLOR_ATTACHMENT14 = 0x8CEE;
		public const uint GL_COLOR_ATTACHMENT15 = 0x8CEF;
		public const uint GL_DEPTH_ATTACHMENT = 0x8D00;
		public const uint GL_STENCIL_ATTACHMENT = 0x8D20;
		public const uint GL_FRAMEBUFFER = 0x8D40;
		public const uint GL_RENDERBUFFER = 0x8D41;
		public const uint GL_RENDERBUFFER_WIDTH = 0x8D42;
		public const uint GL_RENDERBUFFER_HEIGHT = 0x8D43;
		public const uint GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		public const uint GL_STENCIL_INDEX1 = 0x8D46;
		public const uint GL_STENCIL_INDEX4 = 0x8D47;
		public const uint GL_STENCIL_INDEX8 = 0x8D48;
		public const uint GL_STENCIL_INDEX16 = 0x8D49;
		public const uint GL_RENDERBUFFER_RED_SIZE = 0x8D50;
		public const uint GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
		public const uint GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
		public const uint GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		public const uint GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		public const uint GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
		public const uint GL_MAX_SAMPLES = 0x8D57;
		public const uint GL_INDEX = 0x8222;
		public const uint GL_FRAMEBUFFER_SRGB = 0x8DB9;
		public const uint GL_LINES_ADJACENCY_ARB = 0x000A;
		public const uint GL_LINE_STRIP_ADJACENCY_ARB = 0x000B;
		public const uint GL_TRIANGLES_ADJACENCY_ARB = 0x000C;
		public const uint GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D;
		public const uint GL_PROGRAM_POINT_SIZE_ARB = 0x8642;
		public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;
		public const uint GL_GEOMETRY_SHADER_ARB = 0x8DD9;
		public const uint GL_GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;
		public const uint GL_GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;
		public const uint GL_GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;
		public const uint GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;
		public const uint GL_MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;
		public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF;
		public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0;
		public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1;
		public const uint GL_MAX_VARYING_COMPONENTS = 0x8B4B;
		public const uint GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
		public const uint GL_PROGRAM_BINARY_LENGTH = 0x8741;
		public const uint GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
		public const uint GL_PROGRAM_BINARY_FORMATS = 0x87FF;
		public const uint GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
		public const uint GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
		public const uint GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
		public const uint GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
		public const uint GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
		public const uint GL_MAX_VERTEX_STREAMS = 0x8E71;
		public const uint GL_DOUBLE = 0x140A;
		public const uint GL_DOUBLE_VEC2 = 0x8FFC;
		public const uint GL_DOUBLE_VEC3 = 0x8FFD;
		public const uint GL_DOUBLE_VEC4 = 0x8FFE;
		public const uint GL_DOUBLE_MAT2 = 0x8F46;
		public const uint GL_DOUBLE_MAT3 = 0x8F47;
		public const uint GL_DOUBLE_MAT4 = 0x8F48;
		public const uint GL_DOUBLE_MAT2x3 = 0x8F49;
		public const uint GL_DOUBLE_MAT2x4 = 0x8F4A;
		public const uint GL_DOUBLE_MAT3x2 = 0x8F4B;
		public const uint GL_DOUBLE_MAT3x4 = 0x8F4C;
		public const uint GL_DOUBLE_MAT4x2 = 0x8F4D;
		public const uint GL_DOUBLE_MAT4x3 = 0x8F4E;
		public const uint GL_INT64_ARB = 0x140E;
		public const uint GL_INT64_VEC2_ARB = 0x8FE9;
		public const uint GL_INT64_VEC3_ARB = 0x8FEA;
		public const uint GL_INT64_VEC4_ARB = 0x8FEB;
		public const uint GL_UNSIGNED_INT64_VEC2_ARB = 0x8FF5;
		public const uint GL_UNSIGNED_INT64_VEC3_ARB = 0x8FF6;
		public const uint GL_UNSIGNED_INT64_VEC4_ARB = 0x8FF7;
		public const uint GL_HALF_FLOAT_ARB = 0x140B;
		public const uint GL_HALF_FLOAT = 0x140B;
		public const uint GL_CONSTANT_COLOR = 0x8001;
		public const uint GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const uint GL_CONSTANT_ALPHA = 0x8003;
		public const uint GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		public const uint GL_BLEND_COLOR = 0x8005;
		public const uint GL_FUNC_ADD = 0x8006;
		public const uint GL_MIN = 0x8007;
		public const uint GL_MAX = 0x8008;
		public const uint GL_BLEND_EQUATION = 0x8009;
		public const uint GL_FUNC_SUBTRACT = 0x800A;
		public const uint GL_FUNC_REVERSE_SUBTRACT = 0x800B;
		public const uint GL_CONVOLUTION_1D = 0x8010;
		public const uint GL_CONVOLUTION_2D = 0x8011;
		public const uint GL_SEPARABLE_2D = 0x8012;
		public const uint GL_CONVOLUTION_BORDER_MODE = 0x8013;
		public const uint GL_CONVOLUTION_FILTER_SCALE = 0x8014;
		public const uint GL_CONVOLUTION_FILTER_BIAS = 0x8015;
		public const uint GL_REDUCE = 0x8016;
		public const uint GL_CONVOLUTION_FORMAT = 0x8017;
		public const uint GL_CONVOLUTION_WIDTH = 0x8018;
		public const uint GL_CONVOLUTION_HEIGHT = 0x8019;
		public const uint GL_MAX_CONVOLUTION_WIDTH = 0x801A;
		public const uint GL_MAX_CONVOLUTION_HEIGHT = 0x801B;
		public const uint GL_POST_CONVOLUTION_RED_SCALE = 0x801C;
		public const uint GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D;
		public const uint GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E;
		public const uint GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F;
		public const uint GL_POST_CONVOLUTION_RED_BIAS = 0x8020;
		public const uint GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021;
		public const uint GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022;
		public const uint GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023;
		public const uint GL_HISTOGRAM = 0x8024;
		public const uint GL_PROXY_HISTOGRAM = 0x8025;
		public const uint GL_HISTOGRAM_WIDTH = 0x8026;
		public const uint GL_HISTOGRAM_FORMAT = 0x8027;
		public const uint GL_HISTOGRAM_RED_SIZE = 0x8028;
		public const uint GL_HISTOGRAM_GREEN_SIZE = 0x8029;
		public const uint GL_HISTOGRAM_BLUE_SIZE = 0x802A;
		public const uint GL_HISTOGRAM_ALPHA_SIZE = 0x802B;
		public const uint GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C;
		public const uint GL_HISTOGRAM_SINK = 0x802D;
		public const uint GL_MINMAX = 0x802E;
		public const uint GL_MINMAX_FORMAT = 0x802F;
		public const uint GL_MINMAX_SINK = 0x8030;
		public const uint GL_TABLE_TOO_LARGE = 0x8031;
		public const uint GL_COLOR_MATRIX = 0x80B1;
		public const uint GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2;
		public const uint GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
		public const uint GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4;
		public const uint GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;
		public const uint GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;
		public const uint GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;
		public const uint GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8;
		public const uint GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;
		public const uint GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;
		public const uint GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;
		public const uint GL_COLOR_TABLE = 0x80D0;
		public const uint GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
		public const uint GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
		public const uint GL_PROXY_COLOR_TABLE = 0x80D3;
		public const uint GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
		public const uint GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
		public const uint GL_COLOR_TABLE_SCALE = 0x80D6;
		public const uint GL_COLOR_TABLE_BIAS = 0x80D7;
		public const uint GL_COLOR_TABLE_FORMAT = 0x80D8;
		public const uint GL_COLOR_TABLE_WIDTH = 0x80D9;
		public const uint GL_COLOR_TABLE_RED_SIZE = 0x80DA;
		public const uint GL_COLOR_TABLE_GREEN_SIZE = 0x80DB;
		public const uint GL_COLOR_TABLE_BLUE_SIZE = 0x80DC;
		public const uint GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD;
		public const uint GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;
		public const uint GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF;
		public const uint GL_CONSTANT_BORDER = 0x8151;
		public const uint GL_REPLICATE_BORDER = 0x8153;
		public const uint GL_CONVOLUTION_BORDER_COLOR = 0x8154;
		public const uint GL_PARAMETER_BUFFER_ARB = 0x80EE;
		public const uint GL_PARAMETER_BUFFER_BINDING_ARB = 0x80EF;
		public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE;
		public const uint GL_NUM_SAMPLE_COUNTS = 0x9380;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
		public const uint GL_SAMPLES = 0x80A9;
		public const uint GL_TEXTURE_1D = 0x0DE0;
		public const uint GL_TEXTURE_1D_ARRAY = 0x8C18;
		public const uint GL_TEXTURE_2D = 0x0DE1;
		public const uint GL_TEXTURE_2D_ARRAY = 0x8C1A;
		public const uint GL_TEXTURE_3D = 0x806F;
		public const uint GL_TEXTURE_CUBE_MAP = 0x8513;
		public const uint GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
		public const uint GL_TEXTURE_RECTANGLE = 0x84F5;
		public const uint GL_TEXTURE_BUFFER = 0x8C2A;
		public const uint GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
		public const uint GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
		public const uint GL_TEXTURE_COMPRESSED = 0x86A1;
		public const uint GL_INTERNALFORMAT_SUPPORTED = 0x826F;
		public const uint GL_INTERNALFORMAT_PREFERRED = 0x8270;
		public const uint GL_INTERNALFORMAT_RED_SIZE = 0x8271;
		public const uint GL_INTERNALFORMAT_GREEN_SIZE = 0x8272;
		public const uint GL_INTERNALFORMAT_BLUE_SIZE = 0x8273;
		public const uint GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274;
		public const uint GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275;
		public const uint GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276;
		public const uint GL_INTERNALFORMAT_SHARED_SIZE = 0x8277;
		public const uint GL_INTERNALFORMAT_RED_TYPE = 0x8278;
		public const uint GL_INTERNALFORMAT_GREEN_TYPE = 0x8279;
		public const uint GL_INTERNALFORMAT_BLUE_TYPE = 0x827A;
		public const uint GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B;
		public const uint GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C;
		public const uint GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D;
		public const uint GL_MAX_WIDTH = 0x827E;
		public const uint GL_MAX_HEIGHT = 0x827F;
		public const uint GL_MAX_DEPTH = 0x8280;
		public const uint GL_MAX_LAYERS = 0x8281;
		public const uint GL_MAX_COMBINED_DIMENSIONS = 0x8282;
		public const uint GL_COLOR_COMPONENTS = 0x8283;
		public const uint GL_DEPTH_COMPONENTS = 0x8284;
		public const uint GL_STENCIL_COMPONENTS = 0x8285;
		public const uint GL_COLOR_RENDERABLE = 0x8286;
		public const uint GL_DEPTH_RENDERABLE = 0x8287;
		public const uint GL_STENCIL_RENDERABLE = 0x8288;
		public const uint GL_FRAMEBUFFER_RENDERABLE = 0x8289;
		public const uint GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
		public const uint GL_FRAMEBUFFER_BLEND = 0x828B;
		public const uint GL_READ_PIXELS = 0x828C;
		public const uint GL_READ_PIXELS_FORMAT = 0x828D;
		public const uint GL_READ_PIXELS_TYPE = 0x828E;
		public const uint GL_TEXTURE_IMAGE_FORMAT = 0x828F;
		public const uint GL_TEXTURE_IMAGE_TYPE = 0x8290;
		public const uint GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291;
		public const uint GL_GET_TEXTURE_IMAGE_TYPE = 0x8292;
		public const uint GL_MIPMAP = 0x8293;
		public const uint GL_MANUAL_GENERATE_MIPMAP = 0x8294;
		public const uint GL_AUTO_GENERATE_MIPMAP = 0x8295;
		public const uint GL_COLOR_ENCODING = 0x8296;
		public const uint GL_SRGB_READ = 0x8297;
		public const uint GL_SRGB_WRITE = 0x8298;
		public const uint GL_SRGB_DECODE_ARB = 0x8299;
		public const uint GL_FILTER = 0x829A;
		public const uint GL_VERTEX_TEXTURE = 0x829B;
		public const uint GL_TESS_CONTROL_TEXTURE = 0x829C;
		public const uint GL_TESS_EVALUATION_TEXTURE = 0x829D;
		public const uint GL_GEOMETRY_TEXTURE = 0x829E;
		public const uint GL_FRAGMENT_TEXTURE = 0x829F;
		public const uint GL_COMPUTE_TEXTURE = 0x82A0;
		public const uint GL_TEXTURE_SHADOW = 0x82A1;
		public const uint GL_TEXTURE_GATHER = 0x82A2;
		public const uint GL_TEXTURE_GATHER_SHADOW = 0x82A3;
		public const uint GL_SHADER_IMAGE_LOAD = 0x82A4;
		public const uint GL_SHADER_IMAGE_STORE = 0x82A5;
		public const uint GL_SHADER_IMAGE_ATOMIC = 0x82A6;
		public const uint GL_IMAGE_TEXEL_SIZE = 0x82A7;
		public const uint GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8;
		public const uint GL_IMAGE_PIXEL_FORMAT = 0x82A9;
		public const uint GL_IMAGE_PIXEL_TYPE = 0x82AA;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
		public const uint GL_CLEAR_BUFFER = 0x82B4;
		public const uint GL_TEXTURE_VIEW = 0x82B5;
		public const uint GL_VIEW_COMPATIBILITY_CLASS = 0x82B6;
		public const uint GL_FULL_SUPPORT = 0x82B7;
		public const uint GL_CAVEAT_SUPPORT = 0x82B8;
		public const uint GL_IMAGE_CLASS_4_X_32 = 0x82B9;
		public const uint GL_IMAGE_CLASS_2_X_32 = 0x82BA;
		public const uint GL_IMAGE_CLASS_1_X_32 = 0x82BB;
		public const uint GL_IMAGE_CLASS_4_X_16 = 0x82BC;
		public const uint GL_IMAGE_CLASS_2_X_16 = 0x82BD;
		public const uint GL_IMAGE_CLASS_1_X_16 = 0x82BE;
		public const uint GL_IMAGE_CLASS_4_X_8 = 0x82BF;
		public const uint GL_IMAGE_CLASS_2_X_8 = 0x82C0;
		public const uint GL_IMAGE_CLASS_1_X_8 = 0x82C1;
		public const uint GL_IMAGE_CLASS_11_11_10 = 0x82C2;
		public const uint GL_IMAGE_CLASS_10_10_10_2 = 0x82C3;
		public const uint GL_VIEW_CLASS_128_BITS = 0x82C4;
		public const uint GL_VIEW_CLASS_96_BITS = 0x82C5;
		public const uint GL_VIEW_CLASS_64_BITS = 0x82C6;
		public const uint GL_VIEW_CLASS_48_BITS = 0x82C7;
		public const uint GL_VIEW_CLASS_32_BITS = 0x82C8;
		public const uint GL_VIEW_CLASS_24_BITS = 0x82C9;
		public const uint GL_VIEW_CLASS_16_BITS = 0x82CA;
		public const uint GL_VIEW_CLASS_8_BITS = 0x82CB;
		public const uint GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
		public const uint GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
		public const uint GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
		public const uint GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
		public const uint GL_VIEW_CLASS_RGTC1_RED = 0x82D0;
		public const uint GL_VIEW_CLASS_RGTC2_RG = 0x82D1;
		public const uint GL_VIEW_CLASS_BPTC_UNORM = 0x82D2;
		public const uint GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3;
		public const uint GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
		public const uint GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
		public const uint GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
		public const uint GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
		public const uint GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
		public const uint GL_MATRIX_PALETTE_ARB = 0x8840;
		public const uint GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;
		public const uint GL_MAX_PALETTE_MATRICES_ARB = 0x8842;
		public const uint GL_CURRENT_PALETTE_MATRIX_ARB = 0x8843;
		public const uint GL_MATRIX_INDEX_ARRAY_ARB = 0x8844;
		public const uint GL_CURRENT_MATRIX_INDEX_ARB = 0x8845;
		public const uint GL_MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;
		public const uint GL_MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;
		public const uint GL_MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;
		public const uint GL_MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;
		public const uint GL_MULTISAMPLE_ARB = 0x809D;
		public const uint GL_SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;
		public const uint GL_SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;
		public const uint GL_SAMPLE_COVERAGE_ARB = 0x80A0;
		public const uint GL_SAMPLE_BUFFERS_ARB = 0x80A8;
		public const uint GL_SAMPLES_ARB = 0x80A9;
		public const uint GL_SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;
		public const uint GL_SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;
		public const uint GL_MULTISAMPLE_BIT_ARB = 0x20000000;
		public const uint GL_TEXTURE0_ARB = 0x84C0;
		public const uint GL_TEXTURE1_ARB = 0x84C1;
		public const uint GL_TEXTURE2_ARB = 0x84C2;
		public const uint GL_TEXTURE3_ARB = 0x84C3;
		public const uint GL_TEXTURE4_ARB = 0x84C4;
		public const uint GL_TEXTURE5_ARB = 0x84C5;
		public const uint GL_TEXTURE6_ARB = 0x84C6;
		public const uint GL_TEXTURE7_ARB = 0x84C7;
		public const uint GL_TEXTURE8_ARB = 0x84C8;
		public const uint GL_TEXTURE9_ARB = 0x84C9;
		public const uint GL_TEXTURE10_ARB = 0x84CA;
		public const uint GL_TEXTURE11_ARB = 0x84CB;
		public const uint GL_TEXTURE12_ARB = 0x84CC;
		public const uint GL_TEXTURE13_ARB = 0x84CD;
		public const uint GL_TEXTURE14_ARB = 0x84CE;
		public const uint GL_TEXTURE15_ARB = 0x84CF;
		public const uint GL_TEXTURE16_ARB = 0x84D0;
		public const uint GL_TEXTURE17_ARB = 0x84D1;
		public const uint GL_TEXTURE18_ARB = 0x84D2;
		public const uint GL_TEXTURE19_ARB = 0x84D3;
		public const uint GL_TEXTURE20_ARB = 0x84D4;
		public const uint GL_TEXTURE21_ARB = 0x84D5;
		public const uint GL_TEXTURE22_ARB = 0x84D6;
		public const uint GL_TEXTURE23_ARB = 0x84D7;
		public const uint GL_TEXTURE24_ARB = 0x84D8;
		public const uint GL_TEXTURE25_ARB = 0x84D9;
		public const uint GL_TEXTURE26_ARB = 0x84DA;
		public const uint GL_TEXTURE27_ARB = 0x84DB;
		public const uint GL_TEXTURE28_ARB = 0x84DC;
		public const uint GL_TEXTURE29_ARB = 0x84DD;
		public const uint GL_TEXTURE30_ARB = 0x84DE;
		public const uint GL_TEXTURE31_ARB = 0x84DF;
		public const uint GL_ACTIVE_TEXTURE_ARB = 0x84E0;
		public const uint GL_CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;
		public const uint GL_MAX_TEXTURE_UNITS_ARB = 0x84E2;
		public const uint GL_QUERY_COUNTER_BITS_ARB = 0x8864;
		public const uint GL_CURRENT_QUERY_ARB = 0x8865;
		public const uint GL_QUERY_RESULT_ARB = 0x8866;
		public const uint GL_QUERY_RESULT_AVAILABLE_ARB = 0x8867;
		public const uint GL_SAMPLES_PASSED_ARB = 0x8914;
		public const uint GL_ANY_SAMPLES_PASSED = 0x8C2F;
		public const uint GL_MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;
		public const uint GL_COMPLETION_STATUS_ARB = 0x91B1;
		public const uint GL_VERTICES_SUBMITTED_ARB = 0x82EE;
		public const uint GL_PRIMITIVES_SUBMITTED_ARB = 0x82EF;
		public const uint GL_VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0;
		public const uint GL_TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1;
		public const uint GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2;
		public const uint GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3;
		public const uint GL_FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4;
		public const uint GL_COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5;
		public const uint GL_CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6;
		public const uint GL_CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7;
		public const uint GL_PIXEL_PACK_BUFFER_ARB = 0x88EB;
		public const uint GL_PIXEL_UNPACK_BUFFER_ARB = 0x88EC;
		public const uint GL_PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED;
		public const uint GL_PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF;
		public const uint GL_POINT_SIZE_MIN_ARB = 0x8126;
		public const uint GL_POINT_SIZE_MAX_ARB = 0x8127;
		public const uint GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128;
		public const uint GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129;
		public const uint GL_POINT_SPRITE_ARB = 0x8861;
		public const uint GL_COORD_REPLACE_ARB = 0x8862;
		public const uint GL_UNIFORM = 0x92E1;
		public const uint GL_UNIFORM_BLOCK = 0x92E2;
		public const uint GL_PROGRAM_INPUT = 0x92E3;
		public const uint GL_PROGRAM_OUTPUT = 0x92E4;
		public const uint GL_BUFFER_VARIABLE = 0x92E5;
		public const uint GL_SHADER_STORAGE_BLOCK = 0x92E6;
		public const uint GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
		public const uint GL_VERTEX_SUBROUTINE = 0x92E8;
		public const uint GL_TESS_CONTROL_SUBROUTINE = 0x92E9;
		public const uint GL_TESS_EVALUATION_SUBROUTINE = 0x92EA;
		public const uint GL_GEOMETRY_SUBROUTINE = 0x92EB;
		public const uint GL_FRAGMENT_SUBROUTINE = 0x92EC;
		public const uint GL_COMPUTE_SUBROUTINE = 0x92ED;
		public const uint GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
		public const uint GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
		public const uint GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
		public const uint GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
		public const uint GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
		public const uint GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
		public const uint GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
		public const uint GL_ACTIVE_RESOURCES = 0x92F5;
		public const uint GL_MAX_NAME_LENGTH = 0x92F6;
		public const uint GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
		public const uint GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
		public const uint GL_NAME_LENGTH = 0x92F9;
		public const uint GL_TYPE = 0x92FA;
		public const uint GL_ARRAY_SIZE = 0x92FB;
		public const uint GL_OFFSET = 0x92FC;
		public const uint GL_BLOCK_INDEX = 0x92FD;
		public const uint GL_ARRAY_STRIDE = 0x92FE;
		public const uint GL_MATRIX_STRIDE = 0x92FF;
		public const uint GL_IS_ROW_MAJOR = 0x9300;
		public const uint GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
		public const uint GL_BUFFER_BINDING = 0x9302;
		public const uint GL_BUFFER_DATA_SIZE = 0x9303;
		public const uint GL_NUM_ACTIVE_VARIABLES = 0x9304;
		public const uint GL_ACTIVE_VARIABLES = 0x9305;
		public const uint GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;
		public const uint GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
		public const uint GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
		public const uint GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
		public const uint GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
		public const uint GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
		public const uint GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
		public const uint GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
		public const uint GL_LOCATION = 0x930E;
		public const uint GL_LOCATION_INDEX = 0x930F;
		public const uint GL_IS_PER_PATCH = 0x92E7;
		public const uint GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
		public const uint GL_COMPATIBLE_SUBROUTINES = 0x8E4B;
		public const uint GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
		public const uint GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
		public const uint GL_LAST_VERTEX_CONVENTION = 0x8E4E;
		public const uint GL_PROVOKING_VERTEX = 0x8E4F;
		public const uint GL_QUERY_BUFFER = 0x9192;
		public const uint GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;
		public const uint GL_QUERY_BUFFER_BINDING = 0x9193;
		public const uint GL_QUERY_RESULT_NO_WAIT = 0x9194;
		public const uint GL_NO_ERROR = 0;
		public const uint GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004;
		public const uint GL_LOSE_CONTEXT_ON_RESET_ARB = 0x8252;
		public const uint GL_GUILTY_CONTEXT_RESET_ARB = 0x8253;
		public const uint GL_INNOCENT_CONTEXT_RESET_ARB = 0x8254;
		public const uint GL_UNKNOWN_CONTEXT_RESET_ARB = 0x8255;
		public const uint GL_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;
		public const uint GL_NO_RESET_NOTIFICATION_ARB = 0x8261;
		public const uint GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D;
		public const uint GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E;
		public const uint GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F;
		public const uint GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340;
		public const uint GL_SAMPLE_LOCATION_ARB = 0x8E50;
		public const uint GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341;
		public const uint GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342;
		public const uint GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343;
		public const uint GL_SAMPLE_SHADING_ARB = 0x8C36;
		public const uint GL_MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37;
		public const uint GL_SAMPLER_BINDING = 0x8919;
		public const uint GL_VERTEX_SHADER_BIT = 0x00000001;
		public const uint GL_FRAGMENT_SHADER_BIT = 0x00000002;
		public const uint GL_GEOMETRY_SHADER_BIT = 0x00000004;
		public const uint GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
		public const uint GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
		public const uint GL_ALL_SHADER_BITS = 0xFFFFFFFF;
		public const uint GL_PROGRAM_SEPARABLE = 0x8258;
		public const uint GL_ACTIVE_PROGRAM = 0x8259;
		public const uint GL_PROGRAM_PIPELINE_BINDING = 0x825A;
		public const uint GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
		public const uint GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;
		public const uint GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
		public const uint GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
		public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
		public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
		public const uint GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
		public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
		public const uint GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
		public const uint GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
		public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
		public const uint GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
		public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
		public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
		public const uint GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
		public const uint GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
		public const uint GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
		public const uint GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
		public const uint GL_UNIFORM_BARRIER_BIT = 0x00000004;
		public const uint GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
		public const uint GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
		public const uint GL_COMMAND_BARRIER_BIT = 0x00000040;
		public const uint GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
		public const uint GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
		public const uint GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
		public const uint GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400;
		public const uint GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
		public const uint GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
		public const uint GL_ALL_BARRIER_BITS = 0xFFFFFFFF;
		public const uint GL_MAX_IMAGE_UNITS = 0x8F38;
		public const uint GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
		public const uint GL_IMAGE_BINDING_NAME = 0x8F3A;
		public const uint GL_IMAGE_BINDING_LEVEL = 0x8F3B;
		public const uint GL_IMAGE_BINDING_LAYERED = 0x8F3C;
		public const uint GL_IMAGE_BINDING_LAYER = 0x8F3D;
		public const uint GL_IMAGE_BINDING_ACCESS = 0x8F3E;
		public const uint GL_IMAGE_1D = 0x904C;
		public const uint GL_IMAGE_2D = 0x904D;
		public const uint GL_IMAGE_3D = 0x904E;
		public const uint GL_IMAGE_2D_RECT = 0x904F;
		public const uint GL_IMAGE_CUBE = 0x9050;
		public const uint GL_IMAGE_BUFFER = 0x9051;
		public const uint GL_IMAGE_1D_ARRAY = 0x9052;
		public const uint GL_IMAGE_2D_ARRAY = 0x9053;
		public const uint GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;
		public const uint GL_IMAGE_2D_MULTISAMPLE = 0x9055;
		public const uint GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
		public const uint GL_INT_IMAGE_1D = 0x9057;
		public const uint GL_INT_IMAGE_2D = 0x9058;
		public const uint GL_INT_IMAGE_3D = 0x9059;
		public const uint GL_INT_IMAGE_2D_RECT = 0x905A;
		public const uint GL_INT_IMAGE_CUBE = 0x905B;
		public const uint GL_INT_IMAGE_BUFFER = 0x905C;
		public const uint GL_INT_IMAGE_1D_ARRAY = 0x905D;
		public const uint GL_INT_IMAGE_2D_ARRAY = 0x905E;
		public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
		public const uint GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060;
		public const uint GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
		public const uint GL_UNSIGNED_INT_IMAGE_1D = 0x9062;
		public const uint GL_UNSIGNED_INT_IMAGE_2D = 0x9063;
		public const uint GL_UNSIGNED_INT_IMAGE_3D = 0x9064;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;
		public const uint GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
		public const uint GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
		public const uint GL_MAX_IMAGE_SAMPLES = 0x906D;
		public const uint GL_IMAGE_BINDING_FORMAT = 0x906E;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
		public const uint GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
		public const uint GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
		public const uint GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
		public const uint GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
		public const uint GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
		public const uint GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
		public const uint GL_PROGRAM_OBJECT_ARB = 0x8B40;
		public const uint GL_SHADER_OBJECT_ARB = 0x8B48;
		public const uint GL_OBJECT_TYPE_ARB = 0x8B4E;
		public const uint GL_OBJECT_SUBTYPE_ARB = 0x8B4F;
		public const uint GL_FLOAT_VEC2_ARB = 0x8B50;
		public const uint GL_FLOAT_VEC3_ARB = 0x8B51;
		public const uint GL_FLOAT_VEC4_ARB = 0x8B52;
		public const uint GL_INT_VEC2_ARB = 0x8B53;
		public const uint GL_INT_VEC3_ARB = 0x8B54;
		public const uint GL_INT_VEC4_ARB = 0x8B55;
		public const uint GL_BOOL_ARB = 0x8B56;
		public const uint GL_BOOL_VEC2_ARB = 0x8B57;
		public const uint GL_BOOL_VEC3_ARB = 0x8B58;
		public const uint GL_BOOL_VEC4_ARB = 0x8B59;
		public const uint GL_FLOAT_MAT2_ARB = 0x8B5A;
		public const uint GL_FLOAT_MAT3_ARB = 0x8B5B;
		public const uint GL_FLOAT_MAT4_ARB = 0x8B5C;
		public const uint GL_SAMPLER_1D_ARB = 0x8B5D;
		public const uint GL_SAMPLER_2D_ARB = 0x8B5E;
		public const uint GL_SAMPLER_3D_ARB = 0x8B5F;
		public const uint GL_SAMPLER_CUBE_ARB = 0x8B60;
		public const uint GL_SAMPLER_1D_SHADOW_ARB = 0x8B61;
		public const uint GL_SAMPLER_2D_SHADOW_ARB = 0x8B62;
		public const uint GL_SAMPLER_2D_RECT_ARB = 0x8B63;
		public const uint GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64;
		public const uint GL_OBJECT_DELETE_STATUS_ARB = 0x8B80;
		public const uint GL_OBJECT_COMPILE_STATUS_ARB = 0x8B81;
		public const uint GL_OBJECT_LINK_STATUS_ARB = 0x8B82;
		public const uint GL_OBJECT_VALIDATE_STATUS_ARB = 0x8B83;
		public const uint GL_OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84;
		public const uint GL_OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85;
		public const uint GL_OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86;
		public const uint GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87;
		public const uint GL_OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88;
		public const uint GL_SHADER_STORAGE_BUFFER = 0x90D2;
		public const uint GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
		public const uint GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
		public const uint GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
		public const uint GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
		public const uint GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
		public const uint GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
		public const uint GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
		public const uint GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
		public const uint GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
		public const uint GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
		public const uint GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
		public const uint GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
		public const uint GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
		public const uint GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000;
		public const uint GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
		public const uint GL_ACTIVE_SUBROUTINES = 0x8DE5;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
		public const uint GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
		public const uint GL_MAX_SUBROUTINES = 0x8DE7;
		public const uint GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
		public const uint GL_UNIFORM_SIZE = 0x8A38;
		public const uint GL_UNIFORM_NAME_LENGTH = 0x8A39;
		public const uint GL_SHADING_LANGUAGE_VERSION_ARB = 0x8B8C;
		public const uint GL_SHADER_INCLUDE_ARB = 0x8DAE;
		public const uint GL_NAMED_STRING_LENGTH_ARB = 0x8DE9;
		public const uint GL_NAMED_STRING_TYPE_ARB = 0x8DEA;
		public const uint GL_TEXTURE_COMPARE_MODE_ARB = 0x884C;
		public const uint GL_TEXTURE_COMPARE_FUNC_ARB = 0x884D;
		public const uint GL_COMPARE_R_TO_TEXTURE_ARB = 0x884E;
		public const uint GL_TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF;
		public const uint GL_SPARSE_STORAGE_BIT_ARB = 0x0400;
		public const uint GL_SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8;
		public const uint GL_TEXTURE_SPARSE_ARB = 0x91A6;
		public const uint GL_VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7;
		public const uint GL_NUM_SPARSE_LEVELS_ARB = 0x91AA;
		public const uint GL_NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8;
		public const uint GL_VIRTUAL_PAGE_SIZE_X_ARB = 0x9195;
		public const uint GL_VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196;
		public const uint GL_VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197;
		public const uint GL_MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198;
		public const uint GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199;
		public const uint GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A;
		public const uint GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9;
		public const uint GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
		public const uint GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
		public const uint GL_OBJECT_TYPE = 0x9112;
		public const uint GL_SYNC_CONDITION = 0x9113;
		public const uint GL_SYNC_STATUS = 0x9114;
		public const uint GL_SYNC_FLAGS = 0x9115;
		public const uint GL_SYNC_FENCE = 0x9116;
		public const uint GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
		public const uint GL_UNSIGNALED = 0x9118;
		public const uint GL_SIGNALED = 0x9119;
		public const uint GL_ALREADY_SIGNALED = 0x911A;
		public const uint GL_TIMEOUT_EXPIRED = 0x911B;
		public const uint GL_CONDITION_SATISFIED = 0x911C;
		public const uint GL_WAIT_FAILED = 0x911D;
		public const uint GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
		public const uint GL_TIMEOUT_IGNORED = 0xFFFFFFFF;
		public const uint GL_PATCHES = 0x000E;
		public const uint GL_PATCH_VERTICES = 0x8E72;
		public const uint GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
		public const uint GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
		public const uint GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
		public const uint GL_TESS_GEN_MODE = 0x8E76;
		public const uint GL_TESS_GEN_SPACING = 0x8E77;
		public const uint GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
		public const uint GL_TESS_GEN_POINT_MODE = 0x8E79;
		public const uint GL_TRIANGLES = 0x0004;
		public const uint GL_ISOLINES = 0x8E7A;
		public const uint GL_QUADS = 0x0007;
		public const uint GL_EQUAL = 0x0202;
		public const uint GL_FRACTIONAL_ODD = 0x8E7B;
		public const uint GL_FRACTIONAL_EVEN = 0x8E7C;
		public const uint GL_CCW = 0x0901;
		public const uint GL_CW = 0x0900;
		public const uint GL_MAX_PATCH_VERTICES = 0x8E7D;
		public const uint GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
		public const uint GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
		public const uint GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
		public const uint GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
		public const uint GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
		public const uint GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
		public const uint GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
		public const uint GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
		public const uint GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
		public const uint GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
		public const uint GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
		public const uint GL_TESS_EVALUATION_SHADER = 0x8E87;
		public const uint GL_TESS_CONTROL_SHADER = 0x8E88;
		public const uint GL_CLAMP_TO_BORDER_ARB = 0x812D;
		public const uint GL_TEXTURE_BUFFER_ARB = 0x8C2A;
		public const uint GL_MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B;
		public const uint GL_TEXTURE_BINDING_BUFFER_ARB = 0x8C2C;
		public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D;
		public const uint GL_TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E;
		public const uint GL_RGB32F = 0x8815;
		public const uint GL_RGB32UI = 0x8D71;
		public const uint GL_RGB32I = 0x8D83;
		public const uint GL_TEXTURE_BUFFER_OFFSET = 0x919D;
		public const uint GL_TEXTURE_BUFFER_SIZE = 0x919E;
		public const uint GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
		public const uint GL_COMPRESSED_ALPHA_ARB = 0x84E9;
		public const uint GL_COMPRESSED_LUMINANCE_ARB = 0x84EA;
		public const uint GL_COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;
		public const uint GL_COMPRESSED_INTENSITY_ARB = 0x84EC;
		public const uint GL_COMPRESSED_RGB_ARB = 0x84ED;
		public const uint GL_COMPRESSED_RGBA_ARB = 0x84EE;
		public const uint GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF;
		public const uint GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0;
		public const uint GL_TEXTURE_COMPRESSED_ARB = 0x86A1;
		public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;
		public const uint GL_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;
		public const uint GL_COMPRESSED_RGBA_BPTC_UNORM_ARB = 0x8E8C;
		public const uint GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB = 0x8E8D;
		public const uint GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB = 0x8E8E;
		public const uint GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB = 0x8E8F;
		public const uint GL_COMPRESSED_RED_RGTC1 = 0x8DBB;
		public const uint GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
		public const uint GL_COMPRESSED_RG_RGTC2 = 0x8DBD;
		public const uint GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
		public const uint GL_NORMAL_MAP_ARB = 0x8511;
		public const uint GL_REFLECTION_MAP_ARB = 0x8512;
		public const uint GL_TEXTURE_CUBE_MAP_ARB = 0x8513;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARB = 0x8514;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x8515;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x8516;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x8517;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x8518;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x8519;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x851A;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B;
		public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB = 0x851C;
		public const uint GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D;
		public const uint GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E;
		public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F;
		public const uint GL_COMBINE_ARB = 0x8570;
		public const uint GL_COMBINE_RGB_ARB = 0x8571;
		public const uint GL_COMBINE_ALPHA_ARB = 0x8572;
		public const uint GL_SOURCE0_RGB_ARB = 0x8580;
		public const uint GL_SOURCE1_RGB_ARB = 0x8581;
		public const uint GL_SOURCE2_RGB_ARB = 0x8582;
		public const uint GL_SOURCE0_ALPHA_ARB = 0x8588;
		public const uint GL_SOURCE1_ALPHA_ARB = 0x8589;
		public const uint GL_SOURCE2_ALPHA_ARB = 0x858A;
		public const uint GL_OPERAND0_RGB_ARB = 0x8590;
		public const uint GL_OPERAND1_RGB_ARB = 0x8591;
		public const uint GL_OPERAND2_RGB_ARB = 0x8592;
		public const uint GL_OPERAND0_ALPHA_ARB = 0x8598;
		public const uint GL_OPERAND1_ALPHA_ARB = 0x8599;
		public const uint GL_OPERAND2_ALPHA_ARB = 0x859A;
		public const uint GL_RGB_SCALE_ARB = 0x8573;
		public const uint GL_ADD_SIGNED_ARB = 0x8574;
		public const uint GL_INTERPOLATE_ARB = 0x8575;
		public const uint GL_SUBTRACT_ARB = 0x84E7;
		public const uint GL_CONSTANT_ARB = 0x8576;
		public const uint GL_PRIMARY_COLOR_ARB = 0x8577;
		public const uint GL_PREVIOUS_ARB = 0x8578;
		public const uint GL_DOT3_RGB_ARB = 0x86AE;
		public const uint GL_DOT3_RGBA_ARB = 0x86AF;
		public const uint GL_TEXTURE_REDUCTION_MODE_ARB = 0x9366;
		public const uint GL_WEIGHTED_AVERAGE_ARB = 0x9367;
		public const uint GL_TEXTURE_RED_TYPE_ARB = 0x8C10;
		public const uint GL_TEXTURE_GREEN_TYPE_ARB = 0x8C11;
		public const uint GL_TEXTURE_BLUE_TYPE_ARB = 0x8C12;
		public const uint GL_TEXTURE_ALPHA_TYPE_ARB = 0x8C13;
		public const uint GL_TEXTURE_LUMINANCE_TYPE_ARB = 0x8C14;
		public const uint GL_TEXTURE_INTENSITY_TYPE_ARB = 0x8C15;
		public const uint GL_TEXTURE_DEPTH_TYPE_ARB = 0x8C16;
		public const uint GL_UNSIGNED_NORMALIZED_ARB = 0x8C17;
		public const uint GL_RGBA32F_ARB = 0x8814;
		public const uint GL_RGB32F_ARB = 0x8815;
		public const uint GL_ALPHA32F_ARB = 0x8816;
		public const uint GL_INTENSITY32F_ARB = 0x8817;
		public const uint GL_LUMINANCE32F_ARB = 0x8818;
		public const uint GL_LUMINANCE_ALPHA32F_ARB = 0x8819;
		public const uint GL_RGBA16F_ARB = 0x881A;
		public const uint GL_RGB16F_ARB = 0x881B;
		public const uint GL_ALPHA16F_ARB = 0x881C;
		public const uint GL_INTENSITY16F_ARB = 0x881D;
		public const uint GL_LUMINANCE16F_ARB = 0x881E;
		public const uint GL_LUMINANCE_ALPHA16F_ARB = 0x881F;
		public const uint GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5E;
		public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5F;
		public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB = 0x8F9F;
		public const uint GL_MIRROR_CLAMP_TO_EDGE = 0x8743;
		public const uint GL_MIRRORED_REPEAT_ARB = 0x8370;
		public const uint GL_SAMPLE_POSITION = 0x8E50;
		public const uint GL_SAMPLE_MASK = 0x8E51;
		public const uint GL_SAMPLE_MASK_VALUE = 0x8E52;
		public const uint GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
		public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
		public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
		public const uint GL_TEXTURE_SAMPLES = 0x9106;
		public const uint GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
		public const uint GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
		public const uint GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
		public const uint GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
		public const uint GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
		public const uint GL_MAX_INTEGER_SAMPLES = 0x9110;
		public const uint GL_TEXTURE_RECTANGLE_ARB = 0x84F5;
		public const uint GL_TEXTURE_BINDING_RECTANGLE_ARB = 0x84F6;
		public const uint GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7;
		public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE_ARB = 0x84F8;
		public const uint GL_RG = 0x8227;
		public const uint GL_RG_INTEGER = 0x8228;
		public const uint GL_R8 = 0x8229;
		public const uint GL_R16 = 0x822A;
		public const uint GL_RG8 = 0x822B;
		public const uint GL_RG16 = 0x822C;
		public const uint GL_R16F = 0x822D;
		public const uint GL_R32F = 0x822E;
		public const uint GL_RG16F = 0x822F;
		public const uint GL_RG32F = 0x8230;
		public const uint GL_R8I = 0x8231;
		public const uint GL_R8UI = 0x8232;
		public const uint GL_R16I = 0x8233;
		public const uint GL_R16UI = 0x8234;
		public const uint GL_R32I = 0x8235;
		public const uint GL_R32UI = 0x8236;
		public const uint GL_RG8I = 0x8237;
		public const uint GL_RG16I = 0x8239;
		public const uint GL_RG32I = 0x823B;
		public const uint GL_RG32UI = 0x823C;
		public const uint GL_RGB10_A2UI = 0x906F;
		public const uint GL_STENCIL_INDEX = 0x1901;
		public const uint GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
		public const uint GL_TEXTURE_SWIZZLE_R = 0x8E42;
		public const uint GL_TEXTURE_SWIZZLE_G = 0x8E43;
		public const uint GL_TEXTURE_SWIZZLE_B = 0x8E44;
		public const uint GL_TEXTURE_SWIZZLE_A = 0x8E45;
		public const uint GL_TEXTURE_SWIZZLE_RGBA = 0x8E46;
		public const uint GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
		public const uint GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
		public const uint GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD;
		public const uint GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
		public const uint GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
		public const uint GL_TIME_ELAPSED = 0x88BF;
		public const uint GL_TIMESTAMP = 0x8E28;
		public const uint GL_TRANSFORM_FEEDBACK = 0x8E22;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
		public const uint GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
		public const uint GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB = 0x82EC;
		public const uint GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB = 0x82ED;
		public const uint GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
		public const uint GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
		public const uint GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
		public const uint GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;
		public const uint GL_UNIFORM_BUFFER = 0x8A11;
		public const uint GL_UNIFORM_BUFFER_BINDING = 0x8A28;
		public const uint GL_UNIFORM_BUFFER_START = 0x8A29;
		public const uint GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
		public const uint GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
		public const uint GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
		public const uint GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
		public const uint GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
		public const uint GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
		public const uint GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
		public const uint GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
		public const uint GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
		public const uint GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
		public const uint GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
		public const uint GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
		public const uint GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
		public const uint GL_UNIFORM_TYPE = 0x8A37;
		public const uint GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
		public const uint GL_UNIFORM_OFFSET = 0x8A3B;
		public const uint GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
		public const uint GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
		public const uint GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
		public const uint GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
		public const uint GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
		public const uint GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
		public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
		public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
		public const uint GL_INVALID_INDEX = 0xFFFFFFFF;
		public const uint GL_BGRA = 0x80E1;
		public const uint GL_VERTEX_ARRAY_BINDING = 0x85B5;
		public const uint GL_VERTEX_ATTRIB_BINDING = 0x82D4;
		public const uint GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
		public const uint GL_VERTEX_BINDING_DIVISOR = 0x82D6;
		public const uint GL_VERTEX_BINDING_OFFSET = 0x82D7;
		public const uint GL_VERTEX_BINDING_STRIDE = 0x82D8;
		public const uint GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
		public const uint GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
		public const uint GL_MAX_VERTEX_UNITS_ARB = 0x86A4;
		public const uint GL_ACTIVE_VERTEX_UNITS_ARB = 0x86A5;
		public const uint GL_WEIGHT_SUM_UNITY_ARB = 0x86A6;
		public const uint GL_VERTEX_BLEND_ARB = 0x86A7;
		public const uint GL_CURRENT_WEIGHT_ARB = 0x86A8;
		public const uint GL_WEIGHT_ARRAY_TYPE_ARB = 0x86A9;
		public const uint GL_WEIGHT_ARRAY_STRIDE_ARB = 0x86AA;
		public const uint GL_WEIGHT_ARRAY_SIZE_ARB = 0x86AB;
		public const uint GL_WEIGHT_ARRAY_POINTER_ARB = 0x86AC;
		public const uint GL_WEIGHT_ARRAY_ARB = 0x86AD;
		public const uint GL_MODELVIEW0_ARB = 0x1700;
		public const uint GL_MODELVIEW1_ARB = 0x850A;
		public const uint GL_MODELVIEW2_ARB = 0x8722;
		public const uint GL_MODELVIEW3_ARB = 0x8723;
		public const uint GL_MODELVIEW4_ARB = 0x8724;
		public const uint GL_MODELVIEW5_ARB = 0x8725;
		public const uint GL_MODELVIEW6_ARB = 0x8726;
		public const uint GL_MODELVIEW7_ARB = 0x8727;
		public const uint GL_MODELVIEW8_ARB = 0x8728;
		public const uint GL_MODELVIEW9_ARB = 0x8729;
		public const uint GL_MODELVIEW10_ARB = 0x872A;
		public const uint GL_MODELVIEW11_ARB = 0x872B;
		public const uint GL_MODELVIEW12_ARB = 0x872C;
		public const uint GL_MODELVIEW13_ARB = 0x872D;
		public const uint GL_MODELVIEW14_ARB = 0x872E;
		public const uint GL_MODELVIEW15_ARB = 0x872F;
		public const uint GL_MODELVIEW16_ARB = 0x8730;
		public const uint GL_MODELVIEW17_ARB = 0x8731;
		public const uint GL_MODELVIEW18_ARB = 0x8732;
		public const uint GL_MODELVIEW19_ARB = 0x8733;
		public const uint GL_MODELVIEW20_ARB = 0x8734;
		public const uint GL_MODELVIEW21_ARB = 0x8735;
		public const uint GL_MODELVIEW22_ARB = 0x8736;
		public const uint GL_MODELVIEW23_ARB = 0x8737;
		public const uint GL_MODELVIEW24_ARB = 0x8738;
		public const uint GL_MODELVIEW25_ARB = 0x8739;
		public const uint GL_MODELVIEW26_ARB = 0x873A;
		public const uint GL_MODELVIEW27_ARB = 0x873B;
		public const uint GL_MODELVIEW28_ARB = 0x873C;
		public const uint GL_MODELVIEW29_ARB = 0x873D;
		public const uint GL_MODELVIEW30_ARB = 0x873E;
		public const uint GL_MODELVIEW31_ARB = 0x873F;
		public const uint GL_BUFFER_SIZE_ARB = 0x8764;
		public const uint GL_BUFFER_USAGE_ARB = 0x8765;
		public const uint GL_ARRAY_BUFFER_ARB = 0x8892;
		public const uint GL_ELEMENT_ARRAY_BUFFER_ARB = 0x8893;
		public const uint GL_ARRAY_BUFFER_BINDING_ARB = 0x8894;
		public const uint GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895;
		public const uint GL_VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896;
		public const uint GL_NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897;
		public const uint GL_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898;
		public const uint GL_INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899;
		public const uint GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A;
		public const uint GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B;
		public const uint GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C;
		public const uint GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D;
		public const uint GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F;
		public const uint GL_READ_ONLY_ARB = 0x88B8;
		public const uint GL_WRITE_ONLY_ARB = 0x88B9;
		public const uint GL_READ_WRITE_ARB = 0x88BA;
		public const uint GL_BUFFER_ACCESS_ARB = 0x88BB;
		public const uint GL_BUFFER_MAPPED_ARB = 0x88BC;
		public const uint GL_BUFFER_MAP_POINTER_ARB = 0x88BD;
		public const uint GL_STREAM_DRAW_ARB = 0x88E0;
		public const uint GL_STREAM_READ_ARB = 0x88E1;
		public const uint GL_STREAM_COPY_ARB = 0x88E2;
		public const uint GL_STATIC_DRAW_ARB = 0x88E4;
		public const uint GL_STATIC_READ_ARB = 0x88E5;
		public const uint GL_STATIC_COPY_ARB = 0x88E6;
		public const uint GL_DYNAMIC_DRAW_ARB = 0x88E8;
		public const uint GL_DYNAMIC_READ_ARB = 0x88E9;
		public const uint GL_DYNAMIC_COPY_ARB = 0x88EA;
		public const uint GL_COLOR_SUM_ARB = 0x8458;
		public const uint GL_VERTEX_PROGRAM_ARB = 0x8620;
		public const uint GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622;
		public const uint GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623;
		public const uint GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624;
		public const uint GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625;
		public const uint GL_CURRENT_VERTEX_ATTRIB_ARB = 0x8626;
		public const uint GL_VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642;
		public const uint GL_VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643;
		public const uint GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645;
		public const uint GL_MAX_VERTEX_ATTRIBS_ARB = 0x8869;
		public const uint GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A;
		public const uint GL_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0;
		public const uint GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1;
		public const uint GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2;
		public const uint GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3;
		public const uint GL_VERTEX_SHADER_ARB = 0x8B31;
		public const uint GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A;
		public const uint GL_MAX_VARYING_FLOATS_ARB = 0x8B4B;
		public const uint GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C;
		public const uint GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D;
		public const uint GL_OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89;
		public const uint GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A;
		public const uint GL_FLOAT = 0x1406;
		public const uint GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
		public const uint GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
		public const uint GL_INT_2_10_10_10_REV = 0x8D9F;
		public const uint GL_SCISSOR_BOX = 0x0C10;
		public const uint GL_VIEWPORT = 0x0BA2;
		public const uint GL_DEPTH_RANGE = 0x0B70;
		public const uint GL_SCISSOR_TEST = 0x0C11;
		public const uint GL_MAX_VIEWPORTS = 0x825B;
		public const uint GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;
		public const uint GL_VIEWPORT_BOUNDS_RANGE = 0x825D;
		public const uint GL_LAYER_PROVOKING_VERTEX = 0x825E;
		public const uint GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
		public const uint GL_UNDEFINED_VERTEX = 0x8260;
		public const uint GL_MALI_PROGRAM_BINARY_ARM = 0x8F61;
		public const uint GL_MALI_SHADER_BINARY_ARM = 0x8F60;
		public const uint GL_FETCH_PER_SAMPLE_ARM = 0x8F65;
		public const uint GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM = 0x8F66;
		public const uint GL_MAX_DRAW_BUFFERS_ATI = 0x8824;
		public const uint GL_DRAW_BUFFER0_ATI = 0x8825;
		public const uint GL_DRAW_BUFFER1_ATI = 0x8826;
		public const uint GL_DRAW_BUFFER2_ATI = 0x8827;
		public const uint GL_DRAW_BUFFER3_ATI = 0x8828;
		public const uint GL_DRAW_BUFFER4_ATI = 0x8829;
		public const uint GL_DRAW_BUFFER5_ATI = 0x882A;
		public const uint GL_DRAW_BUFFER6_ATI = 0x882B;
		public const uint GL_DRAW_BUFFER7_ATI = 0x882C;
		public const uint GL_DRAW_BUFFER8_ATI = 0x882D;
		public const uint GL_DRAW_BUFFER9_ATI = 0x882E;
		public const uint GL_DRAW_BUFFER10_ATI = 0x882F;
		public const uint GL_DRAW_BUFFER11_ATI = 0x8830;
		public const uint GL_DRAW_BUFFER12_ATI = 0x8831;
		public const uint GL_DRAW_BUFFER13_ATI = 0x8832;
		public const uint GL_DRAW_BUFFER14_ATI = 0x8833;
		public const uint GL_DRAW_BUFFER15_ATI = 0x8834;
		public const uint GL_ELEMENT_ARRAY_ATI = 0x8768;
		public const uint GL_ELEMENT_ARRAY_TYPE_ATI = 0x8769;
		public const uint GL_ELEMENT_ARRAY_POINTER_ATI = 0x876A;
		public const uint GL_BUMP_ROT_MATRIX_ATI = 0x8775;
		public const uint GL_BUMP_ROT_MATRIX_SIZE_ATI = 0x8776;
		public const uint GL_BUMP_NUM_TEX_UNITS_ATI = 0x8777;
		public const uint GL_BUMP_TEX_UNITS_ATI = 0x8778;
		public const uint GL_DUDV_ATI = 0x8779;
		public const uint GL_DU8DV8_ATI = 0x877A;
		public const uint GL_BUMP_ENVMAP_ATI = 0x877B;
		public const uint GL_BUMP_TARGET_ATI = 0x877C;
		public const uint GL_FRAGMENT_SHADER_ATI = 0x8920;
		public const uint GL_REG_0_ATI = 0x8921;
		public const uint GL_REG_1_ATI = 0x8922;
		public const uint GL_REG_2_ATI = 0x8923;
		public const uint GL_REG_3_ATI = 0x8924;
		public const uint GL_REG_4_ATI = 0x8925;
		public const uint GL_REG_5_ATI = 0x8926;
		public const uint GL_REG_6_ATI = 0x8927;
		public const uint GL_REG_7_ATI = 0x8928;
		public const uint GL_REG_8_ATI = 0x8929;
		public const uint GL_REG_9_ATI = 0x892A;
		public const uint GL_REG_10_ATI = 0x892B;
		public const uint GL_REG_11_ATI = 0x892C;
		public const uint GL_REG_12_ATI = 0x892D;
		public const uint GL_REG_13_ATI = 0x892E;
		public const uint GL_REG_14_ATI = 0x892F;
		public const uint GL_REG_15_ATI = 0x8930;
		public const uint GL_REG_16_ATI = 0x8931;
		public const uint GL_REG_17_ATI = 0x8932;
		public const uint GL_REG_18_ATI = 0x8933;
		public const uint GL_REG_19_ATI = 0x8934;
		public const uint GL_REG_20_ATI = 0x8935;
		public const uint GL_REG_21_ATI = 0x8936;
		public const uint GL_REG_22_ATI = 0x8937;
		public const uint GL_REG_23_ATI = 0x8938;
		public const uint GL_REG_24_ATI = 0x8939;
		public const uint GL_REG_25_ATI = 0x893A;
		public const uint GL_REG_26_ATI = 0x893B;
		public const uint GL_REG_27_ATI = 0x893C;
		public const uint GL_REG_28_ATI = 0x893D;
		public const uint GL_REG_29_ATI = 0x893E;
		public const uint GL_REG_30_ATI = 0x893F;
		public const uint GL_REG_31_ATI = 0x8940;
		public const uint GL_CON_0_ATI = 0x8941;
		public const uint GL_CON_1_ATI = 0x8942;
		public const uint GL_CON_2_ATI = 0x8943;
		public const uint GL_CON_3_ATI = 0x8944;
		public const uint GL_CON_4_ATI = 0x8945;
		public const uint GL_CON_5_ATI = 0x8946;
		public const uint GL_CON_6_ATI = 0x8947;
		public const uint GL_CON_7_ATI = 0x8948;
		public const uint GL_CON_8_ATI = 0x8949;
		public const uint GL_CON_9_ATI = 0x894A;
		public const uint GL_CON_10_ATI = 0x894B;
		public const uint GL_CON_11_ATI = 0x894C;
		public const uint GL_CON_12_ATI = 0x894D;
		public const uint GL_CON_13_ATI = 0x894E;
		public const uint GL_CON_14_ATI = 0x894F;
		public const uint GL_CON_15_ATI = 0x8950;
		public const uint GL_CON_16_ATI = 0x8951;
		public const uint GL_CON_17_ATI = 0x8952;
		public const uint GL_CON_18_ATI = 0x8953;
		public const uint GL_CON_19_ATI = 0x8954;
		public const uint GL_CON_20_ATI = 0x8955;
		public const uint GL_CON_21_ATI = 0x8956;
		public const uint GL_CON_22_ATI = 0x8957;
		public const uint GL_CON_23_ATI = 0x8958;
		public const uint GL_CON_24_ATI = 0x8959;
		public const uint GL_CON_25_ATI = 0x895A;
		public const uint GL_CON_26_ATI = 0x895B;
		public const uint GL_CON_27_ATI = 0x895C;
		public const uint GL_CON_28_ATI = 0x895D;
		public const uint GL_CON_29_ATI = 0x895E;
		public const uint GL_CON_30_ATI = 0x895F;
		public const uint GL_CON_31_ATI = 0x8960;
		public const uint GL_MOV_ATI = 0x8961;
		public const uint GL_ADD_ATI = 0x8963;
		public const uint GL_MUL_ATI = 0x8964;
		public const uint GL_SUB_ATI = 0x8965;
		public const uint GL_DOT3_ATI = 0x8966;
		public const uint GL_DOT4_ATI = 0x8967;
		public const uint GL_MAD_ATI = 0x8968;
		public const uint GL_LERP_ATI = 0x8969;
		public const uint GL_CND_ATI = 0x896A;
		public const uint GL_CND0_ATI = 0x896B;
		public const uint GL_DOT2_ADD_ATI = 0x896C;
		public const uint GL_SECONDARY_INTERPOLATOR_ATI = 0x896D;
		public const uint GL_NUM_FRAGMENT_REGISTERS_ATI = 0x896E;
		public const uint GL_NUM_FRAGMENT_CONSTANTS_ATI = 0x896F;
		public const uint GL_NUM_PASSES_ATI = 0x8970;
		public const uint GL_NUM_INSTRUCTIONS_PER_PASS_ATI = 0x8971;
		public const uint GL_NUM_INSTRUCTIONS_TOTAL_ATI = 0x8972;
		public const uint GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973;
		public const uint GL_NUM_LOOPBACK_COMPONENTS_ATI = 0x8974;
		public const uint GL_COLOR_ALPHA_PAIRING_ATI = 0x8975;
		public const uint GL_SWIZZLE_STR_ATI = 0x8976;
		public const uint GL_SWIZZLE_STQ_ATI = 0x8977;
		public const uint GL_SWIZZLE_STR_DR_ATI = 0x8978;
		public const uint GL_SWIZZLE_STQ_DQ_ATI = 0x8979;
		public const uint GL_SWIZZLE_STRQ_ATI = 0x897A;
		public const uint GL_SWIZZLE_STRQ_DQ_ATI = 0x897B;
		public const uint GL_RED_BIT_ATI = 0x00000001;
		public const uint GL_GREEN_BIT_ATI = 0x00000002;
		public const uint GL_BLUE_BIT_ATI = 0x00000004;
		public const uint GL_2X_BIT_ATI = 0x00000001;
		public const uint GL_4X_BIT_ATI = 0x00000002;
		public const uint GL_8X_BIT_ATI = 0x00000004;
		public const uint GL_HALF_BIT_ATI = 0x00000008;
		public const uint GL_QUARTER_BIT_ATI = 0x00000010;
		public const uint GL_EIGHTH_BIT_ATI = 0x00000020;
		public const uint GL_SATURATE_BIT_ATI = 0x00000040;
		public const uint GL_COMP_BIT_ATI = 0x00000002;
		public const uint GL_NEGATE_BIT_ATI = 0x00000004;
		public const uint GL_BIAS_BIT_ATI = 0x00000008;
		public const uint GL_VBO_FREE_MEMORY_ATI = 0x87FB;
		public const uint GL_TEXTURE_FREE_MEMORY_ATI = 0x87FC;
		public const uint GL_RENDERBUFFER_FREE_MEMORY_ATI = 0x87FD;
		public const uint GL_RGBA_FLOAT_MODE_ATI = 0x8820;
		public const uint GL_COLOR_CLEAR_UNCLAMPED_VALUE_ATI = 0x8835;
		public const uint GL_PN_TRIANGLES_ATI = 0x87F0;
		public const uint GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1;
		public const uint GL_PN_TRIANGLES_POINT_MODE_ATI = 0x87F2;
		public const uint GL_PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3;
		public const uint GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4;
		public const uint GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5;
		public const uint GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6;
		public const uint GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7;
		public const uint GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8;
		public const uint GL_STENCIL_BACK_FUNC_ATI = 0x8800;
		public const uint GL_STENCIL_BACK_FAIL_ATI = 0x8801;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803;
		public const uint GL_TEXT_FRAGMENT_SHADER_ATI = 0x8200;
		public const uint GL_MODULATE_ADD_ATI = 0x8744;
		public const uint GL_MODULATE_SIGNED_ADD_ATI = 0x8745;
		public const uint GL_MODULATE_SUBTRACT_ATI = 0x8746;
		public const uint GL_RGBA_FLOAT32_ATI = 0x8814;
		public const uint GL_RGB_FLOAT32_ATI = 0x8815;
		public const uint GL_ALPHA_FLOAT32_ATI = 0x8816;
		public const uint GL_INTENSITY_FLOAT32_ATI = 0x8817;
		public const uint GL_LUMINANCE_FLOAT32_ATI = 0x8818;
		public const uint GL_LUMINANCE_ALPHA_FLOAT32_ATI = 0x8819;
		public const uint GL_RGBA_FLOAT16_ATI = 0x881A;
		public const uint GL_RGB_FLOAT16_ATI = 0x881B;
		public const uint GL_ALPHA_FLOAT16_ATI = 0x881C;
		public const uint GL_INTENSITY_FLOAT16_ATI = 0x881D;
		public const uint GL_LUMINANCE_FLOAT16_ATI = 0x881E;
		public const uint GL_LUMINANCE_ALPHA_FLOAT16_ATI = 0x881F;
		public const uint GL_MIRROR_CLAMP_ATI = 0x8742;
		public const uint GL_MIRROR_CLAMP_TO_EDGE_ATI = 0x8743;
		public const uint GL_STATIC_ATI = 0x8760;
		public const uint GL_DYNAMIC_ATI = 0x8761;
		public const uint GL_PRESERVE_ATI = 0x8762;
		public const uint GL_DISCARD_ATI = 0x8763;
		public const uint GL_OBJECT_BUFFER_SIZE_ATI = 0x8764;
		public const uint GL_OBJECT_BUFFER_USAGE_ATI = 0x8765;
		public const uint GL_ARRAY_OBJECT_BUFFER_ATI = 0x8766;
		public const uint GL_ARRAY_OBJECT_OFFSET_ATI = 0x8767;
		public const uint GL_MAX_VERTEX_STREAMS_ATI = 0x876B;
		public const uint GL_VERTEX_STREAM0_ATI = 0x876C;
		public const uint GL_VERTEX_STREAM1_ATI = 0x876D;
		public const uint GL_VERTEX_STREAM2_ATI = 0x876E;
		public const uint GL_VERTEX_STREAM3_ATI = 0x876F;
		public const uint GL_VERTEX_STREAM4_ATI = 0x8770;
		public const uint GL_VERTEX_STREAM5_ATI = 0x8771;
		public const uint GL_VERTEX_STREAM6_ATI = 0x8772;
		public const uint GL_VERTEX_STREAM7_ATI = 0x8773;
		public const uint GL_VERTEX_SOURCE_ATI = 0x8774;
		public const uint GL_SMAPHS30_PROGRAM_BINARY_DMP = 0x9251;
		public const uint GL_SMAPHS_PROGRAM_BINARY_DMP = 0x9252;
		public const uint GL_DMP_PROGRAM_BINARY_DMP = 0x9253;
		public const uint GL_SHADER_BINARY_DMP = 0x9250;
		public const uint GL_422_EXT = 0x80CC;
		public const uint GL_422_REV_EXT = 0x80CD;
		public const uint GL_422_AVERAGE_EXT = 0x80CE;
		public const uint GL_422_REV_AVERAGE_EXT = 0x80CF;
		public const uint GL_SAMPLER_EXTERNAL_2D_Y2Y_EXT = 0x8BE7;
		public const uint GL_TEXTURE_EXTERNAL_OES = 0x8D65;
		public const uint GL_TEXTURE_BINDING_EXTERNAL_OES = 0x8D67;
		public const uint GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68;
		public const uint GL_ABGR_EXT = 0x8000;
		public const uint GL_BGR_EXT = 0x80E0;
		public const uint GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2;
		public const uint GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3;
		public const uint GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4;
		public const uint GL_MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED;
		public const uint GL_UNIFORM_BUFFER_EXT = 0x8DEE;
		public const uint GL_UNIFORM_BUFFER_BINDING_EXT = 0x8DEF;
		public const uint GL_CONSTANT_COLOR_EXT = 0x8001;
		public const uint GL_ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002;
		public const uint GL_CONSTANT_ALPHA_EXT = 0x8003;
		public const uint GL_ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004;
		public const uint GL_BLEND_COLOR_EXT = 0x8005;
		public const uint GL_BLEND_EQUATION_RGB_EXT = 0x8009;
		public const uint GL_BLEND_EQUATION_ALPHA_EXT = 0x883D;
		public const uint GL_SRC1_COLOR_EXT = 0x88F9;
		public const uint GL_SRC1_ALPHA_EXT = 0x8589;
		public const uint GL_ONE_MINUS_SRC1_COLOR_EXT = 0x88FA;
		public const uint GL_ONE_MINUS_SRC1_ALPHA_EXT = 0x88FB;
		public const uint GL_SRC_ALPHA_SATURATE_EXT = 0x0308;
		public const uint GL_LOCATION_INDEX_EXT = 0x930F;
		public const uint GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT = 0x88FC;
		public const uint GL_BLEND_DST_RGB_EXT = 0x80C8;
		public const uint GL_BLEND_SRC_RGB_EXT = 0x80C9;
		public const uint GL_BLEND_DST_ALPHA_EXT = 0x80CA;
		public const uint GL_BLEND_SRC_ALPHA_EXT = 0x80CB;
		public const uint GL_MIN_EXT = 0x8007;
		public const uint GL_MAX_EXT = 0x8008;
		public const uint GL_FUNC_ADD_EXT = 0x8006;
		public const uint GL_BLEND_EQUATION_EXT = 0x8009;
		public const uint GL_FUNC_SUBTRACT_EXT = 0x800A;
		public const uint GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B;
		public const uint GL_MAP_PERSISTENT_BIT_EXT = 0x0040;
		public const uint GL_MAP_COHERENT_BIT_EXT = 0x0080;
		public const uint GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100;
		public const uint GL_CLIENT_STORAGE_BIT_EXT = 0x0200;
		public const uint GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000;
		public const uint GL_BUFFER_IMMUTABLE_STORAGE_EXT = 0x821F;
		public const uint GL_BUFFER_STORAGE_FLAGS_EXT = 0x8220;
		public const uint GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0;
		public const uint GL_CMYK_EXT = 0x800C;
		public const uint GL_CMYKA_EXT = 0x800D;
		public const uint GL_PACK_CMYK_HINT_EXT = 0x800E;
		public const uint GL_UNPACK_CMYK_HINT_EXT = 0x800F;
		public const uint GL_RGBA16F_EXT = 0x881A;
		public const uint GL_RGB16F_EXT = 0x881B;
		public const uint GL_RG16F_EXT = 0x822F;
		public const uint GL_R16F_EXT = 0x822D;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT = 0x8211;
		public const uint GL_UNSIGNED_NORMALIZED_EXT = 0x8C17;
		public const uint GL_ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8;
		public const uint GL_ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9;
		public const uint GL_CONVOLUTION_1D_EXT = 0x8010;
		public const uint GL_CONVOLUTION_2D_EXT = 0x8011;
		public const uint GL_SEPARABLE_2D_EXT = 0x8012;
		public const uint GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013;
		public const uint GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014;
		public const uint GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015;
		public const uint GL_REDUCE_EXT = 0x8016;
		public const uint GL_CONVOLUTION_FORMAT_EXT = 0x8017;
		public const uint GL_CONVOLUTION_WIDTH_EXT = 0x8018;
		public const uint GL_CONVOLUTION_HEIGHT_EXT = 0x8019;
		public const uint GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A;
		public const uint GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B;
		public const uint GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C;
		public const uint GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D;
		public const uint GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E;
		public const uint GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F;
		public const uint GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020;
		public const uint GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021;
		public const uint GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022;
		public const uint GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023;
		public const uint GL_TANGENT_ARRAY_EXT = 0x8439;
		public const uint GL_BINORMAL_ARRAY_EXT = 0x843A;
		public const uint GL_CURRENT_TANGENT_EXT = 0x843B;
		public const uint GL_CURRENT_BINORMAL_EXT = 0x843C;
		public const uint GL_TANGENT_ARRAY_TYPE_EXT = 0x843E;
		public const uint GL_TANGENT_ARRAY_STRIDE_EXT = 0x843F;
		public const uint GL_BINORMAL_ARRAY_TYPE_EXT = 0x8440;
		public const uint GL_BINORMAL_ARRAY_STRIDE_EXT = 0x8441;
		public const uint GL_TANGENT_ARRAY_POINTER_EXT = 0x8442;
		public const uint GL_BINORMAL_ARRAY_POINTER_EXT = 0x8443;
		public const uint GL_MAP1_TANGENT_EXT = 0x8444;
		public const uint GL_MAP2_TANGENT_EXT = 0x8445;
		public const uint GL_MAP1_BINORMAL_EXT = 0x8446;
		public const uint GL_MAP2_BINORMAL_EXT = 0x8447;
		public const uint GL_CULL_VERTEX_EXT = 0x81AA;
		public const uint GL_CULL_VERTEX_EYE_POSITION_EXT = 0x81AB;
		public const uint GL_CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC;
		public const uint GL_PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F;
		public const uint GL_PROGRAM_OBJECT_EXT = 0x8B40;
		public const uint GL_SHADER_OBJECT_EXT = 0x8B48;
		public const uint GL_BUFFER_OBJECT_EXT = 0x9151;
		public const uint GL_QUERY_OBJECT_EXT = 0x9153;
		public const uint GL_VERTEX_ARRAY_OBJECT_EXT = 0x9154;
		public const uint GL_SAMPLER = 0x82E6;
		public const uint GL_DEPTH_BOUNDS_TEST_EXT = 0x8890;
		public const uint GL_DEPTH_BOUNDS_EXT = 0x8891;
		public const uint GL_PROGRAM_MATRIX_EXT = 0x8E2D;
		public const uint GL_TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E;
		public const uint GL_PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F;
		public const uint GL_COLOR_EXT = 0x1800;
		public const uint GL_DEPTH_EXT = 0x1801;
		public const uint GL_STENCIL_EXT = 0x1802;
		public const uint GL_QUERY_COUNTER_BITS_EXT = 0x8864;
		public const uint GL_CURRENT_QUERY_EXT = 0x8865;
		public const uint GL_QUERY_RESULT_EXT = 0x8866;
		public const uint GL_QUERY_RESULT_AVAILABLE_EXT = 0x8867;
		public const uint GL_TIME_ELAPSED_EXT = 0x88BF;
		public const uint GL_TIMESTAMP_EXT = 0x8E28;
		public const uint GL_GPU_DISJOINT_EXT = 0x8FBB;
		public const uint GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF;
		public const uint GL_MAX_DRAW_BUFFERS_EXT = 0x8824;
		public const uint GL_DRAW_BUFFER0_EXT = 0x8825;
		public const uint GL_DRAW_BUFFER1_EXT = 0x8826;
		public const uint GL_DRAW_BUFFER2_EXT = 0x8827;
		public const uint GL_DRAW_BUFFER3_EXT = 0x8828;
		public const uint GL_DRAW_BUFFER4_EXT = 0x8829;
		public const uint GL_DRAW_BUFFER5_EXT = 0x882A;
		public const uint GL_DRAW_BUFFER6_EXT = 0x882B;
		public const uint GL_DRAW_BUFFER7_EXT = 0x882C;
		public const uint GL_DRAW_BUFFER8_EXT = 0x882D;
		public const uint GL_DRAW_BUFFER9_EXT = 0x882E;
		public const uint GL_DRAW_BUFFER10_EXT = 0x882F;
		public const uint GL_DRAW_BUFFER11_EXT = 0x8830;
		public const uint GL_DRAW_BUFFER12_EXT = 0x8831;
		public const uint GL_DRAW_BUFFER13_EXT = 0x8832;
		public const uint GL_DRAW_BUFFER14_EXT = 0x8833;
		public const uint GL_DRAW_BUFFER15_EXT = 0x8834;
		public const uint GL_COLOR_ATTACHMENT0_EXT = 0x8CE0;
		public const uint GL_COLOR_ATTACHMENT1_EXT = 0x8CE1;
		public const uint GL_COLOR_ATTACHMENT2_EXT = 0x8CE2;
		public const uint GL_COLOR_ATTACHMENT3_EXT = 0x8CE3;
		public const uint GL_COLOR_ATTACHMENT4_EXT = 0x8CE4;
		public const uint GL_COLOR_ATTACHMENT5_EXT = 0x8CE5;
		public const uint GL_COLOR_ATTACHMENT6_EXT = 0x8CE6;
		public const uint GL_COLOR_ATTACHMENT7_EXT = 0x8CE7;
		public const uint GL_COLOR_ATTACHMENT8_EXT = 0x8CE8;
		public const uint GL_COLOR_ATTACHMENT9_EXT = 0x8CE9;
		public const uint GL_COLOR_ATTACHMENT10_EXT = 0x8CEA;
		public const uint GL_COLOR_ATTACHMENT11_EXT = 0x8CEB;
		public const uint GL_COLOR_ATTACHMENT12_EXT = 0x8CEC;
		public const uint GL_COLOR_ATTACHMENT13_EXT = 0x8CED;
		public const uint GL_COLOR_ATTACHMENT14_EXT = 0x8CEE;
		public const uint GL_COLOR_ATTACHMENT15_EXT = 0x8CEF;
		public const uint GL_BLEND_EQUATION_RGB = 0x8009;
		public const uint GL_BLEND_EQUATION_ALPHA = 0x883D;
		public const uint GL_BLEND_SRC_RGB = 0x80C9;
		public const uint GL_BLEND_SRC_ALPHA = 0x80CB;
		public const uint GL_BLEND_DST_RGB = 0x80C8;
		public const uint GL_BLEND_DST_ALPHA = 0x80CA;
		public const uint GL_COLOR_WRITEMASK = 0x0C23;
		public const uint GL_BLEND = 0x0BE2;
		public const uint GL_ZERO = 0;
		public const uint GL_ONE = 1;
		public const uint GL_SRC_COLOR = 0x0300;
		public const uint GL_ONE_MINUS_SRC_COLOR = 0x0301;
		public const uint GL_DST_COLOR = 0x0306;
		public const uint GL_ONE_MINUS_DST_COLOR = 0x0307;
		public const uint GL_SRC_ALPHA = 0x0302;
		public const uint GL_ONE_MINUS_SRC_ALPHA = 0x0303;
		public const uint GL_DST_ALPHA = 0x0304;
		public const uint GL_ONE_MINUS_DST_ALPHA = 0x0305;
		public const uint GL_SRC_ALPHA_SATURATE = 0x0308;
		public const uint GL_MAX_ELEMENTS_VERTICES_EXT = 0x80E8;
		public const uint GL_MAX_ELEMENTS_INDICES_EXT = 0x80E9;
		public const uint GL_FOG_COORDINATE_SOURCE_EXT = 0x8450;
		public const uint GL_FOG_COORDINATE_EXT = 0x8451;
		public const uint GL_FRAGMENT_DEPTH_EXT = 0x8452;
		public const uint GL_CURRENT_FOG_COORDINATE_EXT = 0x8453;
		public const uint GL_FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454;
		public const uint GL_FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455;
		public const uint GL_FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456;
		public const uint GL_FOG_COORDINATE_ARRAY_EXT = 0x8457;
		public const uint GL_READ_FRAMEBUFFER_EXT = 0x8CA8;
		public const uint GL_DRAW_FRAMEBUFFER_EXT = 0x8CA9;
		public const uint GL_DRAW_FRAMEBUFFER_BINDING_EXT = 0x8CA6;
		public const uint GL_READ_FRAMEBUFFER_BINDING_EXT = 0x8CAA;
		public const uint GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56;
		public const uint GL_MAX_SAMPLES_EXT = 0x8D57;
		public const uint GL_SCALED_RESOLVE_FASTEST_EXT = 0x90BA;
		public const uint GL_SCALED_RESOLVE_NICEST_EXT = 0x90BB;
		public const uint GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506;
		public const uint GL_MAX_RENDERBUFFER_SIZE_EXT = 0x84E8;
		public const uint GL_FRAMEBUFFER_BINDING_EXT = 0x8CA6;
		public const uint GL_RENDERBUFFER_BINDING_EXT = 0x8CA7;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4;
		public const uint GL_FRAMEBUFFER_COMPLETE_EXT = 0x8CD5;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC;
		public const uint GL_FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD;
		public const uint GL_DEPTH_ATTACHMENT_EXT = 0x8D00;
		public const uint GL_STENCIL_ATTACHMENT_EXT = 0x8D20;
		public const uint GL_FRAMEBUFFER_EXT = 0x8D40;
		public const uint GL_RENDERBUFFER_EXT = 0x8D41;
		public const uint GL_RENDERBUFFER_WIDTH_EXT = 0x8D42;
		public const uint GL_RENDERBUFFER_HEIGHT_EXT = 0x8D43;
		public const uint GL_RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44;
		public const uint GL_STENCIL_INDEX1_EXT = 0x8D46;
		public const uint GL_STENCIL_INDEX4_EXT = 0x8D47;
		public const uint GL_STENCIL_INDEX8_EXT = 0x8D48;
		public const uint GL_STENCIL_INDEX16_EXT = 0x8D49;
		public const uint GL_RENDERBUFFER_RED_SIZE_EXT = 0x8D50;
		public const uint GL_RENDERBUFFER_GREEN_SIZE_EXT = 0x8D51;
		public const uint GL_RENDERBUFFER_BLUE_SIZE_EXT = 0x8D52;
		public const uint GL_RENDERBUFFER_ALPHA_SIZE_EXT = 0x8D53;
		public const uint GL_RENDERBUFFER_DEPTH_SIZE_EXT = 0x8D54;
		public const uint GL_RENDERBUFFER_STENCIL_SIZE_EXT = 0x8D55;
		public const uint GL_FRAMEBUFFER_SRGB_EXT = 0x8DB9;
		public const uint GL_FRAMEBUFFER_SRGB_CAPABLE_EXT = 0x8DBA;
		public const uint GL_GEOMETRY_SHADER_EXT = 0x8DD9;
		public const uint GL_GEOMETRY_SHADER_BIT_EXT = 0x00000004;
		public const uint GL_GEOMETRY_LINKED_VERTICES_OUT_EXT = 0x8916;
		public const uint GL_GEOMETRY_LINKED_INPUT_TYPE_EXT = 0x8917;
		public const uint GL_GEOMETRY_LINKED_OUTPUT_TYPE_EXT = 0x8918;
		public const uint GL_GEOMETRY_SHADER_INVOCATIONS_EXT = 0x887F;
		public const uint GL_LAYER_PROVOKING_VERTEX_EXT = 0x825E;
		public const uint GL_LINES_ADJACENCY_EXT = 0x000A;
		public const uint GL_LINE_STRIP_ADJACENCY_EXT = 0x000B;
		public const uint GL_TRIANGLES_ADJACENCY_EXT = 0x000C;
		public const uint GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D;
		public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8DDF;
		public const uint GL_MAX_GEOMETRY_UNIFORM_BLOCKS_EXT = 0x8A2C;
		public const uint GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8A32;
		public const uint GL_MAX_GEOMETRY_INPUT_COMPONENTS_EXT = 0x9123;
		public const uint GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT = 0x9124;
		public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT = 0x8DE0;
		public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8DE1;
		public const uint GL_MAX_GEOMETRY_SHADER_INVOCATIONS_EXT = 0x8E5A;
		public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CF;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT = 0x92D5;
		public const uint GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT = 0x90CD;
		public const uint GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT = 0x90D7;
		public const uint GL_FIRST_VERTEX_CONVENTION_EXT = 0x8E4D;
		public const uint GL_LAST_VERTEX_CONVENTION_EXT = 0x8E4E;
		public const uint GL_UNDEFINED_VERTEX_EXT = 0x8260;
		public const uint GL_PRIMITIVES_GENERATED_EXT = 0x8C87;
		public const uint GL_FRAMEBUFFER_DEFAULT_LAYERS_EXT = 0x9312;
		public const uint GL_MAX_FRAMEBUFFER_LAYERS_EXT = 0x9317;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7;
		public const uint GL_REFERENCED_BY_GEOMETRY_SHADER_EXT = 0x9309;
		public const uint GL_GEOMETRY_VERTICES_OUT_EXT = 0x8DDA;
		public const uint GL_GEOMETRY_INPUT_TYPE_EXT = 0x8DDB;
		public const uint GL_GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC;
		public const uint GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT = 0x8DDD;
		public const uint GL_MAX_VERTEX_VARYING_COMPONENTS_EXT = 0x8DDE;
		public const uint GL_MAX_VARYING_COMPONENTS_EXT = 0x8B4B;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4;
		public const uint GL_PROGRAM_POINT_SIZE_EXT = 0x8642;
		public const uint GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT = 0x88FD;
		public const uint GL_SAMPLER_1D_ARRAY_EXT = 0x8DC0;
		public const uint GL_SAMPLER_2D_ARRAY_EXT = 0x8DC1;
		public const uint GL_SAMPLER_BUFFER_EXT = 0x8DC2;
		public const uint GL_SAMPLER_1D_ARRAY_SHADOW_EXT = 0x8DC3;
		public const uint GL_SAMPLER_2D_ARRAY_SHADOW_EXT = 0x8DC4;
		public const uint GL_SAMPLER_CUBE_SHADOW_EXT = 0x8DC5;
		public const uint GL_UNSIGNED_INT_VEC2_EXT = 0x8DC6;
		public const uint GL_UNSIGNED_INT_VEC3_EXT = 0x8DC7;
		public const uint GL_UNSIGNED_INT_VEC4_EXT = 0x8DC8;
		public const uint GL_INT_SAMPLER_1D_EXT = 0x8DC9;
		public const uint GL_INT_SAMPLER_2D_EXT = 0x8DCA;
		public const uint GL_INT_SAMPLER_3D_EXT = 0x8DCB;
		public const uint GL_INT_SAMPLER_CUBE_EXT = 0x8DCC;
		public const uint GL_INT_SAMPLER_2D_RECT_EXT = 0x8DCD;
		public const uint GL_INT_SAMPLER_1D_ARRAY_EXT = 0x8DCE;
		public const uint GL_INT_SAMPLER_2D_ARRAY_EXT = 0x8DCF;
		public const uint GL_INT_SAMPLER_BUFFER_EXT = 0x8DD0;
		public const uint GL_UNSIGNED_INT_SAMPLER_1D_EXT = 0x8DD1;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_EXT = 0x8DD2;
		public const uint GL_UNSIGNED_INT_SAMPLER_3D_EXT = 0x8DD3;
		public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_EXT = 0x8DD4;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT = 0x8DD5;
		public const uint GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT = 0x8DD6;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT = 0x8DD7;
		public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT = 0x8DD8;
		public const uint GL_MIN_PROGRAM_TEXEL_OFFSET_EXT = 0x8904;
		public const uint GL_MAX_PROGRAM_TEXEL_OFFSET_EXT = 0x8905;
		public const uint GL_HISTOGRAM_EXT = 0x8024;
		public const uint GL_PROXY_HISTOGRAM_EXT = 0x8025;
		public const uint GL_HISTOGRAM_WIDTH_EXT = 0x8026;
		public const uint GL_HISTOGRAM_FORMAT_EXT = 0x8027;
		public const uint GL_HISTOGRAM_RED_SIZE_EXT = 0x8028;
		public const uint GL_HISTOGRAM_GREEN_SIZE_EXT = 0x8029;
		public const uint GL_HISTOGRAM_BLUE_SIZE_EXT = 0x802A;
		public const uint GL_HISTOGRAM_ALPHA_SIZE_EXT = 0x802B;
		public const uint GL_HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C;
		public const uint GL_HISTOGRAM_SINK_EXT = 0x802D;
		public const uint GL_MINMAX_EXT = 0x802E;
		public const uint GL_MINMAX_FORMAT_EXT = 0x802F;
		public const uint GL_MINMAX_SINK_EXT = 0x8030;
		public const uint GL_TABLE_TOO_LARGE_EXT = 0x8031;
		public const uint GL_IUI_V2F_EXT = 0x81AD;
		public const uint GL_IUI_V3F_EXT = 0x81AE;
		public const uint GL_IUI_N3F_V2F_EXT = 0x81AF;
		public const uint GL_IUI_N3F_V3F_EXT = 0x81B0;
		public const uint GL_T2F_IUI_V2F_EXT = 0x81B1;
		public const uint GL_T2F_IUI_V3F_EXT = 0x81B2;
		public const uint GL_T2F_IUI_N3F_V2F_EXT = 0x81B3;
		public const uint GL_T2F_IUI_N3F_V3F_EXT = 0x81B4;
		public const uint GL_INDEX_TEST_EXT = 0x81B5;
		public const uint GL_INDEX_TEST_FUNC_EXT = 0x81B6;
		public const uint GL_INDEX_TEST_REF_EXT = 0x81B7;
		public const uint GL_INDEX_MATERIAL_EXT = 0x81B8;
		public const uint GL_INDEX_MATERIAL_PARAMETER_EXT = 0x81B9;
		public const uint GL_INDEX_MATERIAL_FACE_EXT = 0x81BA;
		public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR_EXT = 0x88FE;
		public const uint GL_FRAGMENT_MATERIAL_EXT = 0x8349;
		public const uint GL_FRAGMENT_NORMAL_EXT = 0x834A;
		public const uint GL_FRAGMENT_COLOR_EXT = 0x834C;
		public const uint GL_ATTENUATION_EXT = 0x834D;
		public const uint GL_SHADOW_ATTENUATION_EXT = 0x834E;
		public const uint GL_TEXTURE_APPLICATION_MODE_EXT = 0x834F;
		public const uint GL_TEXTURE_LIGHT_EXT = 0x8350;
		public const uint GL_TEXTURE_MATERIAL_FACE_EXT = 0x8351;
		public const uint GL_TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352;
		public const uint GL_MAP_READ_BIT_EXT = 0x0001;
		public const uint GL_MAP_WRITE_BIT_EXT = 0x0002;
		public const uint GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004;
		public const uint GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008;
		public const uint GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010;
		public const uint GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020;
		public const uint GL_MULTISAMPLE_EXT = 0x809D;
		public const uint GL_SAMPLE_ALPHA_TO_MASK_EXT = 0x809E;
		public const uint GL_SAMPLE_ALPHA_TO_ONE_EXT = 0x809F;
		public const uint GL_SAMPLE_MASK_EXT = 0x80A0;
		public const uint GL_1PASS_EXT = 0x80A1;
		public const uint GL_2PASS_0_EXT = 0x80A2;
		public const uint GL_2PASS_1_EXT = 0x80A3;
		public const uint GL_4PASS_0_EXT = 0x80A4;
		public const uint GL_4PASS_1_EXT = 0x80A5;
		public const uint GL_4PASS_2_EXT = 0x80A6;
		public const uint GL_4PASS_3_EXT = 0x80A7;
		public const uint GL_SAMPLE_BUFFERS_EXT = 0x80A8;
		public const uint GL_SAMPLES_EXT = 0x80A9;
		public const uint GL_SAMPLE_MASK_VALUE_EXT = 0x80AA;
		public const uint GL_SAMPLE_MASK_INVERT_EXT = 0x80AB;
		public const uint GL_SAMPLE_PATTERN_EXT = 0x80AC;
		public const uint GL_MULTISAMPLE_BIT_EXT = 0x20000000;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C;
		public const uint GL_COLOR_ATTACHMENT_EXT = 0x90F0;
		public const uint GL_MULTIVIEW_EXT = 0x90F1;
		public const uint GL_DRAW_BUFFER_EXT = 0x0C01;
		public const uint GL_READ_BUFFER_EXT = 0x0C02;
		public const uint GL_MAX_MULTIVIEW_BUFFERS_EXT = 0x90F2;
		public const uint GL_ANY_SAMPLES_PASSED_EXT = 0x8C2F;
		public const uint GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT = 0x8D6A;
		public const uint GL_DEPTH_STENCIL_EXT = 0x84F9;
		public const uint GL_UNSIGNED_INT_24_8_EXT = 0x84FA;
		public const uint GL_DEPTH24_STENCIL8_EXT = 0x88F0;
		public const uint GL_TEXTURE_STENCIL_SIZE_EXT = 0x88F1;
		public const uint GL_R11F_G11F_B10F_EXT = 0x8C3A;
		public const uint GL_UNSIGNED_INT_10F_11F_11F_REV_EXT = 0x8C3B;
		public const uint GL_RGBA_SIGNED_COMPONENTS_EXT = 0x8C3C;
		public const uint GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033;
		public const uint GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034;
		public const uint GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035;
		public const uint GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036;
		public const uint GL_COLOR_INDEX1_EXT = 0x80E2;
		public const uint GL_COLOR_INDEX2_EXT = 0x80E3;
		public const uint GL_COLOR_INDEX4_EXT = 0x80E4;
		public const uint GL_COLOR_INDEX8_EXT = 0x80E5;
		public const uint GL_COLOR_INDEX12_EXT = 0x80E6;
		public const uint GL_COLOR_INDEX16_EXT = 0x80E7;
		public const uint GL_TEXTURE_INDEX_SIZE_EXT = 0x80ED;
		public const uint GL_PIXEL_PACK_BUFFER_EXT = 0x88EB;
		public const uint GL_PIXEL_UNPACK_BUFFER_EXT = 0x88EC;
		public const uint GL_PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED;
		public const uint GL_PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF;
		public const uint GL_PIXEL_TRANSFORM_2D_EXT = 0x8330;
		public const uint GL_PIXEL_MAG_FILTER_EXT = 0x8331;
		public const uint GL_PIXEL_MIN_FILTER_EXT = 0x8332;
		public const uint GL_PIXEL_CUBIC_WEIGHT_EXT = 0x8333;
		public const uint GL_CUBIC_EXT = 0x8334;
		public const uint GL_AVERAGE_EXT = 0x8335;
		public const uint GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336;
		public const uint GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337;
		public const uint GL_PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338;
		public const uint GL_POINT_SIZE_MIN_EXT = 0x8126;
		public const uint GL_POINT_SIZE_MAX_EXT = 0x8127;
		public const uint GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128;
		public const uint GL_DISTANCE_ATTENUATION_EXT = 0x8129;
		public const uint GL_POLYGON_OFFSET_EXT = 0x8037;
		public const uint GL_POLYGON_OFFSET_FACTOR_EXT = 0x8038;
		public const uint GL_POLYGON_OFFSET_BIAS_EXT = 0x8039;
		public const uint GL_POLYGON_OFFSET_CLAMP_EXT = 0x8E1B;
		public const uint GL_PRIMITIVE_BOUNDING_BOX_EXT = 0x92BE;
		public const uint GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT = 0x8E4C;
		public const uint GL_PROVOKING_VERTEX_EXT = 0x8E4F;
		public const uint GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT = 0x8A54;
		public const uint GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT = 0x8A55;
		public const uint GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT = 0x8A56;
		public const uint GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT = 0x8A57;
		public const uint GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG = 0x93F0;
		public const uint GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG = 0x93F1;
		public const uint GL_RASTER_MULTISAMPLE_EXT = 0x9327;
		public const uint GL_RASTER_SAMPLES_EXT = 0x9328;
		public const uint GL_MAX_RASTER_SAMPLES_EXT = 0x9329;
		public const uint GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A;
		public const uint GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B;
		public const uint GL_EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365;
		public const uint GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366;
		public const uint GL_BYTE = 0x1400;
		public const uint GL_SHORT = 0x1402;
		public const uint GL_R8_SNORM = 0x8F94;
		public const uint GL_RG8_SNORM = 0x8F95;
		public const uint GL_RGBA8_SNORM = 0x8F97;
		public const uint GL_R16_SNORM_EXT = 0x8F98;
		public const uint GL_RG16_SNORM_EXT = 0x8F99;
		public const uint GL_RGBA16_SNORM_EXT = 0x8F9B;
		public const uint GL_RESCALE_NORMAL_EXT = 0x803A;
		public const uint GL_GUILTY_CONTEXT_RESET_EXT = 0x8253;
		public const uint GL_INNOCENT_CONTEXT_RESET_EXT = 0x8254;
		public const uint GL_UNKNOWN_CONTEXT_RESET_EXT = 0x8255;
		public const uint GL_CONTEXT_ROBUST_ACCESS_EXT = 0x90F3;
		public const uint GL_RESET_NOTIFICATION_STRATEGY_EXT = 0x8256;
		public const uint GL_LOSE_CONTEXT_ON_RESET_EXT = 0x8252;
		public const uint GL_NO_RESET_NOTIFICATION_EXT = 0x8261;
		public const uint GL_SRGB_EXT = 0x8C40;
		public const uint GL_SRGB_ALPHA_EXT = 0x8C42;
		public const uint GL_SRGB8_ALPHA8_EXT = 0x8C43;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210;
		public const uint GL_COLOR_SUM_EXT = 0x8458;
		public const uint GL_CURRENT_SECONDARY_COLOR_EXT = 0x8459;
		public const uint GL_SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A;
		public const uint GL_SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B;
		public const uint GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C;
		public const uint GL_SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D;
		public const uint GL_SECONDARY_COLOR_ARRAY_EXT = 0x845E;
		public const uint GL_VERTEX_SHADER_BIT_EXT = 0x00000001;
		public const uint GL_FRAGMENT_SHADER_BIT_EXT = 0x00000002;
		public const uint GL_ALL_SHADER_BITS_EXT = 0xFFFFFFFF;
		public const uint GL_PROGRAM_SEPARABLE_EXT = 0x8258;
		public const uint GL_PROGRAM_PIPELINE_BINDING_EXT = 0x825A;
		public const uint GL_LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8;
		public const uint GL_SINGLE_COLOR_EXT = 0x81F9;
		public const uint GL_SEPARATE_SPECULAR_COLOR_EXT = 0x81FA;
		public const uint GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT = 0x8A52;
		public const uint GL_MAX_IMAGE_UNITS_EXT = 0x8F38;
		public const uint GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39;
		public const uint GL_IMAGE_BINDING_NAME_EXT = 0x8F3A;
		public const uint GL_IMAGE_BINDING_LEVEL_EXT = 0x8F3B;
		public const uint GL_IMAGE_BINDING_LAYERED_EXT = 0x8F3C;
		public const uint GL_IMAGE_BINDING_LAYER_EXT = 0x8F3D;
		public const uint GL_IMAGE_BINDING_ACCESS_EXT = 0x8F3E;
		public const uint GL_IMAGE_1D_EXT = 0x904C;
		public const uint GL_IMAGE_2D_EXT = 0x904D;
		public const uint GL_IMAGE_3D_EXT = 0x904E;
		public const uint GL_IMAGE_2D_RECT_EXT = 0x904F;
		public const uint GL_IMAGE_CUBE_EXT = 0x9050;
		public const uint GL_IMAGE_BUFFER_EXT = 0x9051;
		public const uint GL_IMAGE_1D_ARRAY_EXT = 0x9052;
		public const uint GL_IMAGE_2D_ARRAY_EXT = 0x9053;
		public const uint GL_IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054;
		public const uint GL_IMAGE_2D_MULTISAMPLE_EXT = 0x9055;
		public const uint GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056;
		public const uint GL_INT_IMAGE_1D_EXT = 0x9057;
		public const uint GL_INT_IMAGE_2D_EXT = 0x9058;
		public const uint GL_INT_IMAGE_3D_EXT = 0x9059;
		public const uint GL_INT_IMAGE_2D_RECT_EXT = 0x905A;
		public const uint GL_INT_IMAGE_CUBE_EXT = 0x905B;
		public const uint GL_INT_IMAGE_BUFFER_EXT = 0x905C;
		public const uint GL_INT_IMAGE_1D_ARRAY_EXT = 0x905D;
		public const uint GL_INT_IMAGE_2D_ARRAY_EXT = 0x905E;
		public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F;
		public const uint GL_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060;
		public const uint GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061;
		public const uint GL_UNSIGNED_INT_IMAGE_1D_EXT = 0x9062;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_EXT = 0x9063;
		public const uint GL_UNSIGNED_INT_IMAGE_3D_EXT = 0x9064;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066;
		public const uint GL_UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067;
		public const uint GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C;
		public const uint GL_MAX_IMAGE_SAMPLES_EXT = 0x906D;
		public const uint GL_IMAGE_BINDING_FORMAT_EXT = 0x906E;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001;
		public const uint GL_ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002;
		public const uint GL_UNIFORM_BARRIER_BIT_EXT = 0x00000004;
		public const uint GL_TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008;
		public const uint GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020;
		public const uint GL_COMMAND_BARRIER_BIT_EXT = 0x00000040;
		public const uint GL_PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080;
		public const uint GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100;
		public const uint GL_BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200;
		public const uint GL_FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400;
		public const uint GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800;
		public const uint GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000;
		public const uint GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF;
		public const uint GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT = 0x8F63;
		public const uint GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT = 0x8F67;
		public const uint GL_SHADER_PIXEL_LOCAL_STORAGE_EXT = 0x8F64;
		public const uint GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT = 0x9650;
		public const uint GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT = 0x9651;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT = 0x9652;
		public const uint GL_TEXTURE_COMPARE_MODE_EXT = 0x884C;
		public const uint GL_TEXTURE_COMPARE_FUNC_EXT = 0x884D;
		public const uint GL_COMPARE_REF_TO_TEXTURE_EXT = 0x884E;
		public const uint GL_SAMPLER_2D_SHADOW_EXT = 0x8B62;
		public const uint GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB;
		public const uint GL_TEXTURE_SPARSE_EXT = 0x91A6;
		public const uint GL_VIRTUAL_PAGE_SIZE_INDEX_EXT = 0x91A7;
		public const uint GL_NUM_SPARSE_LEVELS_EXT = 0x91AA;
		public const uint GL_NUM_VIRTUAL_PAGE_SIZES_EXT = 0x91A8;
		public const uint GL_VIRTUAL_PAGE_SIZE_X_EXT = 0x9195;
		public const uint GL_VIRTUAL_PAGE_SIZE_Y_EXT = 0x9196;
		public const uint GL_VIRTUAL_PAGE_SIZE_Z_EXT = 0x9197;
		public const uint GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009;
		public const uint GL_MAX_SPARSE_TEXTURE_SIZE_EXT = 0x9198;
		public const uint GL_MAX_SPARSE_3D_TEXTURE_SIZE_EXT = 0x9199;
		public const uint GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT = 0x919A;
		public const uint GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT = 0x91A9;
		public const uint GL_STENCIL_TAG_BITS_EXT = 0x88F2;
		public const uint GL_STENCIL_CLEAR_TAG_VALUE_EXT = 0x88F3;
		public const uint GL_STENCIL_TEST_TWO_SIDE_EXT = 0x8910;
		public const uint GL_ACTIVE_STENCIL_FACE_EXT = 0x8911;
		public const uint GL_INCR_WRAP_EXT = 0x8507;
		public const uint GL_DECR_WRAP_EXT = 0x8508;
		public const uint GL_PATCHES_EXT = 0x000E;
		public const uint GL_PATCH_VERTICES_EXT = 0x8E72;
		public const uint GL_TESS_CONTROL_OUTPUT_VERTICES_EXT = 0x8E75;
		public const uint GL_TESS_GEN_MODE_EXT = 0x8E76;
		public const uint GL_TESS_GEN_SPACING_EXT = 0x8E77;
		public const uint GL_TESS_GEN_VERTEX_ORDER_EXT = 0x8E78;
		public const uint GL_TESS_GEN_POINT_MODE_EXT = 0x8E79;
		public const uint GL_ISOLINES_EXT = 0x8E7A;
		public const uint GL_QUADS_EXT = 0x0007;
		public const uint GL_FRACTIONAL_ODD_EXT = 0x8E7B;
		public const uint GL_FRACTIONAL_EVEN_EXT = 0x8E7C;
		public const uint GL_MAX_PATCH_VERTICES_EXT = 0x8E7D;
		public const uint GL_MAX_TESS_GEN_LEVEL_EXT = 0x8E7E;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_EXT = 0x8E7F;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT = 0x8E80;
		public const uint GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_EXT = 0x8E81;
		public const uint GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_EXT = 0x8E82;
		public const uint GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_EXT = 0x8E83;
		public const uint GL_MAX_TESS_PATCH_COMPONENTS_EXT = 0x8E84;
		public const uint GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8E85;
		public const uint GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_EXT = 0x8E86;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_EXT = 0x8E89;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_EXT = 0x8E8A;
		public const uint GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_EXT = 0x886C;
		public const uint GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_EXT = 0x886D;
		public const uint GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_EXT = 0x8E1E;
		public const uint GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT = 0x8E1F;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CD;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CE;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT = 0x92D3;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT = 0x92D4;
		public const uint GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT = 0x90CB;
		public const uint GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT = 0x90CC;
		public const uint GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT = 0x90D8;
		public const uint GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT = 0x90D9;
		public const uint GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
		public const uint GL_IS_PER_PATCH_EXT = 0x92E7;
		public const uint GL_REFERENCED_BY_TESS_CONTROL_SHADER_EXT = 0x9307;
		public const uint GL_REFERENCED_BY_TESS_EVALUATION_SHADER_EXT = 0x9308;
		public const uint GL_TESS_CONTROL_SHADER_EXT = 0x8E88;
		public const uint GL_TESS_EVALUATION_SHADER_EXT = 0x8E87;
		public const uint GL_TESS_CONTROL_SHADER_BIT_EXT = 0x00000008;
		public const uint GL_TESS_EVALUATION_SHADER_BIT_EXT = 0x00000010;
		public const uint GL_ALPHA4_EXT = 0x803B;
		public const uint GL_ALPHA8_EXT = 0x803C;
		public const uint GL_ALPHA12_EXT = 0x803D;
		public const uint GL_ALPHA16_EXT = 0x803E;
		public const uint GL_LUMINANCE4_EXT = 0x803F;
		public const uint GL_LUMINANCE8_EXT = 0x8040;
		public const uint GL_LUMINANCE12_EXT = 0x8041;
		public const uint GL_LUMINANCE16_EXT = 0x8042;
		public const uint GL_LUMINANCE4_ALPHA4_EXT = 0x8043;
		public const uint GL_LUMINANCE6_ALPHA2_EXT = 0x8044;
		public const uint GL_LUMINANCE8_ALPHA8_EXT = 0x8045;
		public const uint GL_LUMINANCE12_ALPHA4_EXT = 0x8046;
		public const uint GL_LUMINANCE12_ALPHA12_EXT = 0x8047;
		public const uint GL_LUMINANCE16_ALPHA16_EXT = 0x8048;
		public const uint GL_INTENSITY_EXT = 0x8049;
		public const uint GL_INTENSITY4_EXT = 0x804A;
		public const uint GL_INTENSITY8_EXT = 0x804B;
		public const uint GL_INTENSITY12_EXT = 0x804C;
		public const uint GL_INTENSITY16_EXT = 0x804D;
		public const uint GL_RGB2_EXT = 0x804E;
		public const uint GL_RGB4_EXT = 0x804F;
		public const uint GL_RGB5_EXT = 0x8050;
		public const uint GL_RGB8_EXT = 0x8051;
		public const uint GL_RGB10_EXT = 0x8052;
		public const uint GL_RGB12_EXT = 0x8053;
		public const uint GL_RGB16_EXT = 0x8054;
		public const uint GL_RGBA2_EXT = 0x8055;
		public const uint GL_RGBA4_EXT = 0x8056;
		public const uint GL_RGB5_A1_EXT = 0x8057;
		public const uint GL_RGBA8_EXT = 0x8058;
		public const uint GL_RGB10_A2_EXT = 0x8059;
		public const uint GL_RGBA12_EXT = 0x805A;
		public const uint GL_RGBA16_EXT = 0x805B;
		public const uint GL_TEXTURE_RED_SIZE_EXT = 0x805C;
		public const uint GL_TEXTURE_GREEN_SIZE_EXT = 0x805D;
		public const uint GL_TEXTURE_BLUE_SIZE_EXT = 0x805E;
		public const uint GL_TEXTURE_ALPHA_SIZE_EXT = 0x805F;
		public const uint GL_TEXTURE_LUMINANCE_SIZE_EXT = 0x8060;
		public const uint GL_TEXTURE_INTENSITY_SIZE_EXT = 0x8061;
		public const uint GL_REPLACE_EXT = 0x8062;
		public const uint GL_PROXY_TEXTURE_1D_EXT = 0x8063;
		public const uint GL_PROXY_TEXTURE_2D_EXT = 0x8064;
		public const uint GL_TEXTURE_TOO_LARGE_EXT = 0x8065;
		public const uint GL_PACK_SKIP_IMAGES_EXT = 0x806B;
		public const uint GL_PACK_IMAGE_HEIGHT_EXT = 0x806C;
		public const uint GL_UNPACK_SKIP_IMAGES_EXT = 0x806D;
		public const uint GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E;
		public const uint GL_TEXTURE_3D_EXT = 0x806F;
		public const uint GL_PROXY_TEXTURE_3D_EXT = 0x8070;
		public const uint GL_TEXTURE_DEPTH_EXT = 0x8071;
		public const uint GL_TEXTURE_WRAP_R_EXT = 0x8072;
		public const uint GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073;
		public const uint GL_TEXTURE_1D_ARRAY_EXT = 0x8C18;
		public const uint GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19;
		public const uint GL_TEXTURE_2D_ARRAY_EXT = 0x8C1A;
		public const uint GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B;
		public const uint GL_TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C;
		public const uint GL_TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D;
		public const uint GL_MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF;
		public const uint GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E;
		public const uint GL_TEXTURE_BORDER_COLOR_EXT = 0x1004;
		public const uint GL_CLAMP_TO_BORDER_EXT = 0x812D;
		public const uint GL_TEXTURE_BUFFER_EXT = 0x8C2A;
		public const uint GL_TEXTURE_BUFFER_BINDING_EXT = 0x8C2A;
		public const uint GL_MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B;
		public const uint GL_TEXTURE_BINDING_BUFFER_EXT = 0x8C2C;
		public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D;
		public const uint GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT = 0x919F;
		public const uint GL_TEXTURE_BUFFER_OFFSET_EXT = 0x919D;
		public const uint GL_TEXTURE_BUFFER_SIZE_EXT = 0x919E;
		public const uint GL_TEXTURE_BUFFER_FORMAT_EXT = 0x8C2E;
		public const uint GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0;
		public const uint GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1;
		public const uint GL_COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70;
		public const uint GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71;
		public const uint GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72;
		public const uint GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73;
		public const uint GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB;
		public const uint GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC;
		public const uint GL_COMPRESSED_RED_GREEN_RGTC2_EXT = 0x8DBD;
		public const uint GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT = 0x8DBE;
		public const uint GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2;
		public const uint GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3;
		public const uint GL_NORMAL_MAP_EXT = 0x8511;
		public const uint GL_REFLECTION_MAP_EXT = 0x8512;
		public const uint GL_TEXTURE_CUBE_MAP_EXT = 0x8513;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_EXT = 0x8514;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B;
		public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT = 0x851C;
		public const uint GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT = 0x900A;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900C;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT = 0x900D;
		public const uint GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900E;
		public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900F;
		public const uint GL_COMBINE_EXT = 0x8570;
		public const uint GL_COMBINE_RGB_EXT = 0x8571;
		public const uint GL_COMBINE_ALPHA_EXT = 0x8572;
		public const uint GL_RGB_SCALE_EXT = 0x8573;
		public const uint GL_ADD_SIGNED_EXT = 0x8574;
		public const uint GL_INTERPOLATE_EXT = 0x8575;
		public const uint GL_CONSTANT_EXT = 0x8576;
		public const uint GL_PRIMARY_COLOR_EXT = 0x8577;
		public const uint GL_PREVIOUS_EXT = 0x8578;
		public const uint GL_SOURCE0_RGB_EXT = 0x8580;
		public const uint GL_SOURCE1_RGB_EXT = 0x8581;
		public const uint GL_SOURCE2_RGB_EXT = 0x8582;
		public const uint GL_SOURCE0_ALPHA_EXT = 0x8588;
		public const uint GL_SOURCE1_ALPHA_EXT = 0x8589;
		public const uint GL_SOURCE2_ALPHA_EXT = 0x858A;
		public const uint GL_OPERAND0_RGB_EXT = 0x8590;
		public const uint GL_OPERAND1_RGB_EXT = 0x8591;
		public const uint GL_OPERAND2_RGB_EXT = 0x8592;
		public const uint GL_OPERAND0_ALPHA_EXT = 0x8598;
		public const uint GL_OPERAND1_ALPHA_EXT = 0x8599;
		public const uint GL_OPERAND2_ALPHA_EXT = 0x859A;
		public const uint GL_DOT3_RGB_EXT = 0x8740;
		public const uint GL_DOT3_RGBA_EXT = 0x8741;
		public const uint GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
		public const uint GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
		public const uint GL_RGBA32UI_EXT = 0x8D70;
		public const uint GL_RGB32UI_EXT = 0x8D71;
		public const uint GL_ALPHA32UI_EXT = 0x8D72;
		public const uint GL_INTENSITY32UI_EXT = 0x8D73;
		public const uint GL_LUMINANCE32UI_EXT = 0x8D74;
		public const uint GL_LUMINANCE_ALPHA32UI_EXT = 0x8D75;
		public const uint GL_RGBA16UI_EXT = 0x8D76;
		public const uint GL_RGB16UI_EXT = 0x8D77;
		public const uint GL_ALPHA16UI_EXT = 0x8D78;
		public const uint GL_INTENSITY16UI_EXT = 0x8D79;
		public const uint GL_LUMINANCE16UI_EXT = 0x8D7A;
		public const uint GL_LUMINANCE_ALPHA16UI_EXT = 0x8D7B;
		public const uint GL_RGBA8UI_EXT = 0x8D7C;
		public const uint GL_RGB8UI_EXT = 0x8D7D;
		public const uint GL_ALPHA8UI_EXT = 0x8D7E;
		public const uint GL_INTENSITY8UI_EXT = 0x8D7F;
		public const uint GL_LUMINANCE8UI_EXT = 0x8D80;
		public const uint GL_LUMINANCE_ALPHA8UI_EXT = 0x8D81;
		public const uint GL_RGBA32I_EXT = 0x8D82;
		public const uint GL_RGB32I_EXT = 0x8D83;
		public const uint GL_ALPHA32I_EXT = 0x8D84;
		public const uint GL_INTENSITY32I_EXT = 0x8D85;
		public const uint GL_LUMINANCE32I_EXT = 0x8D86;
		public const uint GL_LUMINANCE_ALPHA32I_EXT = 0x8D87;
		public const uint GL_RGBA16I_EXT = 0x8D88;
		public const uint GL_RGB16I_EXT = 0x8D89;
		public const uint GL_ALPHA16I_EXT = 0x8D8A;
		public const uint GL_INTENSITY16I_EXT = 0x8D8B;
		public const uint GL_LUMINANCE16I_EXT = 0x8D8C;
		public const uint GL_LUMINANCE_ALPHA16I_EXT = 0x8D8D;
		public const uint GL_RGBA8I_EXT = 0x8D8E;
		public const uint GL_RGB8I_EXT = 0x8D8F;
		public const uint GL_ALPHA8I_EXT = 0x8D90;
		public const uint GL_INTENSITY8I_EXT = 0x8D91;
		public const uint GL_LUMINANCE8I_EXT = 0x8D92;
		public const uint GL_LUMINANCE_ALPHA8I_EXT = 0x8D93;
		public const uint GL_RED_INTEGER_EXT = 0x8D94;
		public const uint GL_GREEN_INTEGER_EXT = 0x8D95;
		public const uint GL_BLUE_INTEGER_EXT = 0x8D96;
		public const uint GL_ALPHA_INTEGER_EXT = 0x8D97;
		public const uint GL_RGB_INTEGER_EXT = 0x8D98;
		public const uint GL_RGBA_INTEGER_EXT = 0x8D99;
		public const uint GL_BGR_INTEGER_EXT = 0x8D9A;
		public const uint GL_BGRA_INTEGER_EXT = 0x8D9B;
		public const uint GL_LUMINANCE_INTEGER_EXT = 0x8D9C;
		public const uint GL_LUMINANCE_ALPHA_INTEGER_EXT = 0x8D9D;
		public const uint GL_RGBA_INTEGER_MODE_EXT = 0x8D9E;
		public const uint GL_MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD;
		public const uint GL_TEXTURE_FILTER_CONTROL_EXT = 0x8500;
		public const uint GL_TEXTURE_LOD_BIAS_EXT = 0x8501;
		public const uint GL_MIRROR_CLAMP_EXT = 0x8742;
		public const uint GL_MIRROR_CLAMP_TO_EDGE_EXT = 0x8743;
		public const uint GL_MIRROR_CLAMP_TO_BORDER_EXT = 0x8912;
		public const uint GL_R16_EXT = 0x822A;
		public const uint GL_RG16_EXT = 0x822C;
		public const uint GL_RGB16_SNORM_EXT = 0x8F9A;
		public const uint GL_TEXTURE_PRIORITY_EXT = 0x8066;
		public const uint GL_TEXTURE_RESIDENT_EXT = 0x8067;
		public const uint GL_TEXTURE_1D_BINDING_EXT = 0x8068;
		public const uint GL_TEXTURE_2D_BINDING_EXT = 0x8069;
		public const uint GL_TEXTURE_3D_BINDING_EXT = 0x806A;
		public const uint GL_PERTURB_EXT = 0x85AE;
		public const uint GL_TEXTURE_NORMAL_EXT = 0x85AF;
		public const uint GL_RED_EXT = 0x1903;
		public const uint GL_RG_EXT = 0x8227;
		public const uint GL_R8_EXT = 0x8229;
		public const uint GL_RG8_EXT = 0x822B;
		public const uint GL_SRGB8_EXT = 0x8C41;
		public const uint GL_SLUMINANCE_ALPHA_EXT = 0x8C44;
		public const uint GL_SLUMINANCE8_ALPHA8_EXT = 0x8C45;
		public const uint GL_SLUMINANCE_EXT = 0x8C46;
		public const uint GL_SLUMINANCE8_EXT = 0x8C47;
		public const uint GL_COMPRESSED_SRGB_EXT = 0x8C48;
		public const uint GL_COMPRESSED_SRGB_ALPHA_EXT = 0x8C49;
		public const uint GL_COMPRESSED_SLUMINANCE_EXT = 0x8C4A;
		public const uint GL_COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B;
		public const uint GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;
		public const uint GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;
		public const uint GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;
		public const uint GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;
		public const uint GL_SR8_EXT = 0x8FBD;
		public const uint GL_SRG8_EXT = 0x8FBE;
		public const uint GL_TEXTURE_SRGB_DECODE_EXT = 0x8A48;
		public const uint GL_DECODE_EXT = 0x8A49;
		public const uint GL_SKIP_DECODE_EXT = 0x8A4A;
		public const uint GL_RGB9_E5_EXT = 0x8C3D;
		public const uint GL_UNSIGNED_INT_5_9_9_9_REV_EXT = 0x8C3E;
		public const uint GL_TEXTURE_SHARED_SIZE_EXT = 0x8C3F;
		public const uint GL_ALPHA_SNORM = 0x9010;
		public const uint GL_LUMINANCE_SNORM = 0x9011;
		public const uint GL_LUMINANCE_ALPHA_SNORM = 0x9012;
		public const uint GL_INTENSITY_SNORM = 0x9013;
		public const uint GL_ALPHA8_SNORM = 0x9014;
		public const uint GL_LUMINANCE8_SNORM = 0x9015;
		public const uint GL_LUMINANCE8_ALPHA8_SNORM = 0x9016;
		public const uint GL_INTENSITY8_SNORM = 0x9017;
		public const uint GL_ALPHA16_SNORM = 0x9018;
		public const uint GL_LUMINANCE16_SNORM = 0x9019;
		public const uint GL_LUMINANCE16_ALPHA16_SNORM = 0x901A;
		public const uint GL_INTENSITY16_SNORM = 0x901B;
		public const uint GL_RED_SNORM = 0x8F90;
		public const uint GL_RG_SNORM = 0x8F91;
		public const uint GL_RGB_SNORM = 0x8F92;
		public const uint GL_RGBA_SNORM = 0x8F93;
		public const uint GL_RGB8_SNORM = 0x8F96;
		public const uint GL_R16_SNORM = 0x8F98;
		public const uint GL_RG16_SNORM = 0x8F99;
		public const uint GL_RGB16_SNORM = 0x8F9A;
		public const uint GL_RGBA16_SNORM = 0x8F9B;
		public const uint GL_SIGNED_NORMALIZED = 0x8F9C;
		public const uint GL_TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F;
		public const uint GL_RGBA32F_EXT = 0x8814;
		public const uint GL_RGB32F_EXT = 0x8815;
		public const uint GL_ALPHA32F_EXT = 0x8816;
		public const uint GL_LUMINANCE32F_EXT = 0x8818;
		public const uint GL_LUMINANCE_ALPHA32F_EXT = 0x8819;
		public const uint GL_ALPHA16F_EXT = 0x881C;
		public const uint GL_LUMINANCE16F_EXT = 0x881E;
		public const uint GL_LUMINANCE_ALPHA16F_EXT = 0x881F;
		public const uint GL_R32F_EXT = 0x822E;
		public const uint GL_RG32F_EXT = 0x8230;
		public const uint GL_TEXTURE_SWIZZLE_R_EXT = 0x8E42;
		public const uint GL_TEXTURE_SWIZZLE_G_EXT = 0x8E43;
		public const uint GL_TEXTURE_SWIZZLE_B_EXT = 0x8E44;
		public const uint GL_TEXTURE_SWIZZLE_A_EXT = 0x8E45;
		public const uint GL_TEXTURE_SWIZZLE_RGBA_EXT = 0x8E46;
		public const uint GL_UNSIGNED_INT_2_10_10_10_REV_EXT = 0x8368;
		public const uint GL_TEXTURE_VIEW_MIN_LEVEL_EXT = 0x82DB;
		public const uint GL_TEXTURE_VIEW_NUM_LEVELS_EXT = 0x82DC;
		public const uint GL_TEXTURE_VIEW_MIN_LAYER_EXT = 0x82DD;
		public const uint GL_TEXTURE_VIEW_NUM_LAYERS_EXT = 0x82DE;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_EXT = 0x8C8E;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT = 0x8C84;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT = 0x8C85;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT = 0x8C8F;
		public const uint GL_INTERLEAVED_ATTRIBS_EXT = 0x8C8C;
		public const uint GL_SEPARATE_ATTRIBS_EXT = 0x8C8D;
		public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT = 0x8C88;
		public const uint GL_RASTERIZER_DISCARD_EXT = 0x8C89;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT = 0x8C8A;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT = 0x8C8B;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT = 0x8C80;
		public const uint GL_TRANSFORM_FEEDBACK_VARYINGS_EXT = 0x8C83;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT = 0x8C7F;
		public const uint GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT = 0x8C76;
		public const uint GL_UNPACK_ROW_LENGTH_EXT = 0x0CF2;
		public const uint GL_UNPACK_SKIP_ROWS_EXT = 0x0CF3;
		public const uint GL_UNPACK_SKIP_PIXELS_EXT = 0x0CF4;
		public const uint GL_VERTEX_ARRAY_EXT = 0x8074;
		public const uint GL_NORMAL_ARRAY_EXT = 0x8075;
		public const uint GL_COLOR_ARRAY_EXT = 0x8076;
		public const uint GL_INDEX_ARRAY_EXT = 0x8077;
		public const uint GL_TEXTURE_COORD_ARRAY_EXT = 0x8078;
		public const uint GL_EDGE_FLAG_ARRAY_EXT = 0x8079;
		public const uint GL_VERTEX_ARRAY_SIZE_EXT = 0x807A;
		public const uint GL_VERTEX_ARRAY_TYPE_EXT = 0x807B;
		public const uint GL_VERTEX_ARRAY_STRIDE_EXT = 0x807C;
		public const uint GL_VERTEX_ARRAY_COUNT_EXT = 0x807D;
		public const uint GL_NORMAL_ARRAY_TYPE_EXT = 0x807E;
		public const uint GL_NORMAL_ARRAY_STRIDE_EXT = 0x807F;
		public const uint GL_NORMAL_ARRAY_COUNT_EXT = 0x8080;
		public const uint GL_COLOR_ARRAY_SIZE_EXT = 0x8081;
		public const uint GL_COLOR_ARRAY_TYPE_EXT = 0x8082;
		public const uint GL_COLOR_ARRAY_STRIDE_EXT = 0x8083;
		public const uint GL_COLOR_ARRAY_COUNT_EXT = 0x8084;
		public const uint GL_INDEX_ARRAY_TYPE_EXT = 0x8085;
		public const uint GL_INDEX_ARRAY_STRIDE_EXT = 0x8086;
		public const uint GL_INDEX_ARRAY_COUNT_EXT = 0x8087;
		public const uint GL_TEXTURE_COORD_ARRAY_SIZE_EXT = 0x8088;
		public const uint GL_TEXTURE_COORD_ARRAY_TYPE_EXT = 0x8089;
		public const uint GL_TEXTURE_COORD_ARRAY_STRIDE_EXT = 0x808A;
		public const uint GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B;
		public const uint GL_EDGE_FLAG_ARRAY_STRIDE_EXT = 0x808C;
		public const uint GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D;
		public const uint GL_VERTEX_ARRAY_POINTER_EXT = 0x808E;
		public const uint GL_NORMAL_ARRAY_POINTER_EXT = 0x808F;
		public const uint GL_COLOR_ARRAY_POINTER_EXT = 0x8090;
		public const uint GL_INDEX_ARRAY_POINTER_EXT = 0x8091;
		public const uint GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092;
		public const uint GL_EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093;
		public const uint GL_DOUBLE_VEC2_EXT = 0x8FFC;
		public const uint GL_DOUBLE_VEC3_EXT = 0x8FFD;
		public const uint GL_DOUBLE_VEC4_EXT = 0x8FFE;
		public const uint GL_DOUBLE_MAT2_EXT = 0x8F46;
		public const uint GL_DOUBLE_MAT3_EXT = 0x8F47;
		public const uint GL_DOUBLE_MAT4_EXT = 0x8F48;
		public const uint GL_DOUBLE_MAT2x3_EXT = 0x8F49;
		public const uint GL_DOUBLE_MAT2x4_EXT = 0x8F4A;
		public const uint GL_DOUBLE_MAT3x2_EXT = 0x8F4B;
		public const uint GL_DOUBLE_MAT3x4_EXT = 0x8F4C;
		public const uint GL_DOUBLE_MAT4x2_EXT = 0x8F4D;
		public const uint GL_DOUBLE_MAT4x3_EXT = 0x8F4E;
		public const uint GL_VERTEX_SHADER_EXT = 0x8780;
		public const uint GL_VERTEX_SHADER_BINDING_EXT = 0x8781;
		public const uint GL_OP_INDEX_EXT = 0x8782;
		public const uint GL_OP_NEGATE_EXT = 0x8783;
		public const uint GL_OP_DOT3_EXT = 0x8784;
		public const uint GL_OP_DOT4_EXT = 0x8785;
		public const uint GL_OP_MUL_EXT = 0x8786;
		public const uint GL_OP_ADD_EXT = 0x8787;
		public const uint GL_OP_MADD_EXT = 0x8788;
		public const uint GL_OP_FRAC_EXT = 0x8789;
		public const uint GL_OP_MAX_EXT = 0x878A;
		public const uint GL_OP_MIN_EXT = 0x878B;
		public const uint GL_OP_SET_GE_EXT = 0x878C;
		public const uint GL_OP_SET_LT_EXT = 0x878D;
		public const uint GL_OP_CLAMP_EXT = 0x878E;
		public const uint GL_OP_FLOOR_EXT = 0x878F;
		public const uint GL_OP_ROUND_EXT = 0x8790;
		public const uint GL_OP_EXP_BASE_2_EXT = 0x8791;
		public const uint GL_OP_LOG_BASE_2_EXT = 0x8792;
		public const uint GL_OP_POWER_EXT = 0x8793;
		public const uint GL_OP_RECIP_EXT = 0x8794;
		public const uint GL_OP_RECIP_SQRT_EXT = 0x8795;
		public const uint GL_OP_SUB_EXT = 0x8796;
		public const uint GL_OP_CROSS_PRODUCT_EXT = 0x8797;
		public const uint GL_OP_MULTIPLY_MATRIX_EXT = 0x8798;
		public const uint GL_OP_MOV_EXT = 0x8799;
		public const uint GL_OUTPUT_VERTEX_EXT = 0x879A;
		public const uint GL_OUTPUT_COLOR0_EXT = 0x879B;
		public const uint GL_OUTPUT_COLOR1_EXT = 0x879C;
		public const uint GL_OUTPUT_TEXTURE_COORD0_EXT = 0x879D;
		public const uint GL_OUTPUT_TEXTURE_COORD1_EXT = 0x879E;
		public const uint GL_OUTPUT_TEXTURE_COORD2_EXT = 0x879F;
		public const uint GL_OUTPUT_TEXTURE_COORD3_EXT = 0x87A0;
		public const uint GL_OUTPUT_TEXTURE_COORD4_EXT = 0x87A1;
		public const uint GL_OUTPUT_TEXTURE_COORD5_EXT = 0x87A2;
		public const uint GL_OUTPUT_TEXTURE_COORD6_EXT = 0x87A3;
		public const uint GL_OUTPUT_TEXTURE_COORD7_EXT = 0x87A4;
		public const uint GL_OUTPUT_TEXTURE_COORD8_EXT = 0x87A5;
		public const uint GL_OUTPUT_TEXTURE_COORD9_EXT = 0x87A6;
		public const uint GL_OUTPUT_TEXTURE_COORD10_EXT = 0x87A7;
		public const uint GL_OUTPUT_TEXTURE_COORD11_EXT = 0x87A8;
		public const uint GL_OUTPUT_TEXTURE_COORD12_EXT = 0x87A9;
		public const uint GL_OUTPUT_TEXTURE_COORD13_EXT = 0x87AA;
		public const uint GL_OUTPUT_TEXTURE_COORD14_EXT = 0x87AB;
		public const uint GL_OUTPUT_TEXTURE_COORD15_EXT = 0x87AC;
		public const uint GL_OUTPUT_TEXTURE_COORD16_EXT = 0x87AD;
		public const uint GL_OUTPUT_TEXTURE_COORD17_EXT = 0x87AE;
		public const uint GL_OUTPUT_TEXTURE_COORD18_EXT = 0x87AF;
		public const uint GL_OUTPUT_TEXTURE_COORD19_EXT = 0x87B0;
		public const uint GL_OUTPUT_TEXTURE_COORD20_EXT = 0x87B1;
		public const uint GL_OUTPUT_TEXTURE_COORD21_EXT = 0x87B2;
		public const uint GL_OUTPUT_TEXTURE_COORD22_EXT = 0x87B3;
		public const uint GL_OUTPUT_TEXTURE_COORD23_EXT = 0x87B4;
		public const uint GL_OUTPUT_TEXTURE_COORD24_EXT = 0x87B5;
		public const uint GL_OUTPUT_TEXTURE_COORD25_EXT = 0x87B6;
		public const uint GL_OUTPUT_TEXTURE_COORD26_EXT = 0x87B7;
		public const uint GL_OUTPUT_TEXTURE_COORD27_EXT = 0x87B8;
		public const uint GL_OUTPUT_TEXTURE_COORD28_EXT = 0x87B9;
		public const uint GL_OUTPUT_TEXTURE_COORD29_EXT = 0x87BA;
		public const uint GL_OUTPUT_TEXTURE_COORD30_EXT = 0x87BB;
		public const uint GL_OUTPUT_TEXTURE_COORD31_EXT = 0x87BC;
		public const uint GL_OUTPUT_FOG_EXT = 0x87BD;
		public const uint GL_SCALAR_EXT = 0x87BE;
		public const uint GL_VECTOR_EXT = 0x87BF;
		public const uint GL_MATRIX_EXT = 0x87C0;
		public const uint GL_VARIANT_EXT = 0x87C1;
		public const uint GL_INVARIANT_EXT = 0x87C2;
		public const uint GL_LOCAL_CONSTANT_EXT = 0x87C3;
		public const uint GL_LOCAL_EXT = 0x87C4;
		public const uint GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5;
		public const uint GL_MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6;
		public const uint GL_MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7;
		public const uint GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8;
		public const uint GL_MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9;
		public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA;
		public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB;
		public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CC;
		public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CD;
		public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE;
		public const uint GL_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF;
		public const uint GL_VERTEX_SHADER_VARIANTS_EXT = 0x87D0;
		public const uint GL_VERTEX_SHADER_INVARIANTS_EXT = 0x87D1;
		public const uint GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2;
		public const uint GL_VERTEX_SHADER_LOCALS_EXT = 0x87D3;
		public const uint GL_VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4;
		public const uint GL_X_EXT = 0x87D5;
		public const uint GL_Y_EXT = 0x87D6;
		public const uint GL_Z_EXT = 0x87D7;
		public const uint GL_W_EXT = 0x87D8;
		public const uint GL_NEGATIVE_X_EXT = 0x87D9;
		public const uint GL_NEGATIVE_Y_EXT = 0x87DA;
		public const uint GL_NEGATIVE_Z_EXT = 0x87DB;
		public const uint GL_NEGATIVE_W_EXT = 0x87DC;
		public const uint GL_ZERO_EXT = 0x87DD;
		public const uint GL_ONE_EXT = 0x87DE;
		public const uint GL_NEGATIVE_ONE_EXT = 0x87DF;
		public const uint GL_NORMALIZED_RANGE_EXT = 0x87E0;
		public const uint GL_FULL_RANGE_EXT = 0x87E1;
		public const uint GL_CURRENT_VERTEX_EXT = 0x87E2;
		public const uint GL_MVP_MATRIX_EXT = 0x87E3;
		public const uint GL_VARIANT_VALUE_EXT = 0x87E4;
		public const uint GL_VARIANT_DATATYPE_EXT = 0x87E5;
		public const uint GL_VARIANT_ARRAY_STRIDE_EXT = 0x87E6;
		public const uint GL_VARIANT_ARRAY_TYPE_EXT = 0x87E7;
		public const uint GL_VARIANT_ARRAY_EXT = 0x87E8;
		public const uint GL_VARIANT_ARRAY_POINTER_EXT = 0x87E9;
		public const uint GL_INVARIANT_VALUE_EXT = 0x87EA;
		public const uint GL_INVARIANT_DATATYPE_EXT = 0x87EB;
		public const uint GL_LOCAL_CONSTANT_VALUE_EXT = 0x87EC;
		public const uint GL_LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED;
		public const uint GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3;
		public const uint GL_MODELVIEW1_STACK_DEPTH_EXT = 0x8502;
		public const uint GL_MODELVIEW0_MATRIX_EXT = 0x0BA6;
		public const uint GL_MODELVIEW1_MATRIX_EXT = 0x8506;
		public const uint GL_VERTEX_WEIGHTING_EXT = 0x8509;
		public const uint GL_MODELVIEW0_EXT = 0x1700;
		public const uint GL_MODELVIEW1_EXT = 0x850A;
		public const uint GL_CURRENT_VERTEX_WEIGHT_EXT = 0x850B;
		public const uint GL_VERTEX_WEIGHT_ARRAY_EXT = 0x850C;
		public const uint GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D;
		public const uint GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E;
		public const uint GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F;
		public const uint GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510;
		public const uint GL_SYNC_X11_FENCE_EXT = 0x90E1;
		public const uint GL_GCCSO_SHADER_BINARY_FJ = 0x9260;
		public const uint GL_IGNORE_BORDER_HP = 0x8150;
		public const uint GL_CONSTANT_BORDER_HP = 0x8151;
		public const uint GL_REPLICATE_BORDER_HP = 0x8153;
		public const uint GL_CONVOLUTION_BORDER_COLOR_HP = 0x8154;
		public const uint GL_IMAGE_SCALE_X_HP = 0x8155;
		public const uint GL_IMAGE_SCALE_Y_HP = 0x8156;
		public const uint GL_IMAGE_TRANSLATE_X_HP = 0x8157;
		public const uint GL_IMAGE_TRANSLATE_Y_HP = 0x8158;
		public const uint GL_IMAGE_ROTATE_ANGLE_HP = 0x8159;
		public const uint GL_IMAGE_ROTATE_ORIGIN_X_HP = 0x815A;
		public const uint GL_IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B;
		public const uint GL_IMAGE_MAG_FILTER_HP = 0x815C;
		public const uint GL_IMAGE_MIN_FILTER_HP = 0x815D;
		public const uint GL_IMAGE_CUBIC_WEIGHT_HP = 0x815E;
		public const uint GL_CUBIC_HP = 0x815F;
		public const uint GL_AVERAGE_HP = 0x8160;
		public const uint GL_IMAGE_TRANSFORM_2D_HP = 0x8161;
		public const uint GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162;
		public const uint GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163;
		public const uint GL_OCCLUSION_TEST_HP = 0x8165;
		public const uint GL_OCCLUSION_TEST_RESULT_HP = 0x8166;
		public const uint GL_TEXTURE_LIGHTING_MODE_HP = 0x8167;
		public const uint GL_TEXTURE_POST_SPECULAR_HP = 0x8168;
		public const uint GL_TEXTURE_PRE_SPECULAR_HP = 0x8169;
		public const uint GL_CULL_VERTEX_IBM = 103050;
		public const uint GL_RASTER_POSITION_UNCLIPPED_IBM = 0x19262;
		public const uint GL_ALL_STATIC_DATA_IBM = 103060;
		public const uint GL_STATIC_VERTEX_ARRAY_IBM = 103061;
		public const uint GL_MIRRORED_REPEAT_IBM = 0x8370;
		public const uint GL_VERTEX_ARRAY_LIST_IBM = 103070;
		public const uint GL_NORMAL_ARRAY_LIST_IBM = 103071;
		public const uint GL_COLOR_ARRAY_LIST_IBM = 103072;
		public const uint GL_INDEX_ARRAY_LIST_IBM = 103073;
		public const uint GL_TEXTURE_COORD_ARRAY_LIST_IBM = 103074;
		public const uint GL_EDGE_FLAG_ARRAY_LIST_IBM = 103075;
		public const uint GL_FOG_COORDINATE_ARRAY_LIST_IBM = 103076;
		public const uint GL_SECONDARY_COLOR_ARRAY_LIST_IBM = 103077;
		public const uint GL_VERTEX_ARRAY_LIST_STRIDE_IBM = 103080;
		public const uint GL_NORMAL_ARRAY_LIST_STRIDE_IBM = 103081;
		public const uint GL_COLOR_ARRAY_LIST_STRIDE_IBM = 103082;
		public const uint GL_INDEX_ARRAY_LIST_STRIDE_IBM = 103083;
		public const uint GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM = 103084;
		public const uint GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM = 103085;
		public const uint GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM = 103086;
		public const uint GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM = 103087;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG = 0x913C;
		public const uint GL_NUM_DOWNSAMPLE_SCALES_IMG = 0x913D;
		public const uint GL_DOWNSAMPLE_SCALES_IMG = 0x913E;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG = 0x913F;
		public const uint GL_RENDERBUFFER_SAMPLES_IMG = 0x9133;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134;
		public const uint GL_MAX_SAMPLES_IMG = 0x9135;
		public const uint GL_TEXTURE_SAMPLES_IMG = 0x9136;
		public const uint GL_SGX_PROGRAM_BINARY_IMG = 0x9130;
		public const uint GL_BGRA_IMG = 0x80E1;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG = 0x8365;
		public const uint GL_SGX_BINARY_IMG = 0x8C0A;
		public const uint GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00;
		public const uint GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01;
		public const uint GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02;
		public const uint GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03;
		public const uint GL_COMPRESSED_RGBA_PVRTC_2BPPV2_IMG = 0x9137;
		public const uint GL_COMPRESSED_RGBA_PVRTC_4BPPV2_IMG = 0x9138;
		public const uint GL_MODULATE_COLOR_IMG = 0x8C04;
		public const uint GL_RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05;
		public const uint GL_TEXTURE_ALPHA_MODULATE_IMG = 0x8C06;
		public const uint GL_FACTOR_ALPHA_MODULATE_IMG = 0x8C07;
		public const uint GL_FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08;
		public const uint GL_ADD_BLEND_IMG = 0x8C09;
		public const uint GL_DOT3_RGBA_IMG = 0x86AF;
		public const uint GL_CUBIC_IMG = 0x9139;
		public const uint GL_CUBIC_MIPMAP_NEAREST_IMG = 0x913A;
		public const uint GL_CUBIC_MIPMAP_LINEAR_IMG = 0x913B;
		public const uint GL_CLIP_PLANE0_IMG = 0x3000;
		public const uint GL_CLIP_PLANE1_IMG = 0x3001;
		public const uint GL_CLIP_PLANE2_IMG = 0x3002;
		public const uint GL_CLIP_PLANE3_IMG = 0x3003;
		public const uint GL_CLIP_PLANE4_IMG = 0x3004;
		public const uint GL_CLIP_PLANE5_IMG = 0x3005;
		public const uint GL_MAX_CLIP_PLANES_IMG = 0x0D32;
		public const uint GL_RED_MIN_CLAMP_INGR = 0x8560;
		public const uint GL_GREEN_MIN_CLAMP_INGR = 0x8561;
		public const uint GL_BLUE_MIN_CLAMP_INGR = 0x8562;
		public const uint GL_ALPHA_MIN_CLAMP_INGR = 0x8563;
		public const uint GL_RED_MAX_CLAMP_INGR = 0x8564;
		public const uint GL_GREEN_MAX_CLAMP_INGR = 0x8565;
		public const uint GL_BLUE_MAX_CLAMP_INGR = 0x8566;
		public const uint GL_ALPHA_MAX_CLAMP_INGR = 0x8567;
		public const uint GL_INTERLACE_READ_INGR = 0x8568;
		public const uint GL_TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF;
		public const uint GL_LAYOUT_DEFAULT_INTEL = 0;
		public const uint GL_LAYOUT_LINEAR_INTEL = 1;
		public const uint GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2;
		public const uint GL_PARALLEL_ARRAYS_INTEL = 0x83F4;
		public const uint GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5;
		public const uint GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6;
		public const uint GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7;
		public const uint GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8;
		public const uint GL_PERFQUERY_SINGLE_CONTEXT_INTEL = 0x00000000;
		public const uint GL_PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x00000001;
		public const uint GL_PERFQUERY_WAIT_INTEL = 0x83FB;
		public const uint GL_PERFQUERY_FLUSH_INTEL = 0x83FA;
		public const uint GL_PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9;
		public const uint GL_PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0;
		public const uint GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1;
		public const uint GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2;
		public const uint GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3;
		public const uint GL_PERFQUERY_COUNTER_RAW_INTEL = 0x94F4;
		public const uint GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5;
		public const uint GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8;
		public const uint GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9;
		public const uint GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA;
		public const uint GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB;
		public const uint GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC;
		public const uint GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD;
		public const uint GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE;
		public const uint GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF;
		public const uint GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500;
		public const uint GL_MULTIPLY_KHR = 0x9294;
		public const uint GL_SCREEN_KHR = 0x9295;
		public const uint GL_OVERLAY_KHR = 0x9296;
		public const uint GL_DARKEN_KHR = 0x9297;
		public const uint GL_LIGHTEN_KHR = 0x9298;
		public const uint GL_COLORDODGE_KHR = 0x9299;
		public const uint GL_COLORBURN_KHR = 0x929A;
		public const uint GL_HARDLIGHT_KHR = 0x929B;
		public const uint GL_SOFTLIGHT_KHR = 0x929C;
		public const uint GL_DIFFERENCE_KHR = 0x929E;
		public const uint GL_EXCLUSION_KHR = 0x92A0;
		public const uint GL_HSL_HUE_KHR = 0x92AD;
		public const uint GL_HSL_SATURATION_KHR = 0x92AE;
		public const uint GL_HSL_COLOR_KHR = 0x92AF;
		public const uint GL_HSL_LUMINOSITY_KHR = 0x92B0;
		public const uint GL_BLEND_ADVANCED_COHERENT_KHR = 0x9285;
		public const uint GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
		public const uint GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
		public const uint GL_NONE = 0;
		public const uint GL_CONTEXT_RELEASE_BEHAVIOR_KHR = 0x82FB;
		public const uint GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR = 0x82FC;
		public const uint GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
		public const uint GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
		public const uint GL_DEBUG_CALLBACK_FUNCTION = 0x8244;
		public const uint GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;
		public const uint GL_DEBUG_SOURCE_API = 0x8246;
		public const uint GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
		public const uint GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
		public const uint GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;
		public const uint GL_DEBUG_SOURCE_APPLICATION = 0x824A;
		public const uint GL_DEBUG_SOURCE_OTHER = 0x824B;
		public const uint GL_DEBUG_TYPE_ERROR = 0x824C;
		public const uint GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
		public const uint GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
		public const uint GL_DEBUG_TYPE_PORTABILITY = 0x824F;
		public const uint GL_DEBUG_TYPE_PERFORMANCE = 0x8250;
		public const uint GL_DEBUG_TYPE_OTHER = 0x8251;
		public const uint GL_DEBUG_TYPE_MARKER = 0x8268;
		public const uint GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;
		public const uint GL_DEBUG_TYPE_POP_GROUP = 0x826A;
		public const uint GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;
		public const uint GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
		public const uint GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;
		public const uint GL_BUFFER = 0x82E0;
		public const uint GL_SHADER = 0x82E1;
		public const uint GL_PROGRAM = 0x82E2;
		public const uint GL_VERTEX_ARRAY = 0x8074;
		public const uint GL_QUERY = 0x82E3;
		public const uint GL_PROGRAM_PIPELINE = 0x82E4;
		public const uint GL_MAX_LABEL_LENGTH = 0x82E8;
		public const uint GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
		public const uint GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
		public const uint GL_DEBUG_LOGGED_MESSAGES = 0x9145;
		public const uint GL_DEBUG_SEVERITY_HIGH = 0x9146;
		public const uint GL_DEBUG_SEVERITY_MEDIUM = 0x9147;
		public const uint GL_DEBUG_SEVERITY_LOW = 0x9148;
		public const uint GL_DEBUG_OUTPUT = 0x92E0;
		public const uint GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
		public const uint GL_STACK_OVERFLOW = 0x0503;
		public const uint GL_STACK_UNDERFLOW = 0x0504;
		public const uint GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242;
		public const uint GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR = 0x8243;
		public const uint GL_DEBUG_CALLBACK_FUNCTION_KHR = 0x8244;
		public const uint GL_DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245;
		public const uint GL_DEBUG_SOURCE_API_KHR = 0x8246;
		public const uint GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247;
		public const uint GL_DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248;
		public const uint GL_DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249;
		public const uint GL_DEBUG_SOURCE_APPLICATION_KHR = 0x824A;
		public const uint GL_DEBUG_SOURCE_OTHER_KHR = 0x824B;
		public const uint GL_DEBUG_TYPE_ERROR_KHR = 0x824C;
		public const uint GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D;
		public const uint GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E;
		public const uint GL_DEBUG_TYPE_PORTABILITY_KHR = 0x824F;
		public const uint GL_DEBUG_TYPE_PERFORMANCE_KHR = 0x8250;
		public const uint GL_DEBUG_TYPE_OTHER_KHR = 0x8251;
		public const uint GL_DEBUG_TYPE_MARKER_KHR = 0x8268;
		public const uint GL_DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269;
		public const uint GL_DEBUG_TYPE_POP_GROUP_KHR = 0x826A;
		public const uint GL_DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B;
		public const uint GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C;
		public const uint GL_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D;
		public const uint GL_BUFFER_KHR = 0x82E0;
		public const uint GL_SHADER_KHR = 0x82E1;
		public const uint GL_PROGRAM_KHR = 0x82E2;
		public const uint GL_VERTEX_ARRAY_KHR = 0x8074;
		public const uint GL_QUERY_KHR = 0x82E3;
		public const uint GL_PROGRAM_PIPELINE_KHR = 0x82E4;
		public const uint GL_SAMPLER_KHR = 0x82E6;
		public const uint GL_MAX_LABEL_LENGTH_KHR = 0x82E8;
		public const uint GL_MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143;
		public const uint GL_MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144;
		public const uint GL_DEBUG_LOGGED_MESSAGES_KHR = 0x9145;
		public const uint GL_DEBUG_SEVERITY_HIGH_KHR = 0x9146;
		public const uint GL_DEBUG_SEVERITY_MEDIUM_KHR = 0x9147;
		public const uint GL_DEBUG_SEVERITY_LOW_KHR = 0x9148;
		public const uint GL_DEBUG_OUTPUT_KHR = 0x92E0;
		public const uint GL_CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002;
		public const uint GL_STACK_OVERFLOW_KHR = 0x0503;
		public const uint GL_STACK_UNDERFLOW_KHR = 0x0504;
		public const uint GL_DISPLAY_LIST = 0x82E7;
		public const uint GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008;
		public const uint GL_CONTEXT_ROBUST_ACCESS = 0x90F3;
		public const uint GL_LOSE_CONTEXT_ON_RESET = 0x8252;
		public const uint GL_GUILTY_CONTEXT_RESET = 0x8253;
		public const uint GL_INNOCENT_CONTEXT_RESET = 0x8254;
		public const uint GL_UNKNOWN_CONTEXT_RESET = 0x8255;
		public const uint GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
		public const uint GL_NO_RESET_NOTIFICATION = 0x8261;
		public const uint GL_CONTEXT_LOST = 0x0507;
		public const uint GL_CONTEXT_ROBUST_ACCESS_KHR = 0x90F3;
		public const uint GL_LOSE_CONTEXT_ON_RESET_KHR = 0x8252;
		public const uint GL_GUILTY_CONTEXT_RESET_KHR = 0x8253;
		public const uint GL_INNOCENT_CONTEXT_RESET_KHR = 0x8254;
		public const uint GL_UNKNOWN_CONTEXT_RESET_KHR = 0x8255;
		public const uint GL_RESET_NOTIFICATION_STRATEGY_KHR = 0x8256;
		public const uint GL_NO_RESET_NOTIFICATION_KHR = 0x8261;
		public const uint GL_CONTEXT_LOST_KHR = 0x0507;
		public const uint GL_COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0;
		public const uint GL_COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1;
		public const uint GL_COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2;
		public const uint GL_COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3;
		public const uint GL_COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4;
		public const uint GL_COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5;
		public const uint GL_COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6;
		public const uint GL_COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7;
		public const uint GL_COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8;
		public const uint GL_COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9;
		public const uint GL_COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA;
		public const uint GL_COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB;
		public const uint GL_COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC;
		public const uint GL_COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD;
		public const uint GL_TEXTURE_1D_STACK_MESAX = 0x8759;
		public const uint GL_TEXTURE_2D_STACK_MESAX = 0x875A;
		public const uint GL_PROXY_TEXTURE_1D_STACK_MESAX = 0x875B;
		public const uint GL_PROXY_TEXTURE_2D_STACK_MESAX = 0x875C;
		public const uint GL_TEXTURE_1D_STACK_BINDING_MESAX = 0x875D;
		public const uint GL_TEXTURE_2D_STACK_BINDING_MESAX = 0x875E;
		public const uint GL_PACK_INVERT_MESA = 0x8758;
		public const uint GL_UNSIGNED_SHORT_8_8_MESA = 0x85BA;
		public const uint GL_UNSIGNED_SHORT_8_8_REV_MESA = 0x85BB;
		public const uint GL_YCBCR_MESA = 0x8757;
		public const uint GL_GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX = 0x9047;
		public const uint GL_GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX = 0x9048;
		public const uint GL_GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX = 0x9049;
		public const uint GL_GPU_MEMORY_INFO_EVICTION_COUNT_NVX = 0x904A;
		public const uint GL_GPU_MEMORY_INFO_EVICTED_MEMORY_NVX = 0x904B;
		public const uint GL_BLEND_OVERLAP_NV = 0x9281;
		public const uint GL_BLEND_PREMULTIPLIED_SRC_NV = 0x9280;
		public const uint GL_BLUE_NV = 0x1905;
		public const uint GL_COLORBURN_NV = 0x929A;
		public const uint GL_COLORDODGE_NV = 0x9299;
		public const uint GL_CONJOINT_NV = 0x9284;
		public const uint GL_CONTRAST_NV = 0x92A1;
		public const uint GL_DARKEN_NV = 0x9297;
		public const uint GL_DIFFERENCE_NV = 0x929E;
		public const uint GL_DISJOINT_NV = 0x9283;
		public const uint GL_DST_ATOP_NV = 0x928F;
		public const uint GL_DST_IN_NV = 0x928B;
		public const uint GL_DST_NV = 0x9287;
		public const uint GL_DST_OUT_NV = 0x928D;
		public const uint GL_DST_OVER_NV = 0x9289;
		public const uint GL_EXCLUSION_NV = 0x92A0;
		public const uint GL_GREEN_NV = 0x1904;
		public const uint GL_HARDLIGHT_NV = 0x929B;
		public const uint GL_HARDMIX_NV = 0x92A9;
		public const uint GL_HSL_COLOR_NV = 0x92AF;
		public const uint GL_HSL_HUE_NV = 0x92AD;
		public const uint GL_HSL_LUMINOSITY_NV = 0x92B0;
		public const uint GL_HSL_SATURATION_NV = 0x92AE;
		public const uint GL_INVERT = 0x150A;
		public const uint GL_INVERT_OVG_NV = 0x92B4;
		public const uint GL_INVERT_RGB_NV = 0x92A3;
		public const uint GL_LIGHTEN_NV = 0x9298;
		public const uint GL_LINEARBURN_NV = 0x92A5;
		public const uint GL_LINEARDODGE_NV = 0x92A4;
		public const uint GL_LINEARLIGHT_NV = 0x92A7;
		public const uint GL_MINUS_CLAMPED_NV = 0x92B3;
		public const uint GL_MINUS_NV = 0x929F;
		public const uint GL_MULTIPLY_NV = 0x9294;
		public const uint GL_OVERLAY_NV = 0x9296;
		public const uint GL_PINLIGHT_NV = 0x92A8;
		public const uint GL_PLUS_CLAMPED_ALPHA_NV = 0x92B2;
		public const uint GL_PLUS_CLAMPED_NV = 0x92B1;
		public const uint GL_PLUS_DARKER_NV = 0x9292;
		public const uint GL_PLUS_NV = 0x9291;
		public const uint GL_RED_NV = 0x1903;
		public const uint GL_SCREEN_NV = 0x9295;
		public const uint GL_SOFTLIGHT_NV = 0x929C;
		public const uint GL_SRC_ATOP_NV = 0x928E;
		public const uint GL_SRC_IN_NV = 0x928A;
		public const uint GL_SRC_NV = 0x9286;
		public const uint GL_SRC_OUT_NV = 0x928C;
		public const uint GL_SRC_OVER_NV = 0x9288;
		public const uint GL_UNCORRELATED_NV = 0x9282;
		public const uint GL_VIVIDLIGHT_NV = 0x92A6;
		public const uint GL_XOR_NV = 0x1506;
		public const uint GL_BLEND_ADVANCED_COHERENT_NV = 0x9285;
		public const uint GL_TERMINATE_SEQUENCE_COMMAND_NV = 0x0000;
		public const uint GL_NOP_COMMAND_NV = 0x0001;
		public const uint GL_DRAW_ELEMENTS_COMMAND_NV = 0x0002;
		public const uint GL_DRAW_ARRAYS_COMMAND_NV = 0x0003;
		public const uint GL_DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004;
		public const uint GL_DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005;
		public const uint GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006;
		public const uint GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007;
		public const uint GL_ELEMENT_ADDRESS_COMMAND_NV = 0x0008;
		public const uint GL_ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009;
		public const uint GL_UNIFORM_ADDRESS_COMMAND_NV = 0x000A;
		public const uint GL_BLEND_COLOR_COMMAND_NV = 0x000B;
		public const uint GL_STENCIL_REF_COMMAND_NV = 0x000C;
		public const uint GL_LINE_WIDTH_COMMAND_NV = 0x000D;
		public const uint GL_POLYGON_OFFSET_COMMAND_NV = 0x000E;
		public const uint GL_ALPHA_REF_COMMAND_NV = 0x000F;
		public const uint GL_VIEWPORT_COMMAND_NV = 0x0010;
		public const uint GL_SCISSOR_COMMAND_NV = 0x0011;
		public const uint GL_FRONT_FACE_COMMAND_NV = 0x0012;
		public const uint GL_COMPUTE_PROGRAM_NV = 0x90FB;
		public const uint GL_COMPUTE_PROGRAM_PARAMETER_BUFFER_NV = 0x90FC;
		public const uint GL_QUERY_WAIT_NV = 0x8E13;
		public const uint GL_QUERY_NO_WAIT_NV = 0x8E14;
		public const uint GL_QUERY_BY_REGION_WAIT_NV = 0x8E15;
		public const uint GL_QUERY_BY_REGION_NO_WAIT_NV = 0x8E16;
		public const uint GL_CONSERVATIVE_RASTERIZATION_NV = 0x9346;
		public const uint GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV = 0x9347;
		public const uint GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV = 0x9348;
		public const uint GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV = 0x9349;
		public const uint GL_CONSERVATIVE_RASTER_DILATE_NV = 0x9379;
		public const uint GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A;
		public const uint GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV = 0x937B;
		public const uint GL_COPY_READ_BUFFER_NV = 0x8F36;
		public const uint GL_COPY_WRITE_BUFFER_NV = 0x8F37;
		public const uint GL_DEPTH_STENCIL_TO_RGBA_NV = 0x886E;
		public const uint GL_DEPTH_STENCIL_TO_BGRA_NV = 0x886F;
		public const uint GL_COVERAGE_COMPONENT_NV = 0x8ED0;
		public const uint GL_COVERAGE_COMPONENT4_NV = 0x8ED1;
		public const uint GL_COVERAGE_ATTACHMENT_NV = 0x8ED2;
		public const uint GL_COVERAGE_BUFFERS_NV = 0x8ED3;
		public const uint GL_COVERAGE_SAMPLES_NV = 0x8ED4;
		public const uint GL_COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5;
		public const uint GL_COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6;
		public const uint GL_COVERAGE_AUTOMATIC_NV = 0x8ED7;
		public const uint GL_COVERAGE_BUFFER_BIT_NV = 0x00008000;
		public const uint GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV = 0x90D0;
		public const uint GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV = 0x90D1;
		public const uint GL_DEPTH_COMPONENT32F_NV = 0x8DAB;
		public const uint GL_DEPTH32F_STENCIL8_NV = 0x8DAC;
		public const uint GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV = 0x8DAD;
		public const uint GL_DEPTH_BUFFER_FLOAT_MODE_NV = 0x8DAF;
		public const uint GL_DEPTH_CLAMP_NV = 0x864F;
		public const uint GL_DEPTH_COMPONENT16_NONLINEAR_NV = 0x8E2C;
		public const uint GL_MAX_DRAW_BUFFERS_NV = 0x8824;
		public const uint GL_DRAW_BUFFER0_NV = 0x8825;
		public const uint GL_DRAW_BUFFER1_NV = 0x8826;
		public const uint GL_DRAW_BUFFER2_NV = 0x8827;
		public const uint GL_DRAW_BUFFER3_NV = 0x8828;
		public const uint GL_DRAW_BUFFER4_NV = 0x8829;
		public const uint GL_DRAW_BUFFER5_NV = 0x882A;
		public const uint GL_DRAW_BUFFER6_NV = 0x882B;
		public const uint GL_DRAW_BUFFER7_NV = 0x882C;
		public const uint GL_DRAW_BUFFER8_NV = 0x882D;
		public const uint GL_DRAW_BUFFER9_NV = 0x882E;
		public const uint GL_DRAW_BUFFER10_NV = 0x882F;
		public const uint GL_DRAW_BUFFER11_NV = 0x8830;
		public const uint GL_DRAW_BUFFER12_NV = 0x8831;
		public const uint GL_DRAW_BUFFER13_NV = 0x8832;
		public const uint GL_DRAW_BUFFER14_NV = 0x8833;
		public const uint GL_DRAW_BUFFER15_NV = 0x8834;
		public const uint GL_COLOR_ATTACHMENT0_NV = 0x8CE0;
		public const uint GL_COLOR_ATTACHMENT1_NV = 0x8CE1;
		public const uint GL_COLOR_ATTACHMENT2_NV = 0x8CE2;
		public const uint GL_COLOR_ATTACHMENT3_NV = 0x8CE3;
		public const uint GL_COLOR_ATTACHMENT4_NV = 0x8CE4;
		public const uint GL_COLOR_ATTACHMENT5_NV = 0x8CE5;
		public const uint GL_COLOR_ATTACHMENT6_NV = 0x8CE6;
		public const uint GL_COLOR_ATTACHMENT7_NV = 0x8CE7;
		public const uint GL_COLOR_ATTACHMENT8_NV = 0x8CE8;
		public const uint GL_COLOR_ATTACHMENT9_NV = 0x8CE9;
		public const uint GL_COLOR_ATTACHMENT10_NV = 0x8CEA;
		public const uint GL_COLOR_ATTACHMENT11_NV = 0x8CEB;
		public const uint GL_COLOR_ATTACHMENT12_NV = 0x8CEC;
		public const uint GL_COLOR_ATTACHMENT13_NV = 0x8CED;
		public const uint GL_COLOR_ATTACHMENT14_NV = 0x8CEE;
		public const uint GL_COLOR_ATTACHMENT15_NV = 0x8CEF;
		public const uint GL_EVAL_2D_NV = 0x86C0;
		public const uint GL_EVAL_TRIANGULAR_2D_NV = 0x86C1;
		public const uint GL_MAP_TESSELLATION_NV = 0x86C2;
		public const uint GL_MAP_ATTRIB_U_ORDER_NV = 0x86C3;
		public const uint GL_MAP_ATTRIB_V_ORDER_NV = 0x86C4;
		public const uint GL_EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5;
		public const uint GL_EVAL_VERTEX_ATTRIB0_NV = 0x86C6;
		public const uint GL_EVAL_VERTEX_ATTRIB1_NV = 0x86C7;
		public const uint GL_EVAL_VERTEX_ATTRIB2_NV = 0x86C8;
		public const uint GL_EVAL_VERTEX_ATTRIB3_NV = 0x86C9;
		public const uint GL_EVAL_VERTEX_ATTRIB4_NV = 0x86CA;
		public const uint GL_EVAL_VERTEX_ATTRIB5_NV = 0x86CB;
		public const uint GL_EVAL_VERTEX_ATTRIB6_NV = 0x86CC;
		public const uint GL_EVAL_VERTEX_ATTRIB7_NV = 0x86CD;
		public const uint GL_EVAL_VERTEX_ATTRIB8_NV = 0x86CE;
		public const uint GL_EVAL_VERTEX_ATTRIB9_NV = 0x86CF;
		public const uint GL_EVAL_VERTEX_ATTRIB10_NV = 0x86D0;
		public const uint GL_EVAL_VERTEX_ATTRIB11_NV = 0x86D1;
		public const uint GL_EVAL_VERTEX_ATTRIB12_NV = 0x86D2;
		public const uint GL_EVAL_VERTEX_ATTRIB13_NV = 0x86D3;
		public const uint GL_EVAL_VERTEX_ATTRIB14_NV = 0x86D4;
		public const uint GL_EVAL_VERTEX_ATTRIB15_NV = 0x86D5;
		public const uint GL_MAX_MAP_TESSELLATION_NV = 0x86D6;
		public const uint GL_MAX_RATIONAL_EVAL_ORDER_NV = 0x86D7;
		public const uint GL_SAMPLE_POSITION_NV = 0x8E50;
		public const uint GL_SAMPLE_MASK_NV = 0x8E51;
		public const uint GL_SAMPLE_MASK_VALUE_NV = 0x8E52;
		public const uint GL_TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53;
		public const uint GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54;
		public const uint GL_TEXTURE_RENDERBUFFER_NV = 0x8E55;
		public const uint GL_SAMPLER_RENDERBUFFER_NV = 0x8E56;
		public const uint GL_INT_SAMPLER_RENDERBUFFER_NV = 0x8E57;
		public const uint GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58;
		public const uint GL_MAX_SAMPLE_MASK_WORDS_NV = 0x8E59;
		public const uint GL_MAX_COLOR_ATTACHMENTS_NV = 0x8CDF;
		public const uint GL_ALL_COMPLETED_NV = 0x84F2;
		public const uint GL_FENCE_STATUS_NV = 0x84F3;
		public const uint GL_FENCE_CONDITION_NV = 0x84F4;
		public const uint GL_FILL_RECTANGLE_NV = 0x933C;
		public const uint GL_FLOAT_R_NV = 0x8880;
		public const uint GL_FLOAT_RG_NV = 0x8881;
		public const uint GL_FLOAT_RGB_NV = 0x8882;
		public const uint GL_FLOAT_RGBA_NV = 0x8883;
		public const uint GL_FLOAT_R16_NV = 0x8884;
		public const uint GL_FLOAT_R32_NV = 0x8885;
		public const uint GL_FLOAT_RG16_NV = 0x8886;
		public const uint GL_FLOAT_RG32_NV = 0x8887;
		public const uint GL_FLOAT_RGB16_NV = 0x8888;
		public const uint GL_FLOAT_RGB32_NV = 0x8889;
		public const uint GL_FLOAT_RGBA16_NV = 0x888A;
		public const uint GL_FLOAT_RGBA32_NV = 0x888B;
		public const uint GL_TEXTURE_FLOAT_COMPONENTS_NV = 0x888C;
		public const uint GL_FLOAT_CLEAR_COLOR_VALUE_NV = 0x888D;
		public const uint GL_FLOAT_RGBA_MODE_NV = 0x888E;
		public const uint GL_FOG_DISTANCE_MODE_NV = 0x855A;
		public const uint GL_EYE_RADIAL_NV = 0x855B;
		public const uint GL_EYE_PLANE_ABSOLUTE_NV = 0x855C;
		public const uint GL_EYE_PLANE = 0x2502;
		public const uint GL_FRAGMENT_COVERAGE_TO_COLOR_NV = 0x92DD;
		public const uint GL_FRAGMENT_COVERAGE_COLOR_NV = 0x92DE;
		public const uint GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868;
		public const uint GL_FRAGMENT_PROGRAM_NV = 0x8870;
		public const uint GL_MAX_TEXTURE_COORDS_NV = 0x8871;
		public const uint GL_MAX_TEXTURE_IMAGE_UNITS_NV = 0x8872;
		public const uint GL_FRAGMENT_PROGRAM_BINDING_NV = 0x8873;
		public const uint GL_PROGRAM_ERROR_STRING_NV = 0x8874;
		public const uint GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4;
		public const uint GL_MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5;
		public const uint GL_MAX_PROGRAM_IF_DEPTH_NV = 0x88F6;
		public const uint GL_MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7;
		public const uint GL_MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8;
		public const uint GL_READ_FRAMEBUFFER_NV = 0x8CA8;
		public const uint GL_DRAW_FRAMEBUFFER_NV = 0x8CA9;
		public const uint GL_DRAW_FRAMEBUFFER_BINDING_NV = 0x8CA6;
		public const uint GL_READ_FRAMEBUFFER_BINDING_NV = 0x8CAA;
		public const uint GL_COVERAGE_MODULATION_TABLE_NV = 0x9331;
		public const uint GL_COLOR_SAMPLES_NV = 0x8E20;
		public const uint GL_DEPTH_SAMPLES_NV = 0x932D;
		public const uint GL_STENCIL_SAMPLES_NV = 0x932E;
		public const uint GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F;
		public const uint GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330;
		public const uint GL_COVERAGE_MODULATION_NV = 0x9332;
		public const uint GL_COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333;
		public const uint GL_RENDERBUFFER_SAMPLES_NV = 0x8CAB;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV = 0x8D56;
		public const uint GL_MAX_SAMPLES_NV = 0x8D57;
		public const uint GL_RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB;
		public const uint GL_RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10;
		public const uint GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11;
		public const uint GL_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12;
		public const uint GL_GEOMETRY_PROGRAM_NV = 0x8C26;
		public const uint GL_MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27;
		public const uint GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28;
		public const uint GL_MIN_PROGRAM_TEXEL_OFFSET_NV = 0x8904;
		public const uint GL_MAX_PROGRAM_TEXEL_OFFSET_NV = 0x8905;
		public const uint GL_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8906;
		public const uint GL_PROGRAM_RESULT_COMPONENTS_NV = 0x8907;
		public const uint GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908;
		public const uint GL_MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909;
		public const uint GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5;
		public const uint GL_MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6;
		public const uint GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A;
		public const uint GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5B;
		public const uint GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5C;
		public const uint GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D;
		public const uint GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5E;
		public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5F;
		public const uint GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44;
		public const uint GL_MAX_PROGRAM_SUBROUTINE_NUM_NV = 0x8F45;
		public const uint GL_HALF_FLOAT_NV = 0x140B;
		public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR_NV = 0x88FE;
		public const uint GL_MULTISAMPLES_NV = 0x9371;
		public const uint GL_SUPERSAMPLE_SCALE_X_NV = 0x9372;
		public const uint GL_SUPERSAMPLE_SCALE_Y_NV = 0x9373;
		public const uint GL_CONFORMANT_NV = 0x9374;
		public const uint GL_MAX_SHININESS_NV = 0x8504;
		public const uint GL_MAX_SPOT_EXPONENT_NV = 0x8505;
		public const uint GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534;
		public const uint GL_FLOAT_MAT2x3_NV = 0x8B65;
		public const uint GL_FLOAT_MAT2x4_NV = 0x8B66;
		public const uint GL_FLOAT_MAT3x2_NV = 0x8B67;
		public const uint GL_FLOAT_MAT3x4_NV = 0x8B68;
		public const uint GL_FLOAT_MAT4x2_NV = 0x8B69;
		public const uint GL_FLOAT_MAT4x3_NV = 0x8B6A;
		public const uint GL_PIXEL_COUNTER_BITS_NV = 0x8864;
		public const uint GL_CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865;
		public const uint GL_PIXEL_COUNT_NV = 0x8866;
		public const uint GL_PIXEL_COUNT_AVAILABLE_NV = 0x8867;
		public const uint GL_DEPTH_STENCIL_NV = 0x84F9;
		public const uint GL_UNSIGNED_INT_24_8_NV = 0x84FA;
		public const uint GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0;
		public const uint GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1;
		public const uint GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2;
		public const uint GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3;
		public const uint GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4;
		public const uint GL_PATH_FORMAT_SVG_NV = 0x9070;
		public const uint GL_PATH_FORMAT_PS_NV = 0x9071;
		public const uint GL_STANDARD_FONT_NAME_NV = 0x9072;
		public const uint GL_SYSTEM_FONT_NAME_NV = 0x9073;
		public const uint GL_FILE_NAME_NV = 0x9074;
		public const uint GL_PATH_STROKE_WIDTH_NV = 0x9075;
		public const uint GL_PATH_END_CAPS_NV = 0x9076;
		public const uint GL_PATH_INITIAL_END_CAP_NV = 0x9077;
		public const uint GL_PATH_TERMINAL_END_CAP_NV = 0x9078;
		public const uint GL_PATH_JOIN_STYLE_NV = 0x9079;
		public const uint GL_PATH_MITER_LIMIT_NV = 0x907A;
		public const uint GL_PATH_DASH_CAPS_NV = 0x907B;
		public const uint GL_PATH_INITIAL_DASH_CAP_NV = 0x907C;
		public const uint GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D;
		public const uint GL_PATH_DASH_OFFSET_NV = 0x907E;
		public const uint GL_PATH_CLIENT_LENGTH_NV = 0x907F;
		public const uint GL_PATH_FILL_MODE_NV = 0x9080;
		public const uint GL_PATH_FILL_MASK_NV = 0x9081;
		public const uint GL_PATH_FILL_COVER_MODE_NV = 0x9082;
		public const uint GL_PATH_STROKE_COVER_MODE_NV = 0x9083;
		public const uint GL_PATH_STROKE_MASK_NV = 0x9084;
		public const uint GL_COUNT_UP_NV = 0x9088;
		public const uint GL_COUNT_DOWN_NV = 0x9089;
		public const uint GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A;
		public const uint GL_CONVEX_HULL_NV = 0x908B;
		public const uint GL_BOUNDING_BOX_NV = 0x908D;
		public const uint GL_TRANSLATE_X_NV = 0x908E;
		public const uint GL_TRANSLATE_Y_NV = 0x908F;
		public const uint GL_TRANSLATE_2D_NV = 0x9090;
		public const uint GL_TRANSLATE_3D_NV = 0x9091;
		public const uint GL_AFFINE_2D_NV = 0x9092;
		public const uint GL_AFFINE_3D_NV = 0x9094;
		public const uint GL_TRANSPOSE_AFFINE_2D_NV = 0x9096;
		public const uint GL_TRANSPOSE_AFFINE_3D_NV = 0x9098;
		public const uint GL_UTF8_NV = 0x909A;
		public const uint GL_UTF16_NV = 0x909B;
		public const uint GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C;
		public const uint GL_PATH_COMMAND_COUNT_NV = 0x909D;
		public const uint GL_PATH_COORD_COUNT_NV = 0x909E;
		public const uint GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F;
		public const uint GL_PATH_COMPUTED_LENGTH_NV = 0x90A0;
		public const uint GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1;
		public const uint GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2;
		public const uint GL_SQUARE_NV = 0x90A3;
		public const uint GL_ROUND_NV = 0x90A4;
		public const uint GL_TRIANGULAR_NV = 0x90A5;
		public const uint GL_BEVEL_NV = 0x90A6;
		public const uint GL_MITER_REVERT_NV = 0x90A7;
		public const uint GL_MITER_TRUNCATE_NV = 0x90A8;
		public const uint GL_SKIP_MISSING_GLYPH_NV = 0x90A9;
		public const uint GL_USE_MISSING_GLYPH_NV = 0x90AA;
		public const uint GL_PATH_ERROR_POSITION_NV = 0x90AB;
		public const uint GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD;
		public const uint GL_ADJACENT_PAIRS_NV = 0x90AE;
		public const uint GL_FIRST_TO_REST_NV = 0x90AF;
		public const uint GL_PATH_GEN_MODE_NV = 0x90B0;
		public const uint GL_PATH_GEN_COEFF_NV = 0x90B1;
		public const uint GL_PATH_GEN_COMPONENTS_NV = 0x90B3;
		public const uint GL_PATH_STENCIL_FUNC_NV = 0x90B7;
		public const uint GL_PATH_STENCIL_REF_NV = 0x90B8;
		public const uint GL_PATH_STENCIL_VALUE_MASK_NV = 0x90B9;
		public const uint GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD;
		public const uint GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE;
		public const uint GL_PATH_COVER_DEPTH_FUNC_NV = 0x90BF;
		public const uint GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4;
		public const uint GL_MOVE_TO_RESETS_NV = 0x90B5;
		public const uint GL_MOVE_TO_CONTINUES_NV = 0x90B6;
		public const uint GL_CLOSE_PATH_NV = 0x00;
		public const uint GL_MOVE_TO_NV = 0x02;
		public const uint GL_RELATIVE_MOVE_TO_NV = 0x03;
		public const uint GL_LINE_TO_NV = 0x04;
		public const uint GL_RELATIVE_LINE_TO_NV = 0x05;
		public const uint GL_HORIZONTAL_LINE_TO_NV = 0x06;
		public const uint GL_RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07;
		public const uint GL_VERTICAL_LINE_TO_NV = 0x08;
		public const uint GL_RELATIVE_VERTICAL_LINE_TO_NV = 0x09;
		public const uint GL_QUADRATIC_CURVE_TO_NV = 0x0A;
		public const uint GL_RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B;
		public const uint GL_CUBIC_CURVE_TO_NV = 0x0C;
		public const uint GL_RELATIVE_CUBIC_CURVE_TO_NV = 0x0D;
		public const uint GL_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E;
		public const uint GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F;
		public const uint GL_SMOOTH_CUBIC_CURVE_TO_NV = 0x10;
		public const uint GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11;
		public const uint GL_SMALL_CCW_ARC_TO_NV = 0x12;
		public const uint GL_RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13;
		public const uint GL_SMALL_CW_ARC_TO_NV = 0x14;
		public const uint GL_RELATIVE_SMALL_CW_ARC_TO_NV = 0x15;
		public const uint GL_LARGE_CCW_ARC_TO_NV = 0x16;
		public const uint GL_RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17;
		public const uint GL_LARGE_CW_ARC_TO_NV = 0x18;
		public const uint GL_RELATIVE_LARGE_CW_ARC_TO_NV = 0x19;
		public const uint GL_RESTART_PATH_NV = 0xF0;
		public const uint GL_DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2;
		public const uint GL_DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4;
		public const uint GL_RECT_NV = 0xF6;
		public const uint GL_CIRCULAR_CCW_ARC_TO_NV = 0xF8;
		public const uint GL_CIRCULAR_CW_ARC_TO_NV = 0xFA;
		public const uint GL_CIRCULAR_TANGENT_ARC_TO_NV = 0xFC;
		public const uint GL_ARC_TO_NV = 0xFE;
		public const uint GL_RELATIVE_ARC_TO_NV = 0xFF;
		public const uint GL_BOLD_BIT_NV = 0x01;
		public const uint GL_ITALIC_BIT_NV = 0x02;
		public const uint GL_GLYPH_WIDTH_BIT_NV = 0x01;
		public const uint GL_GLYPH_HEIGHT_BIT_NV = 0x02;
		public const uint GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04;
		public const uint GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08;
		public const uint GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10;
		public const uint GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20;
		public const uint GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40;
		public const uint GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80;
		public const uint GL_GLYPH_HAS_KERNING_BIT_NV = 0x100;
		public const uint GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000;
		public const uint GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000;
		public const uint GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000;
		public const uint GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000;
		public const uint GL_FONT_UNITS_PER_EM_BIT_NV = 0x00100000;
		public const uint GL_FONT_ASCENDER_BIT_NV = 0x00200000;
		public const uint GL_FONT_DESCENDER_BIT_NV = 0x00400000;
		public const uint GL_FONT_HEIGHT_BIT_NV = 0x00800000;
		public const uint GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000;
		public const uint GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000;
		public const uint GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000;
		public const uint GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000;
		public const uint GL_FONT_HAS_KERNING_BIT_NV = 0x10000000;
		public const uint GL_ROUNDED_RECT_NV = 0xE8;
		public const uint GL_RELATIVE_ROUNDED_RECT_NV = 0xE9;
		public const uint GL_ROUNDED_RECT2_NV = 0xEA;
		public const uint GL_RELATIVE_ROUNDED_RECT2_NV = 0xEB;
		public const uint GL_ROUNDED_RECT4_NV = 0xEC;
		public const uint GL_RELATIVE_ROUNDED_RECT4_NV = 0xED;
		public const uint GL_ROUNDED_RECT8_NV = 0xEE;
		public const uint GL_RELATIVE_ROUNDED_RECT8_NV = 0xEF;
		public const uint GL_RELATIVE_RECT_NV = 0xF7;
		public const uint GL_FONT_GLYPHS_AVAILABLE_NV = 0x9368;
		public const uint GL_FONT_TARGET_UNAVAILABLE_NV = 0x9369;
		public const uint GL_FONT_UNAVAILABLE_NV = 0x936A;
		public const uint GL_FONT_UNINTELLIGIBLE_NV = 0x936B;
		public const uint GL_CONIC_CURVE_TO_NV = 0x1A;
		public const uint GL_RELATIVE_CONIC_CURVE_TO_NV = 0x1B;
		public const uint GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000;
		public const uint GL_STANDARD_FONT_FORMAT_NV = 0x936C;
		public const uint GL_2_BYTES_NV = 0x1407;
		public const uint GL_3_BYTES_NV = 0x1408;
		public const uint GL_4_BYTES_NV = 0x1409;
		public const uint GL_EYE_LINEAR_NV = 0x2400;
		public const uint GL_OBJECT_LINEAR_NV = 0x2401;
		public const uint GL_CONSTANT_NV = 0x8576;
		public const uint GL_PATH_FOG_GEN_MODE_NV = 0x90AC;
		public const uint GL_PRIMARY_COLOR = 0x8577;
		public const uint GL_PRIMARY_COLOR_NV = 0x852C;
		public const uint GL_SECONDARY_COLOR_NV = 0x852D;
		public const uint GL_PATH_GEN_COLOR_FORMAT_NV = 0x90B2;
		public const uint GL_PATH_PROJECTION_NV = 0x1701;
		public const uint GL_PATH_MODELVIEW_NV = 0x1700;
		public const uint GL_PATH_MODELVIEW_STACK_DEPTH_NV = 0x0BA3;
		public const uint GL_PATH_MODELVIEW_MATRIX_NV = 0x0BA6;
		public const uint GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0x0D36;
		public const uint GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV = 0x84E3;
		public const uint GL_PATH_PROJECTION_STACK_DEPTH_NV = 0x0BA4;
		public const uint GL_PATH_PROJECTION_MATRIX_NV = 0x0BA7;
		public const uint GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0x0D38;
		public const uint GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV = 0x84E4;
		public const uint GL_FRAGMENT_INPUT_NV = 0x936D;
		public const uint GL_SHARED_EDGE_NV = 0xC0;
		public const uint GL_WRITE_PIXEL_DATA_RANGE_NV = 0x8878;
		public const uint GL_READ_PIXEL_DATA_RANGE_NV = 0x8879;
		public const uint GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A;
		public const uint GL_READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B;
		public const uint GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C;
		public const uint GL_READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D;
		public const uint GL_POINT_SPRITE_NV = 0x8861;
		public const uint GL_COORD_REPLACE_NV = 0x8862;
		public const uint GL_POINT_SPRITE_R_MODE_NV = 0x8863;
		public const uint GL_POLYGON_MODE_NV = 0x0B40;
		public const uint GL_POLYGON_OFFSET_POINT_NV = 0x2A01;
		public const uint GL_POLYGON_OFFSET_LINE_NV = 0x2A02;
		public const uint GL_POINT_NV = 0x1B00;
		public const uint GL_LINE_NV = 0x1B01;
		public const uint GL_FILL_NV = 0x1B02;
		public const uint GL_FRAME_NV = 0x8E26;
		public const uint GL_FIELDS_NV = 0x8E27;
		public const uint GL_CURRENT_TIME_NV = 0x8E28;
		public const uint GL_NUM_FILL_STREAMS_NV = 0x8E29;
		public const uint GL_PRESENT_TIME_NV = 0x8E2A;
		public const uint GL_PRESENT_DURATION_NV = 0x8E2B;
		public const uint GL_PRIMITIVE_RESTART_NV = 0x8558;
		public const uint GL_PRIMITIVE_RESTART_INDEX_NV = 0x8559;
		public const uint GL_READ_BUFFER_NV = 0x0C02;
		public const uint GL_REGISTER_COMBINERS_NV = 0x8522;
		public const uint GL_VARIABLE_A_NV = 0x8523;
		public const uint GL_VARIABLE_B_NV = 0x8524;
		public const uint GL_VARIABLE_C_NV = 0x8525;
		public const uint GL_VARIABLE_D_NV = 0x8526;
		public const uint GL_VARIABLE_E_NV = 0x8527;
		public const uint GL_VARIABLE_F_NV = 0x8528;
		public const uint GL_VARIABLE_G_NV = 0x8529;
		public const uint GL_CONSTANT_COLOR0_NV = 0x852A;
		public const uint GL_CONSTANT_COLOR1_NV = 0x852B;
		public const uint GL_SPARE0_NV = 0x852E;
		public const uint GL_SPARE1_NV = 0x852F;
		public const uint GL_DISCARD_NV = 0x8530;
		public const uint GL_E_TIMES_F_NV = 0x8531;
		public const uint GL_SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532;
		public const uint GL_UNSIGNED_IDENTITY_NV = 0x8536;
		public const uint GL_UNSIGNED_INVERT_NV = 0x8537;
		public const uint GL_EXPAND_NORMAL_NV = 0x8538;
		public const uint GL_EXPAND_NEGATE_NV = 0x8539;
		public const uint GL_HALF_BIAS_NORMAL_NV = 0x853A;
		public const uint GL_HALF_BIAS_NEGATE_NV = 0x853B;
		public const uint GL_SIGNED_IDENTITY_NV = 0x853C;
		public const uint GL_SIGNED_NEGATE_NV = 0x853D;
		public const uint GL_SCALE_BY_TWO_NV = 0x853E;
		public const uint GL_SCALE_BY_FOUR_NV = 0x853F;
		public const uint GL_SCALE_BY_ONE_HALF_NV = 0x8540;
		public const uint GL_BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541;
		public const uint GL_COMBINER_INPUT_NV = 0x8542;
		public const uint GL_COMBINER_MAPPING_NV = 0x8543;
		public const uint GL_COMBINER_COMPONENT_USAGE_NV = 0x8544;
		public const uint GL_COMBINER_AB_DOT_PRODUCT_NV = 0x8545;
		public const uint GL_COMBINER_CD_DOT_PRODUCT_NV = 0x8546;
		public const uint GL_COMBINER_MUX_SUM_NV = 0x8547;
		public const uint GL_COMBINER_SCALE_NV = 0x8548;
		public const uint GL_COMBINER_BIAS_NV = 0x8549;
		public const uint GL_COMBINER_AB_OUTPUT_NV = 0x854A;
		public const uint GL_COMBINER_CD_OUTPUT_NV = 0x854B;
		public const uint GL_COMBINER_SUM_OUTPUT_NV = 0x854C;
		public const uint GL_MAX_GENERAL_COMBINERS_NV = 0x854D;
		public const uint GL_NUM_GENERAL_COMBINERS_NV = 0x854E;
		public const uint GL_COLOR_SUM_CLAMP_NV = 0x854F;
		public const uint GL_COMBINER0_NV = 0x8550;
		public const uint GL_COMBINER1_NV = 0x8551;
		public const uint GL_COMBINER2_NV = 0x8552;
		public const uint GL_COMBINER3_NV = 0x8553;
		public const uint GL_COMBINER4_NV = 0x8554;
		public const uint GL_COMBINER5_NV = 0x8555;
		public const uint GL_COMBINER6_NV = 0x8556;
		public const uint GL_COMBINER7_NV = 0x8557;
		public const uint GL_FOG = 0x0B60;
		public const uint GL_PER_STAGE_CONSTANTS_NV = 0x8535;
		public const uint GL_SLUMINANCE_NV = 0x8C46;
		public const uint GL_SLUMINANCE_ALPHA_NV = 0x8C44;
		public const uint GL_SRGB8_NV = 0x8C41;
		public const uint GL_SLUMINANCE8_NV = 0x8C47;
		public const uint GL_SLUMINANCE8_ALPHA8_NV = 0x8C45;
		public const uint GL_COMPRESSED_SRGB_S3TC_DXT1_NV = 0x8C4C;
		public const uint GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV = 0x8C4D;
		public const uint GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV = 0x8C4E;
		public const uint GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV = 0x8C4F;
		public const uint GL_ETC1_SRGB8_NV = 0x88EE;
		public const uint GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV = 0x933D;
		public const uint GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV = 0x933E;
		public const uint GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV = 0x933F;
		public const uint GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV = 0x9340;
		public const uint GL_SAMPLE_LOCATION_NV = 0x8E50;
		public const uint GL_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9341;
		public const uint GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV = 0x9342;
		public const uint GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV = 0x9343;
		public const uint GL_BUFFER_GPU_ADDRESS_NV = 0x8F1D;
		public const uint GL_GPU_ADDRESS_NV = 0x8F34;
		public const uint GL_MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35;
		public const uint GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010;
		public const uint GL_READ_WRITE = 0x88BA;
		public const uint GL_WRITE_ONLY = 0x88B9;
		public const uint GL_WARP_SIZE_NV = 0x9339;
		public const uint GL_WARPS_PER_SM_NV = 0x933A;
		public const uint GL_SM_COUNT_NV = 0x933B;
		public const uint GL_SAMPLER_2D_ARRAY_SHADOW_NV = 0x8DC4;
		public const uint GL_SAMPLER_CUBE_SHADOW_NV = 0x8DC5;
		public const uint GL_MAX_PROGRAM_PATCH_ATTRIBS_NV = 0x86D8;
		public const uint GL_TESS_CONTROL_PROGRAM_NV = 0x891E;
		public const uint GL_TESS_EVALUATION_PROGRAM_NV = 0x891F;
		public const uint GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV = 0x8C74;
		public const uint GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV = 0x8C75;
		public const uint GL_EMBOSS_LIGHT_NV = 0x855D;
		public const uint GL_EMBOSS_CONSTANT_NV = 0x855E;
		public const uint GL_EMBOSS_MAP_NV = 0x855F;
		public const uint GL_NORMAL_MAP_NV = 0x8511;
		public const uint GL_REFLECTION_MAP_NV = 0x8512;
		public const uint GL_TEXTURE_BORDER_COLOR_NV = 0x1004;
		public const uint GL_CLAMP_TO_BORDER_NV = 0x812D;
		public const uint GL_COMBINE4_NV = 0x8503;
		public const uint GL_SOURCE3_RGB_NV = 0x8583;
		public const uint GL_SOURCE3_ALPHA_NV = 0x858B;
		public const uint GL_OPERAND3_RGB_NV = 0x8593;
		public const uint GL_OPERAND3_ALPHA_NV = 0x859B;
		public const uint GL_TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F;
		public const uint GL_TEXTURE_COVERAGE_SAMPLES_NV = 0x9045;
		public const uint GL_TEXTURE_COLOR_SAMPLES_NV = 0x9046;
		public const uint GL_TEXTURE_RECTANGLE_NV = 0x84F5;
		public const uint GL_TEXTURE_BINDING_RECTANGLE_NV = 0x84F6;
		public const uint GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7;
		public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8;
		public const uint GL_OFFSET_TEXTURE_RECTANGLE_NV = 0x864C;
		public const uint GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D;
		public const uint GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E;
		public const uint GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9;
		public const uint GL_UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA;
		public const uint GL_UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB;
		public const uint GL_DSDT_MAG_INTENSITY_NV = 0x86DC;
		public const uint GL_SHADER_CONSISTENT_NV = 0x86DD;
		public const uint GL_TEXTURE_SHADER_NV = 0x86DE;
		public const uint GL_SHADER_OPERATION_NV = 0x86DF;
		public const uint GL_CULL_MODES_NV = 0x86E0;
		public const uint GL_OFFSET_TEXTURE_MATRIX_NV = 0x86E1;
		public const uint GL_OFFSET_TEXTURE_SCALE_NV = 0x86E2;
		public const uint GL_OFFSET_TEXTURE_BIAS_NV = 0x86E3;
		public const uint GL_OFFSET_TEXTURE_2D_MATRIX_NV = 0x86E1;
		public const uint GL_OFFSET_TEXTURE_2D_SCALE_NV = 0x86E2;
		public const uint GL_OFFSET_TEXTURE_2D_BIAS_NV = 0x86E3;
		public const uint GL_PREVIOUS_TEXTURE_INPUT_NV = 0x86E4;
		public const uint GL_CONST_EYE_NV = 0x86E5;
		public const uint GL_PASS_THROUGH_NV = 0x86E6;
		public const uint GL_CULL_FRAGMENT_NV = 0x86E7;
		public const uint GL_OFFSET_TEXTURE_2D_NV = 0x86E8;
		public const uint GL_DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9;
		public const uint GL_DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA;
		public const uint GL_DOT_PRODUCT_NV = 0x86EC;
		public const uint GL_DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED;
		public const uint GL_DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE;
		public const uint GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0;
		public const uint GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1;
		public const uint GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2;
		public const uint GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3;
		public const uint GL_HILO_NV = 0x86F4;
		public const uint GL_DSDT_NV = 0x86F5;
		public const uint GL_DSDT_MAG_NV = 0x86F6;
		public const uint GL_DSDT_MAG_VIB_NV = 0x86F7;
		public const uint GL_HILO16_NV = 0x86F8;
		public const uint GL_SIGNED_HILO_NV = 0x86F9;
		public const uint GL_SIGNED_HILO16_NV = 0x86FA;
		public const uint GL_SIGNED_RGBA_NV = 0x86FB;
		public const uint GL_SIGNED_RGBA8_NV = 0x86FC;
		public const uint GL_SIGNED_RGB_NV = 0x86FE;
		public const uint GL_SIGNED_RGB8_NV = 0x86FF;
		public const uint GL_SIGNED_LUMINANCE_NV = 0x8701;
		public const uint GL_SIGNED_LUMINANCE8_NV = 0x8702;
		public const uint GL_SIGNED_LUMINANCE_ALPHA_NV = 0x8703;
		public const uint GL_SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704;
		public const uint GL_SIGNED_ALPHA_NV = 0x8705;
		public const uint GL_SIGNED_ALPHA8_NV = 0x8706;
		public const uint GL_SIGNED_INTENSITY_NV = 0x8707;
		public const uint GL_SIGNED_INTENSITY8_NV = 0x8708;
		public const uint GL_DSDT8_NV = 0x8709;
		public const uint GL_DSDT8_MAG8_NV = 0x870A;
		public const uint GL_DSDT8_MAG8_INTENSITY8_NV = 0x870B;
		public const uint GL_SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C;
		public const uint GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D;
		public const uint GL_HI_SCALE_NV = 0x870E;
		public const uint GL_LO_SCALE_NV = 0x870F;
		public const uint GL_DS_SCALE_NV = 0x8710;
		public const uint GL_DT_SCALE_NV = 0x8711;
		public const uint GL_MAGNITUDE_SCALE_NV = 0x8712;
		public const uint GL_VIBRANCE_SCALE_NV = 0x8713;
		public const uint GL_HI_BIAS_NV = 0x8714;
		public const uint GL_LO_BIAS_NV = 0x8715;
		public const uint GL_DS_BIAS_NV = 0x8716;
		public const uint GL_DT_BIAS_NV = 0x8717;
		public const uint GL_MAGNITUDE_BIAS_NV = 0x8718;
		public const uint GL_VIBRANCE_BIAS_NV = 0x8719;
		public const uint GL_TEXTURE_BORDER_VALUES_NV = 0x871A;
		public const uint GL_TEXTURE_HI_SIZE_NV = 0x871B;
		public const uint GL_TEXTURE_LO_SIZE_NV = 0x871C;
		public const uint GL_TEXTURE_DS_SIZE_NV = 0x871D;
		public const uint GL_TEXTURE_DT_SIZE_NV = 0x871E;
		public const uint GL_TEXTURE_MAG_SIZE_NV = 0x871F;
		public const uint GL_DOT_PRODUCT_TEXTURE_3D_NV = 0x86EF;
		public const uint GL_OFFSET_PROJECTIVE_TEXTURE_2D_NV = 0x8850;
		public const uint GL_OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV = 0x8851;
		public const uint GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8852;
		public const uint GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV = 0x8853;
		public const uint GL_OFFSET_HILO_TEXTURE_2D_NV = 0x8854;
		public const uint GL_OFFSET_HILO_TEXTURE_RECTANGLE_NV = 0x8855;
		public const uint GL_OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV = 0x8856;
		public const uint GL_OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8857;
		public const uint GL_DEPENDENT_HILO_TEXTURE_2D_NV = 0x8858;
		public const uint GL_DEPENDENT_RGB_TEXTURE_3D_NV = 0x8859;
		public const uint GL_DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV = 0x885A;
		public const uint GL_DOT_PRODUCT_PASS_THROUGH_NV = 0x885B;
		public const uint GL_DOT_PRODUCT_TEXTURE_1D_NV = 0x885C;
		public const uint GL_DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV = 0x885D;
		public const uint GL_HILO8_NV = 0x885E;
		public const uint GL_SIGNED_HILO8_NV = 0x885F;
		public const uint GL_FORCE_BLUE_TO_ONE_NV = 0x8860;
		public const uint GL_BACK_PRIMARY_COLOR_NV = 0x8C77;
		public const uint GL_BACK_SECONDARY_COLOR_NV = 0x8C78;
		public const uint GL_TEXTURE_COORD_NV = 0x8C79;
		public const uint GL_CLIP_DISTANCE_NV = 0x8C7A;
		public const uint GL_VERTEX_ID_NV = 0x8C7B;
		public const uint GL_PRIMITIVE_ID_NV = 0x8C7C;
		public const uint GL_GENERIC_ATTRIB_NV = 0x8C7D;
		public const uint GL_TRANSFORM_FEEDBACK_ATTRIBS_NV = 0x8C7E;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV = 0x8C7F;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV = 0x8C80;
		public const uint GL_ACTIVE_VARYINGS_NV = 0x8C81;
		public const uint GL_ACTIVE_VARYING_MAX_LENGTH_NV = 0x8C82;
		public const uint GL_TRANSFORM_FEEDBACK_VARYINGS_NV = 0x8C83;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_START_NV = 0x8C84;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV = 0x8C85;
		public const uint GL_TRANSFORM_FEEDBACK_RECORD_NV = 0x8C86;
		public const uint GL_PRIMITIVES_GENERATED_NV = 0x8C87;
		public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV = 0x8C88;
		public const uint GL_RASTERIZER_DISCARD_NV = 0x8C89;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV = 0x8C8A;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV = 0x8C8B;
		public const uint GL_INTERLEAVED_ATTRIBS_NV = 0x8C8C;
		public const uint GL_SEPARATE_ATTRIBS_NV = 0x8C8D;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_NV = 0x8C8E;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV = 0x8C8F;
		public const uint GL_LAYER_NV = 0x8DAA;
		//public const uint GL_NEXT_BUFFER_NV = -2;
		//public const uint GL_SKIP_COMPONENTS4_NV = -3;
		//public const uint GL_SKIP_COMPONENTS3_NV = -4;
		//public const uint GL_SKIP_COMPONENTS2_NV = -5;
		//public const uint GL_SKIP_COMPONENTS1_NV = -6;
		public const uint GL_TRANSFORM_FEEDBACK_NV = 0x8E22;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV = 0x8E23;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV = 0x8E24;
		public const uint GL_TRANSFORM_FEEDBACK_BINDING_NV = 0x8E25;
		public const uint GL_UNIFORM_BUFFER_UNIFIED_NV = 0x936E;
		public const uint GL_UNIFORM_BUFFER_ADDRESS_NV = 0x936F;
		public const uint GL_UNIFORM_BUFFER_LENGTH_NV = 0x9370;
		public const uint GL_SURFACE_STATE_NV = 0x86EB;
		public const uint GL_SURFACE_REGISTERED_NV = 0x86FD;
		public const uint GL_SURFACE_MAPPED_NV = 0x8700;
		public const uint GL_WRITE_DISCARD_NV = 0x88BE;
		public const uint GL_VERTEX_ARRAY_RANGE_NV = 0x851D;
		public const uint GL_VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E;
		public const uint GL_VERTEX_ARRAY_RANGE_VALID_NV = 0x851F;
		public const uint GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520;
		public const uint GL_VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521;
		public const uint GL_VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533;
		public const uint GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E;
		public const uint GL_ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F;
		public const uint GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20;
		public const uint GL_VERTEX_ARRAY_ADDRESS_NV = 0x8F21;
		public const uint GL_NORMAL_ARRAY_ADDRESS_NV = 0x8F22;
		public const uint GL_COLOR_ARRAY_ADDRESS_NV = 0x8F23;
		public const uint GL_INDEX_ARRAY_ADDRESS_NV = 0x8F24;
		public const uint GL_TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25;
		public const uint GL_EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26;
		public const uint GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27;
		public const uint GL_FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28;
		public const uint GL_ELEMENT_ARRAY_ADDRESS_NV = 0x8F29;
		public const uint GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A;
		public const uint GL_VERTEX_ARRAY_LENGTH_NV = 0x8F2B;
		public const uint GL_NORMAL_ARRAY_LENGTH_NV = 0x8F2C;
		public const uint GL_COLOR_ARRAY_LENGTH_NV = 0x8F2D;
		public const uint GL_INDEX_ARRAY_LENGTH_NV = 0x8F2E;
		public const uint GL_TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F;
		public const uint GL_EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30;
		public const uint GL_SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31;
		public const uint GL_FOG_COORD_ARRAY_LENGTH_NV = 0x8F32;
		public const uint GL_ELEMENT_ARRAY_LENGTH_NV = 0x8F33;
		public const uint GL_DRAW_INDIRECT_UNIFIED_NV = 0x8F40;
		public const uint GL_DRAW_INDIRECT_ADDRESS_NV = 0x8F41;
		public const uint GL_DRAW_INDIRECT_LENGTH_NV = 0x8F42;
		public const uint GL_VERTEX_PROGRAM_NV = 0x8620;
		public const uint GL_VERTEX_STATE_PROGRAM_NV = 0x8621;
		public const uint GL_ATTRIB_ARRAY_SIZE_NV = 0x8623;
		public const uint GL_ATTRIB_ARRAY_STRIDE_NV = 0x8624;
		public const uint GL_ATTRIB_ARRAY_TYPE_NV = 0x8625;
		public const uint GL_CURRENT_ATTRIB_NV = 0x8626;
		public const uint GL_PROGRAM_LENGTH_NV = 0x8627;
		public const uint GL_PROGRAM_STRING_NV = 0x8628;
		public const uint GL_MODELVIEW_PROJECTION_NV = 0x8629;
		public const uint GL_IDENTITY_NV = 0x862A;
		public const uint GL_INVERSE_NV = 0x862B;
		public const uint GL_TRANSPOSE_NV = 0x862C;
		public const uint GL_INVERSE_TRANSPOSE_NV = 0x862D;
		public const uint GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E;
		public const uint GL_MAX_TRACK_MATRICES_NV = 0x862F;
		public const uint GL_MATRIX0_NV = 0x8630;
		public const uint GL_MATRIX1_NV = 0x8631;
		public const uint GL_MATRIX2_NV = 0x8632;
		public const uint GL_MATRIX3_NV = 0x8633;
		public const uint GL_MATRIX4_NV = 0x8634;
		public const uint GL_MATRIX5_NV = 0x8635;
		public const uint GL_MATRIX6_NV = 0x8636;
		public const uint GL_MATRIX7_NV = 0x8637;
		public const uint GL_CURRENT_MATRIX_STACK_DEPTH_NV = 0x8640;
		public const uint GL_CURRENT_MATRIX_NV = 0x8641;
		public const uint GL_VERTEX_PROGRAM_POINT_SIZE_NV = 0x8642;
		public const uint GL_VERTEX_PROGRAM_TWO_SIDE_NV = 0x8643;
		public const uint GL_PROGRAM_PARAMETER_NV = 0x8644;
		public const uint GL_ATTRIB_ARRAY_POINTER_NV = 0x8645;
		public const uint GL_PROGRAM_TARGET_NV = 0x8646;
		public const uint GL_PROGRAM_RESIDENT_NV = 0x8647;
		public const uint GL_TRACK_MATRIX_NV = 0x8648;
		public const uint GL_TRACK_MATRIX_TRANSFORM_NV = 0x8649;
		public const uint GL_VERTEX_PROGRAM_BINDING_NV = 0x864A;
		public const uint GL_PROGRAM_ERROR_POSITION_NV = 0x864B;
		public const uint GL_VERTEX_ATTRIB_ARRAY0_NV = 0x8650;
		public const uint GL_VERTEX_ATTRIB_ARRAY1_NV = 0x8651;
		public const uint GL_VERTEX_ATTRIB_ARRAY2_NV = 0x8652;
		public const uint GL_VERTEX_ATTRIB_ARRAY3_NV = 0x8653;
		public const uint GL_VERTEX_ATTRIB_ARRAY4_NV = 0x8654;
		public const uint GL_VERTEX_ATTRIB_ARRAY5_NV = 0x8655;
		public const uint GL_VERTEX_ATTRIB_ARRAY6_NV = 0x8656;
		public const uint GL_VERTEX_ATTRIB_ARRAY7_NV = 0x8657;
		public const uint GL_VERTEX_ATTRIB_ARRAY8_NV = 0x8658;
		public const uint GL_VERTEX_ATTRIB_ARRAY9_NV = 0x8659;
		public const uint GL_VERTEX_ATTRIB_ARRAY10_NV = 0x865A;
		public const uint GL_VERTEX_ATTRIB_ARRAY11_NV = 0x865B;
		public const uint GL_VERTEX_ATTRIB_ARRAY12_NV = 0x865C;
		public const uint GL_VERTEX_ATTRIB_ARRAY13_NV = 0x865D;
		public const uint GL_VERTEX_ATTRIB_ARRAY14_NV = 0x865E;
		public const uint GL_VERTEX_ATTRIB_ARRAY15_NV = 0x865F;
		public const uint GL_MAP1_VERTEX_ATTRIB0_4_NV = 0x8660;
		public const uint GL_MAP1_VERTEX_ATTRIB1_4_NV = 0x8661;
		public const uint GL_MAP1_VERTEX_ATTRIB2_4_NV = 0x8662;
		public const uint GL_MAP1_VERTEX_ATTRIB3_4_NV = 0x8663;
		public const uint GL_MAP1_VERTEX_ATTRIB4_4_NV = 0x8664;
		public const uint GL_MAP1_VERTEX_ATTRIB5_4_NV = 0x8665;
		public const uint GL_MAP1_VERTEX_ATTRIB6_4_NV = 0x8666;
		public const uint GL_MAP1_VERTEX_ATTRIB7_4_NV = 0x8667;
		public const uint GL_MAP1_VERTEX_ATTRIB8_4_NV = 0x8668;
		public const uint GL_MAP1_VERTEX_ATTRIB9_4_NV = 0x8669;
		public const uint GL_MAP1_VERTEX_ATTRIB10_4_NV = 0x866A;
		public const uint GL_MAP1_VERTEX_ATTRIB11_4_NV = 0x866B;
		public const uint GL_MAP1_VERTEX_ATTRIB12_4_NV = 0x866C;
		public const uint GL_MAP1_VERTEX_ATTRIB13_4_NV = 0x866D;
		public const uint GL_MAP1_VERTEX_ATTRIB14_4_NV = 0x866E;
		public const uint GL_MAP1_VERTEX_ATTRIB15_4_NV = 0x866F;
		public const uint GL_MAP2_VERTEX_ATTRIB0_4_NV = 0x8670;
		public const uint GL_MAP2_VERTEX_ATTRIB1_4_NV = 0x8671;
		public const uint GL_MAP2_VERTEX_ATTRIB2_4_NV = 0x8672;
		public const uint GL_MAP2_VERTEX_ATTRIB3_4_NV = 0x8673;
		public const uint GL_MAP2_VERTEX_ATTRIB4_4_NV = 0x8674;
		public const uint GL_MAP2_VERTEX_ATTRIB5_4_NV = 0x8675;
		public const uint GL_MAP2_VERTEX_ATTRIB6_4_NV = 0x8676;
		public const uint GL_MAP2_VERTEX_ATTRIB7_4_NV = 0x8677;
		public const uint GL_MAP2_VERTEX_ATTRIB8_4_NV = 0x8678;
		public const uint GL_MAP2_VERTEX_ATTRIB9_4_NV = 0x8679;
		public const uint GL_MAP2_VERTEX_ATTRIB10_4_NV = 0x867A;
		public const uint GL_MAP2_VERTEX_ATTRIB11_4_NV = 0x867B;
		public const uint GL_MAP2_VERTEX_ATTRIB12_4_NV = 0x867C;
		public const uint GL_MAP2_VERTEX_ATTRIB13_4_NV = 0x867D;
		public const uint GL_MAP2_VERTEX_ATTRIB14_4_NV = 0x867E;
		public const uint GL_MAP2_VERTEX_ATTRIB15_4_NV = 0x867F;
		public const uint GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV = 0x88FD;
		public const uint GL_VIDEO_BUFFER_NV = 0x9020;
		public const uint GL_VIDEO_BUFFER_BINDING_NV = 0x9021;
		public const uint GL_FIELD_UPPER_NV = 0x9022;
		public const uint GL_FIELD_LOWER_NV = 0x9023;
		public const uint GL_NUM_VIDEO_CAPTURE_STREAMS_NV = 0x9024;
		public const uint GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025;
		public const uint GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026;
		public const uint GL_LAST_VIDEO_CAPTURE_STATUS_NV = 0x9027;
		public const uint GL_VIDEO_BUFFER_PITCH_NV = 0x9028;
		public const uint GL_VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029;
		public const uint GL_VIDEO_COLOR_CONVERSION_MAX_NV = 0x902A;
		public const uint GL_VIDEO_COLOR_CONVERSION_MIN_NV = 0x902B;
		public const uint GL_VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C;
		public const uint GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D;
		public const uint GL_PARTIAL_SUCCESS_NV = 0x902E;
		public const uint GL_SUCCESS_NV = 0x902F;
		public const uint GL_FAILURE_NV = 0x9030;
		public const uint GL_YCBYCR8_422_NV = 0x9031;
		public const uint GL_YCBAYCR8A_4224_NV = 0x9032;
		public const uint GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV = 0x9033;
		public const uint GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034;
		public const uint GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV = 0x9035;
		public const uint GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036;
		public const uint GL_Z4Y12Z4CB12Z4CR12_444_NV = 0x9037;
		public const uint GL_VIDEO_CAPTURE_FRAME_WIDTH_NV = 0x9038;
		public const uint GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV = 0x9039;
		public const uint GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A;
		public const uint GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B;
		public const uint GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C;
		public const uint GL_MAX_VIEWPORTS_NV = 0x825B;
		public const uint GL_VIEWPORT_SUBPIXEL_BITS_NV = 0x825C;
		public const uint GL_VIEWPORT_BOUNDS_RANGE_NV = 0x825D;
		public const uint GL_VIEWPORT_INDEX_PROVOKING_VERTEX_NV = 0x825F;
		public const uint GL_SAMPLER_EXTERNAL_OES = 0x8D66;
		public const uint GL_BLEND_EQUATION_RGB_OES = 0x8009;
		public const uint GL_BLEND_EQUATION_ALPHA_OES = 0x883D;
		public const uint GL_BLEND_DST_RGB_OES = 0x80C8;
		public const uint GL_BLEND_SRC_RGB_OES = 0x80C9;
		public const uint GL_BLEND_DST_ALPHA_OES = 0x80CA;
		public const uint GL_BLEND_SRC_ALPHA_OES = 0x80CB;
		public const uint GL_BLEND_EQUATION_OES = 0x8009;
		public const uint GL_FUNC_ADD_OES = 0x8006;
		public const uint GL_FUNC_SUBTRACT_OES = 0x800A;
		public const uint GL_FUNC_REVERSE_SUBTRACT_OES = 0x800B;
		public const uint GL_ETC1_RGB8_OES = 0x8D64;
		public const uint GL_PALETTE4_RGB8_OES = 0x8B90;
		public const uint GL_PALETTE4_RGBA8_OES = 0x8B91;
		public const uint GL_PALETTE4_R5_G6_B5_OES = 0x8B92;
		public const uint GL_PALETTE4_RGBA4_OES = 0x8B93;
		public const uint GL_PALETTE4_RGB5_A1_OES = 0x8B94;
		public const uint GL_PALETTE8_RGB8_OES = 0x8B95;
		public const uint GL_PALETTE8_RGBA8_OES = 0x8B96;
		public const uint GL_PALETTE8_R5_G6_B5_OES = 0x8B97;
		public const uint GL_PALETTE8_RGBA4_OES = 0x8B98;
		public const uint GL_PALETTE8_RGB5_A1_OES = 0x8B99;
		public const uint GL_DEPTH_COMPONENT24_OES = 0x81A6;
		public const uint GL_TEXTURE_CROP_RECT_OES = 0x8B9D;
		public const uint GL_FIXED_OES = 0x140C;
		public const uint GL_NONE_OES = 0;
		public const uint GL_FRAMEBUFFER_OES = 0x8D40;
		public const uint GL_RENDERBUFFER_OES = 0x8D41;
		public const uint GL_RGBA4_OES = 0x8056;
		public const uint GL_RGB5_A1_OES = 0x8057;
		public const uint GL_RGB565_OES = 0x8D62;
		public const uint GL_DEPTH_COMPONENT16_OES = 0x81A5;
		public const uint GL_RENDERBUFFER_WIDTH_OES = 0x8D42;
		public const uint GL_RENDERBUFFER_HEIGHT_OES = 0x8D43;
		public const uint GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44;
		public const uint GL_RENDERBUFFER_RED_SIZE_OES = 0x8D50;
		public const uint GL_RENDERBUFFER_GREEN_SIZE_OES = 0x8D51;
		public const uint GL_RENDERBUFFER_BLUE_SIZE_OES = 0x8D52;
		public const uint GL_RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53;
		public const uint GL_RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54;
		public const uint GL_RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3;
		public const uint GL_COLOR_ATTACHMENT0_OES = 0x8CE0;
		public const uint GL_DEPTH_ATTACHMENT_OES = 0x8D00;
		public const uint GL_STENCIL_ATTACHMENT_OES = 0x8D20;
		public const uint GL_FRAMEBUFFER_COMPLETE_OES = 0x8CD5;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA;
		public const uint GL_FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD;
		public const uint GL_FRAMEBUFFER_BINDING_OES = 0x8CA6;
		public const uint GL_RENDERBUFFER_BINDING_OES = 0x8CA7;
		public const uint GL_MAX_RENDERBUFFER_SIZE_OES = 0x84E8;
		public const uint GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506;
		public const uint GL_GEOMETRY_SHADER_OES = 0x8DD9;
		public const uint GL_GEOMETRY_SHADER_BIT_OES = 0x00000004;
		public const uint GL_GEOMETRY_LINKED_VERTICES_OUT_OES = 0x8916;
		public const uint GL_GEOMETRY_LINKED_INPUT_TYPE_OES = 0x8917;
		public const uint GL_GEOMETRY_LINKED_OUTPUT_TYPE_OES = 0x8918;
		public const uint GL_GEOMETRY_SHADER_INVOCATIONS_OES = 0x887F;
		public const uint GL_LAYER_PROVOKING_VERTEX_OES = 0x825E;
		public const uint GL_LINES_ADJACENCY_OES = 0x000A;
		public const uint GL_LINE_STRIP_ADJACENCY_OES = 0x000B;
		public const uint GL_TRIANGLES_ADJACENCY_OES = 0x000C;
		public const uint GL_TRIANGLE_STRIP_ADJACENCY_OES = 0x000D;
		public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_OES = 0x8DDF;
		public const uint GL_MAX_GEOMETRY_UNIFORM_BLOCKS_OES = 0x8A2C;
		public const uint GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_OES = 0x8A32;
		public const uint GL_MAX_GEOMETRY_INPUT_COMPONENTS_OES = 0x9123;
		public const uint GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_OES = 0x9124;
		public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES_OES = 0x8DE0;
		public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES = 0x8DE1;
		public const uint GL_MAX_GEOMETRY_SHADER_INVOCATIONS_OES = 0x8E5A;
		public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES = 0x8C29;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES = 0x92CF;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTERS_OES = 0x92D5;
		public const uint GL_MAX_GEOMETRY_IMAGE_UNIFORMS_OES = 0x90CD;
		public const uint GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES = 0x90D7;
		public const uint GL_FIRST_VERTEX_CONVENTION_OES = 0x8E4D;
		public const uint GL_LAST_VERTEX_CONVENTION_OES = 0x8E4E;
		public const uint GL_UNDEFINED_VERTEX_OES = 0x8260;
		public const uint GL_PRIMITIVES_GENERATED_OES = 0x8C87;
		public const uint GL_FRAMEBUFFER_DEFAULT_LAYERS_OES = 0x9312;
		public const uint GL_MAX_FRAMEBUFFER_LAYERS_OES = 0x9317;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES = 0x8DA8;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES = 0x8DA7;
		public const uint GL_REFERENCED_BY_GEOMETRY_SHADER_OES = 0x9309;
		public const uint GL_PROGRAM_BINARY_LENGTH_OES = 0x8741;
		public const uint GL_NUM_PROGRAM_BINARY_FORMATS_OES = 0x87FE;
		public const uint GL_PROGRAM_BINARY_FORMATS_OES = 0x87FF;
		public const uint GL_WRITE_ONLY_OES = 0x88B9;
		public const uint GL_BUFFER_ACCESS_OES = 0x88BB;
		public const uint GL_BUFFER_MAPPED_OES = 0x88BC;
		public const uint GL_BUFFER_MAP_POINTER_OES = 0x88BD;
		public const uint GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D;
		public const uint GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E;
		public const uint GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F;
		public const uint GL_MAX_VERTEX_UNITS_OES = 0x86A4;
		public const uint GL_MAX_PALETTE_MATRICES_OES = 0x8842;
		public const uint GL_MATRIX_PALETTE_OES = 0x8840;
		public const uint GL_MATRIX_INDEX_ARRAY_OES = 0x8844;
		public const uint GL_WEIGHT_ARRAY_OES = 0x86AD;
		public const uint GL_CURRENT_PALETTE_MATRIX_OES = 0x8843;
		public const uint GL_MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846;
		public const uint GL_MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847;
		public const uint GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848;
		public const uint GL_MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849;
		public const uint GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E;
		public const uint GL_WEIGHT_ARRAY_SIZE_OES = 0x86AB;
		public const uint GL_WEIGHT_ARRAY_TYPE_OES = 0x86A9;
		public const uint GL_WEIGHT_ARRAY_STRIDE_OES = 0x86AA;
		public const uint GL_WEIGHT_ARRAY_POINTER_OES = 0x86AC;
		public const uint GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E;
		public const uint GL_POINT_SIZE_ARRAY_OES = 0x8B9C;
		public const uint GL_POINT_SIZE_ARRAY_TYPE_OES = 0x898A;
		public const uint GL_POINT_SIZE_ARRAY_STRIDE_OES = 0x898B;
		public const uint GL_POINT_SIZE_ARRAY_POINTER_OES = 0x898C;
		public const uint GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F;
		public const uint GL_POINT_SPRITE_OES = 0x8861;
		public const uint GL_COORD_REPLACE_OES = 0x8862;
		public const uint GL_PRIMITIVE_BOUNDING_BOX_OES = 0x92BE;
		public const uint GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A;
		public const uint GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B;
		public const uint GL_ALPHA8_OES = 0x803C;
		public const uint GL_LUMINANCE4_ALPHA4_OES = 0x8043;
		public const uint GL_LUMINANCE8_ALPHA8_OES = 0x8045;
		public const uint GL_LUMINANCE8_OES = 0x8040;
		public const uint GL_RGB8_OES = 0x8051;
		public const uint GL_RGBA8_OES = 0x8058;
		public const uint GL_SAMPLE_SHADING_OES = 0x8C36;
		public const uint GL_MIN_SAMPLE_SHADING_VALUE_OES = 0x8C37;
		public const uint GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_OES = 0x8E5B;
		public const uint GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_OES = 0x8E5C;
		public const uint GL_FRAGMENT_INTERPOLATION_OFFSET_BITS_OES = 0x8E5D;
		public const uint GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B;
		public const uint GL_STENCIL_INDEX1_OES = 0x8D46;
		public const uint GL_STENCIL_INDEX4_OES = 0x8D47;
		public const uint GL_STENCIL_INDEX8_OES = 0x8D48;
		public const uint GL_INCR_WRAP_OES = 0x8507;
		public const uint GL_DECR_WRAP_OES = 0x8508;
		public const uint GL_FRAMEBUFFER_UNDEFINED_OES = 0x8219;
		public const uint GL_PATCHES_OES = 0x000E;
		public const uint GL_PATCH_VERTICES_OES = 0x8E72;
		public const uint GL_TESS_CONTROL_OUTPUT_VERTICES_OES = 0x8E75;
		public const uint GL_TESS_GEN_MODE_OES = 0x8E76;
		public const uint GL_TESS_GEN_SPACING_OES = 0x8E77;
		public const uint GL_TESS_GEN_VERTEX_ORDER_OES = 0x8E78;
		public const uint GL_TESS_GEN_POINT_MODE_OES = 0x8E79;
		public const uint GL_ISOLINES_OES = 0x8E7A;
		public const uint GL_QUADS_OES = 0x0007;
		public const uint GL_FRACTIONAL_ODD_OES = 0x8E7B;
		public const uint GL_FRACTIONAL_EVEN_OES = 0x8E7C;
		public const uint GL_MAX_PATCH_VERTICES_OES = 0x8E7D;
		public const uint GL_MAX_TESS_GEN_LEVEL_OES = 0x8E7E;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES = 0x8E7F;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES = 0x8E80;
		public const uint GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES = 0x8E81;
		public const uint GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES = 0x8E82;
		public const uint GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES = 0x8E83;
		public const uint GL_MAX_TESS_PATCH_COMPONENTS_OES = 0x8E84;
		public const uint GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES = 0x8E85;
		public const uint GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES = 0x8E86;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES = 0x8E89;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES = 0x8E8A;
		public const uint GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_OES = 0x886C;
		public const uint GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES = 0x886D;
		public const uint GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES = 0x8E1E;
		public const uint GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES = 0x8E1F;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES = 0x92CD;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES = 0x92CE;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES = 0x92D3;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES = 0x92D4;
		public const uint GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES = 0x90CB;
		public const uint GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES = 0x90CC;
		public const uint GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES = 0x90D8;
		public const uint GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES = 0x90D9;
		public const uint GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES = 0x8221;
		public const uint GL_IS_PER_PATCH_OES = 0x92E7;
		public const uint GL_REFERENCED_BY_TESS_CONTROL_SHADER_OES = 0x9307;
		public const uint GL_REFERENCED_BY_TESS_EVALUATION_SHADER_OES = 0x9308;
		public const uint GL_TESS_CONTROL_SHADER_OES = 0x8E88;
		public const uint GL_TESS_EVALUATION_SHADER_OES = 0x8E87;
		public const uint GL_TESS_CONTROL_SHADER_BIT_OES = 0x00000008;
		public const uint GL_TESS_EVALUATION_SHADER_BIT_OES = 0x00000010;
		public const uint GL_TEXTURE_WRAP_R_OES = 0x8072;
		public const uint GL_TEXTURE_3D_OES = 0x806F;
		public const uint GL_TEXTURE_BINDING_3D_OES = 0x806A;
		public const uint GL_MAX_3D_TEXTURE_SIZE_OES = 0x8073;
		public const uint GL_SAMPLER_3D_OES = 0x8B5F;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES = 0x8CD4;
		public const uint GL_TEXTURE_BORDER_COLOR_OES = 0x1004;
		public const uint GL_CLAMP_TO_BORDER_OES = 0x812D;
		public const uint GL_TEXTURE_BUFFER_OES = 0x8C2A;
		public const uint GL_TEXTURE_BUFFER_BINDING_OES = 0x8C2A;
		public const uint GL_MAX_TEXTURE_BUFFER_SIZE_OES = 0x8C2B;
		public const uint GL_TEXTURE_BINDING_BUFFER_OES = 0x8C2C;
		public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING_OES = 0x8C2D;
		public const uint GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES = 0x919F;
		public const uint GL_SAMPLER_BUFFER_OES = 0x8DC2;
		public const uint GL_INT_SAMPLER_BUFFER_OES = 0x8DD0;
		public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER_OES = 0x8DD8;
		public const uint GL_IMAGE_BUFFER_OES = 0x9051;
		public const uint GL_INT_IMAGE_BUFFER_OES = 0x905C;
		public const uint GL_UNSIGNED_INT_IMAGE_BUFFER_OES = 0x9067;
		public const uint GL_TEXTURE_BUFFER_OFFSET_OES = 0x919D;
		public const uint GL_TEXTURE_BUFFER_SIZE_OES = 0x919E;
		public const uint GL_COMPRESSED_RGBA_ASTC_3x3x3_OES = 0x93C0;
		public const uint GL_COMPRESSED_RGBA_ASTC_4x3x3_OES = 0x93C1;
		public const uint GL_COMPRESSED_RGBA_ASTC_4x4x3_OES = 0x93C2;
		public const uint GL_COMPRESSED_RGBA_ASTC_4x4x4_OES = 0x93C3;
		public const uint GL_COMPRESSED_RGBA_ASTC_5x4x4_OES = 0x93C4;
		public const uint GL_COMPRESSED_RGBA_ASTC_5x5x4_OES = 0x93C5;
		public const uint GL_COMPRESSED_RGBA_ASTC_5x5x5_OES = 0x93C6;
		public const uint GL_COMPRESSED_RGBA_ASTC_6x5x5_OES = 0x93C7;
		public const uint GL_COMPRESSED_RGBA_ASTC_6x6x5_OES = 0x93C8;
		public const uint GL_COMPRESSED_RGBA_ASTC_6x6x6_OES = 0x93C9;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES = 0x93E0;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES = 0x93E1;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES = 0x93E2;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES = 0x93E3;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES = 0x93E4;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES = 0x93E5;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES = 0x93E6;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES = 0x93E7;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES = 0x93E8;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES = 0x93E9;
		public const uint GL_NORMAL_MAP_OES = 0x8511;
		public const uint GL_REFLECTION_MAP_OES = 0x8512;
		public const uint GL_TEXTURE_CUBE_MAP_OES = 0x8513;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_OES = 0x8514;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A;
		public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C;
		public const uint GL_TEXTURE_GEN_MODE_OES = 0x2500;
		public const uint GL_TEXTURE_GEN_STR_OES = 0x8D60;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_OES = 0x900A;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY_OES = 0x900C;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_OES = 0x900D;
		public const uint GL_INT_SAMPLER_CUBE_MAP_ARRAY_OES = 0x900E;
		public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_OES = 0x900F;
		public const uint GL_IMAGE_CUBE_MAP_ARRAY_OES = 0x9054;
		public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY_OES = 0x905F;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES = 0x906A;
		public const uint GL_HALF_FLOAT_OES = 0x8D61;
		public const uint GL_MIRRORED_REPEAT_OES = 0x8370;
		public const uint GL_STENCIL_INDEX_OES = 0x1901;
		public const uint GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES = 0x9102;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES = 0x9105;
		public const uint GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910B;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910C;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910D;
		public const uint GL_TEXTURE_VIEW_MIN_LEVEL_OES = 0x82DB;
		public const uint GL_TEXTURE_VIEW_NUM_LEVELS_OES = 0x82DC;
		public const uint GL_TEXTURE_VIEW_MIN_LAYER_OES = 0x82DD;
		public const uint GL_TEXTURE_VIEW_NUM_LAYERS_OES = 0x82DE;
		public const uint GL_VERTEX_ARRAY_BINDING_OES = 0x85B5;
		public const uint GL_UNSIGNED_INT_10_10_10_2_OES = 0x8DF6;
		public const uint GL_INT_10_10_10_2_OES = 0x8DF7;
		public const uint GL_INTERLACE_OML = 0x8980;
		public const uint GL_INTERLACE_READ_OML = 0x8981;
		public const uint GL_PACK_RESAMPLE_OML = 0x8984;
		public const uint GL_UNPACK_RESAMPLE_OML = 0x8985;
		public const uint GL_RESAMPLE_REPLICATE_OML = 0x8986;
		public const uint GL_RESAMPLE_ZERO_FILL_OML = 0x8987;
		public const uint GL_RESAMPLE_AVERAGE_OML = 0x8988;
		public const uint GL_RESAMPLE_DECIMATE_OML = 0x8989;
		public const uint GL_FORMAT_SUBSAMPLE_24_24_OML = 0x8982;
		public const uint GL_FORMAT_SUBSAMPLE_244_244_OML = 0x8983;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632;
		public const uint GL_MAX_VIEWS_OVR = 0x9631;
		public const uint GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8;
		public const uint GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD;
		public const uint GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE;
		public const uint GL_NATIVE_GRAPHICS_HANDLE_PGI = 0x1A202;
		public const uint GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203;
		public const uint GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204;
		public const uint GL_ALWAYS_FAST_HINT_PGI = 0x1A20C;
		public const uint GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D;
		public const uint GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E;
		public const uint GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F;
		public const uint GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210;
		public const uint GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211;
		public const uint GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216;
		public const uint GL_STRICT_LIGHTING_HINT_PGI = 0x1A217;
		public const uint GL_STRICT_SCISSOR_HINT_PGI = 0x1A218;
		public const uint GL_FULL_STIPPLE_HINT_PGI = 0x1A219;
		public const uint GL_CLIP_NEAR_HINT_PGI = 0x1A220;
		public const uint GL_CLIP_FAR_HINT_PGI = 0x1A221;
		public const uint GL_WIDE_LINE_HINT_PGI = 0x1A222;
		public const uint GL_BACK_NORMALS_HINT_PGI = 0x1A223;
		public const uint GL_VERTEX_DATA_HINT_PGI = 0x1A22A;
		public const uint GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B;
		public const uint GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C;
		public const uint GL_MAX_VERTEX_HINT_PGI = 0x1A22D;
		public const uint GL_COLOR3_BIT_PGI = 0x00010000;
		public const uint GL_COLOR4_BIT_PGI = 0x00020000;
		public const uint GL_EDGEFLAG_BIT_PGI = 0x00040000;
		public const uint GL_INDEX_BIT_PGI = 0x00080000;
		public const uint GL_MAT_AMBIENT_BIT_PGI = 0x00100000;
		public const uint GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x00200000;
		public const uint GL_MAT_DIFFUSE_BIT_PGI = 0x00400000;
		public const uint GL_MAT_EMISSION_BIT_PGI = 0x00800000;
		public const uint GL_MAT_COLOR_INDEXES_BIT_PGI = 0x01000000;
		public const uint GL_MAT_SHININESS_BIT_PGI = 0x02000000;
		public const uint GL_MAT_SPECULAR_BIT_PGI = 0x04000000;
		public const uint GL_NORMAL_BIT_PGI = 0x08000000;
		public const uint GL_TEXCOORD1_BIT_PGI = 0x10000000;
		public const uint GL_TEXCOORD2_BIT_PGI = 0x20000000;
		public const uint GL_TEXCOORD3_BIT_PGI = 0x40000000;
		public const uint GL_TEXCOORD4_BIT_PGI = 0x80000000;
		public const uint GL_VERTEX23_BIT_PGI = 0x00000004;
		public const uint GL_VERTEX4_BIT_PGI = 0x00000008;
		public const uint GL_ALPHA_TEST_QCOM = 0x0BC0;
		public const uint GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1;
		public const uint GL_ALPHA_TEST_REF_QCOM = 0x0BC2;
		public const uint GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0;
		public const uint GL_CPU_OPTIMIZED_QCOM = 0x8FB1;
		public const uint GL_GPU_OPTIMIZED_QCOM = 0x8FB2;
		public const uint GL_RENDER_DIRECT_TO_FRAMEBUFFER_QCOM = 0x8FB3;
		public const uint GL_TEXTURE_WIDTH_QCOM = 0x8BD2;
		public const uint GL_TEXTURE_HEIGHT_QCOM = 0x8BD3;
		public const uint GL_TEXTURE_DEPTH_QCOM = 0x8BD4;
		public const uint GL_TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5;
		public const uint GL_TEXTURE_FORMAT_QCOM = 0x8BD6;
		public const uint GL_TEXTURE_TYPE_QCOM = 0x8BD7;
		public const uint GL_TEXTURE_IMAGE_VALID_QCOM = 0x8BD8;
		public const uint GL_TEXTURE_NUM_LEVELS_QCOM = 0x8BD9;
		public const uint GL_TEXTURE_TARGET_QCOM = 0x8BDA;
		public const uint GL_TEXTURE_OBJECT_VALID_QCOM = 0x8BDB;
		public const uint GL_STATE_RESTORE = 0x8BDC;
		public const uint GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0;
		public const uint GL_COLOR_BUFFER_BIT0_QCOM = 0x00000001;
		public const uint GL_COLOR_BUFFER_BIT1_QCOM = 0x00000002;
		public const uint GL_COLOR_BUFFER_BIT2_QCOM = 0x00000004;
		public const uint GL_COLOR_BUFFER_BIT3_QCOM = 0x00000008;
		public const uint GL_COLOR_BUFFER_BIT4_QCOM = 0x00000010;
		public const uint GL_COLOR_BUFFER_BIT5_QCOM = 0x00000020;
		public const uint GL_COLOR_BUFFER_BIT6_QCOM = 0x00000040;
		public const uint GL_COLOR_BUFFER_BIT7_QCOM = 0x00000080;
		public const uint GL_DEPTH_BUFFER_BIT0_QCOM = 0x00000100;
		public const uint GL_DEPTH_BUFFER_BIT1_QCOM = 0x00000200;
		public const uint GL_DEPTH_BUFFER_BIT2_QCOM = 0x00000400;
		public const uint GL_DEPTH_BUFFER_BIT3_QCOM = 0x00000800;
		public const uint GL_DEPTH_BUFFER_BIT4_QCOM = 0x00001000;
		public const uint GL_DEPTH_BUFFER_BIT5_QCOM = 0x00002000;
		public const uint GL_DEPTH_BUFFER_BIT6_QCOM = 0x00004000;
		public const uint GL_DEPTH_BUFFER_BIT7_QCOM = 0x00008000;
		public const uint GL_STENCIL_BUFFER_BIT0_QCOM = 0x00010000;
		public const uint GL_STENCIL_BUFFER_BIT1_QCOM = 0x00020000;
		public const uint GL_STENCIL_BUFFER_BIT2_QCOM = 0x00040000;
		public const uint GL_STENCIL_BUFFER_BIT3_QCOM = 0x00080000;
		public const uint GL_STENCIL_BUFFER_BIT4_QCOM = 0x00100000;
		public const uint GL_STENCIL_BUFFER_BIT5_QCOM = 0x00200000;
		public const uint GL_STENCIL_BUFFER_BIT6_QCOM = 0x00400000;
		public const uint GL_STENCIL_BUFFER_BIT7_QCOM = 0x00800000;
		public const uint GL_MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000;
		public const uint GL_MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000;
		public const uint GL_MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000;
		public const uint GL_MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000;
		public const uint GL_MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000;
		public const uint GL_MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000;
		public const uint GL_MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000;
		public const uint GL_MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000;
		public const uint GL_WRITEONLY_RENDERING_QCOM = 0x8823;
		public const uint GL_SCREEN_COORDINATES_REND = 0x8490;
		public const uint GL_INVERTED_SCREEN_W_REND = 0x8491;
		public const uint GL_RGB_S3TC = 0x83A0;
		public const uint GL_RGB4_S3TC = 0x83A1;
		public const uint GL_RGBA_S3TC = 0x83A2;
		public const uint GL_RGBA4_S3TC = 0x83A3;
		public const uint GL_RGBA_DXT5_S3TC = 0x83A4;
		public const uint GL_RGBA4_DXT5_S3TC = 0x83A5;
		public const uint GL_DETAIL_TEXTURE_2D_SGIS = 0x8095;
		public const uint GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096;
		public const uint GL_LINEAR_DETAIL_SGIS = 0x8097;
		public const uint GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098;
		public const uint GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099;
		public const uint GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A;
		public const uint GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B;
		public const uint GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C;
		public const uint GL_FOG_FUNC_SGIS = 0x812A;
		public const uint GL_FOG_FUNC_POINTS_SGIS = 0x812B;
		public const uint GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C;
		public const uint GL_GENERATE_MIPMAP_SGIS = 0x8191;
		public const uint GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192;
		public const uint GL_MULTISAMPLE_SGIS = 0x809D;
		public const uint GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E;
		public const uint GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F;
		public const uint GL_SAMPLE_MASK_SGIS = 0x80A0;
		public const uint GL_1PASS_SGIS = 0x80A1;
		public const uint GL_2PASS_0_SGIS = 0x80A2;
		public const uint GL_2PASS_1_SGIS = 0x80A3;
		public const uint GL_4PASS_0_SGIS = 0x80A4;
		public const uint GL_4PASS_1_SGIS = 0x80A5;
		public const uint GL_4PASS_2_SGIS = 0x80A6;
		public const uint GL_4PASS_3_SGIS = 0x80A7;
		public const uint GL_SAMPLE_BUFFERS_SGIS = 0x80A8;
		public const uint GL_SAMPLES_SGIS = 0x80A9;
		public const uint GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA;
		public const uint GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB;
		public const uint GL_SAMPLE_PATTERN_SGIS = 0x80AC;
		public const uint GL_PIXEL_TEXTURE_SGIS = 0x8353;
		public const uint GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354;
		public const uint GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355;
		public const uint GL_PIXEL_GROUP_COLOR_SGIS = 0x8356;
		public const uint GL_EYE_DISTANCE_TO_POINT_SGIS = 0x81F0;
		public const uint GL_OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1;
		public const uint GL_EYE_DISTANCE_TO_LINE_SGIS = 0x81F2;
		public const uint GL_OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3;
		public const uint GL_EYE_POINT_SGIS = 0x81F4;
		public const uint GL_OBJECT_POINT_SGIS = 0x81F5;
		public const uint GL_EYE_LINE_SGIS = 0x81F6;
		public const uint GL_OBJECT_LINE_SGIS = 0x81F7;
		public const uint GL_POINT_SIZE_MIN_SGIS = 0x8126;
		public const uint GL_POINT_SIZE_MAX_SGIS = 0x8127;
		public const uint GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128;
		public const uint GL_DISTANCE_ATTENUATION_SGIS = 0x8129;
		public const uint GL_LINEAR_SHARPEN_SGIS = 0x80AD;
		public const uint GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE;
		public const uint GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF;
		public const uint GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0;
		public const uint GL_PACK_SKIP_VOLUMES_SGIS = 0x8130;
		public const uint GL_PACK_IMAGE_DEPTH_SGIS = 0x8131;
		public const uint GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132;
		public const uint GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133;
		public const uint GL_TEXTURE_4D_SGIS = 0x8134;
		public const uint GL_PROXY_TEXTURE_4D_SGIS = 0x8135;
		public const uint GL_TEXTURE_4DSIZE_SGIS = 0x8136;
		public const uint GL_TEXTURE_WRAP_Q_SGIS = 0x8137;
		public const uint GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138;
		public const uint GL_TEXTURE_4D_BINDING_SGIS = 0x814F;
		public const uint GL_CLAMP_TO_BORDER_SGIS = 0x812D;
		public const uint GL_TEXTURE_COLOR_WRITEMASK_SGIS = 0x81EF;
		public const uint GL_CLAMP_TO_EDGE_SGIS = 0x812F;
		public const uint GL_FILTER4_SGIS = 0x8146;
		public const uint GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147;
		public const uint GL_TEXTURE_MIN_LOD_SGIS = 0x813A;
		public const uint GL_TEXTURE_MAX_LOD_SGIS = 0x813B;
		public const uint GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C;
		public const uint GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D;
		public const uint GL_DUAL_ALPHA4_SGIS = 0x8110;
		public const uint GL_DUAL_ALPHA8_SGIS = 0x8111;
		public const uint GL_DUAL_ALPHA12_SGIS = 0x8112;
		public const uint GL_DUAL_ALPHA16_SGIS = 0x8113;
		public const uint GL_DUAL_LUMINANCE4_SGIS = 0x8114;
		public const uint GL_DUAL_LUMINANCE8_SGIS = 0x8115;
		public const uint GL_DUAL_LUMINANCE12_SGIS = 0x8116;
		public const uint GL_DUAL_LUMINANCE16_SGIS = 0x8117;
		public const uint GL_DUAL_INTENSITY4_SGIS = 0x8118;
		public const uint GL_DUAL_INTENSITY8_SGIS = 0x8119;
		public const uint GL_DUAL_INTENSITY12_SGIS = 0x811A;
		public const uint GL_DUAL_INTENSITY16_SGIS = 0x811B;
		public const uint GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C;
		public const uint GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D;
		public const uint GL_QUAD_ALPHA4_SGIS = 0x811E;
		public const uint GL_QUAD_ALPHA8_SGIS = 0x811F;
		public const uint GL_QUAD_LUMINANCE4_SGIS = 0x8120;
		public const uint GL_QUAD_LUMINANCE8_SGIS = 0x8121;
		public const uint GL_QUAD_INTENSITY4_SGIS = 0x8122;
		public const uint GL_QUAD_INTENSITY8_SGIS = 0x8123;
		public const uint GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124;
		public const uint GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125;
		public const uint GL_ASYNC_MARKER_SGIX = 0x8329;
		public const uint GL_ASYNC_HISTOGRAM_SGIX = 0x832C;
		public const uint GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D;
		public const uint GL_ASYNC_TEX_IMAGE_SGIX = 0x835C;
		public const uint GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D;
		public const uint GL_ASYNC_READ_PIXELS_SGIX = 0x835E;
		public const uint GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F;
		public const uint GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360;
		public const uint GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361;
		public const uint GL_ALPHA_MIN_SGIX = 0x8320;
		public const uint GL_ALPHA_MAX_SGIX = 0x8321;
		public const uint GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183;
		public const uint GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170;
		public const uint GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171;
		public const uint GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172;
		public const uint GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173;
		public const uint GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174;
		public const uint GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175;
		public const uint GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176;
		public const uint GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177;
		public const uint GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178;
		public const uint GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D;
		public const uint GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E;
		public const uint GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F;
		public const uint GL_CONVOLUTION_HINT_SGIX = 0x8316;
		public const uint GL_DEPTH_COMPONENT16_SGIX = 0x81A5;
		public const uint GL_DEPTH_COMPONENT24_SGIX = 0x81A6;
		public const uint GL_DEPTH_COMPONENT32_SGIX = 0x81A7;
		public const uint GL_FOG_OFFSET_SGIX = 0x8198;
		public const uint GL_FOG_OFFSET_VALUE_SGIX = 0x8199;
		public const uint GL_FRAGMENT_LIGHTING_SGIX = 0x8400;
		public const uint GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401;
		public const uint GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402;
		public const uint GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403;
		public const uint GL_MAX_FRAGMENT_LIGHTS_SGIX = 0x8404;
		public const uint GL_MAX_ACTIVE_LIGHTS_SGIX = 0x8405;
		public const uint GL_CURRENT_RASTER_NORMAL_SGIX = 0x8406;
		public const uint GL_LIGHT_ENV_MODE_SGIX = 0x8407;
		public const uint GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408;
		public const uint GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409;
		public const uint GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A;
		public const uint GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B;
		public const uint GL_FRAGMENT_LIGHT0_SGIX = 0x840C;
		public const uint GL_FRAGMENT_LIGHT1_SGIX = 0x840D;
		public const uint GL_FRAGMENT_LIGHT2_SGIX = 0x840E;
		public const uint GL_FRAGMENT_LIGHT3_SGIX = 0x840F;
		public const uint GL_FRAGMENT_LIGHT4_SGIX = 0x8410;
		public const uint GL_FRAGMENT_LIGHT5_SGIX = 0x8411;
		public const uint GL_FRAGMENT_LIGHT6_SGIX = 0x8412;
		public const uint GL_FRAGMENT_LIGHT7_SGIX = 0x8413;
		public const uint GL_FRAMEZOOM_SGIX = 0x818B;
		public const uint GL_FRAMEZOOM_FACTOR_SGIX = 0x818C;
		public const uint GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D;
		public const uint GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180;
		public const uint GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181;
		public const uint GL_INTERLACE_SGIX = 0x8094;
		public const uint GL_IR_INSTRUMENT1_SGIX = 0x817F;
		public const uint GL_LIST_PRIORITY_SGIX = 0x8182;
		public const uint GL_PIXEL_TEX_GEN_SGIX = 0x8139;
		public const uint GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B;
		public const uint GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E;
		public const uint GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F;
		public const uint GL_PIXEL_TILE_WIDTH_SGIX = 0x8140;
		public const uint GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141;
		public const uint GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142;
		public const uint GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143;
		public const uint GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144;
		public const uint GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145;
		public const uint GL_TEXTURE_DEFORMATION_BIT_SGIX = 0x00000001;
		public const uint GL_GEOMETRY_DEFORMATION_BIT_SGIX = 0x00000002;
		public const uint GL_GEOMETRY_DEFORMATION_SGIX = 0x8194;
		public const uint GL_TEXTURE_DEFORMATION_SGIX = 0x8195;
		public const uint GL_DEFORMATIONS_MASK_SGIX = 0x8196;
		public const uint GL_MAX_DEFORMATION_ORDER_SGIX = 0x8197;
		public const uint GL_REFERENCE_PLANE_SGIX = 0x817D;
		public const uint GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E;
		public const uint GL_PACK_RESAMPLE_SGIX = 0x842E;
		public const uint GL_UNPACK_RESAMPLE_SGIX = 0x842F;
		public const uint GL_RESAMPLE_REPLICATE_SGIX = 0x8433;
		public const uint GL_RESAMPLE_ZERO_FILL_SGIX = 0x8434;
		public const uint GL_RESAMPLE_DECIMATE_SGIX = 0x8430;
		public const uint GL_SCALEBIAS_HINT_SGIX = 0x8322;
		public const uint GL_TEXTURE_COMPARE_SGIX = 0x819A;
		public const uint GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B;
		public const uint GL_TEXTURE_LEQUAL_R_SGIX = 0x819C;
		public const uint GL_TEXTURE_GEQUAL_R_SGIX = 0x819D;
		public const uint GL_SHADOW_AMBIENT_SGIX = 0x80BF;
		public const uint GL_SPRITE_SGIX = 0x8148;
		public const uint GL_SPRITE_MODE_SGIX = 0x8149;
		public const uint GL_SPRITE_AXIS_SGIX = 0x814A;
		public const uint GL_SPRITE_TRANSLATION_SGIX = 0x814B;
		public const uint GL_SPRITE_AXIAL_SGIX = 0x814C;
		public const uint GL_SPRITE_OBJECT_ALIGNED_SGIX = 0x814D;
		public const uint GL_SPRITE_EYE_ALIGNED_SGIX = 0x814E;
		public const uint GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0;
		public const uint GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1;
		public const uint GL_PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2;
		public const uint GL_PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3;
		public const uint GL_PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4;
		public const uint GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE;
		public const uint GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369;
		public const uint GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A;
		public const uint GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B;
		public const uint GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E;
		public const uint GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F;
		public const uint GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190;
		public const uint GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E;
		public const uint GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179;
		public const uint GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A;
		public const uint GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B;
		public const uint GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C;
		public const uint GL_VERTEX_PRECLIP_SGIX = 0x83EE;
		public const uint GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF;
		public const uint GL_YCRCB_422_SGIX = 0x81BB;
		public const uint GL_YCRCB_444_SGIX = 0x81BC;
		public const uint GL_YCRCB_SGIX = 0x8318;
		public const uint GL_YCRCBA_SGIX = 0x8319;
		public const uint GL_COLOR_MATRIX_SGI = 0x80B1;
		public const uint GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2;
		public const uint GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3;
		public const uint GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4;
		public const uint GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5;
		public const uint GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6;
		public const uint GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7;
		public const uint GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8;
		public const uint GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9;
		public const uint GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA;
		public const uint GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB;
		public const uint GL_COLOR_TABLE_SGI = 0x80D0;
		public const uint GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1;
		public const uint GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2;
		public const uint GL_PROXY_COLOR_TABLE_SGI = 0x80D3;
		public const uint GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4;
		public const uint GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5;
		public const uint GL_COLOR_TABLE_SCALE_SGI = 0x80D6;
		public const uint GL_COLOR_TABLE_BIAS_SGI = 0x80D7;
		public const uint GL_COLOR_TABLE_FORMAT_SGI = 0x80D8;
		public const uint GL_COLOR_TABLE_WIDTH_SGI = 0x80D9;
		public const uint GL_COLOR_TABLE_RED_SIZE_SGI = 0x80DA;
		public const uint GL_COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB;
		public const uint GL_COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC;
		public const uint GL_COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD;
		public const uint GL_COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE;
		public const uint GL_COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF;
		public const uint GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC;
		public const uint GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD;
		public const uint GL_UNPACK_CONSTANT_DATA_SUNX = 0x81D5;
		public const uint GL_TEXTURE_CONSTANT_DATA_SUNX = 0x81D6;
		public const uint GL_WRAP_BORDER_SUN = 0x81D4;
		public const uint GL_GLOBAL_ALPHA_SUN = 0x81D9;
		public const uint GL_GLOBAL_ALPHA_FACTOR_SUN = 0x81DA;
		public const uint GL_QUAD_MESH_SUN = 0x8614;
		public const uint GL_TRIANGLE_MESH_SUN = 0x8615;
		public const uint GL_SLICE_ACCUM_SUN = 0x85CC;
		public const uint GL_RESTART_SUN = 0x0001;
		public const uint GL_REPLACE_MIDDLE_SUN = 0x0002;
		public const uint GL_REPLACE_OLDEST_SUN = 0x0003;
		public const uint GL_TRIANGLE_LIST_SUN = 0x81D7;
		public const uint GL_REPLACEMENT_CODE_SUN = 0x81D8;
		public const uint GL_REPLACEMENT_CODE_ARRAY_SUN = 0x85C0;
		public const uint GL_REPLACEMENT_CODE_ARRAY_TYPE_SUN = 0x85C1;
		public const uint GL_REPLACEMENT_CODE_ARRAY_STRIDE_SUN = 0x85C2;
		public const uint GL_REPLACEMENT_CODE_ARRAY_POINTER_SUN = 0x85C3;
		public const uint GL_R1UI_V3F_SUN = 0x85C4;
		public const uint GL_R1UI_C4UB_V3F_SUN = 0x85C5;
		public const uint GL_R1UI_C3F_V3F_SUN = 0x85C6;
		public const uint GL_R1UI_N3F_V3F_SUN = 0x85C7;
		public const uint GL_R1UI_C4F_N3F_V3F_SUN = 0x85C8;
		public const uint GL_R1UI_T2F_V3F_SUN = 0x85C9;
		public const uint GL_R1UI_T2F_N3F_V3F_SUN = 0x85CA;
		public const uint GL_R1UI_T2F_C4F_N3F_V3F_SUN = 0x85CB;
		public const uint GL_SHADER_BINARY_VIV = 0x8FC4;
		public const uint GL_PHONG_WIN = 0x80EA;
		public const uint GL_PHONG_HINT_WIN = 0x80EB;
		public const uint GL_FOG_SPECULAR_TEXTURE_WIN = 0x80EC;
		
		#endregion
		
		#region Delegates
		
		private delegate void glTbufferMask3DFXDelegate(uint mask);
		private delegate void glDebugMessageEnableAMDDelegate(uint category, uint severity, int count, uint[] ids, bool enabled);
		private delegate void glDebugMessageInsertAMDDelegate(uint category, uint severity, uint id, int length, char[] buf);
		private delegate void glDebugMessageCallbackAMDDelegate(nint callback, nint userParam);
		private delegate uint glGetDebugMessageLogAMDDelegate(uint count, int bufsize, uint[] categories, uint[] severities, uint[] ids, int[] lengths, char[] message);
		private delegate void glBlendFuncIndexedAMDDelegate(uint buf, uint src, uint dst);
		private delegate void glBlendFuncSeparateIndexedAMDDelegate(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		private delegate void glBlendEquationIndexedAMDDelegate(uint buf, uint mode);
		private delegate void glBlendEquationSeparateIndexedAMDDelegate(uint buf, uint modeRGB, uint modeAlpha);
		private delegate void glUniform1i64NVDelegate(int location, Int64 x);
		private delegate void glUniform2i64NVDelegate(int location, Int64 x, Int64 y);
		private delegate void glUniform3i64NVDelegate(int location, Int64 x, Int64 y, Int64 z);
		private delegate void glUniform4i64NVDelegate(int location, Int64 x, Int64 y, Int64 z, Int64 w);
		private delegate void glUniform1i64vNVDelegate(int location, int count, Int64[] value);
		private delegate void glUniform2i64vNVDelegate(int location, int count, Int64[] value);
		private delegate void glUniform3i64vNVDelegate(int location, int count, Int64[] value);
		private delegate void glUniform4i64vNVDelegate(int location, int count, Int64[] value);
		private delegate void glUniform1ui64NVDelegate(int location, UInt64 x);
		private delegate void glUniform2ui64NVDelegate(int location, UInt64 x, UInt64 y);
		private delegate void glUniform3ui64NVDelegate(int location, UInt64 x, UInt64 y, UInt64 z);
		private delegate void glUniform4ui64NVDelegate(int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
		private delegate void glUniform1ui64vNVDelegate(int location, int count, UInt64[] value);
		private delegate void glUniform2ui64vNVDelegate(int location, int count, UInt64[] value);
		private delegate void glUniform3ui64vNVDelegate(int location, int count, UInt64[] value);
		private delegate void glUniform4ui64vNVDelegate(int location, int count, UInt64[] value);
		private delegate void glGetUniformi64vNVDelegate(uint program, int location, Int64[] @params);
		private delegate void glGetUniformui64vNVDelegate(uint program, int location, UInt64[] @params);
		private delegate void glProgramUniform1i64NVDelegate(uint program, int location, Int64 x);
		private delegate void glProgramUniform2i64NVDelegate(uint program, int location, Int64 x, Int64 y);
		private delegate void glProgramUniform3i64NVDelegate(uint program, int location, Int64 x, Int64 y, Int64 z);
		private delegate void glProgramUniform4i64NVDelegate(uint program, int location, Int64 x, Int64 y, Int64 z, Int64 w);
		private delegate void glProgramUniform1i64vNVDelegate(uint program, int location, int count, Int64[] value);
		private delegate void glProgramUniform2i64vNVDelegate(uint program, int location, int count, Int64[] value);
		private delegate void glProgramUniform3i64vNVDelegate(uint program, int location, int count, Int64[] value);
		private delegate void glProgramUniform4i64vNVDelegate(uint program, int location, int count, Int64[] value);
		private delegate void glProgramUniform1ui64NVDelegate(uint program, int location, UInt64 x);
		private delegate void glProgramUniform2ui64NVDelegate(uint program, int location, UInt64 x, UInt64 y);
		private delegate void glProgramUniform3ui64NVDelegate(uint program, int location, UInt64 x, UInt64 y, UInt64 z);
		private delegate void glProgramUniform4ui64NVDelegate(uint program, int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
		private delegate void glProgramUniform1ui64vNVDelegate(uint program, int location, int count, UInt64[] value);
		private delegate void glProgramUniform2ui64vNVDelegate(uint program, int location, int count, UInt64[] value);
		private delegate void glProgramUniform3ui64vNVDelegate(uint program, int location, int count, UInt64[] value);
		private delegate void glProgramUniform4ui64vNVDelegate(uint program, int location, int count, UInt64[] value);
		private delegate void glVertexAttribParameteriAMDDelegate(uint index, uint pname, int param);
		private delegate void glMultiDrawArraysIndirectAMDDelegate(uint mode, nint indirect, int primcount, int stride);
		private delegate void glMultiDrawElementsIndirectAMDDelegate(uint mode, uint type, nint indirect, int primcount, int stride);
		private delegate void glGenNamesAMDDelegate(uint identifier, uint num, uint[] names);
		private delegate void glDeleteNamesAMDDelegate(uint identifier, uint num, uint[] names);
		private delegate bool glIsNameAMDDelegate(uint identifier, uint name);
		private delegate void glQueryObjectParameteruiAMDDelegate(uint target, uint id, uint pname, uint param);
		private delegate void glGetPerfMonitorGroupsAMDDelegate(int[] numGroups, int groupsSize, uint[] groups);
		private delegate void glGetPerfMonitorCountersAMDDelegate(uint group, int[] numCounters, int[] maxActiveCounters, int counterSize, uint[] counters);
		private delegate void glGetPerfMonitorGroupStringAMDDelegate(uint group, int bufSize, int[] length, char[] groupString);
		private delegate void glGetPerfMonitorCounterStringAMDDelegate(uint group, uint counter, int bufSize, int[] length, char[] counterString);
		private delegate void glGetPerfMonitorCounterInfoAMDDelegate(uint group, uint counter, uint pname, nint data);
		private delegate void glGenPerfMonitorsAMDDelegate(int n, uint[] monitors);
		private delegate void glDeletePerfMonitorsAMDDelegate(int n, uint[] monitors);
		private delegate void glSelectPerfMonitorCountersAMDDelegate(uint monitor, bool enable, uint group, int numCounters, uint[] counterList);
		private delegate void glBeginPerfMonitorAMDDelegate(uint monitor);
		private delegate void glEndPerfMonitorAMDDelegate(uint monitor);
		private delegate void glGetPerfMonitorCounterDataAMDDelegate(uint monitor, uint pname, int dataSize, uint[] data, int[] bytesWritten);
		private delegate void glSetMultisamplefvAMDDelegate(uint pname, uint index, float[] val);
		private delegate void glTexStorageSparseAMDDelegate(uint target, uint internalFormat, int width, int height, int depth, int layers, uint flags);
		private delegate void glTextureStorageSparseAMDDelegate(uint texture, uint target, uint internalFormat, int width, int height, int depth, int layers, uint flags);
		private delegate void glStencilOpValueAMDDelegate(uint face, uint value);
		private delegate void glTessellationFactorAMDDelegate(float factor);
		private delegate void glTessellationModeAMDDelegate(uint mode);
		private delegate void glBlitFramebufferANGLEDelegate(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private delegate void glRenderbufferStorageMultisampleANGLEDelegate(uint target, int samples, uint internalformat, int width, int height);
		private delegate void glDrawArraysInstancedANGLEDelegate(uint mode, int first, int count, int primcount);
		private delegate void glDrawElementsInstancedANGLEDelegate(uint mode, int count, uint type, nint indices, int primcount);
		private delegate void glVertexAttribDivisorANGLEDelegate(uint index, uint divisor);
		private delegate void glGetTranslatedShaderSourceANGLEDelegate(uint shader, int bufsize, int[] length, char[] source);
		private delegate void glCopyTextureLevelsAPPLEDelegate(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount);
		private delegate void glElementPointerAPPLEDelegate(uint type, nint pointer);
		private delegate void glDrawElementArrayAPPLEDelegate(uint mode, int first, int count);
		private delegate void glDrawRangeElementArrayAPPLEDelegate(uint mode, uint start, uint end, int first, int count);
		private delegate void glMultiDrawElementArrayAPPLEDelegate(uint mode, int[] first, int[] count, int primcount);
		private delegate void glMultiDrawRangeElementArrayAPPLEDelegate(uint mode, uint start, uint end, int[] first, int[] count, int primcount);
		private delegate void glGenFencesAPPLEDelegate(int n, uint[] fences);
		private delegate void glDeleteFencesAPPLEDelegate(int n, uint[] fences);
		private delegate void glSetFenceAPPLEDelegate(uint fence);
		private delegate bool glIsFenceAPPLEDelegate(uint fence);
		private delegate bool glTestFenceAPPLEDelegate(uint fence);
		private delegate void glFinishFenceAPPLEDelegate(uint fence);
		private delegate bool glTestObjectAPPLEDelegate(uint @object, uint name);
		private delegate void glFinishObjectAPPLEDelegate(uint @object, int name);
		private delegate void glBufferParameteriAPPLEDelegate(uint target, uint pname, int param);
		private delegate void glFlushMappedBufferRangeAPPLEDelegate(uint target, nint offset, nint size);
		private delegate void glRenderbufferStorageMultisampleAPPLEDelegate(uint target, int samples, uint internalformat, int width, int height);
		private delegate void glResolveMultisampleFramebufferAPPLEDelegate();
		private delegate uint glObjectPurgeableAPPLEDelegate(uint objectType, uint name, uint option);
		private delegate uint glObjectUnpurgeableAPPLEDelegate(uint objectType, uint name, uint option);
		private delegate void glGetObjectParameterivAPPLEDelegate(uint objectType, uint name, uint pname, int[] @params);
		private delegate nint glFenceSyncAPPLEDelegate(uint condition, uint flags);
		private delegate bool glIsSyncAPPLEDelegate(nint sync);
		private delegate void glDeleteSyncAPPLEDelegate(nint sync);
		private delegate uint glClientWaitSyncAPPLEDelegate(nint sync, uint flags, UInt64 timeout);
		private delegate void glWaitSyncAPPLEDelegate(nint sync, uint flags, UInt64 timeout);
		private delegate void glGetInteger64vAPPLEDelegate(uint pname, Int64[] @params);
		private delegate void glGetSyncivAPPLEDelegate(nint sync, uint pname, int bufSize, int[] length, int[] values);
		private delegate void glTextureRangeAPPLEDelegate(uint target, int length, nint pointer);
		private delegate void glGetTexParameterPointervAPPLEDelegate(uint target, uint pname, nint @params);
		private delegate void glBindVertexArrayAPPLEDelegate(uint array);
		private delegate void glDeleteVertexArraysAPPLEDelegate(int n, uint[] arrays);
		private delegate void glGenVertexArraysAPPLEDelegate(int n, uint[] arrays);
		private delegate bool glIsVertexArrayAPPLEDelegate(uint array);
		private delegate void glVertexArrayRangeAPPLEDelegate(int length, nint pointer);
		private delegate void glFlushVertexArrayRangeAPPLEDelegate(int length, nint pointer);
		private delegate void glVertexArrayParameteriAPPLEDelegate(uint pname, int param);
		private delegate void glEnableVertexAttribAPPLEDelegate(uint index, uint pname);
		private delegate void glDisableVertexAttribAPPLEDelegate(uint index, uint pname);
		private delegate bool glIsVertexAttribEnabledAPPLEDelegate(uint index, uint pname);
		private delegate void glMapVertexAttrib1dAPPLEDelegate(uint index, uint size, double u1, double u2, int stride, int order, double[] points);
		private delegate void glMapVertexAttrib1fAPPLEDelegate(uint index, uint size, float u1, float u2, int stride, int order, float[] points);
		private delegate void glMapVertexAttrib2dAPPLEDelegate(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);
		private delegate void glMapVertexAttrib2fAPPLEDelegate(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points);
		private delegate void glReleaseShaderCompilerDelegate();
		private delegate void glShaderBinaryDelegate(int count, uint[] shaders, uint binaryformat, nint binary, int length);
		private delegate void glGetShaderPrecisionFormatDelegate(uint shadertype, uint precisiontype, int[] range, int[] precision);
		private delegate void glDepthRangefDelegate(float n, float f);
		private delegate void glClearDepthfDelegate(float d);
		private delegate void glMemoryBarrierByRegionDelegate(uint barriers);
		private delegate void glPrimitiveBoundingBoxARBDelegate(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
		private delegate void glDrawArraysInstancedBaseInstanceDelegate(uint mode, int first, int count, int instancecount, uint baseinstance);
		private delegate void glDrawElementsInstancedBaseInstanceDelegate(uint mode, int count, uint type, nint indices, int instancecount, uint baseinstance);
		private delegate void glDrawElementsInstancedBaseVertexBaseInstanceDelegate(uint mode, int count, uint type, nint indices, int instancecount, int basevertex, uint baseinstance);
		private delegate UInt64 glGetTextureHandleARBDelegate(uint texture);
		private delegate UInt64 glGetTextureSamplerHandleARBDelegate(uint texture, uint sampler);
		private delegate void glMakeTextureHandleResidentARBDelegate(UInt64 handle);
		private delegate void glMakeTextureHandleNonResidentARBDelegate(UInt64 handle);
		private delegate UInt64 glGetImageHandleARBDelegate(uint texture, int level, bool layered, int layer, uint format);
		private delegate void glMakeImageHandleResidentARBDelegate(UInt64 handle, uint access);
		private delegate void glMakeImageHandleNonResidentARBDelegate(UInt64 handle);
		private delegate void glUniformHandleui64ARBDelegate(int location, UInt64 value);
		private delegate void glUniformHandleui64vARBDelegate(int location, int count, UInt64[] value);
		private delegate void glProgramUniformHandleui64ARBDelegate(uint program, int location, UInt64 value);
		private delegate void glProgramUniformHandleui64vARBDelegate(uint program, int location, int count, UInt64[] values);
		private delegate bool glIsTextureHandleResidentARBDelegate(UInt64 handle);
		private delegate bool glIsImageHandleResidentARBDelegate(UInt64 handle);
		private delegate void glVertexAttribL1ui64ARBDelegate(uint index, UInt64 x);
		private delegate void glVertexAttribL1ui64vARBDelegate(uint index, UInt64[] v);
		private delegate void glGetVertexAttribLui64vARBDelegate(uint index, uint pname, UInt64[] @params);
		private delegate void glBindFragDataLocationIndexedDelegate(uint program, uint colorNumber, uint index, char[] name);
		private delegate int glGetFragDataIndexDelegate(uint program, char[] name);
		private delegate void glBufferStorageDelegate(uint target, nint size, nint data, uint flags);
		private delegate nint glCreateSyncFromCLeventARBDelegate(nint context, nint @event, uint flags);
		private delegate void glClearBufferDataDelegate(uint target, uint internalformat, uint format, uint type, nint data);
		private delegate void glClearBufferSubDataDelegate(uint target, uint internalformat, nint offset, nint size, uint format, uint type, nint data);
		private delegate void glClearTexImageDelegate(uint texture, int level, uint format, uint type, nint data);
		private delegate void glClearTexSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint data);
		private delegate void glClipControlDelegate(uint origin, uint depth);
		private delegate void glClampColorARBDelegate(uint target, uint clamp);
		private delegate void glDispatchComputeDelegate(uint num_groups_x, uint num_groups_y, uint num_groups_z);
		private delegate void glDispatchComputeIndirectDelegate(nint indirect);
		private delegate void glDispatchComputeGroupSizeARBDelegate(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z);
		private delegate void glCopyBufferSubDataDelegate(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size);
		private delegate void glCopyImageSubDataDelegate(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
		private delegate void glDebugMessageControlARBDelegate(uint source, uint type, uint severity, int count, uint[] ids, bool enabled);
		private delegate void glDebugMessageInsertARBDelegate(uint source, uint type, uint id, uint severity, int length, char[] buf);
		private delegate void glDebugMessageCallbackARBDelegate(nint callback, nint userParam);
		private delegate uint glGetDebugMessageLogARBDelegate(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, char[] messageLog);
		private delegate void glCreateTransformFeedbacksDelegate(int n, uint[] ids);
		private delegate void glTransformFeedbackBufferBaseDelegate(uint xfb, uint index, uint buffer);
		private delegate void glTransformFeedbackBufferRangeDelegate(uint xfb, uint index, uint buffer, nint offset, nint size);
		private delegate void glGetTransformFeedbackivDelegate(uint xfb, uint pname, int[] param);
		private delegate void glGetTransformFeedbacki_vDelegate(uint xfb, uint pname, uint index, int[] param);
		private delegate void glGetTransformFeedbacki64_vDelegate(uint xfb, uint pname, uint index, Int64[] param);
		private delegate void glCreateBuffersDelegate(int n, uint[] buffers);
		private delegate void glNamedBufferStorageDelegate(uint buffer, nint size, nint data, uint flags);
		private delegate void glNamedBufferDataDelegate(uint buffer, nint size, nint data, uint usage);
		private delegate void glNamedBufferSubDataDelegate(uint buffer, nint offset, nint size, nint data);
		private delegate void glCopyNamedBufferSubDataDelegate(uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size);
		private delegate void glClearNamedBufferDataDelegate(uint buffer, uint internalformat, uint format, uint type, nint data);
		private delegate void glClearNamedBufferSubDataDelegate(uint buffer, uint internalformat, nint offset, nint size, uint format, uint type, nint data);
		private delegate void glMapNamedBufferDelegate(uint buffer, uint access);
		private delegate void glMapNamedBufferRangeDelegate(uint buffer, nint offset, nint length, uint access);
		private delegate bool glUnmapNamedBufferDelegate(uint buffer);
		private delegate void glFlushMappedNamedBufferRangeDelegate(uint buffer, nint offset, nint length);
		private delegate void glGetNamedBufferParameterivDelegate(uint buffer, uint pname, int[] @params);
		private delegate void glGetNamedBufferParameteri64vDelegate(uint buffer, uint pname, Int64[] @params);
		private delegate void glGetNamedBufferPointervDelegate(uint buffer, uint pname, nint @params);
		private delegate void glGetNamedBufferSubDataDelegate(uint buffer, nint offset, nint size, nint data);
		private delegate void glCreateFramebuffersDelegate(int n, uint[] framebuffers);
		private delegate void glNamedFramebufferRenderbufferDelegate(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private delegate void glNamedFramebufferParameteriDelegate(uint framebuffer, uint pname, int param);
		private delegate void glNamedFramebufferTextureDelegate(uint framebuffer, uint attachment, uint texture, int level);
		private delegate void glNamedFramebufferTextureLayerDelegate(uint framebuffer, uint attachment, uint texture, int level, int layer);
		private delegate void glNamedFramebufferDrawBufferDelegate(uint framebuffer, uint buf);
		private delegate void glNamedFramebufferDrawBuffersDelegate(uint framebuffer, int n, uint[] bufs);
		private delegate void glNamedFramebufferReadBufferDelegate(uint framebuffer, uint src);
		private delegate void glInvalidateNamedFramebufferDataDelegate(uint framebuffer, int numAttachments, uint[] attachments);
		private delegate void glInvalidateNamedFramebufferSubDataDelegate(uint framebuffer, int numAttachments, uint[] attachments, int x, int y, int width, int height);
		private delegate void glClearNamedFramebufferivDelegate(uint framebuffer, uint buffer, int drawbuffer, int[] value);
		private delegate void glClearNamedFramebufferuivDelegate(uint framebuffer, uint buffer, int drawbuffer, uint[] value);
		private delegate void glClearNamedFramebufferfvDelegate(uint framebuffer, uint buffer, int drawbuffer, float[] value);
		private delegate void glClearNamedFramebufferfiDelegate(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);
		private delegate void glBlitNamedFramebufferDelegate(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private delegate uint glCheckNamedFramebufferStatusDelegate(uint framebuffer, uint target);
		private delegate void glGetNamedFramebufferParameterivDelegate(uint framebuffer, uint pname, int[] param);
		private delegate void glGetNamedFramebufferAttachmentParameterivDelegate(uint framebuffer, uint attachment, uint pname, int[] @params);
		private delegate void glCreateRenderbuffersDelegate(int n, uint[] renderbuffers);
		private delegate void glNamedRenderbufferStorageDelegate(uint renderbuffer, uint internalformat, int width, int height);
		private delegate void glNamedRenderbufferStorageMultisampleDelegate(uint renderbuffer, int samples, uint internalformat, int width, int height);
		private delegate void glGetNamedRenderbufferParameterivDelegate(uint renderbuffer, uint pname, int[] @params);
		private delegate void glCreateTexturesDelegate(uint target, int n, uint[] textures);
		private delegate void glTextureBufferDelegate(uint texture, uint internalformat, uint buffer);
		private delegate void glTextureBufferRangeDelegate(uint texture, uint internalformat, uint buffer, nint offset, nint size);
		private delegate void glTextureStorage1DDelegate(uint texture, int levels, uint internalformat, int width);
		private delegate void glTextureStorage2DDelegate(uint texture, int levels, uint internalformat, int width, int height);
		private delegate void glTextureStorage3DDelegate(uint texture, int levels, uint internalformat, int width, int height, int depth);
		private delegate void glTextureStorage2DMultisampleDelegate(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private delegate void glTextureStorage3DMultisampleDelegate(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glTextureSubImage1DDelegate(uint texture, int level, int xoffset, int width, uint format, uint type, nint pixels);
		private delegate void glTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels);
		private delegate void glTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels);
		private delegate void glCompressedTextureSubImage1DDelegate(uint texture, int level, int xoffset, int width, uint format, int imageSize, nint data);
		private delegate void glCompressedTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint data);
		private delegate void glCompressedTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data);
		private delegate void glCopyTextureSubImage1DDelegate(uint texture, int level, int xoffset, int x, int y, int width);
		private delegate void glCopyTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		private delegate void glCopyTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		private delegate void glTextureParameterfDelegate(uint texture, uint pname, float param);
		private delegate void glTextureParameterfvDelegate(uint texture, uint pname, float[] param);
		private delegate void glTextureParameteriDelegate(uint texture, uint pname, int param);
		private delegate void glTextureParameterIivDelegate(uint texture, uint pname, int[] @params);
		private delegate void glTextureParameterIuivDelegate(uint texture, uint pname, uint[] @params);
		private delegate void glTextureParameterivDelegate(uint texture, uint pname, int[] param);
		private delegate void glGenerateTextureMipmapDelegate(uint texture);
		private delegate void glBindTextureUnitDelegate(uint unit, uint texture);
		private delegate void glGetTextureImageDelegate(uint texture, int level, uint format, uint type, int bufSize, nint pixels);
		private delegate void glGetCompressedTextureImageDelegate(uint texture, int level, int bufSize, nint pixels);
		private delegate void glGetTextureLevelParameterfvDelegate(uint texture, int level, uint pname, float[] @params);
		private delegate void glGetTextureLevelParameterivDelegate(uint texture, int level, uint pname, int[] @params);
		private delegate void glGetTextureParameterfvDelegate(uint texture, uint pname, float[] @params);
		private delegate void glGetTextureParameterIivDelegate(uint texture, uint pname, int[] @params);
		private delegate void glGetTextureParameterIuivDelegate(uint texture, uint pname, uint[] @params);
		private delegate void glGetTextureParameterivDelegate(uint texture, uint pname, int[] @params);
		private delegate void glCreateVertexArraysDelegate(int n, uint[] arrays);
		private delegate void glDisableVertexArrayAttribDelegate(uint vaobj, uint index);
		private delegate void glEnableVertexArrayAttribDelegate(uint vaobj, uint index);
		private delegate void glVertexArrayElementBufferDelegate(uint vaobj, uint buffer);
		private delegate void glVertexArrayVertexBufferDelegate(uint vaobj, uint bindingindex, uint buffer, nint offset, int stride);
		private delegate void glVertexArrayVertexBuffersDelegate(uint vaobj, uint first, int count, uint[] buffers, nint offsets, int[] strides);
		private delegate void glVertexArrayAttribBindingDelegate(uint vaobj, uint attribindex, uint bindingindex);
		private delegate void glVertexArrayAttribFormatDelegate(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		private delegate void glVertexArrayAttribIFormatDelegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexArrayAttribLFormatDelegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexArrayBindingDivisorDelegate(uint vaobj, uint bindingindex, uint divisor);
		private delegate void glGetVertexArrayivDelegate(uint vaobj, uint pname, int[] param);
		private delegate void glGetVertexArrayIndexedivDelegate(uint vaobj, uint index, uint pname, int[] param);
		private delegate void glGetVertexArrayIndexed64ivDelegate(uint vaobj, uint index, uint pname, Int64[] param);
		private delegate void glCreateSamplersDelegate(int n, uint[] samplers);
		private delegate void glCreateProgramPipelinesDelegate(int n, uint[] pipelines);
		private delegate void glCreateQueriesDelegate(uint target, int n, uint[] ids);
		private delegate void glGetQueryBufferObjecti64vDelegate(uint id, uint buffer, uint pname, nint offset);
		private delegate void glGetQueryBufferObjectivDelegate(uint id, uint buffer, uint pname, nint offset);
		private delegate void glGetQueryBufferObjectui64vDelegate(uint id, uint buffer, uint pname, nint offset);
		private delegate void glGetQueryBufferObjectuivDelegate(uint id, uint buffer, uint pname, nint offset);
		private delegate void glDrawBuffersARBDelegate(int n, uint[] bufs);
		private delegate void glBlendEquationiARBDelegate(uint buf, uint mode);
		private delegate void glBlendEquationSeparateiARBDelegate(uint buf, uint modeRGB, uint modeAlpha);
		private delegate void glBlendFunciARBDelegate(uint buf, uint src, uint dst);
		private delegate void glBlendFuncSeparateiARBDelegate(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		private delegate void glDrawElementsBaseVertexDelegate(uint mode, int count, uint type, nint indices, int basevertex);
		private delegate void glDrawRangeElementsBaseVertexDelegate(uint mode, uint start, uint end, int count, uint type, nint indices, int basevertex);
		private delegate void glDrawElementsInstancedBaseVertexDelegate(uint mode, int count, uint type, nint indices, int instancecount, int basevertex);
		private delegate void glMultiDrawElementsBaseVertexDelegate(uint mode, int[] count, uint type, nint indices, int drawcount, int[] basevertex);
		private delegate void glDrawArraysIndirectDelegate(uint mode, nint indirect);
		private delegate void glDrawElementsIndirectDelegate(uint mode, uint type, nint indirect);
		private delegate void glDrawArraysInstancedARBDelegate(uint mode, int first, int count, int primcount);
		private delegate void glDrawElementsInstancedARBDelegate(uint mode, int count, uint type, nint indices, int primcount);
		private delegate void glProgramStringARBDelegate(uint target, uint format, int len, nint @string);
		private delegate void glBindProgramARBDelegate(uint target, uint program);
		private delegate void glDeleteProgramsARBDelegate(int n, uint[] programs);
		private delegate void glGenProgramsARBDelegate(int n, uint[] programs);
		private delegate void glProgramEnvParameter4dARBDelegate(uint target, uint index, double x, double y, double z, double w);
		private delegate void glProgramEnvParameter4dvARBDelegate(uint target, uint index, double[] @params);
		private delegate void glProgramEnvParameter4fARBDelegate(uint target, uint index, float x, float y, float z, float w);
		private delegate void glProgramEnvParameter4fvARBDelegate(uint target, uint index, float[] @params);
		private delegate void glProgramLocalParameter4dARBDelegate(uint target, uint index, double x, double y, double z, double w);
		private delegate void glProgramLocalParameter4dvARBDelegate(uint target, uint index, double[] @params);
		private delegate void glProgramLocalParameter4fARBDelegate(uint target, uint index, float x, float y, float z, float w);
		private delegate void glProgramLocalParameter4fvARBDelegate(uint target, uint index, float[] @params);
		private delegate void glGetProgramEnvParameterdvARBDelegate(uint target, uint index, double[] @params);
		private delegate void glGetProgramEnvParameterfvARBDelegate(uint target, uint index, float[] @params);
		private delegate void glGetProgramLocalParameterdvARBDelegate(uint target, uint index, double[] @params);
		private delegate void glGetProgramLocalParameterfvARBDelegate(uint target, uint index, float[] @params);
		private delegate void glGetProgramivARBDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetProgramStringARBDelegate(uint target, uint pname, nint @string);
		private delegate bool glIsProgramARBDelegate(uint program);
		private delegate void glFramebufferParameteriDelegate(uint target, uint pname, int param);
		private delegate void glGetFramebufferParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate bool glIsRenderbufferDelegate(uint renderbuffer);
		private delegate void glBindRenderbufferDelegate(uint target, uint renderbuffer);
		private delegate void glDeleteRenderbuffersDelegate(int n, uint[] renderbuffers);
		private delegate void glGenRenderbuffersDelegate(int n, uint[] renderbuffers);
		private delegate void glRenderbufferStorageDelegate(uint target, uint internalformat, int width, int height);
		private delegate void glGetRenderbufferParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate bool glIsFramebufferDelegate(uint framebuffer);
		private delegate void glBindFramebufferDelegate(uint target, uint framebuffer);
		private delegate void glDeleteFramebuffersDelegate(int n, uint[] framebuffers);
		private delegate void glGenFramebuffersDelegate(int n, uint[] framebuffers);
		private delegate uint glCheckFramebufferStatusDelegate(uint target);
		private delegate void glFramebufferTexture1DDelegate(uint target, uint attachment, uint textarget, uint texture, int level);
		private delegate void glFramebufferTexture2DDelegate(uint target, uint attachment, uint textarget, uint texture, int level);
		private delegate void glFramebufferTexture3DDelegate(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
		private delegate void glFramebufferRenderbufferDelegate(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private delegate void glGetFramebufferAttachmentParameterivDelegate(uint target, uint attachment, uint pname, int[] @params);
		private delegate void glGenerateMipmapDelegate(uint target);
		private delegate void glBlitFramebufferDelegate(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private delegate void glRenderbufferStorageMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height);
		private delegate void glFramebufferTextureLayerDelegate(uint target, uint attachment, uint texture, int level, int layer);
		private delegate void glProgramParameteriARBDelegate(uint program, uint pname, int value);
		private delegate void glFramebufferTextureARBDelegate(uint target, uint attachment, uint texture, int level);
		private delegate void glFramebufferTextureLayerARBDelegate(uint target, uint attachment, uint texture, int level, int layer);
		private delegate void glFramebufferTextureFaceARBDelegate(uint target, uint attachment, uint texture, int level, uint face);
		private delegate void glGetProgramBinaryDelegate(uint program, int bufSize, int[] length, uint[] binaryFormat, nint binary);
		private delegate void glProgramBinaryDelegate(uint program, uint binaryFormat, nint binary, int length);
		private delegate void glProgramParameteriDelegate(uint program, uint pname, int value);
		private delegate void glGetTextureSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, nint pixels);
		private delegate void glGetCompressedTextureSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, nint pixels);
		private delegate void glUniform1dDelegate(int location, double x);
		private delegate void glUniform2dDelegate(int location, double x, double y);
		private delegate void glUniform3dDelegate(int location, double x, double y, double z);
		private delegate void glUniform4dDelegate(int location, double x, double y, double z, double w);
		private delegate void glUniform1dvDelegate(int location, int count, double[] value);
		private delegate void glUniform2dvDelegate(int location, int count, double[] value);
		private delegate void glUniform3dvDelegate(int location, int count, double[] value);
		private delegate void glUniform4dvDelegate(int location, int count, double[] value);
		private delegate void glUniformMatrix2dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix3dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix4dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix2x3dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix2x4dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix3x2dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix3x4dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix4x2dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix4x3dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glGetUniformdvDelegate(uint program, int location, double[] @params);
		private delegate void glUniform1i64ARBDelegate(int location, Int64 x);
		private delegate void glUniform2i64ARBDelegate(int location, Int64 x, Int64 y);
		private delegate void glUniform3i64ARBDelegate(int location, Int64 x, Int64 y, Int64 z);
		private delegate void glUniform4i64ARBDelegate(int location, Int64 x, Int64 y, Int64 z, Int64 w);
		private delegate void glUniform1i64vARBDelegate(int location, int count, Int64[] value);
		private delegate void glUniform2i64vARBDelegate(int location, int count, Int64[] value);
		private delegate void glUniform3i64vARBDelegate(int location, int count, Int64[] value);
		private delegate void glUniform4i64vARBDelegate(int location, int count, Int64[] value);
		private delegate void glUniform1ui64ARBDelegate(int location, UInt64 x);
		private delegate void glUniform2ui64ARBDelegate(int location, UInt64 x, UInt64 y);
		private delegate void glUniform3ui64ARBDelegate(int location, UInt64 x, UInt64 y, UInt64 z);
		private delegate void glUniform4ui64ARBDelegate(int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
		private delegate void glUniform1ui64vARBDelegate(int location, int count, UInt64[] value);
		private delegate void glUniform2ui64vARBDelegate(int location, int count, UInt64[] value);
		private delegate void glUniform3ui64vARBDelegate(int location, int count, UInt64[] value);
		private delegate void glUniform4ui64vARBDelegate(int location, int count, UInt64[] value);
		private delegate void glGetUniformi64vARBDelegate(uint program, int location, Int64[] @params);
		private delegate void glGetUniformui64vARBDelegate(uint program, int location, UInt64[] @params);
		private delegate void glGetnUniformi64vARBDelegate(uint program, int location, int bufSize, Int64[] @params);
		private delegate void glGetnUniformui64vARBDelegate(uint program, int location, int bufSize, UInt64[] @params);
		private delegate void glProgramUniform1i64ARBDelegate(uint program, int location, Int64 x);
		private delegate void glProgramUniform2i64ARBDelegate(uint program, int location, Int64 x, Int64 y);
		private delegate void glProgramUniform3i64ARBDelegate(uint program, int location, Int64 x, Int64 y, Int64 z);
		private delegate void glProgramUniform4i64ARBDelegate(uint program, int location, Int64 x, Int64 y, Int64 z, Int64 w);
		private delegate void glProgramUniform1i64vARBDelegate(uint program, int location, int count, Int64[] value);
		private delegate void glProgramUniform2i64vARBDelegate(uint program, int location, int count, Int64[] value);
		private delegate void glProgramUniform3i64vARBDelegate(uint program, int location, int count, Int64[] value);
		private delegate void glProgramUniform4i64vARBDelegate(uint program, int location, int count, Int64[] value);
		private delegate void glProgramUniform1ui64ARBDelegate(uint program, int location, UInt64 x);
		private delegate void glProgramUniform2ui64ARBDelegate(uint program, int location, UInt64 x, UInt64 y);
		private delegate void glProgramUniform3ui64ARBDelegate(uint program, int location, UInt64 x, UInt64 y, UInt64 z);
		private delegate void glProgramUniform4ui64ARBDelegate(uint program, int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
		private delegate void glProgramUniform1ui64vARBDelegate(uint program, int location, int count, UInt64[] value);
		private delegate void glProgramUniform2ui64vARBDelegate(uint program, int location, int count, UInt64[] value);
		private delegate void glProgramUniform3ui64vARBDelegate(uint program, int location, int count, UInt64[] value);
		private delegate void glProgramUniform4ui64vARBDelegate(uint program, int location, int count, UInt64[] value);
		private delegate void glBlendColorDelegate(float red, float green, float blue, float alpha);
		private delegate void glBlendEquationDelegate(uint mode);
		private delegate void glColorTableDelegate(uint target, uint internalformat, int width, uint format, uint type, nint table);
		private delegate void glColorTableParameterfvDelegate(uint target, uint pname, float[] @params);
		private delegate void glColorTableParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate void glCopyColorTableDelegate(uint target, uint internalformat, int x, int y, int width);
		private delegate void glGetColorTableDelegate(uint target, uint format, uint type, nint table);
		private delegate void glGetColorTableParameterfvDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetColorTableParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate void glColorSubTableDelegate(uint target, int start, int count, uint format, uint type, nint data);
		private delegate void glCopyColorSubTableDelegate(uint target, int start, int x, int y, int width);
		private delegate void glConvolutionFilter1DDelegate(uint target, uint internalformat, int width, uint format, uint type, nint image);
		private delegate void glConvolutionFilter2DDelegate(uint target, uint internalformat, int width, int height, uint format, uint type, nint image);
		private delegate void glConvolutionParameterfDelegate(uint target, uint pname, float @params);
		private delegate void glConvolutionParameterfvDelegate(uint target, uint pname, float[] @params);
		private delegate void glConvolutionParameteriDelegate(uint target, uint pname, int @params);
		private delegate void glConvolutionParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate void glCopyConvolutionFilter1DDelegate(uint target, uint internalformat, int x, int y, int width);
		private delegate void glCopyConvolutionFilter2DDelegate(uint target, uint internalformat, int x, int y, int width, int height);
		private delegate void glGetConvolutionFilterDelegate(uint target, uint format, uint type, nint image);
		private delegate void glGetConvolutionParameterfvDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetConvolutionParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetSeparableFilterDelegate(uint target, uint format, uint type, nint row, nint column, nint span);
		private delegate void glSeparableFilter2DDelegate(uint target, uint internalformat, int width, int height, uint format, uint type, nint row, nint column);
		private delegate void glGetHistogramDelegate(uint target, bool reset, uint format, uint type, nint values);
		private delegate void glGetHistogramParameterfvDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetHistogramParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetMinmaxDelegate(uint target, bool reset, uint format, uint type, nint values);
		private delegate void glGetMinmaxParameterfvDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetMinmaxParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate void glHistogramDelegate(uint target, int width, uint internalformat, bool sink);
		private delegate void glMinmaxDelegate(uint target, uint internalformat, bool sink);
		private delegate void glResetHistogramDelegate(uint target);
		private delegate void glResetMinmaxDelegate(uint target);
		private delegate void glMultiDrawArraysIndirectCountARBDelegate(uint mode, nint indirect, nint drawcount, int maxdrawcount, int stride);
		private delegate void glMultiDrawElementsIndirectCountARBDelegate(uint mode, uint type, nint indirect, nint drawcount, int maxdrawcount, int stride);
		private delegate void glVertexAttribDivisorARBDelegate(uint index, uint divisor);
		private delegate void glGetInternalformativDelegate(uint target, uint internalformat, uint pname, int bufSize, int[] @params);
		private delegate void glGetInternalformati64vDelegate(uint target, uint internalformat, uint pname, int bufSize, Int64[] @params);
		private delegate void glInvalidateTexSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
		private delegate void glInvalidateTexImageDelegate(uint texture, int level);
		private delegate void glInvalidateBufferSubDataDelegate(uint buffer, nint offset, nint length);
		private delegate void glInvalidateBufferDataDelegate(uint buffer);
		private delegate void glInvalidateFramebufferDelegate(uint target, int numAttachments, uint[] attachments);
		private delegate void glInvalidateSubFramebufferDelegate(uint target, int numAttachments, uint[] attachments, int x, int y, int width, int height);
		private delegate void glMapBufferRangeDelegate(uint target, nint offset, nint length, uint access);
		private delegate void glFlushMappedBufferRangeDelegate(uint target, nint offset, nint length);
		private delegate void glCurrentPaletteMatrixARBDelegate(int index);
		private delegate void glMatrixIndexubvARBDelegate(int size, byte[] indices);
		private delegate void glMatrixIndexusvARBDelegate(int size, ushort[] indices);
		private delegate void glMatrixIndexuivARBDelegate(int size, uint[] indices);
		private delegate void glMatrixIndexPointerARBDelegate(int size, uint type, int stride, nint pointer);
		private delegate void glBindBuffersBaseDelegate(uint target, uint first, int count, uint[] buffers);
		private delegate void glBindBuffersRangeDelegate(uint target, uint first, int count, uint[] buffers, nint offsets, nint sizes);
		private delegate void glBindTexturesDelegate(uint first, int count, uint[] textures);
		private delegate void glBindSamplersDelegate(uint first, int count, uint[] samplers);
		private delegate void glBindImageTexturesDelegate(uint first, int count, uint[] textures);
		private delegate void glBindVertexBuffersDelegate(uint first, int count, uint[] buffers, nint offsets, int[] strides);
		private delegate void glMultiDrawArraysIndirectDelegate(uint mode, nint indirect, int drawcount, int stride);
		private delegate void glMultiDrawElementsIndirectDelegate(uint mode, uint type, nint indirect, int drawcount, int stride);
		private delegate void glSampleCoverageARBDelegate(float value, bool invert);
		private delegate void glActiveTextureARBDelegate(uint texture);
		private delegate void glClientActiveTextureARBDelegate(uint texture);
		private delegate void glMultiTexCoord1dARBDelegate(uint target, double s);
		private delegate void glMultiTexCoord1dvARBDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord1fARBDelegate(uint target, float s);
		private delegate void glMultiTexCoord1fvARBDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord1iARBDelegate(uint target, int s);
		private delegate void glMultiTexCoord1ivARBDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord1sARBDelegate(uint target, short s);
		private delegate void glMultiTexCoord1svARBDelegate(uint target, short[] v);
		private delegate void glMultiTexCoord2dARBDelegate(uint target, double s, double t);
		private delegate void glMultiTexCoord2dvARBDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord2fARBDelegate(uint target, float s, float t);
		private delegate void glMultiTexCoord2fvARBDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord2iARBDelegate(uint target, int s, int t);
		private delegate void glMultiTexCoord2ivARBDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord2sARBDelegate(uint target, short s, short t);
		private delegate void glMultiTexCoord2svARBDelegate(uint target, short[] v);
		private delegate void glMultiTexCoord3dARBDelegate(uint target, double s, double t, double r);
		private delegate void glMultiTexCoord3dvARBDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord3fARBDelegate(uint target, float s, float t, float r);
		private delegate void glMultiTexCoord3fvARBDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord3iARBDelegate(uint target, int s, int t, int r);
		private delegate void glMultiTexCoord3ivARBDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord3sARBDelegate(uint target, short s, short t, short r);
		private delegate void glMultiTexCoord3svARBDelegate(uint target, short[] v);
		private delegate void glMultiTexCoord4dARBDelegate(uint target, double s, double t, double r, double q);
		private delegate void glMultiTexCoord4dvARBDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord4fARBDelegate(uint target, float s, float t, float r, float q);
		private delegate void glMultiTexCoord4fvARBDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord4iARBDelegate(uint target, int s, int t, int r, int q);
		private delegate void glMultiTexCoord4ivARBDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord4sARBDelegate(uint target, short s, short t, short r, short q);
		private delegate void glMultiTexCoord4svARBDelegate(uint target, short[] v);
		private delegate void glGenQueriesARBDelegate(int n, uint[] ids);
		private delegate void glDeleteQueriesARBDelegate(int n, uint[] ids);
		private delegate bool glIsQueryARBDelegate(uint id);
		private delegate void glBeginQueryARBDelegate(uint target, uint id);
		private delegate void glEndQueryARBDelegate(uint target);
		private delegate void glGetQueryivARBDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetQueryObjectivARBDelegate(uint id, uint pname, int[] @params);
		private delegate void glGetQueryObjectuivARBDelegate(uint id, uint pname, uint[] @params);
		private delegate void glMaxShaderCompilerThreadsARBDelegate(uint count);
		private delegate void glPointParameterfARBDelegate(uint pname, float param);
		private delegate void glPointParameterfvARBDelegate(uint pname, float[] @params);
		private delegate void glGetProgramInterfaceivDelegate(uint program, uint programInterface, uint pname, int[] @params);
		private delegate uint glGetProgramResourceIndexDelegate(uint program, uint programInterface, char[] name);
		private delegate void glGetProgramResourceNameDelegate(uint program, uint programInterface, uint index, int bufSize, int[] length, char[] name);
		private delegate void glGetProgramResourceivDelegate(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, int[] @params);
		private delegate int glGetProgramResourceLocationDelegate(uint program, uint programInterface, char[] name);
		private delegate int glGetProgramResourceLocationIndexDelegate(uint program, uint programInterface, char[] name);
		private delegate void glProvokingVertexDelegate(uint mode);
		private delegate uint glGetGraphicsResetStatusARBDelegate();
		private delegate void glGetnTexImageARBDelegate(uint target, int level, uint format, uint type, int bufSize, nint img);
		private delegate void glReadnPixelsARBDelegate(int x, int y, int width, int height, uint format, uint type, int bufSize, nint data);
		private delegate void glGetnCompressedTexImageARBDelegate(uint target, int lod, int bufSize, nint img);
		private delegate void glGetnUniformfvARBDelegate(uint program, int location, int bufSize, float[] @params);
		private delegate void glGetnUniformivARBDelegate(uint program, int location, int bufSize, int[] @params);
		private delegate void glGetnUniformuivARBDelegate(uint program, int location, int bufSize, uint[] @params);
		private delegate void glGetnUniformdvARBDelegate(uint program, int location, int bufSize, double[] @params);
		private delegate void glGetnMapdvARBDelegate(uint target, uint query, int bufSize, double[] v);
		private delegate void glGetnMapfvARBDelegate(uint target, uint query, int bufSize, float[] v);
		private delegate void glGetnMapivARBDelegate(uint target, uint query, int bufSize, int[] v);
		private delegate void glGetnPixelMapfvARBDelegate(uint map, int bufSize, float[] values);
		private delegate void glGetnPixelMapuivARBDelegate(uint map, int bufSize, uint[] values);
		private delegate void glGetnPixelMapusvARBDelegate(uint map, int bufSize, ushort[] values);
		private delegate void glGetnPolygonStippleARBDelegate(int bufSize, byte[] pattern);
		private delegate void glGetnColorTableARBDelegate(uint target, uint format, uint type, int bufSize, nint table);
		private delegate void glGetnConvolutionFilterARBDelegate(uint target, uint format, uint type, int bufSize, nint image);
		private delegate void glGetnSeparableFilterARBDelegate(uint target, uint format, uint type, int rowBufSize, nint row, int columnBufSize, nint column, nint span);
		private delegate void glGetnHistogramARBDelegate(uint target, bool reset, uint format, uint type, int bufSize, nint values);
		private delegate void glGetnMinmaxARBDelegate(uint target, bool reset, uint format, uint type, int bufSize, nint values);
		private delegate void glFramebufferSampleLocationsfvARBDelegate(uint target, uint start, int count, float[] v);
		private delegate void glNamedFramebufferSampleLocationsfvARBDelegate(uint framebuffer, uint start, int count, float[] v);
		private delegate void glEvaluateDepthValuesARBDelegate();
		private delegate void glMinSampleShadingARBDelegate(float value);
		private delegate void glGenSamplersDelegate(int count, uint[] samplers);
		private delegate void glDeleteSamplersDelegate(int count, uint[] samplers);
		private delegate bool glIsSamplerDelegate(uint sampler);
		private delegate void glBindSamplerDelegate(uint unit, uint sampler);
		private delegate void glSamplerParameteriDelegate(uint sampler, uint pname, int param);
		private delegate void glSamplerParameterivDelegate(uint sampler, uint pname, int[] param);
		private delegate void glSamplerParameterfDelegate(uint sampler, uint pname, float param);
		private delegate void glSamplerParameterfvDelegate(uint sampler, uint pname, float[] param);
		private delegate void glSamplerParameterIivDelegate(uint sampler, uint pname, int[] param);
		private delegate void glSamplerParameterIuivDelegate(uint sampler, uint pname, uint[] param);
		private delegate void glGetSamplerParameterivDelegate(uint sampler, uint pname, int[] @params);
		private delegate void glGetSamplerParameterIivDelegate(uint sampler, uint pname, int[] @params);
		private delegate void glGetSamplerParameterfvDelegate(uint sampler, uint pname, float[] @params);
		private delegate void glGetSamplerParameterIuivDelegate(uint sampler, uint pname, uint[] @params);
		private delegate void glUseProgramStagesDelegate(uint pipeline, uint stages, uint program);
		private delegate void glActiveShaderProgramDelegate(uint pipeline, uint program);
		private delegate uint glCreateShaderProgramvDelegate(uint type, int count, char[] strings);
		private delegate void glBindProgramPipelineDelegate(uint pipeline);
		private delegate void glDeleteProgramPipelinesDelegate(int n, uint[] pipelines);
		private delegate void glGenProgramPipelinesDelegate(int n, uint[] pipelines);
		private delegate bool glIsProgramPipelineDelegate(uint pipeline);
		private delegate void glGetProgramPipelineivDelegate(uint pipeline, uint pname, int[] @params);
		private delegate void glProgramUniform1iDelegate(uint program, int location, int v0);
		private delegate void glProgramUniform1ivDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform1fDelegate(uint program, int location, float v0);
		private delegate void glProgramUniform1fvDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform1dDelegate(uint program, int location, double v0);
		private delegate void glProgramUniform1dvDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform1uiDelegate(uint program, int location, uint v0);
		private delegate void glProgramUniform1uivDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniform2iDelegate(uint program, int location, int v0, int v1);
		private delegate void glProgramUniform2ivDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform2fDelegate(uint program, int location, float v0, float v1);
		private delegate void glProgramUniform2fvDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform2dDelegate(uint program, int location, double v0, double v1);
		private delegate void glProgramUniform2dvDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform2uiDelegate(uint program, int location, uint v0, uint v1);
		private delegate void glProgramUniform2uivDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniform3iDelegate(uint program, int location, int v0, int v1, int v2);
		private delegate void glProgramUniform3ivDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform3fDelegate(uint program, int location, float v0, float v1, float v2);
		private delegate void glProgramUniform3fvDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform3dDelegate(uint program, int location, double v0, double v1, double v2);
		private delegate void glProgramUniform3dvDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform3uiDelegate(uint program, int location, uint v0, uint v1, uint v2);
		private delegate void glProgramUniform3uivDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniform4iDelegate(uint program, int location, int v0, int v1, int v2, int v3);
		private delegate void glProgramUniform4ivDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform4fDelegate(uint program, int location, float v0, float v1, float v2, float v3);
		private delegate void glProgramUniform4fvDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform4dDelegate(uint program, int location, double v0, double v1, double v2, double v3);
		private delegate void glProgramUniform4dvDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform4uiDelegate(uint program, int location, uint v0, uint v1, uint v2, uint v3);
		private delegate void glProgramUniform4uivDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniformMatrix2fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix2x3fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3x2fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2x4fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4x2fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3x4fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4x3fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2x3dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3x2dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix2x4dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4x2dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3x4dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4x3dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glValidateProgramPipelineDelegate(uint pipeline);
		private delegate void glGetProgramPipelineInfoLogDelegate(uint pipeline, int bufSize, int[] length, char[] infoLog);
		private delegate void glGetActiveAtomicCounterBufferivDelegate(uint program, uint bufferIndex, uint pname, int[] @params);
		private delegate void glBindImageTextureDelegate(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);
		private delegate void glMemoryBarrierDelegate(uint barriers);
		private delegate void glDeleteObjectARBDelegate(nint obj);
		private delegate nint glGetHandleARBDelegate(uint pname);
		private delegate void glDetachObjectARBDelegate(nint containerObj, nint attachedObj);
		private delegate nint glCreateShaderObjectARBDelegate(uint shaderType);
		private delegate void glShaderSourceARBDelegate(nint shaderObj, int count, char[] @string, int[] length);
		private delegate void glCompileShaderARBDelegate(nint shaderObj);
		private delegate nint glCreateProgramObjectARBDelegate();
		private delegate void glAttachObjectARBDelegate(nint containerObj, nint obj);
		private delegate void glLinkProgramARBDelegate(nint programObj);
		private delegate void glUseProgramObjectARBDelegate(nint programObj);
		private delegate void glValidateProgramARBDelegate(nint programObj);
		private delegate void glUniform1fARBDelegate(int location, float v0);
		private delegate void glUniform2fARBDelegate(int location, float v0, float v1);
		private delegate void glUniform3fARBDelegate(int location, float v0, float v1, float v2);
		private delegate void glUniform4fARBDelegate(int location, float v0, float v1, float v2, float v3);
		private delegate void glUniform1iARBDelegate(int location, int v0);
		private delegate void glUniform2iARBDelegate(int location, int v0, int v1);
		private delegate void glUniform3iARBDelegate(int location, int v0, int v1, int v2);
		private delegate void glUniform4iARBDelegate(int location, int v0, int v1, int v2, int v3);
		private delegate void glUniform1fvARBDelegate(int location, int count, float[] value);
		private delegate void glUniform2fvARBDelegate(int location, int count, float[] value);
		private delegate void glUniform3fvARBDelegate(int location, int count, float[] value);
		private delegate void glUniform4fvARBDelegate(int location, int count, float[] value);
		private delegate void glUniform1ivARBDelegate(int location, int count, int[] value);
		private delegate void glUniform2ivARBDelegate(int location, int count, int[] value);
		private delegate void glUniform3ivARBDelegate(int location, int count, int[] value);
		private delegate void glUniform4ivARBDelegate(int location, int count, int[] value);
		private delegate void glUniformMatrix2fvARBDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix3fvARBDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix4fvARBDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glGetObjectParameterfvARBDelegate(nint obj, uint pname, float[] @params);
		private delegate void glGetObjectParameterivARBDelegate(nint obj, uint pname, int[] @params);
		private delegate void glGetInfoLogARBDelegate(nint obj, int maxLength, int[] length, char[] infoLog);
		private delegate void glGetAttachedObjectsARBDelegate(nint containerObj, int maxCount, int[] count, nint obj);
		private delegate int glGetUniformLocationARBDelegate(nint programObj, char[] name);
		private delegate void glGetActiveUniformARBDelegate(nint programObj, uint index, int maxLength, int[] length, int[] size, uint[] type, char[] name);
		private delegate void glGetUniformfvARBDelegate(nint programObj, int location, float[] @params);
		private delegate void glGetUniformivARBDelegate(nint programObj, int location, int[] @params);
		private delegate void glGetShaderSourceARBDelegate(nint obj, int maxLength, int[] length, char[] source);
		private delegate void glShaderStorageBlockBindingDelegate(uint program, uint storageBlockIndex, uint storageBlockBinding);
		private delegate int glGetSubroutineUniformLocationDelegate(uint program, uint shadertype, char[] name);
		private delegate uint glGetSubroutineIndexDelegate(uint program, uint shadertype, char[] name);
		private delegate void glGetActiveSubroutineUniformivDelegate(uint program, uint shadertype, uint index, uint pname, int[] values);
		private delegate void glGetActiveSubroutineUniformNameDelegate(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name);
		private delegate void glGetActiveSubroutineNameDelegate(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name);
		private delegate void glUniformSubroutinesuivDelegate(uint shadertype, int count, uint[] indices);
		private delegate void glGetUniformSubroutineuivDelegate(uint shadertype, int location, uint[] @params);
		private delegate void glGetProgramStageivDelegate(uint program, uint shadertype, uint pname, int[] values);
		private delegate void glNamedStringARBDelegate(uint type, int namelen, char[] name, int stringlen, char[] @string);
		private delegate void glDeleteNamedStringARBDelegate(int namelen, char[] name);
		private delegate void glCompileShaderIncludeARBDelegate(uint shader, int count, char[] path, int[] length);
		private delegate bool glIsNamedStringARBDelegate(int namelen, char[] name);
		private delegate void glGetNamedStringARBDelegate(int namelen, char[] name, int bufSize, int[] stringlen, char[] @string);
		private delegate void glGetNamedStringivARBDelegate(int namelen, char[] name, uint pname, int[] @params);
		private delegate void glBufferPageCommitmentARBDelegate(uint target, nint offset, nint size, bool commit);
		private delegate void glNamedBufferPageCommitmentEXTDelegate(uint buffer, nint offset, nint size, bool commit);
		private delegate void glNamedBufferPageCommitmentARBDelegate(uint buffer, nint offset, nint size, bool commit);
		private delegate void glTexPageCommitmentARBDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit);
		private delegate nint glFenceSyncDelegate(uint condition, uint flags);
		private delegate bool glIsSyncDelegate(nint sync);
		private delegate void glDeleteSyncDelegate(nint sync);
		private delegate uint glClientWaitSyncDelegate(nint sync, uint flags, UInt64 timeout);
		private delegate void glWaitSyncDelegate(nint sync, uint flags, UInt64 timeout);
		private delegate void glGetInteger64vDelegate(uint pname, Int64[] data);
		private delegate void glGetSyncivDelegate(nint sync, uint pname, int bufSize, int[] length, int[] values);
		private delegate void glPatchParameteriDelegate(uint pname, int value);
		private delegate void glPatchParameterfvDelegate(uint pname, float[] values);
		private delegate void glTextureBarrierDelegate();
		private delegate void glTexBufferARBDelegate(uint target, uint internalformat, uint buffer);
		private delegate void glTexBufferRangeDelegate(uint target, uint internalformat, uint buffer, nint offset, nint size);
		private delegate void glCompressedTexImage3DARBDelegate(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint data);
		private delegate void glCompressedTexImage2DARBDelegate(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, nint data);
		private delegate void glCompressedTexImage1DARBDelegate(uint target, int level, uint internalformat, int width, int border, int imageSize, nint data);
		private delegate void glCompressedTexSubImage3DARBDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data);
		private delegate void glCompressedTexSubImage2DARBDelegate(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint data);
		private delegate void glCompressedTexSubImage1DARBDelegate(uint target, int level, int xoffset, int width, uint format, int imageSize, nint data);
		private delegate void glGetCompressedTexImageARBDelegate(uint target, int level, nint img);
		private delegate void glTexImage2DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private delegate void glTexImage3DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glGetMultisamplefvDelegate(uint pname, uint index, float[] val);
		private delegate void glSampleMaskiDelegate(uint maskNumber, uint mask);
		private delegate void glTexStorage1DDelegate(uint target, int levels, uint internalformat, int width);
		private delegate void glTexStorage2DDelegate(uint target, int levels, uint internalformat, int width, int height);
		private delegate void glTexStorage3DDelegate(uint target, int levels, uint internalformat, int width, int height, int depth);
		private delegate void glTexStorage2DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private delegate void glTexStorage3DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glTextureViewDelegate(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
		private delegate void glQueryCounterDelegate(uint id, uint target);
		private delegate void glGetQueryObjecti64vDelegate(uint id, uint pname, Int64[] @params);
		private delegate void glGetQueryObjectui64vDelegate(uint id, uint pname, UInt64[] @params);
		private delegate void glBindTransformFeedbackDelegate(uint target, uint id);
		private delegate void glDeleteTransformFeedbacksDelegate(int n, uint[] ids);
		private delegate void glGenTransformFeedbacksDelegate(int n, uint[] ids);
		private delegate bool glIsTransformFeedbackDelegate(uint id);
		private delegate void glPauseTransformFeedbackDelegate();
		private delegate void glResumeTransformFeedbackDelegate();
		private delegate void glDrawTransformFeedbackDelegate(uint mode, uint id);
		private delegate void glDrawTransformFeedbackStreamDelegate(uint mode, uint id, uint stream);
		private delegate void glBeginQueryIndexedDelegate(uint target, uint index, uint id);
		private delegate void glEndQueryIndexedDelegate(uint target, uint index);
		private delegate void glGetQueryIndexedivDelegate(uint target, uint index, uint pname, int[] @params);
		private delegate void glDrawTransformFeedbackInstancedDelegate(uint mode, uint id, int instancecount);
		private delegate void glDrawTransformFeedbackStreamInstancedDelegate(uint mode, uint id, uint stream, int instancecount);
		private delegate void glLoadTransposeMatrixfARBDelegate(float[] m);
		private delegate void glLoadTransposeMatrixdARBDelegate(double[] m);
		private delegate void glMultTransposeMatrixfARBDelegate(float[] m);
		private delegate void glMultTransposeMatrixdARBDelegate(double[] m);
		private delegate void glGetUniformIndicesDelegate(uint program, int uniformCount, char[] uniformNames, uint[] uniformIndices);
		private delegate void glGetActiveUniformsivDelegate(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] @params);
		private delegate void glGetActiveUniformNameDelegate(uint program, uint uniformIndex, int bufSize, int[] length, char[] uniformName);
		private delegate uint glGetUniformBlockIndexDelegate(uint program, char[] uniformBlockName);
		private delegate void glGetActiveUniformBlockivDelegate(uint program, uint uniformBlockIndex, uint pname, int[] @params);
		private delegate void glGetActiveUniformBlockNameDelegate(uint program, uint uniformBlockIndex, int bufSize, int[] length, char[] uniformBlockName);
		private delegate void glUniformBlockBindingDelegate(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
		private delegate void glBindBufferRangeDelegate(uint target, uint index, uint buffer, nint offset, nint size);
		private delegate void glBindBufferBaseDelegate(uint target, uint index, uint buffer);
		private delegate void glGetIntegeri_vDelegate(uint target, uint index, int[] data);
		private delegate void glBindVertexArrayDelegate(uint array);
		private delegate void glDeleteVertexArraysDelegate(int n, uint[] arrays);
		private delegate void glGenVertexArraysDelegate(int n, uint[] arrays);
		private delegate bool glIsVertexArrayDelegate(uint array);
		private delegate void glVertexAttribL1dDelegate(uint index, double x);
		private delegate void glVertexAttribL2dDelegate(uint index, double x, double y);
		private delegate void glVertexAttribL3dDelegate(uint index, double x, double y, double z);
		private delegate void glVertexAttribL4dDelegate(uint index, double x, double y, double z, double w);
		private delegate void glVertexAttribL1dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribL2dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribL3dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribL4dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribLPointerDelegate(uint index, int size, uint type, int stride, nint pointer);
		private delegate void glGetVertexAttribLdvDelegate(uint index, uint pname, double[] @params);
		private delegate void glBindVertexBufferDelegate(uint bindingindex, uint buffer, nint offset, int stride);
		private delegate void glVertexAttribFormatDelegate(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		private delegate void glVertexAttribIFormatDelegate(uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexAttribLFormatDelegate(uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexAttribBindingDelegate(uint attribindex, uint bindingindex);
		private delegate void glVertexBindingDivisorDelegate(uint bindingindex, uint divisor);
		private delegate void glWeightbvARBDelegate(int size, byte[] weights);
		private delegate void glWeightsvARBDelegate(int size, short[] weights);
		private delegate void glWeightivARBDelegate(int size, int[] weights);
		private delegate void glWeightfvARBDelegate(int size, float[] weights);
		private delegate void glWeightdvARBDelegate(int size, double[] weights);
		private delegate void glWeightubvARBDelegate(int size, byte[] weights);
		private delegate void glWeightusvARBDelegate(int size, ushort[] weights);
		private delegate void glWeightuivARBDelegate(int size, uint[] weights);
		private delegate void glWeightPointerARBDelegate(int size, uint type, int stride, nint pointer);
		private delegate void glVertexBlendARBDelegate(int count);
		private delegate void glBindBufferARBDelegate(uint target, uint buffer);
		private delegate void glDeleteBuffersARBDelegate(int n, uint[] buffers);
		private delegate void glGenBuffersARBDelegate(int n, uint[] buffers);
		private delegate bool glIsBufferARBDelegate(uint buffer);
		private delegate void glBufferDataARBDelegate(uint target, nint size, nint data, uint usage);
		private delegate void glBufferSubDataARBDelegate(uint target, nint offset, nint size, nint data);
		private delegate void glGetBufferSubDataARBDelegate(uint target, nint offset, nint size, nint data);
		private delegate void glMapBufferARBDelegate(uint target, uint access);
		private delegate bool glUnmapBufferARBDelegate(uint target);
		private delegate void glGetBufferParameterivARBDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetBufferPointervARBDelegate(uint target, uint pname, nint @params);
		private delegate void glVertexAttrib1dARBDelegate(uint index, double x);
		private delegate void glVertexAttrib1dvARBDelegate(uint index, double[] v);
		private delegate void glVertexAttrib1fARBDelegate(uint index, float x);
		private delegate void glVertexAttrib1fvARBDelegate(uint index, float[] v);
		private delegate void glVertexAttrib1sARBDelegate(uint index, short x);
		private delegate void glVertexAttrib1svARBDelegate(uint index, short[] v);
		private delegate void glVertexAttrib2dARBDelegate(uint index, double x, double y);
		private delegate void glVertexAttrib2dvARBDelegate(uint index, double[] v);
		private delegate void glVertexAttrib2fARBDelegate(uint index, float x, float y);
		private delegate void glVertexAttrib2fvARBDelegate(uint index, float[] v);
		private delegate void glVertexAttrib2sARBDelegate(uint index, short x, short y);
		private delegate void glVertexAttrib2svARBDelegate(uint index, short[] v);
		private delegate void glVertexAttrib3dARBDelegate(uint index, double x, double y, double z);
		private delegate void glVertexAttrib3dvARBDelegate(uint index, double[] v);
		private delegate void glVertexAttrib3fARBDelegate(uint index, float x, float y, float z);
		private delegate void glVertexAttrib3fvARBDelegate(uint index, float[] v);
		private delegate void glVertexAttrib3sARBDelegate(uint index, short x, short y, short z);
		private delegate void glVertexAttrib3svARBDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4NbvARBDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4NivARBDelegate(uint index, int[] v);
		private delegate void glVertexAttrib4NsvARBDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4NubARBDelegate(uint index, byte x, byte y, byte z, byte w);
		private delegate void glVertexAttrib4NubvARBDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4NuivARBDelegate(uint index, uint[] v);
		private delegate void glVertexAttrib4NusvARBDelegate(uint index, ushort[] v);
		private delegate void glVertexAttrib4bvARBDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4dARBDelegate(uint index, double x, double y, double z, double w);
		private delegate void glVertexAttrib4dvARBDelegate(uint index, double[] v);
		private delegate void glVertexAttrib4fARBDelegate(uint index, float x, float y, float z, float w);
		private delegate void glVertexAttrib4fvARBDelegate(uint index, float[] v);
		private delegate void glVertexAttrib4ivARBDelegate(uint index, int[] v);
		private delegate void glVertexAttrib4sARBDelegate(uint index, short x, short y, short z, short w);
		private delegate void glVertexAttrib4svARBDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4ubvARBDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4uivARBDelegate(uint index, uint[] v);
		private delegate void glVertexAttrib4usvARBDelegate(uint index, ushort[] v);
		private delegate void glVertexAttribPointerARBDelegate(uint index, int size, uint type, bool normalized, int stride, nint pointer);
		private delegate void glEnableVertexAttribArrayARBDelegate(uint index);
		private delegate void glDisableVertexAttribArrayARBDelegate(uint index);
		private delegate void glGetVertexAttribdvARBDelegate(uint index, uint pname, double[] @params);
		private delegate void glGetVertexAttribfvARBDelegate(uint index, uint pname, float[] @params);
		private delegate void glGetVertexAttribivARBDelegate(uint index, uint pname, int[] @params);
		private delegate void glGetVertexAttribPointervARBDelegate(uint index, uint pname, nint pointer);
		private delegate void glBindAttribLocationARBDelegate(nint programObj, uint index, char[] name);
		private delegate void glGetActiveAttribARBDelegate(nint programObj, uint index, int maxLength, int[] length, int[] size, uint[] type, char[] name);
		private delegate int glGetAttribLocationARBDelegate(nint programObj, char[] name);
		private delegate void glVertexAttribP1uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP1uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexAttribP2uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP2uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexAttribP3uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP3uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexAttribP4uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP4uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexP2uiDelegate(uint type, uint value);
		private delegate void glVertexP2uivDelegate(uint type, uint[] value);
		private delegate void glVertexP3uiDelegate(uint type, uint value);
		private delegate void glVertexP3uivDelegate(uint type, uint[] value);
		private delegate void glVertexP4uiDelegate(uint type, uint value);
		private delegate void glVertexP4uivDelegate(uint type, uint[] value);
		private delegate void glTexCoordP1uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP1uivDelegate(uint type, uint[] coords);
		private delegate void glTexCoordP2uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP2uivDelegate(uint type, uint[] coords);
		private delegate void glTexCoordP3uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP3uivDelegate(uint type, uint[] coords);
		private delegate void glTexCoordP4uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP4uivDelegate(uint type, uint[] coords);
		private delegate void glMultiTexCoordP1uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP1uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glMultiTexCoordP2uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP2uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glMultiTexCoordP3uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP3uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glMultiTexCoordP4uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP4uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glNormalP3uiDelegate(uint type, uint coords);
		private delegate void glNormalP3uivDelegate(uint type, uint[] coords);
		private delegate void glColorP3uiDelegate(uint type, uint color);
		private delegate void glColorP3uivDelegate(uint type, uint[] color);
		private delegate void glColorP4uiDelegate(uint type, uint color);
		private delegate void glColorP4uivDelegate(uint type, uint[] color);
		private delegate void glSecondaryColorP3uiDelegate(uint type, uint color);
		private delegate void glSecondaryColorP3uivDelegate(uint type, uint[] color);
		private delegate void glViewportArrayvDelegate(uint first, int count, float[] v);
		private delegate void glViewportIndexedfDelegate(uint index, float x, float y, float w, float h);
		private delegate void glViewportIndexedfvDelegate(uint index, float[] v);
		private delegate void glScissorArrayvDelegate(uint first, int count, int[] v);
		private delegate void glScissorIndexedDelegate(uint index, int left, int bottom, int width, int height);
		private delegate void glScissorIndexedvDelegate(uint index, int[] v);
		private delegate void glDepthRangeArrayvDelegate(uint first, int count, double[] v);
		private delegate void glDepthRangeIndexedDelegate(uint index, double n, double f);
		private delegate void glGetFloati_vDelegate(uint target, uint index, float[] data);
		private delegate void glGetDoublei_vDelegate(uint target, uint index, double[] data);
		private delegate void glWindowPos2dARBDelegate(double x, double y);
		private delegate void glWindowPos2dvARBDelegate(double[] v);
		private delegate void glWindowPos2fARBDelegate(float x, float y);
		private delegate void glWindowPos2fvARBDelegate(float[] v);
		private delegate void glWindowPos2iARBDelegate(int x, int y);
		private delegate void glWindowPos2ivARBDelegate(int[] v);
		private delegate void glWindowPos2sARBDelegate(short x, short y);
		private delegate void glWindowPos2svARBDelegate(short[] v);
		private delegate void glWindowPos3dARBDelegate(double x, double y, double z);
		private delegate void glWindowPos3dvARBDelegate(double[] v);
		private delegate void glWindowPos3fARBDelegate(float x, float y, float z);
		private delegate void glWindowPos3fvARBDelegate(float[] v);
		private delegate void glWindowPos3iARBDelegate(int x, int y, int z);
		private delegate void glWindowPos3ivARBDelegate(int[] v);
		private delegate void glWindowPos3sARBDelegate(short x, short y, short z);
		private delegate void glWindowPos3svARBDelegate(short[] v);
		private delegate void glDrawBuffersATIDelegate(int n, uint[] bufs);
		private delegate void glElementPointerATIDelegate(uint type, nint pointer);
		private delegate void glDrawElementArrayATIDelegate(uint mode, int count);
		private delegate void glDrawRangeElementArrayATIDelegate(uint mode, uint start, uint end, int count);
		private delegate void glTexBumpParameterivATIDelegate(uint pname, int[] param);
		private delegate void glTexBumpParameterfvATIDelegate(uint pname, float[] param);
		private delegate void glGetTexBumpParameterivATIDelegate(uint pname, int[] param);
		private delegate void glGetTexBumpParameterfvATIDelegate(uint pname, float[] param);
		private delegate uint glGenFragmentShadersATIDelegate(uint range);
		private delegate void glBindFragmentShaderATIDelegate(uint id);
		private delegate void glDeleteFragmentShaderATIDelegate(uint id);
		private delegate void glBeginFragmentShaderATIDelegate();
		private delegate void glEndFragmentShaderATIDelegate();
		private delegate void glPassTexCoordATIDelegate(uint dst, uint coord, uint swizzle);
		private delegate void glSampleMapATIDelegate(uint dst, uint interp, uint swizzle);
		private delegate void glColorFragmentOp1ATIDelegate(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
		private delegate void glColorFragmentOp2ATIDelegate(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
		private delegate void glColorFragmentOp3ATIDelegate(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
		private delegate void glAlphaFragmentOp1ATIDelegate(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
		private delegate void glAlphaFragmentOp2ATIDelegate(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
		private delegate void glAlphaFragmentOp3ATIDelegate(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
		private delegate void glSetFragmentShaderConstantATIDelegate(uint dst, float[] value);
		private delegate void glMapObjectBufferATIDelegate(uint buffer);
		private delegate void glUnmapObjectBufferATIDelegate(uint buffer);
		private delegate void glPNTrianglesiATIDelegate(uint pname, int param);
		private delegate void glPNTrianglesfATIDelegate(uint pname, float param);
		private delegate void glStencilOpSeparateATIDelegate(uint face, uint sfail, uint dpfail, uint dppass);
		private delegate void glStencilFuncSeparateATIDelegate(uint frontfunc, uint backfunc, int @ref, uint mask);
		private delegate uint glNewObjectBufferATIDelegate(int size, nint pointer, uint usage);
		private delegate bool glIsObjectBufferATIDelegate(uint buffer);
		private delegate void glUpdateObjectBufferATIDelegate(uint buffer, uint offset, int size, nint pointer, uint preserve);
		private delegate void glGetObjectBufferfvATIDelegate(uint buffer, uint pname, float[] @params);
		private delegate void glGetObjectBufferivATIDelegate(uint buffer, uint pname, int[] @params);
		private delegate void glFreeObjectBufferATIDelegate(uint buffer);
		private delegate void glArrayObjectATIDelegate(uint array, int size, uint type, int stride, uint buffer, uint offset);
		private delegate void glGetArrayObjectfvATIDelegate(uint array, uint pname, float[] @params);
		private delegate void glGetArrayObjectivATIDelegate(uint array, uint pname, int[] @params);
		private delegate void glVariantArrayObjectATIDelegate(uint id, uint type, int stride, uint buffer, uint offset);
		private delegate void glGetVariantArrayObjectfvATIDelegate(uint id, uint pname, float[] @params);
		private delegate void glGetVariantArrayObjectivATIDelegate(uint id, uint pname, int[] @params);
		private delegate void glVertexAttribArrayObjectATIDelegate(uint index, int size, uint type, bool normalized, int stride, uint buffer, uint offset);
		private delegate void glGetVertexAttribArrayObjectfvATIDelegate(uint index, uint pname, float[] @params);
		private delegate void glGetVertexAttribArrayObjectivATIDelegate(uint index, uint pname, int[] @params);
		private delegate void glVertexStream1sATIDelegate(uint stream, short x);
		private delegate void glVertexStream1svATIDelegate(uint stream, short[] coords);
		private delegate void glVertexStream1iATIDelegate(uint stream, int x);
		private delegate void glVertexStream1ivATIDelegate(uint stream, int[] coords);
		private delegate void glVertexStream1fATIDelegate(uint stream, float x);
		private delegate void glVertexStream1fvATIDelegate(uint stream, float[] coords);
		private delegate void glVertexStream1dATIDelegate(uint stream, double x);
		private delegate void glVertexStream1dvATIDelegate(uint stream, double[] coords);
		private delegate void glVertexStream2sATIDelegate(uint stream, short x, short y);
		private delegate void glVertexStream2svATIDelegate(uint stream, short[] coords);
		private delegate void glVertexStream2iATIDelegate(uint stream, int x, int y);
		private delegate void glVertexStream2ivATIDelegate(uint stream, int[] coords);
		private delegate void glVertexStream2fATIDelegate(uint stream, float x, float y);
		private delegate void glVertexStream2fvATIDelegate(uint stream, float[] coords);
		private delegate void glVertexStream2dATIDelegate(uint stream, double x, double y);
		private delegate void glVertexStream2dvATIDelegate(uint stream, double[] coords);
		private delegate void glVertexStream3sATIDelegate(uint stream, short x, short y, short z);
		private delegate void glVertexStream3svATIDelegate(uint stream, short[] coords);
		private delegate void glVertexStream3iATIDelegate(uint stream, int x, int y, int z);
		private delegate void glVertexStream3ivATIDelegate(uint stream, int[] coords);
		private delegate void glVertexStream3fATIDelegate(uint stream, float x, float y, float z);
		private delegate void glVertexStream3fvATIDelegate(uint stream, float[] coords);
		private delegate void glVertexStream3dATIDelegate(uint stream, double x, double y, double z);
		private delegate void glVertexStream3dvATIDelegate(uint stream, double[] coords);
		private delegate void glVertexStream4sATIDelegate(uint stream, short x, short y, short z, short w);
		private delegate void glVertexStream4svATIDelegate(uint stream, short[] coords);
		private delegate void glVertexStream4iATIDelegate(uint stream, int x, int y, int z, int w);
		private delegate void glVertexStream4ivATIDelegate(uint stream, int[] coords);
		private delegate void glVertexStream4fATIDelegate(uint stream, float x, float y, float z, float w);
		private delegate void glVertexStream4fvATIDelegate(uint stream, float[] coords);
		private delegate void glVertexStream4dATIDelegate(uint stream, double x, double y, double z, double w);
		private delegate void glVertexStream4dvATIDelegate(uint stream, double[] coords);
		private delegate void glNormalStream3bATIDelegate(uint stream, byte nx, byte ny, byte nz);
		private delegate void glNormalStream3bvATIDelegate(uint stream, byte[] coords);
		private delegate void glNormalStream3sATIDelegate(uint stream, short nx, short ny, short nz);
		private delegate void glNormalStream3svATIDelegate(uint stream, short[] coords);
		private delegate void glNormalStream3iATIDelegate(uint stream, int nx, int ny, int nz);
		private delegate void glNormalStream3ivATIDelegate(uint stream, int[] coords);
		private delegate void glNormalStream3fATIDelegate(uint stream, float nx, float ny, float nz);
		private delegate void glNormalStream3fvATIDelegate(uint stream, float[] coords);
		private delegate void glNormalStream3dATIDelegate(uint stream, double nx, double ny, double nz);
		private delegate void glNormalStream3dvATIDelegate(uint stream, double[] coords);
		private delegate void glClientActiveVertexStreamATIDelegate(uint stream);
		private delegate void glVertexBlendEnviATIDelegate(uint pname, int param);
		private delegate void glVertexBlendEnvfATIDelegate(uint pname, float param);
		private delegate void glDrawArraysInstancedBaseInstanceEXTDelegate(uint mode, int first, int count, int instancecount, uint baseinstance);
		private delegate void glDrawElementsInstancedBaseInstanceEXTDelegate(uint mode, int count, uint type, nint indices, int instancecount, uint baseinstance);
		private delegate void glDrawElementsInstancedBaseVertexBaseInstanceEXTDelegate(uint mode, int count, uint type, nint indices, int instancecount, int basevertex, uint baseinstance);
		private delegate void glUniformBufferEXTDelegate(uint program, int location, uint buffer);
		private delegate int glGetUniformBufferSizeEXTDelegate(uint program, int location);
		private delegate nint glGetUniformOffsetEXTDelegate(uint program, int location);
		private delegate void glBlendColorEXTDelegate(float red, float green, float blue, float alpha);
		private delegate void glBlendEquationSeparateEXTDelegate(uint modeRGB, uint modeAlpha);
		private delegate void glBindFragDataLocationIndexedEXTDelegate(uint program, uint colorNumber, uint index, char[] name);
		private delegate void glBindFragDataLocationEXTDelegate(uint program, uint color, char[] name);
		private delegate int glGetProgramResourceLocationIndexEXTDelegate(uint program, uint programInterface, char[] name);
		private delegate int glGetFragDataIndexEXTDelegate(uint program, char[] name);
		private delegate void glBlendFuncSeparateEXTDelegate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
		private delegate void glBlendEquationEXTDelegate(uint mode);
		private delegate void glBufferStorageEXTDelegate(uint target, nint size, nint data, uint flags);
		private delegate void glColorSubTableEXTDelegate(uint target, int start, int count, uint format, uint type, nint data);
		private delegate void glCopyColorSubTableEXTDelegate(uint target, int start, int x, int y, int width);
		private delegate void glLockArraysEXTDelegate(int first, int count);
		private delegate void glUnlockArraysEXTDelegate();
		private delegate void glConvolutionFilter1DEXTDelegate(uint target, uint internalformat, int width, uint format, uint type, nint image);
		private delegate void glConvolutionFilter2DEXTDelegate(uint target, uint internalformat, int width, int height, uint format, uint type, nint image);
		private delegate void glConvolutionParameterfEXTDelegate(uint target, uint pname, float @params);
		private delegate void glConvolutionParameterfvEXTDelegate(uint target, uint pname, float[] @params);
		private delegate void glConvolutionParameteriEXTDelegate(uint target, uint pname, int @params);
		private delegate void glConvolutionParameterivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate void glCopyConvolutionFilter1DEXTDelegate(uint target, uint internalformat, int x, int y, int width);
		private delegate void glCopyConvolutionFilter2DEXTDelegate(uint target, uint internalformat, int x, int y, int width, int height);
		private delegate void glGetConvolutionFilterEXTDelegate(uint target, uint format, uint type, nint image);
		private delegate void glGetConvolutionParameterfvEXTDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetConvolutionParameterivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetSeparableFilterEXTDelegate(uint target, uint format, uint type, nint row, nint column, nint span);
		private delegate void glSeparableFilter2DEXTDelegate(uint target, uint internalformat, int width, int height, uint format, uint type, nint row, nint column);
		private delegate void glTangent3bEXTDelegate(byte tx, byte ty, byte tz);
		private delegate void glTangent3bvEXTDelegate(byte[] v);
		private delegate void glTangent3dEXTDelegate(double tx, double ty, double tz);
		private delegate void glTangent3dvEXTDelegate(double[] v);
		private delegate void glTangent3fEXTDelegate(float tx, float ty, float tz);
		private delegate void glTangent3fvEXTDelegate(float[] v);
		private delegate void glTangent3iEXTDelegate(int tx, int ty, int tz);
		private delegate void glTangent3ivEXTDelegate(int[] v);
		private delegate void glTangent3sEXTDelegate(short tx, short ty, short tz);
		private delegate void glTangent3svEXTDelegate(short[] v);
		private delegate void glBinormal3bEXTDelegate(byte bx, byte by, byte bz);
		private delegate void glBinormal3bvEXTDelegate(byte[] v);
		private delegate void glBinormal3dEXTDelegate(double bx, double by, double bz);
		private delegate void glBinormal3dvEXTDelegate(double[] v);
		private delegate void glBinormal3fEXTDelegate(float bx, float by, float bz);
		private delegate void glBinormal3fvEXTDelegate(float[] v);
		private delegate void glBinormal3iEXTDelegate(int bx, int by, int bz);
		private delegate void glBinormal3ivEXTDelegate(int[] v);
		private delegate void glBinormal3sEXTDelegate(short bx, short by, short bz);
		private delegate void glBinormal3svEXTDelegate(short[] v);
		private delegate void glTangentPointerEXTDelegate(uint type, int stride, nint pointer);
		private delegate void glBinormalPointerEXTDelegate(uint type, int stride, nint pointer);
		private delegate void glCopyImageSubDataEXTDelegate(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
		private delegate void glCopyTexImage1DEXTDelegate(uint target, int level, uint internalformat, int x, int y, int width, int border);
		private delegate void glCopyTexImage2DEXTDelegate(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
		private delegate void glCopyTexSubImage1DEXTDelegate(uint target, int level, int xoffset, int x, int y, int width);
		private delegate void glCopyTexSubImage2DEXTDelegate(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		private delegate void glCopyTexSubImage3DEXTDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		private delegate void glCullParameterdvEXTDelegate(uint pname, double[] @params);
		private delegate void glCullParameterfvEXTDelegate(uint pname, float[] @params);
		private delegate void glLabelObjectEXTDelegate(uint type, uint @object, int length, char[] label);
		private delegate void glGetObjectLabelEXTDelegate(uint type, uint @object, int bufSize, int[] length, char[] label);
		private delegate void glInsertEventMarkerEXTDelegate(int length, char[] marker);
		private delegate void glPushGroupMarkerEXTDelegate(int length, char[] marker);
		private delegate void glPopGroupMarkerEXTDelegate();
		private delegate void glDepthBoundsEXTDelegate(double zmin, double zmax);
		private delegate void glMatrixLoadfEXTDelegate(uint mode, float[] m);
		private delegate void glMatrixLoaddEXTDelegate(uint mode, double[] m);
		private delegate void glMatrixMultfEXTDelegate(uint mode, float[] m);
		private delegate void glMatrixMultdEXTDelegate(uint mode, double[] m);
		private delegate void glMatrixLoadIdentityEXTDelegate(uint mode);
		private delegate void glMatrixRotatefEXTDelegate(uint mode, float angle, float x, float y, float z);
		private delegate void glMatrixRotatedEXTDelegate(uint mode, double angle, double x, double y, double z);
		private delegate void glMatrixScalefEXTDelegate(uint mode, float x, float y, float z);
		private delegate void glMatrixScaledEXTDelegate(uint mode, double x, double y, double z);
		private delegate void glMatrixTranslatefEXTDelegate(uint mode, float x, float y, float z);
		private delegate void glMatrixTranslatedEXTDelegate(uint mode, double x, double y, double z);
		private delegate void glMatrixFrustumEXTDelegate(uint mode, double left, double right, double bottom, double top, double zNear, double zFar);
		private delegate void glMatrixOrthoEXTDelegate(uint mode, double left, double right, double bottom, double top, double zNear, double zFar);
		private delegate void glMatrixPopEXTDelegate(uint mode);
		private delegate void glMatrixPushEXTDelegate(uint mode);
		private delegate void glClientAttribDefaultEXTDelegate(uint mask);
		private delegate void glPushClientAttribDefaultEXTDelegate(uint mask);
		private delegate void glTextureParameterfEXTDelegate(uint texture, uint target, uint pname, float param);
		private delegate void glTextureParameterfvEXTDelegate(uint texture, uint target, uint pname, float[] @params);
		private delegate void glTextureParameteriEXTDelegate(uint texture, uint target, uint pname, int param);
		private delegate void glTextureParameterivEXTDelegate(uint texture, uint target, uint pname, int[] @params);
		private delegate void glTextureImage1DEXTDelegate(uint texture, uint target, int level, int internalformat, int width, int border, uint format, uint type, nint pixels);
		private delegate void glTextureImage2DEXTDelegate(uint texture, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, nint pixels);
		private delegate void glTextureSubImage1DEXTDelegate(uint texture, uint target, int level, int xoffset, int width, uint format, uint type, nint pixels);
		private delegate void glTextureSubImage2DEXTDelegate(uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels);
		private delegate void glCopyTextureImage1DEXTDelegate(uint texture, uint target, int level, uint internalformat, int x, int y, int width, int border);
		private delegate void glCopyTextureImage2DEXTDelegate(uint texture, uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
		private delegate void glCopyTextureSubImage1DEXTDelegate(uint texture, uint target, int level, int xoffset, int x, int y, int width);
		private delegate void glCopyTextureSubImage2DEXTDelegate(uint texture, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		private delegate void glGetTextureImageEXTDelegate(uint texture, uint target, int level, uint format, uint type, nint pixels);
		private delegate void glGetTextureParameterfvEXTDelegate(uint texture, uint target, uint pname, float[] @params);
		private delegate void glGetTextureParameterivEXTDelegate(uint texture, uint target, uint pname, int[] @params);
		private delegate void glGetTextureLevelParameterfvEXTDelegate(uint texture, uint target, int level, uint pname, float[] @params);
		private delegate void glGetTextureLevelParameterivEXTDelegate(uint texture, uint target, int level, uint pname, int[] @params);
		private delegate void glTextureImage3DEXTDelegate(uint texture, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels);
		private delegate void glTextureSubImage3DEXTDelegate(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels);
		private delegate void glCopyTextureSubImage3DEXTDelegate(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		private delegate void glBindMultiTextureEXTDelegate(uint texunit, uint target, uint texture);
		private delegate void glMultiTexCoordPointerEXTDelegate(uint texunit, int size, uint type, int stride, nint pointer);
		private delegate void glMultiTexEnvfEXTDelegate(uint texunit, uint target, uint pname, float param);
		private delegate void glMultiTexEnvfvEXTDelegate(uint texunit, uint target, uint pname, float[] @params);
		private delegate void glMultiTexEnviEXTDelegate(uint texunit, uint target, uint pname, int param);
		private delegate void glMultiTexEnvivEXTDelegate(uint texunit, uint target, uint pname, int[] @params);
		private delegate void glMultiTexGendEXTDelegate(uint texunit, uint coord, uint pname, double param);
		private delegate void glMultiTexGendvEXTDelegate(uint texunit, uint coord, uint pname, double[] @params);
		private delegate void glMultiTexGenfEXTDelegate(uint texunit, uint coord, uint pname, float param);
		private delegate void glMultiTexGenfvEXTDelegate(uint texunit, uint coord, uint pname, float[] @params);
		private delegate void glMultiTexGeniEXTDelegate(uint texunit, uint coord, uint pname, int param);
		private delegate void glMultiTexGenivEXTDelegate(uint texunit, uint coord, uint pname, int[] @params);
		private delegate void glGetMultiTexEnvfvEXTDelegate(uint texunit, uint target, uint pname, float[] @params);
		private delegate void glGetMultiTexEnvivEXTDelegate(uint texunit, uint target, uint pname, int[] @params);
		private delegate void glGetMultiTexGendvEXTDelegate(uint texunit, uint coord, uint pname, double[] @params);
		private delegate void glGetMultiTexGenfvEXTDelegate(uint texunit, uint coord, uint pname, float[] @params);
		private delegate void glGetMultiTexGenivEXTDelegate(uint texunit, uint coord, uint pname, int[] @params);
		private delegate void glMultiTexParameteriEXTDelegate(uint texunit, uint target, uint pname, int param);
		private delegate void glMultiTexParameterivEXTDelegate(uint texunit, uint target, uint pname, int[] @params);
		private delegate void glMultiTexParameterfEXTDelegate(uint texunit, uint target, uint pname, float param);
		private delegate void glMultiTexParameterfvEXTDelegate(uint texunit, uint target, uint pname, float[] @params);
		private delegate void glMultiTexImage1DEXTDelegate(uint texunit, uint target, int level, int internalformat, int width, int border, uint format, uint type, nint pixels);
		private delegate void glMultiTexImage2DEXTDelegate(uint texunit, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, nint pixels);
		private delegate void glMultiTexSubImage1DEXTDelegate(uint texunit, uint target, int level, int xoffset, int width, uint format, uint type, nint pixels);
		private delegate void glMultiTexSubImage2DEXTDelegate(uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels);
		private delegate void glCopyMultiTexImage1DEXTDelegate(uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int border);
		private delegate void glCopyMultiTexImage2DEXTDelegate(uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
		private delegate void glCopyMultiTexSubImage1DEXTDelegate(uint texunit, uint target, int level, int xoffset, int x, int y, int width);
		private delegate void glCopyMultiTexSubImage2DEXTDelegate(uint texunit, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		private delegate void glGetMultiTexImageEXTDelegate(uint texunit, uint target, int level, uint format, uint type, nint pixels);
		private delegate void glGetMultiTexParameterfvEXTDelegate(uint texunit, uint target, uint pname, float[] @params);
		private delegate void glGetMultiTexParameterivEXTDelegate(uint texunit, uint target, uint pname, int[] @params);
		private delegate void glGetMultiTexLevelParameterfvEXTDelegate(uint texunit, uint target, int level, uint pname, float[] @params);
		private delegate void glGetMultiTexLevelParameterivEXTDelegate(uint texunit, uint target, int level, uint pname, int[] @params);
		private delegate void glMultiTexImage3DEXTDelegate(uint texunit, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels);
		private delegate void glMultiTexSubImage3DEXTDelegate(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels);
		private delegate void glCopyMultiTexSubImage3DEXTDelegate(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		private delegate void glEnableClientStateIndexedEXTDelegate(uint array, uint index);
		private delegate void glDisableClientStateIndexedEXTDelegate(uint array, uint index);
		private delegate void glGetFloatIndexedvEXTDelegate(uint target, uint index, float[] data);
		private delegate void glGetDoubleIndexedvEXTDelegate(uint target, uint index, double[] data);
		private delegate void glGetPointerIndexedvEXTDelegate(uint target, uint index, nint data);
		private delegate void glEnableIndexedEXTDelegate(uint target, uint index);
		private delegate void glDisableIndexedEXTDelegate(uint target, uint index);
		private delegate bool glIsEnabledIndexedEXTDelegate(uint target, uint index);
		private delegate void glGetIntegerIndexedvEXTDelegate(uint target, uint index, int[] data);
		private delegate void glGetBooleanIndexedvEXTDelegate(uint target, uint index, bool[] data);
		private delegate void glCompressedTextureImage3DEXTDelegate(uint texture, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint bits);
		private delegate void glCompressedTextureImage2DEXTDelegate(uint texture, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, nint bits);
		private delegate void glCompressedTextureImage1DEXTDelegate(uint texture, uint target, int level, uint internalformat, int width, int border, int imageSize, nint bits);
		private delegate void glCompressedTextureSubImage3DEXTDelegate(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint bits);
		private delegate void glCompressedTextureSubImage2DEXTDelegate(uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint bits);
		private delegate void glCompressedTextureSubImage1DEXTDelegate(uint texture, uint target, int level, int xoffset, int width, uint format, int imageSize, nint bits);
		private delegate void glGetCompressedTextureImageEXTDelegate(uint texture, uint target, int lod, nint img);
		private delegate void glCompressedMultiTexImage3DEXTDelegate(uint texunit, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint bits);
		private delegate void glCompressedMultiTexImage2DEXTDelegate(uint texunit, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, nint bits);
		private delegate void glCompressedMultiTexImage1DEXTDelegate(uint texunit, uint target, int level, uint internalformat, int width, int border, int imageSize, nint bits);
		private delegate void glCompressedMultiTexSubImage3DEXTDelegate(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint bits);
		private delegate void glCompressedMultiTexSubImage2DEXTDelegate(uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint bits);
		private delegate void glCompressedMultiTexSubImage1DEXTDelegate(uint texunit, uint target, int level, int xoffset, int width, uint format, int imageSize, nint bits);
		private delegate void glGetCompressedMultiTexImageEXTDelegate(uint texunit, uint target, int lod, nint img);
		private delegate void glMatrixLoadTransposefEXTDelegate(uint mode, float[] m);
		private delegate void glMatrixLoadTransposedEXTDelegate(uint mode, double[] m);
		private delegate void glMatrixMultTransposefEXTDelegate(uint mode, float[] m);
		private delegate void glMatrixMultTransposedEXTDelegate(uint mode, double[] m);
		private delegate void glNamedBufferDataEXTDelegate(uint buffer, nint size, nint data, uint usage);
		private delegate void glNamedBufferSubDataEXTDelegate(uint buffer, nint offset, nint size, nint data);
		private delegate void glMapNamedBufferEXTDelegate(uint buffer, uint access);
		private delegate bool glUnmapNamedBufferEXTDelegate(uint buffer);
		private delegate void glGetNamedBufferParameterivEXTDelegate(uint buffer, uint pname, int[] @params);
		private delegate void glGetNamedBufferPointervEXTDelegate(uint buffer, uint pname, nint @params);
		private delegate void glGetNamedBufferSubDataEXTDelegate(uint buffer, nint offset, nint size, nint data);
		private delegate void glProgramUniform1fEXTDelegate(uint program, int location, float v0);
		private delegate void glProgramUniform2fEXTDelegate(uint program, int location, float v0, float v1);
		private delegate void glProgramUniform3fEXTDelegate(uint program, int location, float v0, float v1, float v2);
		private delegate void glProgramUniform4fEXTDelegate(uint program, int location, float v0, float v1, float v2, float v3);
		private delegate void glProgramUniform1iEXTDelegate(uint program, int location, int v0);
		private delegate void glProgramUniform2iEXTDelegate(uint program, int location, int v0, int v1);
		private delegate void glProgramUniform3iEXTDelegate(uint program, int location, int v0, int v1, int v2);
		private delegate void glProgramUniform4iEXTDelegate(uint program, int location, int v0, int v1, int v2, int v3);
		private delegate void glProgramUniform1fvEXTDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform2fvEXTDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform3fvEXTDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform4fvEXTDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform1ivEXTDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform2ivEXTDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform3ivEXTDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform4ivEXTDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniformMatrix2fvEXTDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3fvEXTDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4fvEXTDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2x3fvEXTDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3x2fvEXTDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2x4fvEXTDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4x2fvEXTDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3x4fvEXTDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4x3fvEXTDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glTextureBufferEXTDelegate(uint texture, uint target, uint internalformat, uint buffer);
		private delegate void glMultiTexBufferEXTDelegate(uint texunit, uint target, uint internalformat, uint buffer);
		private delegate void glTextureParameterIivEXTDelegate(uint texture, uint target, uint pname, int[] @params);
		private delegate void glTextureParameterIuivEXTDelegate(uint texture, uint target, uint pname, uint[] @params);
		private delegate void glGetTextureParameterIivEXTDelegate(uint texture, uint target, uint pname, int[] @params);
		private delegate void glGetTextureParameterIuivEXTDelegate(uint texture, uint target, uint pname, uint[] @params);
		private delegate void glMultiTexParameterIivEXTDelegate(uint texunit, uint target, uint pname, int[] @params);
		private delegate void glMultiTexParameterIuivEXTDelegate(uint texunit, uint target, uint pname, uint[] @params);
		private delegate void glGetMultiTexParameterIivEXTDelegate(uint texunit, uint target, uint pname, int[] @params);
		private delegate void glGetMultiTexParameterIuivEXTDelegate(uint texunit, uint target, uint pname, uint[] @params);
		private delegate void glProgramUniform1uiEXTDelegate(uint program, int location, uint v0);
		private delegate void glProgramUniform2uiEXTDelegate(uint program, int location, uint v0, uint v1);
		private delegate void glProgramUniform3uiEXTDelegate(uint program, int location, uint v0, uint v1, uint v2);
		private delegate void glProgramUniform4uiEXTDelegate(uint program, int location, uint v0, uint v1, uint v2, uint v3);
		private delegate void glProgramUniform1uivEXTDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniform2uivEXTDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniform3uivEXTDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniform4uivEXTDelegate(uint program, int location, int count, uint[] value);
		private delegate void glNamedProgramLocalParameters4fvEXTDelegate(uint program, uint target, uint index, int count, float[] @params);
		private delegate void glNamedProgramLocalParameterI4iEXTDelegate(uint program, uint target, uint index, int x, int y, int z, int w);
		private delegate void glNamedProgramLocalParameterI4ivEXTDelegate(uint program, uint target, uint index, int[] @params);
		private delegate void glNamedProgramLocalParametersI4ivEXTDelegate(uint program, uint target, uint index, int count, int[] @params);
		private delegate void glNamedProgramLocalParameterI4uiEXTDelegate(uint program, uint target, uint index, uint x, uint y, uint z, uint w);
		private delegate void glNamedProgramLocalParameterI4uivEXTDelegate(uint program, uint target, uint index, uint[] @params);
		private delegate void glNamedProgramLocalParametersI4uivEXTDelegate(uint program, uint target, uint index, int count, uint[] @params);
		private delegate void glGetNamedProgramLocalParameterIivEXTDelegate(uint program, uint target, uint index, int[] @params);
		private delegate void glGetNamedProgramLocalParameterIuivEXTDelegate(uint program, uint target, uint index, uint[] @params);
		private delegate void glEnableClientStateiEXTDelegate(uint array, uint index);
		private delegate void glDisableClientStateiEXTDelegate(uint array, uint index);
		private delegate void glGetFloati_vEXTDelegate(uint pname, uint index, float[] @params);
		private delegate void glGetDoublei_vEXTDelegate(uint pname, uint index, double[] @params);
		private delegate void glGetPointeri_vEXTDelegate(uint pname, uint index, nint @params);
		private delegate void glNamedProgramStringEXTDelegate(uint program, uint target, uint format, int len, nint @string);
		private delegate void glNamedProgramLocalParameter4dEXTDelegate(uint program, uint target, uint index, double x, double y, double z, double w);
		private delegate void glNamedProgramLocalParameter4dvEXTDelegate(uint program, uint target, uint index, double[] @params);
		private delegate void glNamedProgramLocalParameter4fEXTDelegate(uint program, uint target, uint index, float x, float y, float z, float w);
		private delegate void glNamedProgramLocalParameter4fvEXTDelegate(uint program, uint target, uint index, float[] @params);
		private delegate void glGetNamedProgramLocalParameterdvEXTDelegate(uint program, uint target, uint index, double[] @params);
		private delegate void glGetNamedProgramLocalParameterfvEXTDelegate(uint program, uint target, uint index, float[] @params);
		private delegate void glGetNamedProgramivEXTDelegate(uint program, uint target, uint pname, int[] @params);
		private delegate void glGetNamedProgramStringEXTDelegate(uint program, uint target, uint pname, nint @string);
		private delegate void glNamedRenderbufferStorageEXTDelegate(uint renderbuffer, uint internalformat, int width, int height);
		private delegate void glGetNamedRenderbufferParameterivEXTDelegate(uint renderbuffer, uint pname, int[] @params);
		private delegate void glNamedRenderbufferStorageMultisampleEXTDelegate(uint renderbuffer, int samples, uint internalformat, int width, int height);
		private delegate void glNamedRenderbufferStorageMultisampleCoverageEXTDelegate(uint renderbuffer, int coverageSamples, int colorSamples, uint internalformat, int width, int height);
		private delegate uint glCheckNamedFramebufferStatusEXTDelegate(uint framebuffer, uint target);
		private delegate void glNamedFramebufferTexture1DEXTDelegate(uint framebuffer, uint attachment, uint textarget, uint texture, int level);
		private delegate void glNamedFramebufferTexture2DEXTDelegate(uint framebuffer, uint attachment, uint textarget, uint texture, int level);
		private delegate void glNamedFramebufferTexture3DEXTDelegate(uint framebuffer, uint attachment, uint textarget, uint texture, int level, int zoffset);
		private delegate void glNamedFramebufferRenderbufferEXTDelegate(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private delegate void glGetNamedFramebufferAttachmentParameterivEXTDelegate(uint framebuffer, uint attachment, uint pname, int[] @params);
		private delegate void glGenerateTextureMipmapEXTDelegate(uint texture, uint target);
		private delegate void glGenerateMultiTexMipmapEXTDelegate(uint texunit, uint target);
		private delegate void glFramebufferDrawBufferEXTDelegate(uint framebuffer, uint mode);
		private delegate void glFramebufferDrawBuffersEXTDelegate(uint framebuffer, int n, uint[] bufs);
		private delegate void glFramebufferReadBufferEXTDelegate(uint framebuffer, uint mode);
		private delegate void glGetFramebufferParameterivEXTDelegate(uint framebuffer, uint pname, int[] @params);
		private delegate void glNamedCopyBufferSubDataEXTDelegate(uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size);
		private delegate void glNamedFramebufferTextureEXTDelegate(uint framebuffer, uint attachment, uint texture, int level);
		private delegate void glNamedFramebufferTextureLayerEXTDelegate(uint framebuffer, uint attachment, uint texture, int level, int layer);
		private delegate void glNamedFramebufferTextureFaceEXTDelegate(uint framebuffer, uint attachment, uint texture, int level, uint face);
		private delegate void glTextureRenderbufferEXTDelegate(uint texture, uint target, uint renderbuffer);
		private delegate void glMultiTexRenderbufferEXTDelegate(uint texunit, uint target, uint renderbuffer);
		private delegate void glVertexArrayVertexOffsetEXTDelegate(uint vaobj, uint buffer, int size, uint type, int stride, nint offset);
		private delegate void glVertexArrayColorOffsetEXTDelegate(uint vaobj, uint buffer, int size, uint type, int stride, nint offset);
		private delegate void glVertexArrayEdgeFlagOffsetEXTDelegate(uint vaobj, uint buffer, int stride, nint offset);
		private delegate void glVertexArrayIndexOffsetEXTDelegate(uint vaobj, uint buffer, uint type, int stride, nint offset);
		private delegate void glVertexArrayNormalOffsetEXTDelegate(uint vaobj, uint buffer, uint type, int stride, nint offset);
		private delegate void glVertexArrayTexCoordOffsetEXTDelegate(uint vaobj, uint buffer, int size, uint type, int stride, nint offset);
		private delegate void glVertexArrayMultiTexCoordOffsetEXTDelegate(uint vaobj, uint buffer, uint texunit, int size, uint type, int stride, nint offset);
		private delegate void glVertexArrayFogCoordOffsetEXTDelegate(uint vaobj, uint buffer, uint type, int stride, nint offset);
		private delegate void glVertexArraySecondaryColorOffsetEXTDelegate(uint vaobj, uint buffer, int size, uint type, int stride, nint offset);
		private delegate void glVertexArrayVertexAttribOffsetEXTDelegate(uint vaobj, uint buffer, uint index, int size, uint type, bool normalized, int stride, nint offset);
		private delegate void glVertexArrayVertexAttribIOffsetEXTDelegate(uint vaobj, uint buffer, uint index, int size, uint type, int stride, nint offset);
		private delegate void glEnableVertexArrayEXTDelegate(uint vaobj, uint array);
		private delegate void glDisableVertexArrayEXTDelegate(uint vaobj, uint array);
		private delegate void glEnableVertexArrayAttribEXTDelegate(uint vaobj, uint index);
		private delegate void glDisableVertexArrayAttribEXTDelegate(uint vaobj, uint index);
		private delegate void glGetVertexArrayIntegervEXTDelegate(uint vaobj, uint pname, int[] param);
		private delegate void glGetVertexArrayPointervEXTDelegate(uint vaobj, uint pname, nint param);
		private delegate void glGetVertexArrayIntegeri_vEXTDelegate(uint vaobj, uint index, uint pname, int[] param);
		private delegate void glGetVertexArrayPointeri_vEXTDelegate(uint vaobj, uint index, uint pname, nint param);
		private delegate void glMapNamedBufferRangeEXTDelegate(uint buffer, nint offset, nint length, uint access);
		private delegate void glFlushMappedNamedBufferRangeEXTDelegate(uint buffer, nint offset, nint length);
		private delegate void glNamedBufferStorageEXTDelegate(uint buffer, nint size, nint data, uint flags);
		private delegate void glClearNamedBufferDataEXTDelegate(uint buffer, uint internalformat, uint format, uint type, nint data);
		private delegate void glClearNamedBufferSubDataEXTDelegate(uint buffer, uint internalformat, nint offset, nint size, uint format, uint type, nint data);
		private delegate void glNamedFramebufferParameteriEXTDelegate(uint framebuffer, uint pname, int param);
		private delegate void glGetNamedFramebufferParameterivEXTDelegate(uint framebuffer, uint pname, int[] @params);
		private delegate void glProgramUniform1dEXTDelegate(uint program, int location, double x);
		private delegate void glProgramUniform2dEXTDelegate(uint program, int location, double x, double y);
		private delegate void glProgramUniform3dEXTDelegate(uint program, int location, double x, double y, double z);
		private delegate void glProgramUniform4dEXTDelegate(uint program, int location, double x, double y, double z, double w);
		private delegate void glProgramUniform1dvEXTDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform2dvEXTDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform3dvEXTDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform4dvEXTDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniformMatrix2dvEXTDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3dvEXTDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4dvEXTDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix2x3dvEXTDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix2x4dvEXTDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3x2dvEXTDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3x4dvEXTDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4x2dvEXTDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4x3dvEXTDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glTextureBufferRangeEXTDelegate(uint texture, uint target, uint internalformat, uint buffer, nint offset, nint size);
		private delegate void glTextureStorage1DEXTDelegate(uint texture, uint target, int levels, uint internalformat, int width);
		private delegate void glTextureStorage2DEXTDelegate(uint texture, uint target, int levels, uint internalformat, int width, int height);
		private delegate void glTextureStorage3DEXTDelegate(uint texture, uint target, int levels, uint internalformat, int width, int height, int depth);
		private delegate void glTextureStorage2DMultisampleEXTDelegate(uint texture, uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private delegate void glTextureStorage3DMultisampleEXTDelegate(uint texture, uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glVertexArrayBindVertexBufferEXTDelegate(uint vaobj, uint bindingindex, uint buffer, nint offset, int stride);
		private delegate void glVertexArrayVertexAttribFormatEXTDelegate(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		private delegate void glVertexArrayVertexAttribIFormatEXTDelegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexArrayVertexAttribLFormatEXTDelegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexArrayVertexAttribBindingEXTDelegate(uint vaobj, uint attribindex, uint bindingindex);
		private delegate void glVertexArrayVertexBindingDivisorEXTDelegate(uint vaobj, uint bindingindex, uint divisor);
		private delegate void glVertexArrayVertexAttribLOffsetEXTDelegate(uint vaobj, uint buffer, uint index, int size, uint type, int stride, nint offset);
		private delegate void glTexturePageCommitmentEXTDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit);
		private delegate void glVertexArrayVertexAttribDivisorEXTDelegate(uint vaobj, uint index, uint divisor);
		private delegate void glDiscardFramebufferEXTDelegate(uint target, int numAttachments, uint[] attachments);
		private delegate void glGenQueriesEXTDelegate(int n, uint[] ids);
		private delegate void glDeleteQueriesEXTDelegate(int n, uint[] ids);
		private delegate bool glIsQueryEXTDelegate(uint id);
		private delegate void glBeginQueryEXTDelegate(uint target, uint id);
		private delegate void glEndQueryEXTDelegate(uint target);
		private delegate void glQueryCounterEXTDelegate(uint id, uint target);
		private delegate void glGetQueryivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetQueryObjectivEXTDelegate(uint id, uint pname, int[] @params);
		private delegate void glGetQueryObjectuivEXTDelegate(uint id, uint pname, uint[] @params);
		private delegate void glGetQueryObjecti64vEXTDelegate(uint id, uint pname, Int64[] @params);
		private delegate void glGetQueryObjectui64vEXTDelegate(uint id, uint pname, UInt64[] @params);
		private delegate void glDrawBuffersEXTDelegate(int n, uint[] bufs);
		private delegate void glColorMaskIndexedEXTDelegate(uint index, bool r, bool g, bool b, bool a);
		private delegate void glEnableiEXTDelegate(uint target, uint index);
		private delegate void glDisableiEXTDelegate(uint target, uint index);
		private delegate void glBlendEquationiEXTDelegate(uint buf, uint mode);
		private delegate void glBlendEquationSeparateiEXTDelegate(uint buf, uint modeRGB, uint modeAlpha);
		private delegate void glBlendFunciEXTDelegate(uint buf, uint src, uint dst);
		private delegate void glBlendFuncSeparateiEXTDelegate(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		private delegate void glColorMaskiEXTDelegate(uint index, bool r, bool g, bool b, bool a);
		private delegate bool glIsEnablediEXTDelegate(uint target, uint index);
		private delegate void glDrawElementsBaseVertexEXTDelegate(uint mode, int count, uint type, nint indices, int basevertex);
		private delegate void glDrawRangeElementsBaseVertexEXTDelegate(uint mode, uint start, uint end, int count, uint type, nint indices, int basevertex);
		private delegate void glDrawElementsInstancedBaseVertexEXTDelegate(uint mode, int count, uint type, nint indices, int instancecount, int basevertex);
		private delegate void glMultiDrawElementsBaseVertexEXTDelegate(uint mode, int[] count, uint type, nint indices, int primcount, int[] basevertex);
		private delegate void glDrawArraysInstancedEXTDelegate(uint mode, int start, int count, int primcount);
		private delegate void glDrawElementsInstancedEXTDelegate(uint mode, int count, uint type, nint indices, int primcount);
		private delegate void glDrawRangeElementsEXTDelegate(uint mode, uint start, uint end, int count, uint type, nint indices);
		private delegate void glFogCoordfEXTDelegate(float coord);
		private delegate void glFogCoordfvEXTDelegate(float[] coord);
		private delegate void glFogCoorddEXTDelegate(double coord);
		private delegate void glFogCoorddvEXTDelegate(double[] coord);
		private delegate void glFogCoordPointerEXTDelegate(uint type, int stride, nint pointer);
		private delegate void glBlitFramebufferEXTDelegate(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private delegate void glRenderbufferStorageMultisampleEXTDelegate(uint target, int samples, uint internalformat, int width, int height);
		private delegate bool glIsRenderbufferEXTDelegate(uint renderbuffer);
		private delegate void glBindRenderbufferEXTDelegate(uint target, uint renderbuffer);
		private delegate void glDeleteRenderbuffersEXTDelegate(int n, uint[] renderbuffers);
		private delegate void glGenRenderbuffersEXTDelegate(int n, uint[] renderbuffers);
		private delegate void glRenderbufferStorageEXTDelegate(uint target, uint internalformat, int width, int height);
		private delegate void glGetRenderbufferParameterivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate bool glIsFramebufferEXTDelegate(uint framebuffer);
		private delegate void glBindFramebufferEXTDelegate(uint target, uint framebuffer);
		private delegate void glDeleteFramebuffersEXTDelegate(int n, uint[] framebuffers);
		private delegate void glGenFramebuffersEXTDelegate(int n, uint[] framebuffers);
		private delegate uint glCheckFramebufferStatusEXTDelegate(uint target);
		private delegate void glFramebufferTexture1DEXTDelegate(uint target, uint attachment, uint textarget, uint texture, int level);
		private delegate void glFramebufferTexture2DEXTDelegate(uint target, uint attachment, uint textarget, uint texture, int level);
		private delegate void glFramebufferTexture3DEXTDelegate(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
		private delegate void glFramebufferRenderbufferEXTDelegate(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private delegate void glGetFramebufferAttachmentParameterivEXTDelegate(uint target, uint attachment, uint pname, int[] @params);
		private delegate void glGenerateMipmapEXTDelegate(uint target);
		private delegate void glFramebufferTextureEXTDelegate(uint target, uint attachment, uint texture, int level);
		private delegate void glProgramParameteriEXTDelegate(uint program, uint pname, int value);
		private delegate void glProgramEnvParameters4fvEXTDelegate(uint target, uint index, int count, float[] @params);
		private delegate void glProgramLocalParameters4fvEXTDelegate(uint target, uint index, int count, float[] @params);
		private delegate void glGetUniformuivEXTDelegate(uint program, int location, uint[] @params);
		private delegate int glGetFragDataLocationEXTDelegate(uint program, char[] name);
		private delegate void glUniform1uiEXTDelegate(int location, uint v0);
		private delegate void glUniform2uiEXTDelegate(int location, uint v0, uint v1);
		private delegate void glUniform3uiEXTDelegate(int location, uint v0, uint v1, uint v2);
		private delegate void glUniform4uiEXTDelegate(int location, uint v0, uint v1, uint v2, uint v3);
		private delegate void glUniform1uivEXTDelegate(int location, int count, uint[] value);
		private delegate void glUniform2uivEXTDelegate(int location, int count, uint[] value);
		private delegate void glUniform3uivEXTDelegate(int location, int count, uint[] value);
		private delegate void glUniform4uivEXTDelegate(int location, int count, uint[] value);
		private delegate void glGetHistogramEXTDelegate(uint target, bool reset, uint format, uint type, nint values);
		private delegate void glGetHistogramParameterfvEXTDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetHistogramParameterivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetMinmaxEXTDelegate(uint target, bool reset, uint format, uint type, nint values);
		private delegate void glGetMinmaxParameterfvEXTDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetMinmaxParameterivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate void glHistogramEXTDelegate(uint target, int width, uint internalformat, bool sink);
		private delegate void glMinmaxEXTDelegate(uint target, uint internalformat, bool sink);
		private delegate void glResetHistogramEXTDelegate(uint target);
		private delegate void glResetMinmaxEXTDelegate(uint target);
		private delegate void glIndexFuncEXTDelegate(uint func, float @ref);
		private delegate void glIndexMaterialEXTDelegate(uint face, uint mode);
		private delegate void glVertexAttribDivisorEXTDelegate(uint index, uint divisor);
		private delegate void glApplyTextureEXTDelegate(uint mode);
		private delegate void glTextureLightEXTDelegate(uint pname);
		private delegate void glTextureMaterialEXTDelegate(uint face, uint mode);
		private delegate void glMapBufferRangeEXTDelegate(uint target, nint offset, nint length, uint access);
		private delegate void glFlushMappedBufferRangeEXTDelegate(uint target, nint offset, nint length);
		private delegate void glMultiDrawArraysEXTDelegate(uint mode, int[] first, int[] count, int primcount);
		private delegate void glMultiDrawElementsEXTDelegate(uint mode, int[] count, uint type, nint indices, int primcount);
		private delegate void glMultiDrawArraysIndirectEXTDelegate(uint mode, nint indirect, int drawcount, int stride);
		private delegate void glMultiDrawElementsIndirectEXTDelegate(uint mode, uint type, nint indirect, int drawcount, int stride);
		private delegate void glSampleMaskEXTDelegate(float value, bool invert);
		private delegate void glSamplePatternEXTDelegate(uint pattern);
		private delegate void glFramebufferTexture2DMultisampleEXTDelegate(uint target, uint attachment, uint textarget, uint texture, int level, int samples);
		private delegate void glReadBufferIndexedEXTDelegate(uint src, int index);
		private delegate void glDrawBuffersIndexedEXTDelegate(int n, uint[] location, int[] indices);
		private delegate void glGetIntegeri_vEXTDelegate(uint target, uint index, int[] data);
		private delegate void glColorTableEXTDelegate(uint target, uint internalFormat, int width, uint format, uint type, nint table);
		private delegate void glGetColorTableEXTDelegate(uint target, uint format, uint type, nint data);
		private delegate void glGetColorTableParameterivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetColorTableParameterfvEXTDelegate(uint target, uint pname, float[] @params);
		private delegate void glPixelTransformParameteriEXTDelegate(uint target, uint pname, int param);
		private delegate void glPixelTransformParameterfEXTDelegate(uint target, uint pname, float param);
		private delegate void glPixelTransformParameterivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate void glPixelTransformParameterfvEXTDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetPixelTransformParameterivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetPixelTransformParameterfvEXTDelegate(uint target, uint pname, float[] @params);
		private delegate void glPointParameterfEXTDelegate(uint pname, float param);
		private delegate void glPointParameterfvEXTDelegate(uint pname, float[] @params);
		private delegate void glPolygonOffsetEXTDelegate(float factor, float bias);
		private delegate void glPolygonOffsetClampEXTDelegate(float factor, float units, float clamp);
		private delegate void glPrimitiveBoundingBoxEXTDelegate(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
		private delegate void glProvokingVertexEXTDelegate(uint mode);
		private delegate void glRasterSamplesEXTDelegate(uint samples, bool fixedsamplelocations);
		private delegate uint glGetGraphicsResetStatusEXTDelegate();
		private delegate void glReadnPixelsEXTDelegate(int x, int y, int width, int height, uint format, uint type, int bufSize, nint data);
		private delegate void glGetnUniformfvEXTDelegate(uint program, int location, int bufSize, float[] @params);
		private delegate void glGetnUniformivEXTDelegate(uint program, int location, int bufSize, int[] @params);
		private delegate void glSecondaryColor3bEXTDelegate(byte red, byte green, byte blue);
		private delegate void glSecondaryColor3bvEXTDelegate(byte[] v);
		private delegate void glSecondaryColor3dEXTDelegate(double red, double green, double blue);
		private delegate void glSecondaryColor3dvEXTDelegate(double[] v);
		private delegate void glSecondaryColor3fEXTDelegate(float red, float green, float blue);
		private delegate void glSecondaryColor3fvEXTDelegate(float[] v);
		private delegate void glSecondaryColor3iEXTDelegate(int red, int green, int blue);
		private delegate void glSecondaryColor3ivEXTDelegate(int[] v);
		private delegate void glSecondaryColor3sEXTDelegate(short red, short green, short blue);
		private delegate void glSecondaryColor3svEXTDelegate(short[] v);
		private delegate void glSecondaryColor3ubEXTDelegate(byte red, byte green, byte blue);
		private delegate void glSecondaryColor3ubvEXTDelegate(byte[] v);
		private delegate void glSecondaryColor3uiEXTDelegate(uint red, uint green, uint blue);
		private delegate void glSecondaryColor3uivEXTDelegate(uint[] v);
		private delegate void glSecondaryColor3usEXTDelegate(ushort red, ushort green, ushort blue);
		private delegate void glSecondaryColor3usvEXTDelegate(ushort[] v);
		private delegate void glSecondaryColorPointerEXTDelegate(int size, uint type, int stride, nint pointer);
		private delegate void glUseShaderProgramEXTDelegate(uint type, uint program);
		private delegate void glActiveProgramEXTDelegate(uint program);
		private delegate uint glCreateShaderProgramEXTDelegate(uint type, char[] @string);
		private delegate void glActiveShaderProgramEXTDelegate(uint pipeline, uint program);
		private delegate void glBindProgramPipelineEXTDelegate(uint pipeline);
		private delegate uint glCreateShaderProgramvEXTDelegate(uint type, int count, char[] strings);
		private delegate void glDeleteProgramPipelinesEXTDelegate(int n, uint[] pipelines);
		private delegate void glGenProgramPipelinesEXTDelegate(int n, uint[] pipelines);
		private delegate void glGetProgramPipelineInfoLogEXTDelegate(uint pipeline, int bufSize, int[] length, char[] infoLog);
		private delegate void glGetProgramPipelineivEXTDelegate(uint pipeline, uint pname, int[] @params);
		private delegate bool glIsProgramPipelineEXTDelegate(uint pipeline);
		private delegate void glUseProgramStagesEXTDelegate(uint pipeline, uint stages, uint program);
		private delegate void glValidateProgramPipelineEXTDelegate(uint pipeline);
		private delegate void glBindImageTextureEXTDelegate(uint index, uint texture, int level, bool layered, int layer, uint access, int format);
		private delegate void glMemoryBarrierEXTDelegate(uint barriers);
		private delegate void glFramebufferPixelLocalStorageSizeEXTDelegate(uint target, int size);
		private delegate int glGetFramebufferPixelLocalStorageSizeEXTDelegate(uint target);
		private delegate void glClearPixelLocalStorageuiEXTDelegate(int offset, int n, uint[] values);
		private delegate void glTexPageCommitmentEXTDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit);
		private delegate void glStencilClearTagEXTDelegate(int stencilTagBits, uint stencilClearTag);
		private delegate void glActiveStencilFaceEXTDelegate(uint face);
		private delegate void glTexSubImage1DEXTDelegate(uint target, int level, int xoffset, int width, uint format, uint type, nint pixels);
		private delegate void glTexSubImage2DEXTDelegate(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels);
		private delegate void glPatchParameteriEXTDelegate(uint pname, int value);
		private delegate void glTexImage3DEXTDelegate(uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels);
		private delegate void glTexSubImage3DEXTDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels);
		private delegate void glFramebufferTextureLayerEXTDelegate(uint target, uint attachment, uint texture, int level, int layer);
		private delegate void glTexParameterIivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate void glTexParameterIuivEXTDelegate(uint target, uint pname, uint[] @params);
		private delegate void glGetTexParameterIivEXTDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetTexParameterIuivEXTDelegate(uint target, uint pname, uint[] @params);
		private delegate void glSamplerParameterIivEXTDelegate(uint sampler, uint pname, int[] param);
		private delegate void glSamplerParameterIuivEXTDelegate(uint sampler, uint pname, uint[] param);
		private delegate void glGetSamplerParameterIivEXTDelegate(uint sampler, uint pname, int[] @params);
		private delegate void glGetSamplerParameterIuivEXTDelegate(uint sampler, uint pname, uint[] @params);
		private delegate void glTexBufferEXTDelegate(uint target, uint internalformat, uint buffer);
		private delegate void glTexBufferRangeEXTDelegate(uint target, uint internalformat, uint buffer, nint offset, nint size);
		private delegate void glClearColorIiEXTDelegate(int red, int green, int blue, int alpha);
		private delegate void glClearColorIuiEXTDelegate(uint red, uint green, uint blue, uint alpha);
		private delegate bool glAreTexturesResidentEXTDelegate(int n, uint[] textures, bool[] residences);
		private delegate void glBindTextureEXTDelegate(uint target, uint texture);
		private delegate void glDeleteTexturesEXTDelegate(int n, uint[] textures);
		private delegate void glGenTexturesEXTDelegate(int n, uint[] textures);
		private delegate bool glIsTextureEXTDelegate(uint texture);
		private delegate void glPrioritizeTexturesEXTDelegate(int n, uint[] textures, float[] priorities);
		private delegate void glTextureNormalEXTDelegate(uint mode);
		private delegate void glTexStorage1DEXTDelegate(uint target, int levels, uint internalformat, int width);
		private delegate void glTexStorage2DEXTDelegate(uint target, int levels, uint internalformat, int width, int height);
		private delegate void glTexStorage3DEXTDelegate(uint target, int levels, uint internalformat, int width, int height, int depth);
		private delegate void glTextureViewEXTDelegate(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
		private delegate void glBeginTransformFeedbackEXTDelegate(uint primitiveMode);
		private delegate void glEndTransformFeedbackEXTDelegate();
		private delegate void glBindBufferRangeEXTDelegate(uint target, uint index, uint buffer, nint offset, nint size);
		private delegate void glBindBufferOffsetEXTDelegate(uint target, uint index, uint buffer, nint offset);
		private delegate void glBindBufferBaseEXTDelegate(uint target, uint index, uint buffer);
		private delegate void glTransformFeedbackVaryingsEXTDelegate(uint program, int count, char[] varyings, uint bufferMode);
		private delegate void glGetTransformFeedbackVaryingEXTDelegate(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, char[] name);
		private delegate void glArrayElementEXTDelegate(int i);
		private delegate void glColorPointerEXTDelegate(int size, uint type, int stride, int count, nint pointer);
		private delegate void glDrawArraysEXTDelegate(uint mode, int first, int count);
		private delegate void glEdgeFlagPointerEXTDelegate(int stride, int count, bool[] pointer);
		private delegate void glGetPointervEXTDelegate(uint pname, nint @params);
		private delegate void glIndexPointerEXTDelegate(uint type, int stride, int count, nint pointer);
		private delegate void glNormalPointerEXTDelegate(uint type, int stride, int count, nint pointer);
		private delegate void glTexCoordPointerEXTDelegate(int size, uint type, int stride, int count, nint pointer);
		private delegate void glVertexPointerEXTDelegate(int size, uint type, int stride, int count, nint pointer);
		private delegate void glVertexAttribL1dEXTDelegate(uint index, double x);
		private delegate void glVertexAttribL2dEXTDelegate(uint index, double x, double y);
		private delegate void glVertexAttribL3dEXTDelegate(uint index, double x, double y, double z);
		private delegate void glVertexAttribL4dEXTDelegate(uint index, double x, double y, double z, double w);
		private delegate void glVertexAttribL1dvEXTDelegate(uint index, double[] v);
		private delegate void glVertexAttribL2dvEXTDelegate(uint index, double[] v);
		private delegate void glVertexAttribL3dvEXTDelegate(uint index, double[] v);
		private delegate void glVertexAttribL4dvEXTDelegate(uint index, double[] v);
		private delegate void glVertexAttribLPointerEXTDelegate(uint index, int size, uint type, int stride, nint pointer);
		private delegate void glGetVertexAttribLdvEXTDelegate(uint index, uint pname, double[] @params);
		private delegate void glBeginVertexShaderEXTDelegate();
		private delegate void glEndVertexShaderEXTDelegate();
		private delegate void glBindVertexShaderEXTDelegate(uint id);
		private delegate uint glGenVertexShadersEXTDelegate(uint range);
		private delegate void glDeleteVertexShaderEXTDelegate(uint id);
		private delegate void glShaderOp1EXTDelegate(uint op, uint res, uint arg1);
		private delegate void glShaderOp2EXTDelegate(uint op, uint res, uint arg1, uint arg2);
		private delegate void glShaderOp3EXTDelegate(uint op, uint res, uint arg1, uint arg2, uint arg3);
		private delegate void glSwizzleEXTDelegate(uint res, uint @in, uint outX, uint outY, uint outZ, uint outW);
		private delegate void glWriteMaskEXTDelegate(uint res, uint @in, uint outX, uint outY, uint outZ, uint outW);
		private delegate void glInsertComponentEXTDelegate(uint res, uint src, uint num);
		private delegate void glExtractComponentEXTDelegate(uint res, uint src, uint num);
		private delegate uint glGenSymbolsEXTDelegate(uint datatype, uint storagetype, uint range, uint components);
		private delegate void glSetInvariantEXTDelegate(uint id, uint type, nint addr);
		private delegate void glSetLocalConstantEXTDelegate(uint id, uint type, nint addr);
		private delegate void glVariantbvEXTDelegate(uint id, byte[] addr);
		private delegate void glVariantsvEXTDelegate(uint id, short[] addr);
		private delegate void glVariantivEXTDelegate(uint id, int[] addr);
		private delegate void glVariantfvEXTDelegate(uint id, float[] addr);
		private delegate void glVariantdvEXTDelegate(uint id, double[] addr);
		private delegate void glVariantubvEXTDelegate(uint id, byte[] addr);
		private delegate void glVariantusvEXTDelegate(uint id, ushort[] addr);
		private delegate void glVariantuivEXTDelegate(uint id, uint[] addr);
		private delegate void glVariantPointerEXTDelegate(uint id, uint type, uint stride, nint addr);
		private delegate void glEnableVariantClientStateEXTDelegate(uint id);
		private delegate void glDisableVariantClientStateEXTDelegate(uint id);
		private delegate uint glBindLightParameterEXTDelegate(uint light, uint value);
		private delegate uint glBindMaterialParameterEXTDelegate(uint face, uint value);
		private delegate uint glBindTexGenParameterEXTDelegate(uint unit, uint coord, uint value);
		private delegate uint glBindTextureUnitParameterEXTDelegate(uint unit, uint value);
		private delegate uint glBindParameterEXTDelegate(uint value);
		private delegate bool glIsVariantEnabledEXTDelegate(uint id, uint cap);
		private delegate void glGetVariantBooleanvEXTDelegate(uint id, uint value, bool[] data);
		private delegate void glGetVariantIntegervEXTDelegate(uint id, uint value, int[] data);
		private delegate void glGetVariantFloatvEXTDelegate(uint id, uint value, float[] data);
		private delegate void glGetVariantPointervEXTDelegate(uint id, uint value, nint data);
		private delegate void glGetInvariantBooleanvEXTDelegate(uint id, uint value, bool[] data);
		private delegate void glGetInvariantIntegervEXTDelegate(uint id, uint value, int[] data);
		private delegate void glGetInvariantFloatvEXTDelegate(uint id, uint value, float[] data);
		private delegate void glGetLocalConstantBooleanvEXTDelegate(uint id, uint value, bool[] data);
		private delegate void glGetLocalConstantIntegervEXTDelegate(uint id, uint value, int[] data);
		private delegate void glGetLocalConstantFloatvEXTDelegate(uint id, uint value, float[] data);
		private delegate void glVertexWeightfEXTDelegate(float weight);
		private delegate void glVertexWeightfvEXTDelegate(float[] weight);
		private delegate void glVertexWeightPointerEXTDelegate(int size, uint type, int stride, nint pointer);
		private delegate nint glImportSyncEXTDelegate(uint external_sync_type, nint external_sync, uint flags);
		private delegate void glFrameTerminatorGREMEDYDelegate();
		private delegate void glStringMarkerGREMEDYDelegate(int len, nint @string);
		private delegate void glImageTransformParameteriHPDelegate(uint target, uint pname, int param);
		private delegate void glImageTransformParameterfHPDelegate(uint target, uint pname, float param);
		private delegate void glImageTransformParameterivHPDelegate(uint target, uint pname, int[] @params);
		private delegate void glImageTransformParameterfvHPDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetImageTransformParameterivHPDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetImageTransformParameterfvHPDelegate(uint target, uint pname, float[] @params);
		private delegate void glMultiModeDrawArraysIBMDelegate(uint[] mode, int[] first, int[] count, int primcount, int modestride);
		private delegate void glMultiModeDrawElementsIBMDelegate(uint[] mode, int[] count, uint type, nint indices, int primcount, int modestride);
		private delegate void glFlushStaticDataIBMDelegate(uint target);
		private delegate void glColorPointerListIBMDelegate(int size, uint type, int stride, nint pointer, int ptrstride);
		private delegate void glSecondaryColorPointerListIBMDelegate(int size, uint type, int stride, nint pointer, int ptrstride);
		private delegate void glEdgeFlagPointerListIBMDelegate(int stride, bool[] pointer, int ptrstride);
		private delegate void glFogCoordPointerListIBMDelegate(uint type, int stride, nint pointer, int ptrstride);
		private delegate void glIndexPointerListIBMDelegate(uint type, int stride, nint pointer, int ptrstride);
		private delegate void glNormalPointerListIBMDelegate(uint type, int stride, nint pointer, int ptrstride);
		private delegate void glTexCoordPointerListIBMDelegate(int size, uint type, int stride, nint pointer, int ptrstride);
		private delegate void glVertexPointerListIBMDelegate(int size, uint type, int stride, nint pointer, int ptrstride);
		private delegate void glFramebufferTexture2DDownsampleIMGDelegate(uint target, uint attachment, uint textarget, uint texture, int level, int xscale, int yscale);
		private delegate void glFramebufferTextureLayerDownsampleIMGDelegate(uint target, uint attachment, uint texture, int level, int layer, int xscale, int yscale);
		private delegate void glRenderbufferStorageMultisampleIMGDelegate(uint target, int samples, uint internalformat, int width, int height);
		private delegate void glFramebufferTexture2DMultisampleIMGDelegate(uint target, uint attachment, uint textarget, uint texture, int level, int samples);
		private delegate void glClipPlanefIMGDelegate(uint p, float[] eqn);
		private delegate void glClipPlanexIMGDelegate(uint p, Int32[] eqn);
		private delegate void glBlendFuncSeparateINGRDelegate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
		private delegate void glApplyFramebufferAttachmentCMAAINTELDelegate();
		private delegate void glSyncTextureINTELDelegate(uint texture);
		private delegate void glUnmapTexture2DINTELDelegate(uint texture, int level);
		private delegate void glMapTexture2DINTELDelegate(uint texture, int level, uint access, int[] stride, uint[] layout);
		private delegate void glVertexPointervINTELDelegate(int size, uint type, nint pointer);
		private delegate void glNormalPointervINTELDelegate(uint type, nint pointer);
		private delegate void glColorPointervINTELDelegate(int size, uint type, nint pointer);
		private delegate void glTexCoordPointervINTELDelegate(int size, uint type, nint pointer);
		private delegate void glBeginPerfQueryINTELDelegate(uint queryHandle);
		private delegate void glCreatePerfQueryINTELDelegate(uint queryId, uint[] queryHandle);
		private delegate void glDeletePerfQueryINTELDelegate(uint queryHandle);
		private delegate void glEndPerfQueryINTELDelegate(uint queryHandle);
		private delegate void glGetFirstPerfQueryIdINTELDelegate(uint[] queryId);
		private delegate void glGetNextPerfQueryIdINTELDelegate(uint queryId, uint[] nextQueryId);
		private delegate void glGetPerfCounterInfoINTELDelegate(uint queryId, uint counterId, uint counterNameLength, char[] counterName, uint counterDescLength, char[] counterDesc, uint[] counterOffset, uint[] counterDataSize, uint[] counterTypeEnum, uint[] counterDataTypeEnum, UInt64[] rawCounterMaxValue);
		private delegate void glGetPerfQueryDataINTELDelegate(uint queryHandle, uint flags, int dataSize, nint data, uint[] bytesWritten);
		private delegate void glGetPerfQueryIdByNameINTELDelegate(char[] queryName, uint[] queryId);
		private delegate void glGetPerfQueryInfoINTELDelegate(uint queryId, uint queryNameLength, char[] queryName, uint[] dataSize, uint[] noCounters, uint[] noInstances, uint[] capsMask);
		private delegate void glBlendBarrierKHRDelegate();
		private delegate void glDebugMessageControlDelegate(uint source, uint type, uint severity, int count, uint[] ids, bool enabled);
		private delegate void glDebugMessageInsertDelegate(uint source, uint type, uint id, uint severity, int length, char[] buf);
		private delegate void glDebugMessageCallbackDelegate(nint callback, nint userParam);
		private delegate uint glGetDebugMessageLogDelegate(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, char[] messageLog);
		private delegate void glPushDebugGroupDelegate(uint source, uint id, int length, char[] message);
		private delegate void glPopDebugGroupDelegate();
		private delegate void glObjectLabelDelegate(uint identifier, uint name, int length, char[] label);
		private delegate void glGetObjectLabelDelegate(uint identifier, uint name, int bufSize, int[] length, char[] label);
		private delegate void glObjectPtrLabelDelegate(nint ptr, int length, char[] label);
		private delegate void glGetObjectPtrLabelDelegate(nint ptr, int bufSize, int[] length, char[] label);
		private delegate void glGetPointervDelegate(uint pname, nint @params);
		private delegate void glDebugMessageControlKHRDelegate(uint source, uint type, uint severity, int count, uint[] ids, bool enabled);
		private delegate void glDebugMessageInsertKHRDelegate(uint source, uint type, uint id, uint severity, int length, char[] buf);
		private delegate void glDebugMessageCallbackKHRDelegate(nint callback, nint userParam);
		private delegate uint glGetDebugMessageLogKHRDelegate(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, char[] messageLog);
		private delegate void glPushDebugGroupKHRDelegate(uint source, uint id, int length, char[] message);
		private delegate void glPopDebugGroupKHRDelegate();
		private delegate void glObjectLabelKHRDelegate(uint identifier, uint name, int length, char[] label);
		private delegate void glGetObjectLabelKHRDelegate(uint identifier, uint name, int bufSize, int[] length, char[] label);
		private delegate void glObjectPtrLabelKHRDelegate(nint ptr, int length, char[] label);
		private delegate void glGetObjectPtrLabelKHRDelegate(nint ptr, int bufSize, int[] length, char[] label);
		private delegate void glGetPointervKHRDelegate(uint pname, nint @params);
		private delegate uint glGetGraphicsResetStatusDelegate();
		private delegate void glReadnPixelsDelegate(int x, int y, int width, int height, uint format, uint type, int bufSize, nint data);
		private delegate void glGetnUniformfvDelegate(uint program, int location, int bufSize, float[] @params);
		private delegate void glGetnUniformivDelegate(uint program, int location, int bufSize, int[] @params);
		private delegate void glGetnUniformuivDelegate(uint program, int location, int bufSize, uint[] @params);
		private delegate uint glGetGraphicsResetStatusKHRDelegate();
		private delegate void glReadnPixelsKHRDelegate(int x, int y, int width, int height, uint format, uint type, int bufSize, nint data);
		private delegate void glGetnUniformfvKHRDelegate(uint program, int location, int bufSize, float[] @params);
		private delegate void glGetnUniformivKHRDelegate(uint program, int location, int bufSize, int[] @params);
		private delegate void glGetnUniformuivKHRDelegate(uint program, int location, int bufSize, uint[] @params);
		private delegate void glResizeBuffersMESADelegate();
		private delegate void glWindowPos2dMESADelegate(double x, double y);
		private delegate void glWindowPos2dvMESADelegate(double[] v);
		private delegate void glWindowPos2fMESADelegate(float x, float y);
		private delegate void glWindowPos2fvMESADelegate(float[] v);
		private delegate void glWindowPos2iMESADelegate(int x, int y);
		private delegate void glWindowPos2ivMESADelegate(int[] v);
		private delegate void glWindowPos2sMESADelegate(short x, short y);
		private delegate void glWindowPos2svMESADelegate(short[] v);
		private delegate void glWindowPos3dMESADelegate(double x, double y, double z);
		private delegate void glWindowPos3dvMESADelegate(double[] v);
		private delegate void glWindowPos3fMESADelegate(float x, float y, float z);
		private delegate void glWindowPos3fvMESADelegate(float[] v);
		private delegate void glWindowPos3iMESADelegate(int x, int y, int z);
		private delegate void glWindowPos3ivMESADelegate(int[] v);
		private delegate void glWindowPos3sMESADelegate(short x, short y, short z);
		private delegate void glWindowPos3svMESADelegate(short[] v);
		private delegate void glWindowPos4dMESADelegate(double x, double y, double z, double w);
		private delegate void glWindowPos4dvMESADelegate(double[] v);
		private delegate void glWindowPos4fMESADelegate(float x, float y, float z, float w);
		private delegate void glWindowPos4fvMESADelegate(float[] v);
		private delegate void glWindowPos4iMESADelegate(int x, int y, int z, int w);
		private delegate void glWindowPos4ivMESADelegate(int[] v);
		private delegate void glWindowPos4sMESADelegate(short x, short y, short z, short w);
		private delegate void glWindowPos4svMESADelegate(short[] v);
		private delegate void glBeginConditionalRenderNVXDelegate(uint id);
		private delegate void glEndConditionalRenderNVXDelegate();
		private delegate void glMultiDrawArraysIndirectBindlessNVDelegate(uint mode, nint indirect, int drawCount, int stride, int vertexBufferCount);
		private delegate void glMultiDrawElementsIndirectBindlessNVDelegate(uint mode, uint type, nint indirect, int drawCount, int stride, int vertexBufferCount);
		private delegate void glMultiDrawArraysIndirectBindlessCountNVDelegate(uint mode, nint indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount);
		private delegate void glMultiDrawElementsIndirectBindlessCountNVDelegate(uint mode, uint type, nint indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount);
		private delegate UInt64 glGetTextureHandleNVDelegate(uint texture);
		private delegate UInt64 glGetTextureSamplerHandleNVDelegate(uint texture, uint sampler);
		private delegate void glMakeTextureHandleResidentNVDelegate(UInt64 handle);
		private delegate void glMakeTextureHandleNonResidentNVDelegate(UInt64 handle);
		private delegate UInt64 glGetImageHandleNVDelegate(uint texture, int level, bool layered, int layer, uint format);
		private delegate void glMakeImageHandleResidentNVDelegate(UInt64 handle, uint access);
		private delegate void glMakeImageHandleNonResidentNVDelegate(UInt64 handle);
		private delegate void glUniformHandleui64NVDelegate(int location, UInt64 value);
		private delegate void glUniformHandleui64vNVDelegate(int location, int count, UInt64[] value);
		private delegate void glProgramUniformHandleui64NVDelegate(uint program, int location, UInt64 value);
		private delegate void glProgramUniformHandleui64vNVDelegate(uint program, int location, int count, UInt64[] values);
		private delegate bool glIsTextureHandleResidentNVDelegate(UInt64 handle);
		private delegate bool glIsImageHandleResidentNVDelegate(UInt64 handle);
		private delegate void glBlendParameteriNVDelegate(uint pname, int value);
		private delegate void glBlendBarrierNVDelegate();
		private delegate void glCreateStatesNVDelegate(int n, uint[] states);
		private delegate void glDeleteStatesNVDelegate(int n, uint[] states);
		private delegate bool glIsStateNVDelegate(uint state);
		private delegate void glStateCaptureNVDelegate(uint state, uint mode);
		private delegate uint glGetCommandHeaderNVDelegate(uint tokenID, uint size);
		private delegate ushort glGetStageIndexNVDelegate(uint shadertype);
		private delegate void glDrawCommandsNVDelegate(uint primitiveMode, uint buffer, nint indirects, int[] sizes, uint count);
		private delegate void glDrawCommandsAddressNVDelegate(uint primitiveMode, UInt64[] indirects, int[] sizes, uint count);
		private delegate void glDrawCommandsStatesNVDelegate(uint buffer, nint indirects, int[] sizes, uint[] states, uint[] fbos, uint count);
		private delegate void glDrawCommandsStatesAddressNVDelegate(UInt64[] indirects, int[] sizes, uint[] states, uint[] fbos, uint count);
		private delegate void glCreateCommandListsNVDelegate(int n, uint[] lists);
		private delegate void glDeleteCommandListsNVDelegate(int n, uint[] lists);
		private delegate bool glIsCommandListNVDelegate(uint list);
		private delegate void glListDrawCommandsStatesClientNVDelegate(uint list, uint segment, nint indirects, int[] sizes, uint[] states, uint[] fbos, uint count);
		private delegate void glCommandListSegmentsNVDelegate(uint list, uint segments);
		private delegate void glCompileCommandListNVDelegate(uint list);
		private delegate void glCallCommandListNVDelegate(uint list);
		private delegate void glBeginConditionalRenderNVDelegate(uint id, uint mode);
		private delegate void glEndConditionalRenderNVDelegate();
		private delegate void glSubpixelPrecisionBiasNVDelegate(uint xbits, uint ybits);
		private delegate void glConservativeRasterParameterfNVDelegate(uint pname, float value);
		private delegate void glCopyBufferSubDataNVDelegate(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size);
		private delegate void glCopyImageSubDataNVDelegate(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth);
		private delegate void glCoverageMaskNVDelegate(bool mask);
		private delegate void glCoverageOperationNVDelegate(uint operation);
		private delegate void glDepthRangedNVDelegate(double zNear, double zFar);
		private delegate void glClearDepthdNVDelegate(double depth);
		private delegate void glDepthBoundsdNVDelegate(double zmin, double zmax);
		private delegate void glDrawBuffersNVDelegate(int n, uint[] bufs);
		private delegate void glDrawArraysInstancedNVDelegate(uint mode, int first, int count, int primcount);
		private delegate void glDrawElementsInstancedNVDelegate(uint mode, int count, uint type, nint indices, int primcount);
		private delegate void glDrawTextureNVDelegate(uint texture, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);
		private delegate void glMapControlPointsNVDelegate(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, bool packed, nint points);
		private delegate void glMapParameterivNVDelegate(uint target, uint pname, int[] @params);
		private delegate void glMapParameterfvNVDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetMapControlPointsNVDelegate(uint target, uint index, uint type, int ustride, int vstride, bool packed, nint points);
		private delegate void glGetMapParameterivNVDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetMapParameterfvNVDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetMapAttribParameterivNVDelegate(uint target, uint index, uint pname, int[] @params);
		private delegate void glGetMapAttribParameterfvNVDelegate(uint target, uint index, uint pname, float[] @params);
		private delegate void glEvalMapsNVDelegate(uint target, uint mode);
		private delegate void glGetMultisamplefvNVDelegate(uint pname, uint index, float[] val);
		private delegate void glSampleMaskIndexedNVDelegate(uint index, uint mask);
		private delegate void glTexRenderbufferNVDelegate(uint target, uint renderbuffer);
		private delegate void glDeleteFencesNVDelegate(int n, uint[] fences);
		private delegate void glGenFencesNVDelegate(int n, uint[] fences);
		private delegate bool glIsFenceNVDelegate(uint fence);
		private delegate bool glTestFenceNVDelegate(uint fence);
		private delegate void glGetFenceivNVDelegate(uint fence, uint pname, int[] @params);
		private delegate void glFinishFenceNVDelegate(uint fence);
		private delegate void glSetFenceNVDelegate(uint fence, uint condition);
		private delegate void glFragmentCoverageColorNVDelegate(uint color);
		private delegate void glProgramNamedParameter4fNVDelegate(uint id, int len, byte[] name, float x, float y, float z, float w);
		private delegate void glProgramNamedParameter4fvNVDelegate(uint id, int len, byte[] name, float[] v);
		private delegate void glProgramNamedParameter4dNVDelegate(uint id, int len, byte[] name, double x, double y, double z, double w);
		private delegate void glProgramNamedParameter4dvNVDelegate(uint id, int len, byte[] name, double[] v);
		private delegate void glGetProgramNamedParameterfvNVDelegate(uint id, int len, byte[] name, float[] @params);
		private delegate void glGetProgramNamedParameterdvNVDelegate(uint id, int len, byte[] name, double[] @params);
		private delegate void glBlitFramebufferNVDelegate(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private delegate void glCoverageModulationTableNVDelegate(int n, float[] v);
		private delegate void glGetCoverageModulationTableNVDelegate(int bufsize, float[] v);
		private delegate void glCoverageModulationNVDelegate(uint components);
		private delegate void glRenderbufferStorageMultisampleNVDelegate(uint target, int samples, uint internalformat, int width, int height);
		private delegate void glRenderbufferStorageMultisampleCoverageNVDelegate(uint target, int coverageSamples, int colorSamples, uint internalformat, int width, int height);
		private delegate void glProgramVertexLimitNVDelegate(uint target, int limit);
		private delegate void glFramebufferTextureFaceEXTDelegate(uint target, uint attachment, uint texture, int level, uint face);
		private delegate void glProgramLocalParameterI4iNVDelegate(uint target, uint index, int x, int y, int z, int w);
		private delegate void glProgramLocalParameterI4ivNVDelegate(uint target, uint index, int[] @params);
		private delegate void glProgramLocalParametersI4ivNVDelegate(uint target, uint index, int count, int[] @params);
		private delegate void glProgramLocalParameterI4uiNVDelegate(uint target, uint index, uint x, uint y, uint z, uint w);
		private delegate void glProgramLocalParameterI4uivNVDelegate(uint target, uint index, uint[] @params);
		private delegate void glProgramLocalParametersI4uivNVDelegate(uint target, uint index, int count, uint[] @params);
		private delegate void glProgramEnvParameterI4iNVDelegate(uint target, uint index, int x, int y, int z, int w);
		private delegate void glProgramEnvParameterI4ivNVDelegate(uint target, uint index, int[] @params);
		private delegate void glProgramEnvParametersI4ivNVDelegate(uint target, uint index, int count, int[] @params);
		private delegate void glProgramEnvParameterI4uiNVDelegate(uint target, uint index, uint x, uint y, uint z, uint w);
		private delegate void glProgramEnvParameterI4uivNVDelegate(uint target, uint index, uint[] @params);
		private delegate void glProgramEnvParametersI4uivNVDelegate(uint target, uint index, int count, uint[] @params);
		private delegate void glGetProgramLocalParameterIivNVDelegate(uint target, uint index, int[] @params);
		private delegate void glGetProgramLocalParameterIuivNVDelegate(uint target, uint index, uint[] @params);
		private delegate void glGetProgramEnvParameterIivNVDelegate(uint target, uint index, int[] @params);
		private delegate void glGetProgramEnvParameterIuivNVDelegate(uint target, uint index, uint[] @params);
		private delegate void glProgramSubroutineParametersuivNVDelegate(uint target, int count, uint[] @params);
		private delegate void glGetProgramSubroutineParameteruivNVDelegate(uint target, uint index, uint[] param);
		private delegate void glVertex2hNVDelegate(ushort x, ushort y);
		private delegate void glVertex2hvNVDelegate(ushort[] v);
		private delegate void glVertex3hNVDelegate(ushort x, ushort y, ushort z);
		private delegate void glVertex3hvNVDelegate(ushort[] v);
		private delegate void glVertex4hNVDelegate(ushort x, ushort y, ushort z, ushort w);
		private delegate void glVertex4hvNVDelegate(ushort[] v);
		private delegate void glNormal3hNVDelegate(ushort nx, ushort ny, ushort nz);
		private delegate void glNormal3hvNVDelegate(ushort[] v);
		private delegate void glColor3hNVDelegate(ushort red, ushort green, ushort blue);
		private delegate void glColor3hvNVDelegate(ushort[] v);
		private delegate void glColor4hNVDelegate(ushort red, ushort green, ushort blue, ushort alpha);
		private delegate void glColor4hvNVDelegate(ushort[] v);
		private delegate void glTexCoord1hNVDelegate(ushort s);
		private delegate void glTexCoord1hvNVDelegate(ushort[] v);
		private delegate void glTexCoord2hNVDelegate(ushort s, ushort t);
		private delegate void glTexCoord2hvNVDelegate(ushort[] v);
		private delegate void glTexCoord3hNVDelegate(ushort s, ushort t, ushort r);
		private delegate void glTexCoord3hvNVDelegate(ushort[] v);
		private delegate void glTexCoord4hNVDelegate(ushort s, ushort t, ushort r, ushort q);
		private delegate void glTexCoord4hvNVDelegate(ushort[] v);
		private delegate void glMultiTexCoord1hNVDelegate(uint target, ushort s);
		private delegate void glMultiTexCoord1hvNVDelegate(uint target, ushort[] v);
		private delegate void glMultiTexCoord2hNVDelegate(uint target, ushort s, ushort t);
		private delegate void glMultiTexCoord2hvNVDelegate(uint target, ushort[] v);
		private delegate void glMultiTexCoord3hNVDelegate(uint target, ushort s, ushort t, ushort r);
		private delegate void glMultiTexCoord3hvNVDelegate(uint target, ushort[] v);
		private delegate void glMultiTexCoord4hNVDelegate(uint target, ushort s, ushort t, ushort r, ushort q);
		private delegate void glMultiTexCoord4hvNVDelegate(uint target, ushort[] v);
		private delegate void glFogCoordhNVDelegate(ushort fog);
		private delegate void glFogCoordhvNVDelegate(ushort[] fog);
		private delegate void glSecondaryColor3hNVDelegate(ushort red, ushort green, ushort blue);
		private delegate void glSecondaryColor3hvNVDelegate(ushort[] v);
		private delegate void glVertexWeighthNVDelegate(ushort weight);
		private delegate void glVertexWeighthvNVDelegate(ushort[] weight);
		private delegate void glVertexAttrib1hNVDelegate(uint index, ushort x);
		private delegate void glVertexAttrib1hvNVDelegate(uint index, ushort[] v);
		private delegate void glVertexAttrib2hNVDelegate(uint index, ushort x, ushort y);
		private delegate void glVertexAttrib2hvNVDelegate(uint index, ushort[] v);
		private delegate void glVertexAttrib3hNVDelegate(uint index, ushort x, ushort y, ushort z);
		private delegate void glVertexAttrib3hvNVDelegate(uint index, ushort[] v);
		private delegate void glVertexAttrib4hNVDelegate(uint index, ushort x, ushort y, ushort z, ushort w);
		private delegate void glVertexAttrib4hvNVDelegate(uint index, ushort[] v);
		private delegate void glVertexAttribs1hvNVDelegate(uint index, int n, ushort[] v);
		private delegate void glVertexAttribs2hvNVDelegate(uint index, int n, ushort[] v);
		private delegate void glVertexAttribs3hvNVDelegate(uint index, int n, ushort[] v);
		private delegate void glVertexAttribs4hvNVDelegate(uint index, int n, ushort[] v);
		private delegate void glVertexAttribDivisorNVDelegate(uint index, uint divisor);
		private delegate void glGetInternalformatSampleivNVDelegate(uint target, uint internalformat, int samples, uint pname, int bufSize, int[] @params);
		private delegate void glUniformMatrix2x3fvNVDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix3x2fvNVDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix2x4fvNVDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix4x2fvNVDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix3x4fvNVDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix4x3fvNVDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glGenOcclusionQueriesNVDelegate(int n, uint[] ids);
		private delegate void glDeleteOcclusionQueriesNVDelegate(int n, uint[] ids);
		private delegate bool glIsOcclusionQueryNVDelegate(uint id);
		private delegate void glBeginOcclusionQueryNVDelegate(uint id);
		private delegate void glEndOcclusionQueryNVDelegate();
		private delegate void glGetOcclusionQueryivNVDelegate(uint id, uint pname, int[] @params);
		private delegate void glGetOcclusionQueryuivNVDelegate(uint id, uint pname, uint[] @params);
		private delegate void glProgramBufferParametersfvNVDelegate(uint target, uint bindingIndex, uint wordIndex, int count, float[] @params);
		private delegate void glProgramBufferParametersIivNVDelegate(uint target, uint bindingIndex, uint wordIndex, int count, int[] @params);
		private delegate void glProgramBufferParametersIuivNVDelegate(uint target, uint bindingIndex, uint wordIndex, int count, uint[] @params);
		private delegate uint glGenPathsNVDelegate(int range);
		private delegate void glDeletePathsNVDelegate(uint path, int range);
		private delegate bool glIsPathNVDelegate(uint path);
		private delegate void glPathCommandsNVDelegate(uint path, int numCommands, byte[] commands, int numCoords, uint coordType, nint coords);
		private delegate void glPathCoordsNVDelegate(uint path, int numCoords, uint coordType, nint coords);
		private delegate void glPathSubCommandsNVDelegate(uint path, int commandStart, int commandsToDelete, int numCommands, byte[] commands, int numCoords, uint coordType, nint coords);
		private delegate void glPathSubCoordsNVDelegate(uint path, int coordStart, int numCoords, uint coordType, nint coords);
		private delegate void glPathStringNVDelegate(uint path, uint format, int length, nint pathString);
		private delegate void glPathGlyphsNVDelegate(uint firstPathName, uint fontTarget, nint fontName, uint fontStyle, int numGlyphs, uint type, nint charcodes, uint handleMissingGlyphs, uint pathParameterTemplate, float emScale);
		private delegate void glPathGlyphRangeNVDelegate(uint firstPathName, uint fontTarget, nint fontName, uint fontStyle, uint firstGlyph, int numGlyphs, uint handleMissingGlyphs, uint pathParameterTemplate, float emScale);
		private delegate void glWeightPathsNVDelegate(uint resultPath, int numPaths, uint[] paths, float[] weights);
		private delegate void glCopyPathNVDelegate(uint resultPath, uint srcPath);
		private delegate void glInterpolatePathsNVDelegate(uint resultPath, uint pathA, uint pathB, float weight);
		private delegate void glTransformPathNVDelegate(uint resultPath, uint srcPath, uint transformType, float[] transformValues);
		private delegate void glPathParameterivNVDelegate(uint path, uint pname, int[] value);
		private delegate void glPathParameteriNVDelegate(uint path, uint pname, int value);
		private delegate void glPathParameterfvNVDelegate(uint path, uint pname, float[] value);
		private delegate void glPathParameterfNVDelegate(uint path, uint pname, float value);
		private delegate void glPathDashArrayNVDelegate(uint path, int dashCount, float[] dashArray);
		private delegate void glPathStencilFuncNVDelegate(uint func, int @ref, uint mask);
		private delegate void glPathStencilDepthOffsetNVDelegate(float factor, float units);
		private delegate void glStencilFillPathNVDelegate(uint path, uint fillMode, uint mask);
		private delegate void glStencilStrokePathNVDelegate(uint path, int reference, uint mask);
		private delegate void glStencilFillPathInstancedNVDelegate(int numPaths, uint pathNameType, nint paths, uint pathBase, uint fillMode, uint mask, uint transformType, float[] transformValues);
		private delegate void glStencilStrokePathInstancedNVDelegate(int numPaths, uint pathNameType, nint paths, uint pathBase, int reference, uint mask, uint transformType, float[] transformValues);
		private delegate void glPathCoverDepthFuncNVDelegate(uint func);
		private delegate void glCoverFillPathNVDelegate(uint path, uint coverMode);
		private delegate void glCoverStrokePathNVDelegate(uint path, uint coverMode);
		private delegate void glCoverFillPathInstancedNVDelegate(int numPaths, uint pathNameType, nint paths, uint pathBase, uint coverMode, uint transformType, float[] transformValues);
		private delegate void glCoverStrokePathInstancedNVDelegate(int numPaths, uint pathNameType, nint paths, uint pathBase, uint coverMode, uint transformType, float[] transformValues);
		private delegate void glGetPathParameterivNVDelegate(uint path, uint pname, int[] value);
		private delegate void glGetPathParameterfvNVDelegate(uint path, uint pname, float[] value);
		private delegate void glGetPathCommandsNVDelegate(uint path, byte[] commands);
		private delegate void glGetPathCoordsNVDelegate(uint path, float[] coords);
		private delegate void glGetPathDashArrayNVDelegate(uint path, float[] dashArray);
		private delegate void glGetPathMetricsNVDelegate(uint metricQueryMask, int numPaths, uint pathNameType, nint paths, uint pathBase, int stride, float[] metrics);
		private delegate void glGetPathMetricRangeNVDelegate(uint metricQueryMask, uint firstPathName, int numPaths, int stride, float[] metrics);
		private delegate void glGetPathSpacingNVDelegate(uint pathListMode, int numPaths, uint pathNameType, nint paths, uint pathBase, float advanceScale, float kerningScale, uint transformType, float[] returnedSpacing);
		private delegate bool glIsPointInFillPathNVDelegate(uint path, uint mask, float x, float y);
		private delegate bool glIsPointInStrokePathNVDelegate(uint path, float x, float y);
		private delegate float glGetPathLengthNVDelegate(uint path, int startSegment, int numSegments);
		private delegate bool glPointAlongPathNVDelegate(uint path, int startSegment, int numSegments, float distance, float[] x, float[] y, float[] tangentX, float[] tangentY);
		private delegate void glMatrixLoad3x2fNVDelegate(uint matrixMode, float[] m);
		private delegate void glMatrixLoad3x3fNVDelegate(uint matrixMode, float[] m);
		private delegate void glMatrixLoadTranspose3x3fNVDelegate(uint matrixMode, float[] m);
		private delegate void glMatrixMult3x2fNVDelegate(uint matrixMode, float[] m);
		private delegate void glMatrixMult3x3fNVDelegate(uint matrixMode, float[] m);
		private delegate void glMatrixMultTranspose3x3fNVDelegate(uint matrixMode, float[] m);
		private delegate void glStencilThenCoverFillPathNVDelegate(uint path, uint fillMode, uint mask, uint coverMode);
		private delegate void glStencilThenCoverStrokePathNVDelegate(uint path, int reference, uint mask, uint coverMode);
		private delegate void glStencilThenCoverFillPathInstancedNVDelegate(int numPaths, uint pathNameType, nint paths, uint pathBase, uint fillMode, uint mask, uint coverMode, uint transformType, float[] transformValues);
		private delegate void glStencilThenCoverStrokePathInstancedNVDelegate(int numPaths, uint pathNameType, nint paths, uint pathBase, int reference, uint mask, uint coverMode, uint transformType, float[] transformValues);
		private delegate uint glPathGlyphIndexRangeNVDelegate(uint fontTarget, nint fontName, uint fontStyle, uint pathParameterTemplate, float emScale, uint baseAndCount);
		private delegate uint glPathGlyphIndexArrayNVDelegate(uint firstPathName, uint fontTarget, nint fontName, uint fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale);
		private delegate uint glPathMemoryGlyphIndexArrayNVDelegate(uint firstPathName, uint fontTarget, nint fontSize, nint fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale);
		private delegate void glProgramPathFragmentInputGenNVDelegate(uint program, int location, uint genMode, int components, float[] coeffs);
		private delegate void glGetProgramResourcefvNVDelegate(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, float[] @params);
		private delegate void glPathColorGenNVDelegate(uint color, uint genMode, uint colorFormat, float[] coeffs);
		private delegate void glPathTexGenNVDelegate(uint texCoordSet, uint genMode, int components, float[] coeffs);
		private delegate void glPathFogGenNVDelegate(uint genMode);
		private delegate void glGetPathColorGenivNVDelegate(uint color, uint pname, int[] value);
		private delegate void glGetPathColorGenfvNVDelegate(uint color, uint pname, float[] value);
		private delegate void glGetPathTexGenivNVDelegate(uint texCoordSet, uint pname, int[] value);
		private delegate void glGetPathTexGenfvNVDelegate(uint texCoordSet, uint pname, float[] value);
		private delegate void glPixelDataRangeNVDelegate(uint target, int length, nint pointer);
		private delegate void glFlushPixelDataRangeNVDelegate(uint target);
		private delegate void glPointParameteriNVDelegate(uint pname, int param);
		private delegate void glPointParameterivNVDelegate(uint pname, int[] @params);
		private delegate void glPolygonModeNVDelegate(uint face, uint mode);
		private delegate void glPresentFrameKeyedNVDelegate(uint video_slot, UInt64 minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint key0, uint target1, uint fill1, uint key1);
		private delegate void glPresentFrameDualFillNVDelegate(uint video_slot, UInt64 minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint target1, uint fill1, uint target2, uint fill2, uint target3, uint fill3);
		private delegate void glGetVideoivNVDelegate(uint video_slot, uint pname, int[] @params);
		private delegate void glGetVideouivNVDelegate(uint video_slot, uint pname, uint[] @params);
		private delegate void glGetVideoi64vNVDelegate(uint video_slot, uint pname, Int64[] @params);
		private delegate void glGetVideoui64vNVDelegate(uint video_slot, uint pname, UInt64[] @params);
		private delegate void glPrimitiveRestartNVDelegate();
		private delegate void glPrimitiveRestartIndexNVDelegate(uint index);
		private delegate void glReadBufferNVDelegate(uint mode);
		private delegate void glCombinerParameterfvNVDelegate(uint pname, float[] @params);
		private delegate void glCombinerParameterfNVDelegate(uint pname, float param);
		private delegate void glCombinerParameterivNVDelegate(uint pname, int[] @params);
		private delegate void glCombinerParameteriNVDelegate(uint pname, int param);
		private delegate void glCombinerInputNVDelegate(uint stage, uint portion, uint variable, uint input, uint mapping, uint componentUsage);
		private delegate void glCombinerOutputNVDelegate(uint stage, uint portion, uint abOutput, uint cdOutput, uint sumOutput, uint scale, uint bias, bool abDotProduct, bool cdDotProduct, bool muxSum);
		private delegate void glFinalCombinerInputNVDelegate(uint variable, uint input, uint mapping, uint componentUsage);
		private delegate void glGetCombinerInputParameterfvNVDelegate(uint stage, uint portion, uint variable, uint pname, float[] @params);
		private delegate void glGetCombinerInputParameterivNVDelegate(uint stage, uint portion, uint variable, uint pname, int[] @params);
		private delegate void glGetCombinerOutputParameterfvNVDelegate(uint stage, uint portion, uint pname, float[] @params);
		private delegate void glGetCombinerOutputParameterivNVDelegate(uint stage, uint portion, uint pname, int[] @params);
		private delegate void glGetFinalCombinerInputParameterfvNVDelegate(uint variable, uint pname, float[] @params);
		private delegate void glGetFinalCombinerInputParameterivNVDelegate(uint variable, uint pname, int[] @params);
		private delegate void glCombinerStageParameterfvNVDelegate(uint stage, uint pname, float[] @params);
		private delegate void glGetCombinerStageParameterfvNVDelegate(uint stage, uint pname, float[] @params);
		private delegate void glFramebufferSampleLocationsfvNVDelegate(uint target, uint start, int count, float[] v);
		private delegate void glNamedFramebufferSampleLocationsfvNVDelegate(uint framebuffer, uint start, int count, float[] v);
		private delegate void glResolveDepthValuesNVDelegate();
		private delegate void glMakeBufferResidentNVDelegate(uint target, uint access);
		private delegate void glMakeBufferNonResidentNVDelegate(uint target);
		private delegate bool glIsBufferResidentNVDelegate(uint target);
		private delegate void glMakeNamedBufferResidentNVDelegate(uint buffer, uint access);
		private delegate void glMakeNamedBufferNonResidentNVDelegate(uint buffer);
		private delegate bool glIsNamedBufferResidentNVDelegate(uint buffer);
		private delegate void glGetBufferParameterui64vNVDelegate(uint target, uint pname, UInt64[] @params);
		private delegate void glGetNamedBufferParameterui64vNVDelegate(uint buffer, uint pname, UInt64[] @params);
		private delegate void glGetIntegerui64vNVDelegate(uint value, UInt64[] result);
		private delegate void glUniformui64NVDelegate(int location, UInt64 value);
		private delegate void glUniformui64vNVDelegate(int location, int count, UInt64[] value);
		private delegate void glProgramUniformui64NVDelegate(uint program, int location, UInt64 value);
		private delegate void glProgramUniformui64vNVDelegate(uint program, int location, int count, UInt64[] value);
		private delegate void glTextureBarrierNVDelegate();
		private delegate void glTexImage2DMultisampleCoverageNVDelegate(uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, bool fixedSampleLocations);
		private delegate void glTexImage3DMultisampleCoverageNVDelegate(uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations);
		private delegate void glTextureImage2DMultisampleNVDelegate(uint texture, uint target, int samples, int internalFormat, int width, int height, bool fixedSampleLocations);
		private delegate void glTextureImage3DMultisampleNVDelegate(uint texture, uint target, int samples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations);
		private delegate void glTextureImage2DMultisampleCoverageNVDelegate(uint texture, uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, bool fixedSampleLocations);
		private delegate void glTextureImage3DMultisampleCoverageNVDelegate(uint texture, uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations);
		private delegate void glBeginTransformFeedbackNVDelegate(uint primitiveMode);
		private delegate void glEndTransformFeedbackNVDelegate();
		private delegate void glTransformFeedbackAttribsNVDelegate(int count, int[] attribs, uint bufferMode);
		private delegate void glBindBufferRangeNVDelegate(uint target, uint index, uint buffer, nint offset, nint size);
		private delegate void glBindBufferOffsetNVDelegate(uint target, uint index, uint buffer, nint offset);
		private delegate void glBindBufferBaseNVDelegate(uint target, uint index, uint buffer);
		private delegate void glTransformFeedbackVaryingsNVDelegate(uint program, int count, int[] locations, uint bufferMode);
		private delegate void glActiveVaryingNVDelegate(uint program, char[] name);
		private delegate int glGetVaryingLocationNVDelegate(uint program, char[] name);
		private delegate void glGetActiveVaryingNVDelegate(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, char[] name);
		private delegate void glGetTransformFeedbackVaryingNVDelegate(uint program, uint index, int[] location);
		private delegate void glTransformFeedbackStreamAttribsNVDelegate(int count, int[] attribs, int nbuffers, int[] bufstreams, uint bufferMode);
		private delegate void glBindTransformFeedbackNVDelegate(uint target, uint id);
		private delegate void glDeleteTransformFeedbacksNVDelegate(int n, uint[] ids);
		private delegate void glGenTransformFeedbacksNVDelegate(int n, uint[] ids);
		private delegate bool glIsTransformFeedbackNVDelegate(uint id);
		private delegate void glPauseTransformFeedbackNVDelegate();
		private delegate void glResumeTransformFeedbackNVDelegate();
		private delegate void glDrawTransformFeedbackNVDelegate(uint mode, uint id);
		private delegate void glVDPAUInitNVDelegate(nint vdpDevice, nint getProcAddress);
		private delegate void glVDPAUFiniNVDelegate();
		private delegate nint glVDPAURegisterVideoSurfaceNVDelegate(nint vdpSurface, uint target, int numTextureNames, uint[] textureNames);
		private delegate nint glVDPAURegisterOutputSurfaceNVDelegate(nint vdpSurface, uint target, int numTextureNames, uint[] textureNames);
		private delegate bool glVDPAUIsSurfaceNVDelegate(nint surface);
		private delegate void glVDPAUUnregisterSurfaceNVDelegate(nint surface);
		private delegate void glVDPAUGetSurfaceivNVDelegate(nint surface, uint pname, int bufSize, int[] length, int[] values);
		private delegate void glVDPAUSurfaceAccessNVDelegate(nint surface, uint access);
		private delegate void glVDPAUMapSurfacesNVDelegate(int numSurfaces, nint surfaces);
		private delegate void glVDPAUUnmapSurfacesNVDelegate(int numSurface, nint surfaces);
		private delegate void glFlushVertexArrayRangeNVDelegate();
		private delegate void glVertexArrayRangeNVDelegate(int length, nint pointer);
		private delegate void glVertexAttribL1i64NVDelegate(uint index, Int64 x);
		private delegate void glVertexAttribL2i64NVDelegate(uint index, Int64 x, Int64 y);
		private delegate void glVertexAttribL3i64NVDelegate(uint index, Int64 x, Int64 y, Int64 z);
		private delegate void glVertexAttribL4i64NVDelegate(uint index, Int64 x, Int64 y, Int64 z, Int64 w);
		private delegate void glVertexAttribL1i64vNVDelegate(uint index, Int64[] v);
		private delegate void glVertexAttribL2i64vNVDelegate(uint index, Int64[] v);
		private delegate void glVertexAttribL3i64vNVDelegate(uint index, Int64[] v);
		private delegate void glVertexAttribL4i64vNVDelegate(uint index, Int64[] v);
		private delegate void glVertexAttribL1ui64NVDelegate(uint index, UInt64 x);
		private delegate void glVertexAttribL2ui64NVDelegate(uint index, UInt64 x, UInt64 y);
		private delegate void glVertexAttribL3ui64NVDelegate(uint index, UInt64 x, UInt64 y, UInt64 z);
		private delegate void glVertexAttribL4ui64NVDelegate(uint index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
		private delegate void glVertexAttribL1ui64vNVDelegate(uint index, UInt64[] v);
		private delegate void glVertexAttribL2ui64vNVDelegate(uint index, UInt64[] v);
		private delegate void glVertexAttribL3ui64vNVDelegate(uint index, UInt64[] v);
		private delegate void glVertexAttribL4ui64vNVDelegate(uint index, UInt64[] v);
		private delegate void glGetVertexAttribLi64vNVDelegate(uint index, uint pname, Int64[] @params);
		private delegate void glGetVertexAttribLui64vNVDelegate(uint index, uint pname, UInt64[] @params);
		private delegate void glVertexAttribLFormatNVDelegate(uint index, int size, uint type, int stride);
		private delegate void glBufferAddressRangeNVDelegate(uint pname, uint index, UInt64 address, nint length);
		private delegate void glVertexFormatNVDelegate(int size, uint type, int stride);
		private delegate void glNormalFormatNVDelegate(uint type, int stride);
		private delegate void glColorFormatNVDelegate(int size, uint type, int stride);
		private delegate void glIndexFormatNVDelegate(uint type, int stride);
		private delegate void glTexCoordFormatNVDelegate(int size, uint type, int stride);
		private delegate void glEdgeFlagFormatNVDelegate(int stride);
		private delegate void glSecondaryColorFormatNVDelegate(int size, uint type, int stride);
		private delegate void glFogCoordFormatNVDelegate(uint type, int stride);
		private delegate void glVertexAttribFormatNVDelegate(uint index, int size, uint type, bool normalized, int stride);
		private delegate void glVertexAttribIFormatNVDelegate(uint index, int size, uint type, int stride);
		private delegate void glGetIntegerui64i_vNVDelegate(uint value, uint index, UInt64[] result);
		private delegate bool glAreProgramsResidentNVDelegate(int n, uint[] programs, bool[] residences);
		private delegate void glBindProgramNVDelegate(uint target, uint id);
		private delegate void glDeleteProgramsNVDelegate(int n, uint[] programs);
		private delegate void glExecuteProgramNVDelegate(uint target, uint id, float[] @params);
		private delegate void glGenProgramsNVDelegate(int n, uint[] programs);
		private delegate void glGetProgramParameterdvNVDelegate(uint target, uint index, uint pname, double[] @params);
		private delegate void glGetProgramParameterfvNVDelegate(uint target, uint index, uint pname, float[] @params);
		private delegate void glGetProgramivNVDelegate(uint id, uint pname, int[] @params);
		private delegate void glGetProgramStringNVDelegate(uint id, uint pname, byte[] program);
		private delegate void glGetTrackMatrixivNVDelegate(uint target, uint address, uint pname, int[] @params);
		private delegate void glGetVertexAttribdvNVDelegate(uint index, uint pname, double[] @params);
		private delegate void glGetVertexAttribfvNVDelegate(uint index, uint pname, float[] @params);
		private delegate void glGetVertexAttribivNVDelegate(uint index, uint pname, int[] @params);
		private delegate void glGetVertexAttribPointervNVDelegate(uint index, uint pname, nint pointer);
		private delegate bool glIsProgramNVDelegate(uint id);
		private delegate void glLoadProgramNVDelegate(uint target, uint id, int len, byte[] program);
		private delegate void glProgramParameter4dNVDelegate(uint target, uint index, double x, double y, double z, double w);
		private delegate void glProgramParameter4dvNVDelegate(uint target, uint index, double[] v);
		private delegate void glProgramParameter4fNVDelegate(uint target, uint index, float x, float y, float z, float w);
		private delegate void glProgramParameter4fvNVDelegate(uint target, uint index, float[] v);
		private delegate void glProgramParameters4dvNVDelegate(uint target, uint index, int count, double[] v);
		private delegate void glProgramParameters4fvNVDelegate(uint target, uint index, int count, float[] v);
		private delegate void glRequestResidentProgramsNVDelegate(int n, uint[] programs);
		private delegate void glTrackMatrixNVDelegate(uint target, uint address, uint matrix, uint transform);
		private delegate void glVertexAttribPointerNVDelegate(uint index, int fsize, uint type, int stride, nint pointer);
		private delegate void glVertexAttrib1dNVDelegate(uint index, double x);
		private delegate void glVertexAttrib1dvNVDelegate(uint index, double[] v);
		private delegate void glVertexAttrib1fNVDelegate(uint index, float x);
		private delegate void glVertexAttrib1fvNVDelegate(uint index, float[] v);
		private delegate void glVertexAttrib1sNVDelegate(uint index, short x);
		private delegate void glVertexAttrib1svNVDelegate(uint index, short[] v);
		private delegate void glVertexAttrib2dNVDelegate(uint index, double x, double y);
		private delegate void glVertexAttrib2dvNVDelegate(uint index, double[] v);
		private delegate void glVertexAttrib2fNVDelegate(uint index, float x, float y);
		private delegate void glVertexAttrib2fvNVDelegate(uint index, float[] v);
		private delegate void glVertexAttrib2sNVDelegate(uint index, short x, short y);
		private delegate void glVertexAttrib2svNVDelegate(uint index, short[] v);
		private delegate void glVertexAttrib3dNVDelegate(uint index, double x, double y, double z);
		private delegate void glVertexAttrib3dvNVDelegate(uint index, double[] v);
		private delegate void glVertexAttrib3fNVDelegate(uint index, float x, float y, float z);
		private delegate void glVertexAttrib3fvNVDelegate(uint index, float[] v);
		private delegate void glVertexAttrib3sNVDelegate(uint index, short x, short y, short z);
		private delegate void glVertexAttrib3svNVDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4dNVDelegate(uint index, double x, double y, double z, double w);
		private delegate void glVertexAttrib4dvNVDelegate(uint index, double[] v);
		private delegate void glVertexAttrib4fNVDelegate(uint index, float x, float y, float z, float w);
		private delegate void glVertexAttrib4fvNVDelegate(uint index, float[] v);
		private delegate void glVertexAttrib4sNVDelegate(uint index, short x, short y, short z, short w);
		private delegate void glVertexAttrib4svNVDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4ubNVDelegate(uint index, byte x, byte y, byte z, byte w);
		private delegate void glVertexAttrib4ubvNVDelegate(uint index, byte[] v);
		private delegate void glVertexAttribs1dvNVDelegate(uint index, int count, double[] v);
		private delegate void glVertexAttribs1fvNVDelegate(uint index, int count, float[] v);
		private delegate void glVertexAttribs1svNVDelegate(uint index, int count, short[] v);
		private delegate void glVertexAttribs2dvNVDelegate(uint index, int count, double[] v);
		private delegate void glVertexAttribs2fvNVDelegate(uint index, int count, float[] v);
		private delegate void glVertexAttribs2svNVDelegate(uint index, int count, short[] v);
		private delegate void glVertexAttribs3dvNVDelegate(uint index, int count, double[] v);
		private delegate void glVertexAttribs3fvNVDelegate(uint index, int count, float[] v);
		private delegate void glVertexAttribs3svNVDelegate(uint index, int count, short[] v);
		private delegate void glVertexAttribs4dvNVDelegate(uint index, int count, double[] v);
		private delegate void glVertexAttribs4fvNVDelegate(uint index, int count, float[] v);
		private delegate void glVertexAttribs4svNVDelegate(uint index, int count, short[] v);
		private delegate void glVertexAttribs4ubvNVDelegate(uint index, int count, byte[] v);
		private delegate void glVertexAttribI1iEXTDelegate(uint index, int x);
		private delegate void glVertexAttribI2iEXTDelegate(uint index, int x, int y);
		private delegate void glVertexAttribI3iEXTDelegate(uint index, int x, int y, int z);
		private delegate void glVertexAttribI4iEXTDelegate(uint index, int x, int y, int z, int w);
		private delegate void glVertexAttribI1uiEXTDelegate(uint index, uint x);
		private delegate void glVertexAttribI2uiEXTDelegate(uint index, uint x, uint y);
		private delegate void glVertexAttribI3uiEXTDelegate(uint index, uint x, uint y, uint z);
		private delegate void glVertexAttribI4uiEXTDelegate(uint index, uint x, uint y, uint z, uint w);
		private delegate void glVertexAttribI1ivEXTDelegate(uint index, int[] v);
		private delegate void glVertexAttribI2ivEXTDelegate(uint index, int[] v);
		private delegate void glVertexAttribI3ivEXTDelegate(uint index, int[] v);
		private delegate void glVertexAttribI4ivEXTDelegate(uint index, int[] v);
		private delegate void glVertexAttribI1uivEXTDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI2uivEXTDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI3uivEXTDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI4uivEXTDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI4bvEXTDelegate(uint index, byte[] v);
		private delegate void glVertexAttribI4svEXTDelegate(uint index, short[] v);
		private delegate void glVertexAttribI4ubvEXTDelegate(uint index, byte[] v);
		private delegate void glVertexAttribI4usvEXTDelegate(uint index, ushort[] v);
		private delegate void glVertexAttribIPointerEXTDelegate(uint index, int size, uint type, int stride, nint pointer);
		private delegate void glGetVertexAttribIivEXTDelegate(uint index, uint pname, int[] @params);
		private delegate void glGetVertexAttribIuivEXTDelegate(uint index, uint pname, uint[] @params);
		private delegate void glBeginVideoCaptureNVDelegate(uint video_capture_slot);
		private delegate void glBindVideoCaptureStreamBufferNVDelegate(uint video_capture_slot, uint stream, uint frame_region, nint offset);
		private delegate void glBindVideoCaptureStreamTextureNVDelegate(uint video_capture_slot, uint stream, uint frame_region, uint target, uint texture);
		private delegate void glEndVideoCaptureNVDelegate(uint video_capture_slot);
		private delegate void glGetVideoCaptureivNVDelegate(uint video_capture_slot, uint pname, int[] @params);
		private delegate void glGetVideoCaptureStreamivNVDelegate(uint video_capture_slot, uint stream, uint pname, int[] @params);
		private delegate void glGetVideoCaptureStreamfvNVDelegate(uint video_capture_slot, uint stream, uint pname, float[] @params);
		private delegate void glGetVideoCaptureStreamdvNVDelegate(uint video_capture_slot, uint stream, uint pname, double[] @params);
		private delegate uint glVideoCaptureNVDelegate(uint video_capture_slot, uint[] sequence_num, UInt64[] capture_time);
		private delegate void glVideoCaptureStreamParameterivNVDelegate(uint video_capture_slot, uint stream, uint pname, int[] @params);
		private delegate void glVideoCaptureStreamParameterfvNVDelegate(uint video_capture_slot, uint stream, uint pname, float[] @params);
		private delegate void glVideoCaptureStreamParameterdvNVDelegate(uint video_capture_slot, uint stream, uint pname, double[] @params);
		private delegate void glViewportArrayvNVDelegate(uint first, int count, float[] v);
		private delegate void glViewportIndexedfNVDelegate(uint index, float x, float y, float w, float h);
		private delegate void glViewportIndexedfvNVDelegate(uint index, float[] v);
		private delegate void glScissorArrayvNVDelegate(uint first, int count, int[] v);
		private delegate void glScissorIndexedNVDelegate(uint index, int left, int bottom, int width, int height);
		private delegate void glScissorIndexedvNVDelegate(uint index, int[] v);
		private delegate void glDepthRangeArrayfvNVDelegate(uint first, int count, float[] v);
		private delegate void glDepthRangeIndexedfNVDelegate(uint index, float n, float f);
		private delegate void glGetFloati_vNVDelegate(uint target, uint index, float[] data);
		private delegate void glEnableiNVDelegate(uint target, uint index);
		private delegate void glDisableiNVDelegate(uint target, uint index);
		private delegate bool glIsEnablediNVDelegate(uint target, uint index);
		private delegate void glEGLImageTargetTexture2DOESDelegate(uint target, nint image);
		private delegate void glEGLImageTargetRenderbufferStorageOESDelegate(uint target, nint image);
		private delegate void glBlendEquationSeparateOESDelegate(uint modeRGB, uint modeAlpha);
		private delegate void glBlendFuncSeparateOESDelegate(uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		private delegate void glBlendEquationOESDelegate(uint mode);
		private delegate void glMultiTexCoord1bOESDelegate(uint texture, byte s);
		private delegate void glMultiTexCoord1bvOESDelegate(uint texture, byte[] coords);
		private delegate void glMultiTexCoord2bOESDelegate(uint texture, byte s, byte t);
		private delegate void glMultiTexCoord2bvOESDelegate(uint texture, byte[] coords);
		private delegate void glMultiTexCoord3bOESDelegate(uint texture, byte s, byte t, byte r);
		private delegate void glMultiTexCoord3bvOESDelegate(uint texture, byte[] coords);
		private delegate void glMultiTexCoord4bOESDelegate(uint texture, byte s, byte t, byte r, byte q);
		private delegate void glMultiTexCoord4bvOESDelegate(uint texture, byte[] coords);
		private delegate void glTexCoord1bOESDelegate(byte s);
		private delegate void glTexCoord1bvOESDelegate(byte[] coords);
		private delegate void glTexCoord2bOESDelegate(byte s, byte t);
		private delegate void glTexCoord2bvOESDelegate(byte[] coords);
		private delegate void glTexCoord3bOESDelegate(byte s, byte t, byte r);
		private delegate void glTexCoord3bvOESDelegate(byte[] coords);
		private delegate void glTexCoord4bOESDelegate(byte s, byte t, byte r, byte q);
		private delegate void glTexCoord4bvOESDelegate(byte[] coords);
		private delegate void glVertex2bOESDelegate(byte x, byte y);
		private delegate void glVertex2bvOESDelegate(byte[] coords);
		private delegate void glVertex3bOESDelegate(byte x, byte y, byte z);
		private delegate void glVertex3bvOESDelegate(byte[] coords);
		private delegate void glVertex4bOESDelegate(byte x, byte y, byte z, byte w);
		private delegate void glVertex4bvOESDelegate(byte[] coords);
		private delegate void glCopyImageSubDataOESDelegate(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
		private delegate void glEnableiOESDelegate(uint target, uint index);
		private delegate void glDisableiOESDelegate(uint target, uint index);
		private delegate void glBlendEquationiOESDelegate(uint buf, uint mode);
		private delegate void glBlendEquationSeparateiOESDelegate(uint buf, uint modeRGB, uint modeAlpha);
		private delegate void glBlendFunciOESDelegate(uint buf, uint src, uint dst);
		private delegate void glBlendFuncSeparateiOESDelegate(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		private delegate void glColorMaskiOESDelegate(uint index, bool r, bool g, bool b, bool a);
		private delegate bool glIsEnablediOESDelegate(uint target, uint index);
		private delegate void glDrawElementsBaseVertexOESDelegate(uint mode, int count, uint type, nint indices, int basevertex);
		private delegate void glDrawRangeElementsBaseVertexOESDelegate(uint mode, uint start, uint end, int count, uint type, nint indices, int basevertex);
		private delegate void glDrawElementsInstancedBaseVertexOESDelegate(uint mode, int count, uint type, nint indices, int instancecount, int basevertex);
		private delegate void glMultiDrawElementsBaseVertexOESDelegate(uint mode, int[] count, uint type, nint indices, int primcount, int[] basevertex);
		private delegate void glDrawTexsOESDelegate(short x, short y, short z, short width, short height);
		private delegate void glDrawTexiOESDelegate(int x, int y, int z, int width, int height);
		private delegate void glDrawTexxOESDelegate(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);
		private delegate void glDrawTexsvOESDelegate(short[] coords);
		private delegate void glDrawTexivOESDelegate(int[] coords);
		private delegate void glDrawTexxvOESDelegate(Int32[] coords);
		private delegate void glDrawTexfOESDelegate(float x, float y, float z, float width, float height);
		private delegate void glDrawTexfvOESDelegate(float[] coords);
		private delegate void glAlphaFuncxOESDelegate(uint func, Int32 @ref);
		private delegate void glClearColorxOESDelegate(Int32 red, Int32 green, Int32 blue, Int32 alpha);
		private delegate void glClearDepthxOESDelegate(Int32 depth);
		private delegate void glClipPlanexOESDelegate(uint plane, Int32[] equation);
		private delegate void glColor4xOESDelegate(Int32 red, Int32 green, Int32 blue, Int32 alpha);
		private delegate void glDepthRangexOESDelegate(Int32 n, Int32 f);
		private delegate void glFogxOESDelegate(uint pname, Int32 param);
		private delegate void glFogxvOESDelegate(uint pname, Int32[] param);
		private delegate void glFrustumxOESDelegate(Int32 l, Int32 r, Int32 b, Int32 t, Int32 n, Int32 f);
		private delegate void glGetClipPlanexOESDelegate(uint plane, Int32[] equation);
		private delegate void glGetFixedvOESDelegate(uint pname, Int32[] @params);
		private delegate void glGetTexEnvxvOESDelegate(uint target, uint pname, Int32[] @params);
		private delegate void glGetTexParameterxvOESDelegate(uint target, uint pname, Int32[] @params);
		private delegate void glLightModelxOESDelegate(uint pname, Int32 param);
		private delegate void glLightModelxvOESDelegate(uint pname, Int32[] param);
		private delegate void glLightxOESDelegate(uint light, uint pname, Int32 param);
		private delegate void glLightxvOESDelegate(uint light, uint pname, Int32[] @params);
		private delegate void glLineWidthxOESDelegate(Int32 width);
		private delegate void glLoadMatrixxOESDelegate(Int32[] m);
		private delegate void glMaterialxOESDelegate(uint face, uint pname, Int32 param);
		private delegate void glMaterialxvOESDelegate(uint face, uint pname, Int32[] param);
		private delegate void glMultMatrixxOESDelegate(Int32[] m);
		private delegate void glMultiTexCoord4xOESDelegate(uint texture, Int32 s, Int32 t, Int32 r, Int32 q);
		private delegate void glNormal3xOESDelegate(Int32 nx, Int32 ny, Int32 nz);
		private delegate void glOrthoxOESDelegate(Int32 l, Int32 r, Int32 b, Int32 t, Int32 n, Int32 f);
		private delegate void glPointParameterxvOESDelegate(uint pname, Int32[] @params);
		private delegate void glPointSizexOESDelegate(Int32 size);
		private delegate void glPolygonOffsetxOESDelegate(Int32 factor, Int32 units);
		private delegate void glRotatexOESDelegate(Int32 angle, Int32 x, Int32 y, Int32 z);
		private delegate void glScalexOESDelegate(Int32 x, Int32 y, Int32 z);
		private delegate void glTexEnvxOESDelegate(uint target, uint pname, Int32 param);
		private delegate void glTexEnvxvOESDelegate(uint target, uint pname, Int32[] @params);
		private delegate void glTexParameterxOESDelegate(uint target, uint pname, Int32 param);
		private delegate void glTexParameterxvOESDelegate(uint target, uint pname, Int32[] @params);
		private delegate void glTranslatexOESDelegate(Int32 x, Int32 y, Int32 z);
		private delegate void glGetLightxvOESDelegate(uint light, uint pname, Int32[] @params);
		private delegate void glGetMaterialxvOESDelegate(uint face, uint pname, Int32[] @params);
		private delegate void glPointParameterxOESDelegate(uint pname, Int32 param);
		private delegate void glSampleCoveragexOESDelegate(int value, bool invert);
		private delegate void glAccumxOESDelegate(uint op, Int32 value);
		private delegate void glBitmapxOESDelegate(int width, int height, Int32 xorig, Int32 yorig, Int32 xmove, Int32 ymove, byte[] bitmap);
		private delegate void glBlendColorxOESDelegate(Int32 red, Int32 green, Int32 blue, Int32 alpha);
		private delegate void glClearAccumxOESDelegate(Int32 red, Int32 green, Int32 blue, Int32 alpha);
		private delegate void glColor3xOESDelegate(Int32 red, Int32 green, Int32 blue);
		private delegate void glColor3xvOESDelegate(Int32[] components);
		private delegate void glColor4xvOESDelegate(Int32[] components);
		private delegate void glConvolutionParameterxOESDelegate(uint target, uint pname, Int32 param);
		private delegate void glConvolutionParameterxvOESDelegate(uint target, uint pname, Int32[] @params);
		private delegate void glEvalCoord1xOESDelegate(Int32 u);
		private delegate void glEvalCoord1xvOESDelegate(Int32[] coords);
		private delegate void glEvalCoord2xOESDelegate(Int32 u, Int32 v);
		private delegate void glEvalCoord2xvOESDelegate(Int32[] coords);
		private delegate void glFeedbackBufferxOESDelegate(int n, uint type, Int32[] buffer);
		private delegate void glGetConvolutionParameterxvOESDelegate(uint target, uint pname, Int32[] @params);
		private delegate void glGetHistogramParameterxvOESDelegate(uint target, uint pname, Int32[] @params);
		private delegate void glGetLightxOESDelegate(uint light, uint pname, Int32[] @params);
		private delegate void glGetMapxvOESDelegate(uint target, uint query, Int32[] v);
		private delegate void glGetMaterialxOESDelegate(uint face, uint pname, Int32 param);
		private delegate void glGetPixelMapxvDelegate(uint map, int size, Int32[] values);
		private delegate void glGetTexGenxvOESDelegate(uint coord, uint pname, Int32[] @params);
		private delegate void glGetTexLevelParameterxvOESDelegate(uint target, int level, uint pname, Int32[] @params);
		private delegate void glIndexxOESDelegate(Int32 component);
		private delegate void glIndexxvOESDelegate(Int32[] component);
		private delegate void glLoadTransposeMatrixxOESDelegate(Int32[] m);
		private delegate void glMap1xOESDelegate(uint target, Int32 u1, Int32 u2, int stride, int order, Int32 points);
		private delegate void glMap2xOESDelegate(uint target, Int32 u1, Int32 u2, int ustride, int uorder, Int32 v1, Int32 v2, int vstride, int vorder, Int32 points);
		private delegate void glMapGrid1xOESDelegate(int n, Int32 u1, Int32 u2);
		private delegate void glMapGrid2xOESDelegate(int n, Int32 u1, Int32 u2, Int32 v1, Int32 v2);
		private delegate void glMultTransposeMatrixxOESDelegate(Int32[] m);
		private delegate void glMultiTexCoord1xOESDelegate(uint texture, Int32 s);
		private delegate void glMultiTexCoord1xvOESDelegate(uint texture, Int32[] coords);
		private delegate void glMultiTexCoord2xOESDelegate(uint texture, Int32 s, Int32 t);
		private delegate void glMultiTexCoord2xvOESDelegate(uint texture, Int32[] coords);
		private delegate void glMultiTexCoord3xOESDelegate(uint texture, Int32 s, Int32 t, Int32 r);
		private delegate void glMultiTexCoord3xvOESDelegate(uint texture, Int32[] coords);
		private delegate void glMultiTexCoord4xvOESDelegate(uint texture, Int32[] coords);
		private delegate void glNormal3xvOESDelegate(Int32[] coords);
		private delegate void glPassThroughxOESDelegate(Int32 token);
		private delegate void glPixelMapxDelegate(uint map, int size, Int32[] values);
		private delegate void glPixelStorexDelegate(uint pname, Int32 param);
		private delegate void glPixelTransferxOESDelegate(uint pname, Int32 param);
		private delegate void glPixelZoomxOESDelegate(Int32 xfactor, Int32 yfactor);
		private delegate void glPrioritizeTexturesxOESDelegate(int n, uint[] textures, Int32[] priorities);
		private delegate void glRasterPos2xOESDelegate(Int32 x, Int32 y);
		private delegate void glRasterPos2xvOESDelegate(Int32[] coords);
		private delegate void glRasterPos3xOESDelegate(Int32 x, Int32 y, Int32 z);
		private delegate void glRasterPos3xvOESDelegate(Int32[] coords);
		private delegate void glRasterPos4xOESDelegate(Int32 x, Int32 y, Int32 z, Int32 w);
		private delegate void glRasterPos4xvOESDelegate(Int32[] coords);
		private delegate void glRectxOESDelegate(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
		private delegate void glRectxvOESDelegate(Int32[] v1, Int32[] v2);
		private delegate void glTexCoord1xOESDelegate(Int32 s);
		private delegate void glTexCoord1xvOESDelegate(Int32[] coords);
		private delegate void glTexCoord2xOESDelegate(Int32 s, Int32 t);
		private delegate void glTexCoord2xvOESDelegate(Int32[] coords);
		private delegate void glTexCoord3xOESDelegate(Int32 s, Int32 t, Int32 r);
		private delegate void glTexCoord3xvOESDelegate(Int32[] coords);
		private delegate void glTexCoord4xOESDelegate(Int32 s, Int32 t, Int32 r, Int32 q);
		private delegate void glTexCoord4xvOESDelegate(Int32[] coords);
		private delegate void glTexGenxOESDelegate(uint coord, uint pname, Int32 param);
		private delegate void glTexGenxvOESDelegate(uint coord, uint pname, Int32[] @params);
		private delegate void glVertex2xOESDelegate(Int32 x);
		private delegate void glVertex2xvOESDelegate(Int32[] coords);
		private delegate void glVertex3xOESDelegate(Int32 x, Int32 y);
		private delegate void glVertex3xvOESDelegate(Int32[] coords);
		private delegate void glVertex4xOESDelegate(Int32 x, Int32 y, Int32 z);
		private delegate void glVertex4xvOESDelegate(Int32[] coords);
		private delegate bool glIsRenderbufferOESDelegate(uint renderbuffer);
		private delegate void glBindRenderbufferOESDelegate(uint target, uint renderbuffer);
		private delegate void glDeleteRenderbuffersOESDelegate(int n, uint[] renderbuffers);
		private delegate void glGenRenderbuffersOESDelegate(int n, uint[] renderbuffers);
		private delegate void glRenderbufferStorageOESDelegate(uint target, uint internalformat, int width, int height);
		private delegate void glGetRenderbufferParameterivOESDelegate(uint target, uint pname, int[] @params);
		private delegate bool glIsFramebufferOESDelegate(uint framebuffer);
		private delegate void glBindFramebufferOESDelegate(uint target, uint framebuffer);
		private delegate void glDeleteFramebuffersOESDelegate(int n, uint[] framebuffers);
		private delegate void glGenFramebuffersOESDelegate(int n, uint[] framebuffers);
		private delegate uint glCheckFramebufferStatusOESDelegate(uint target);
		private delegate void glFramebufferRenderbufferOESDelegate(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private delegate void glFramebufferTexture2DOESDelegate(uint target, uint attachment, uint textarget, uint texture, int level);
		private delegate void glGetFramebufferAttachmentParameterivOESDelegate(uint target, uint attachment, uint pname, int[] @params);
		private delegate void glGenerateMipmapOESDelegate(uint target);
		private delegate void glFramebufferTextureOESDelegate(uint target, uint attachment, uint texture, int level);
		private delegate void glGetProgramBinaryOESDelegate(uint program, int bufSize, int[] length, uint[] binaryFormat, nint binary);
		private delegate void glProgramBinaryOESDelegate(uint program, uint binaryFormat, nint binary, int length);
		private delegate void glMapBufferOESDelegate(uint target, uint access);
		private delegate bool glUnmapBufferOESDelegate(uint target);
		private delegate void glGetBufferPointervOESDelegate(uint target, uint pname, nint @params);
		private delegate void glCurrentPaletteMatrixOESDelegate(uint matrixpaletteindex);
		private delegate void glLoadPaletteFromModelViewMatrixOESDelegate();
		private delegate void glMatrixIndexPointerOESDelegate(int size, uint type, int stride, nint pointer);
		private delegate void glWeightPointerOESDelegate(int size, uint type, int stride, nint pointer);
		private delegate void glPointSizePointerOESDelegate(uint type, int stride, nint pointer);
		private delegate void glPrimitiveBoundingBoxOESDelegate(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
		private delegate uint glQueryMatrixxOESDelegate(Int32[] mantissa, int[] exponent);
		private delegate void glMinSampleShadingOESDelegate(float value);
		private delegate void glClearDepthfOESDelegate(float depth);
		private delegate void glClipPlanefOESDelegate(uint plane, float[] equation);
		private delegate void glDepthRangefOESDelegate(float n, float f);
		private delegate void glFrustumfOESDelegate(float l, float r, float b, float t, float n, float f);
		private delegate void glGetClipPlanefOESDelegate(uint plane, float[] equation);
		private delegate void glOrthofOESDelegate(float l, float r, float b, float t, float n, float f);
		private delegate void glPatchParameteriOESDelegate(uint pname, int value);
		private delegate void glTexImage3DOESDelegate(uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels);
		private delegate void glTexSubImage3DOESDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels);
		private delegate void glCopyTexSubImage3DOESDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		private delegate void glCompressedTexImage3DOESDelegate(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint data);
		private delegate void glCompressedTexSubImage3DOESDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data);
		private delegate void glFramebufferTexture3DOESDelegate(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
		private delegate void glTexParameterIivOESDelegate(uint target, uint pname, int[] @params);
		private delegate void glTexParameterIuivOESDelegate(uint target, uint pname, uint[] @params);
		private delegate void glGetTexParameterIivOESDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetTexParameterIuivOESDelegate(uint target, uint pname, uint[] @params);
		private delegate void glSamplerParameterIivOESDelegate(uint sampler, uint pname, int[] param);
		private delegate void glSamplerParameterIuivOESDelegate(uint sampler, uint pname, uint[] param);
		private delegate void glGetSamplerParameterIivOESDelegate(uint sampler, uint pname, int[] @params);
		private delegate void glGetSamplerParameterIuivOESDelegate(uint sampler, uint pname, uint[] @params);
		private delegate void glTexBufferOESDelegate(uint target, uint internalformat, uint buffer);
		private delegate void glTexBufferRangeOESDelegate(uint target, uint internalformat, uint buffer, nint offset, nint size);
		private delegate void glTexGenfOESDelegate(uint coord, uint pname, float param);
		private delegate void glTexGenfvOESDelegate(uint coord, uint pname, float[] @params);
		private delegate void glTexGeniOESDelegate(uint coord, uint pname, int param);
		private delegate void glTexGenivOESDelegate(uint coord, uint pname, int[] @params);
		private delegate void glGetTexGenfvOESDelegate(uint coord, uint pname, float[] @params);
		private delegate void glGetTexGenivOESDelegate(uint coord, uint pname, int[] @params);
		private delegate void glTexStorage3DMultisampleOESDelegate(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glTextureViewOESDelegate(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
		private delegate void glBindVertexArrayOESDelegate(uint array);
		private delegate void glDeleteVertexArraysOESDelegate(int n, uint[] arrays);
		private delegate void glGenVertexArraysOESDelegate(int n, uint[] arrays);
		private delegate bool glIsVertexArrayOESDelegate(uint array);
		private delegate void glFramebufferTextureMultiviewOVRDelegate(uint target, uint attachment, uint texture, int level, int baseViewIndex, int numViews);
		private delegate void glFramebufferTextureMultisampleMultiviewOVRDelegate(uint target, uint attachment, uint texture, int level, int samples, int baseViewIndex, int numViews);
		private delegate void glHintPGIDelegate(uint target, int mode);
		private delegate void glAlphaFuncQCOMDelegate(uint func, float @ref);
		private delegate void glGetDriverControlsQCOMDelegate(int[] num, int size, uint[] driverControls);
		private delegate void glGetDriverControlStringQCOMDelegate(uint driverControl, int bufSize, int[] length, char[] driverControlString);
		private delegate void glEnableDriverControlQCOMDelegate(uint driverControl);
		private delegate void glDisableDriverControlQCOMDelegate(uint driverControl);
		private delegate void glExtGetTexturesQCOMDelegate(uint[] textures, int maxTextures, int[] numTextures);
		private delegate void glExtGetBuffersQCOMDelegate(uint[] buffers, int maxBuffers, int[] numBuffers);
		private delegate void glExtGetRenderbuffersQCOMDelegate(uint[] renderbuffers, int maxRenderbuffers, int[] numRenderbuffers);
		private delegate void glExtGetFramebuffersQCOMDelegate(uint[] framebuffers, int maxFramebuffers, int[] numFramebuffers);
		private delegate void glExtGetTexLevelParameterivQCOMDelegate(uint texture, uint face, int level, uint pname, int[] @params);
		private delegate void glExtTexObjectStateOverrideiQCOMDelegate(uint target, uint pname, int param);
		private delegate void glExtGetTexSubImageQCOMDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint texels);
		private delegate void glExtGetBufferPointervQCOMDelegate(uint target, nint @params);
		private delegate void glExtGetShadersQCOMDelegate(uint[] shaders, int maxShaders, int[] numShaders);
		private delegate void glExtGetProgramsQCOMDelegate(uint[] programs, int maxPrograms, int[] numPrograms);
		private delegate bool glExtIsProgramBinaryQCOMDelegate(uint program);
		private delegate void glExtGetProgramBinarySourceQCOMDelegate(uint program, uint shadertype, char[] source, int[] length);
		private delegate void glStartTilingQCOMDelegate(uint x, uint y, uint width, uint height, uint preserveMask);
		private delegate void glEndTilingQCOMDelegate(uint preserveMask);
		private delegate void glDetailTexFuncSGISDelegate(uint target, int n, float[] points);
		private delegate void glGetDetailTexFuncSGISDelegate(uint target, float[] points);
		private delegate void glFogFuncSGISDelegate(int n, float[] points);
		private delegate void glGetFogFuncSGISDelegate(float[] points);
		private delegate void glSampleMaskSGISDelegate(float value, bool invert);
		private delegate void glSamplePatternSGISDelegate(uint pattern);
		private delegate void glPixelTexGenParameteriSGISDelegate(uint pname, int param);
		private delegate void glPixelTexGenParameterivSGISDelegate(uint pname, int[] @params);
		private delegate void glPixelTexGenParameterfSGISDelegate(uint pname, float param);
		private delegate void glPixelTexGenParameterfvSGISDelegate(uint pname, float[] @params);
		private delegate void glGetPixelTexGenParameterivSGISDelegate(uint pname, int[] @params);
		private delegate void glGetPixelTexGenParameterfvSGISDelegate(uint pname, float[] @params);
		private delegate void glPointParameterfSGISDelegate(uint pname, float param);
		private delegate void glPointParameterfvSGISDelegate(uint pname, float[] @params);
		private delegate void glSharpenTexFuncSGISDelegate(uint target, int n, float[] points);
		private delegate void glGetSharpenTexFuncSGISDelegate(uint target, float[] points);
		private delegate void glTexImage4DSGISDelegate(uint target, int level, uint internalformat, int width, int height, int depth, int size4d, int border, uint format, uint type, nint pixels);
		private delegate void glTexSubImage4DSGISDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, uint format, uint type, nint pixels);
		private delegate void glTextureColorMaskSGISDelegate(bool red, bool green, bool blue, bool alpha);
		private delegate void glGetTexFilterFuncSGISDelegate(uint target, uint filter, float[] weights);
		private delegate void glTexFilterFuncSGISDelegate(uint target, uint filter, int n, float[] weights);
		private delegate void glAsyncMarkerSGIXDelegate(uint marker);
		private delegate int glFinishAsyncSGIXDelegate(uint[] markerp);
		private delegate int glPollAsyncSGIXDelegate(uint[] markerp);
		private delegate uint glGenAsyncMarkersSGIXDelegate(int range);
		private delegate void glDeleteAsyncMarkersSGIXDelegate(uint marker, int range);
		private delegate bool glIsAsyncMarkerSGIXDelegate(uint marker);
		private delegate void glFlushRasterSGIXDelegate();
		private delegate void glFragmentColorMaterialSGIXDelegate(uint face, uint mode);
		private delegate void glFragmentLightfSGIXDelegate(uint light, uint pname, float param);
		private delegate void glFragmentLightfvSGIXDelegate(uint light, uint pname, float[] @params);
		private delegate void glFragmentLightiSGIXDelegate(uint light, uint pname, int param);
		private delegate void glFragmentLightivSGIXDelegate(uint light, uint pname, int[] @params);
		private delegate void glFragmentLightModelfSGIXDelegate(uint pname, float param);
		private delegate void glFragmentLightModelfvSGIXDelegate(uint pname, float[] @params);
		private delegate void glFragmentLightModeliSGIXDelegate(uint pname, int param);
		private delegate void glFragmentLightModelivSGIXDelegate(uint pname, int[] @params);
		private delegate void glFragmentMaterialfSGIXDelegate(uint face, uint pname, float param);
		private delegate void glFragmentMaterialfvSGIXDelegate(uint face, uint pname, float[] @params);
		private delegate void glFragmentMaterialiSGIXDelegate(uint face, uint pname, int param);
		private delegate void glFragmentMaterialivSGIXDelegate(uint face, uint pname, int[] @params);
		private delegate void glGetFragmentLightfvSGIXDelegate(uint light, uint pname, float[] @params);
		private delegate void glGetFragmentLightivSGIXDelegate(uint light, uint pname, int[] @params);
		private delegate void glGetFragmentMaterialfvSGIXDelegate(uint face, uint pname, float[] @params);
		private delegate void glGetFragmentMaterialivSGIXDelegate(uint face, uint pname, int[] @params);
		private delegate void glLightEnviSGIXDelegate(uint pname, int param);
		private delegate void glFrameZoomSGIXDelegate(int factor);
		private delegate void glIglooInterfaceSGIXDelegate(uint pname, nint @params);
		private delegate int glGetInstrumentsSGIXDelegate();
		private delegate void glInstrumentsBufferSGIXDelegate(int size, int[] buffer);
		private delegate int glPollInstrumentsSGIXDelegate(int[] marker_p);
		private delegate void glReadInstrumentsSGIXDelegate(int marker);
		private delegate void glStartInstrumentsSGIXDelegate();
		private delegate void glStopInstrumentsSGIXDelegate(int marker);
		private delegate void glGetListParameterfvSGIXDelegate(uint list, uint pname, float[] @params);
		private delegate void glGetListParameterivSGIXDelegate(uint list, uint pname, int[] @params);
		private delegate void glListParameterfSGIXDelegate(uint list, uint pname, float param);
		private delegate void glListParameterfvSGIXDelegate(uint list, uint pname, float[] @params);
		private delegate void glListParameteriSGIXDelegate(uint list, uint pname, int param);
		private delegate void glListParameterivSGIXDelegate(uint list, uint pname, int[] @params);
		private delegate void glPixelTexGenSGIXDelegate(uint mode);
		private delegate void glDeformationMap3dSGIXDelegate(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double[] points);
		private delegate void glDeformationMap3fSGIXDelegate(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float[] points);
		private delegate void glDeformSGIXDelegate(uint mask);
		private delegate void glLoadIdentityDeformationMapSGIXDelegate(uint mask);
		private delegate void glReferencePlaneSGIXDelegate(double[] equation);
		private delegate void glSpriteParameterfSGIXDelegate(uint pname, float param);
		private delegate void glSpriteParameterfvSGIXDelegate(uint pname, float[] @params);
		private delegate void glSpriteParameteriSGIXDelegate(uint pname, int param);
		private delegate void glSpriteParameterivSGIXDelegate(uint pname, int[] @params);
		private delegate void glTagSampleBufferSGIXDelegate();
		private delegate void glColorTableSGIDelegate(uint target, uint internalformat, int width, uint format, uint type, nint table);
		private delegate void glColorTableParameterfvSGIDelegate(uint target, uint pname, float[] @params);
		private delegate void glColorTableParameterivSGIDelegate(uint target, uint pname, int[] @params);
		private delegate void glCopyColorTableSGIDelegate(uint target, uint internalformat, int x, int y, int width);
		private delegate void glGetColorTableSGIDelegate(uint target, uint format, uint type, nint table);
		private delegate void glGetColorTableParameterfvSGIDelegate(uint target, uint pname, float[] @params);
		private delegate void glGetColorTableParameterivSGIDelegate(uint target, uint pname, int[] @params);
		private delegate void glFinishTextureSUNXDelegate();
		private delegate void glGlobalAlphaFactorbSUNDelegate(byte factor);
		private delegate void glGlobalAlphaFactorsSUNDelegate(short factor);
		private delegate void glGlobalAlphaFactoriSUNDelegate(int factor);
		private delegate void glGlobalAlphaFactorfSUNDelegate(float factor);
		private delegate void glGlobalAlphaFactordSUNDelegate(double factor);
		private delegate void glGlobalAlphaFactorubSUNDelegate(byte factor);
		private delegate void glGlobalAlphaFactorusSUNDelegate(ushort factor);
		private delegate void glGlobalAlphaFactoruiSUNDelegate(uint factor);
		private delegate void glDrawMeshArraysSUNDelegate(uint mode, int first, int count, int width);
		private delegate void glReplacementCodeuiSUNDelegate(uint code);
		private delegate void glReplacementCodeusSUNDelegate(ushort code);
		private delegate void glReplacementCodeubSUNDelegate(byte code);
		private delegate void glReplacementCodeuivSUNDelegate(uint[] code);
		private delegate void glReplacementCodeusvSUNDelegate(ushort[] code);
		private delegate void glReplacementCodeubvSUNDelegate(byte[] code);
		private delegate void glReplacementCodePointerSUNDelegate(uint type, int stride, nint pointer);
		private delegate void glColor4ubVertex2fSUNDelegate(byte r, byte g, byte b, byte a, float x, float y);
		private delegate void glColor4ubVertex2fvSUNDelegate(byte[] c, float[] v);
		private delegate void glColor4ubVertex3fSUNDelegate(byte r, byte g, byte b, byte a, float x, float y, float z);
		private delegate void glColor4ubVertex3fvSUNDelegate(byte[] c, float[] v);
		private delegate void glColor3fVertex3fSUNDelegate(float r, float g, float b, float x, float y, float z);
		private delegate void glColor3fVertex3fvSUNDelegate(float[] c, float[] v);
		private delegate void glNormal3fVertex3fSUNDelegate(float nx, float ny, float nz, float x, float y, float z);
		private delegate void glNormal3fVertex3fvSUNDelegate(float[] n, float[] v);
		private delegate void glColor4fNormal3fVertex3fSUNDelegate(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
		private delegate void glColor4fNormal3fVertex3fvSUNDelegate(float[] c, float[] n, float[] v);
		private delegate void glTexCoord2fVertex3fSUNDelegate(float s, float t, float x, float y, float z);
		private delegate void glTexCoord2fVertex3fvSUNDelegate(float[] tc, float[] v);
		private delegate void glTexCoord4fVertex4fSUNDelegate(float s, float t, float p, float q, float x, float y, float z, float w);
		private delegate void glTexCoord4fVertex4fvSUNDelegate(float[] tc, float[] v);
		private delegate void glTexCoord2fColor4ubVertex3fSUNDelegate(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);
		private delegate void glTexCoord2fColor4ubVertex3fvSUNDelegate(float[] tc, byte[] c, float[] v);
		private delegate void glTexCoord2fColor3fVertex3fSUNDelegate(float s, float t, float r, float g, float b, float x, float y, float z);
		private delegate void glTexCoord2fColor3fVertex3fvSUNDelegate(float[] tc, float[] c, float[] v);
		private delegate void glTexCoord2fNormal3fVertex3fSUNDelegate(float s, float t, float nx, float ny, float nz, float x, float y, float z);
		private delegate void glTexCoord2fNormal3fVertex3fvSUNDelegate(float[] tc, float[] n, float[] v);
		private delegate void glTexCoord2fColor4fNormal3fVertex3fSUNDelegate(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
		private delegate void glTexCoord2fColor4fNormal3fVertex3fvSUNDelegate(float[] tc, float[] c, float[] n, float[] v);
		private delegate void glTexCoord4fColor4fNormal3fVertex4fSUNDelegate(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);
		private delegate void glTexCoord4fColor4fNormal3fVertex4fvSUNDelegate(float[] tc, float[] c, float[] n, float[] v);
		private delegate void glReplacementCodeuiVertex3fSUNDelegate(uint rc, float x, float y, float z);
		private delegate void glReplacementCodeuiVertex3fvSUNDelegate(uint[] rc, float[] v);
		private delegate void glReplacementCodeuiColor4ubVertex3fSUNDelegate(uint rc, byte r, byte g, byte b, byte a, float x, float y, float z);
		private delegate void glReplacementCodeuiColor4ubVertex3fvSUNDelegate(uint[] rc, byte[] c, float[] v);
		private delegate void glReplacementCodeuiColor3fVertex3fSUNDelegate(uint rc, float r, float g, float b, float x, float y, float z);
		private delegate void glReplacementCodeuiColor3fVertex3fvSUNDelegate(uint[] rc, float[] c, float[] v);
		private delegate void glReplacementCodeuiNormal3fVertex3fSUNDelegate(uint rc, float nx, float ny, float nz, float x, float y, float z);
		private delegate void glReplacementCodeuiNormal3fVertex3fvSUNDelegate(uint[] rc, float[] n, float[] v);
		private delegate void glReplacementCodeuiColor4fNormal3fVertex3fSUNDelegate(uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
		private delegate void glReplacementCodeuiColor4fNormal3fVertex3fvSUNDelegate(uint[] rc, float[] c, float[] n, float[] v);
		private delegate void glReplacementCodeuiTexCoord2fVertex3fSUNDelegate(uint rc, float s, float t, float x, float y, float z);
		private delegate void glReplacementCodeuiTexCoord2fVertex3fvSUNDelegate(uint[] rc, float[] tc, float[] v);
		private delegate void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUNDelegate(uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);
		private delegate void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUNDelegate(uint[] rc, float[] tc, float[] n, float[] v);
		private delegate void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUNDelegate(uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
		private delegate void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUNDelegate(uint[] rc, float[] tc, float[] c, float[] n, float[] v);
		#endregion
		
		#region Commands
		
		public static void glTbufferMask3DFX(uint mask)
		{
			Native.GetDelegateFor<glTbufferMask3DFXDelegate>()(mask);
		}
		
		public static void glDebugMessageEnableAMD(uint category, uint severity, int count, uint[] ids, bool enabled)
		{
			Native.GetDelegateFor<glDebugMessageEnableAMDDelegate>()(category, severity, count, ids, enabled);
		}
		
		public static void glDebugMessageInsertAMD(uint category, uint severity, uint id, int length, char[] buf)
		{
			Native.GetDelegateFor<glDebugMessageInsertAMDDelegate>()(category, severity, id, length, buf);
		}
		
		public static void glDebugMessageCallbackAMD(nint callback, nint userParam)
		{
			Native.GetDelegateFor<glDebugMessageCallbackAMDDelegate>()(callback, userParam);
		}
		
		public static uint glGetDebugMessageLogAMD(uint count, int bufsize, uint[] categories, uint[] severities, uint[] ids, int[] lengths, char[] message)
		{
			return (uint)Native.GetDelegateFor<glGetDebugMessageLogAMDDelegate>()(count, bufsize, categories, severities, ids, lengths, message);
		}
		
		public static void glBlendFuncIndexedAMD(uint buf, uint src, uint dst)
		{
			Native.GetDelegateFor<glBlendFuncIndexedAMDDelegate>()(buf, src, dst);
		}
		
		public static void glBlendFuncSeparateIndexedAMD(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
		{
			Native.GetDelegateFor<glBlendFuncSeparateIndexedAMDDelegate>()(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}
		
		public static void glBlendEquationIndexedAMD(uint buf, uint mode)
		{
			Native.GetDelegateFor<glBlendEquationIndexedAMDDelegate>()(buf, mode);
		}
		
		public static void glBlendEquationSeparateIndexedAMD(uint buf, uint modeRGB, uint modeAlpha)
		{
			Native.GetDelegateFor<glBlendEquationSeparateIndexedAMDDelegate>()(buf, modeRGB, modeAlpha);
		}
		
		public static void glUniform1i64NV(int location, Int64 x)
		{
			Native.GetDelegateFor<glUniform1i64NVDelegate>()(location, x);
		}
		
		public static void glUniform2i64NV(int location, Int64 x, Int64 y)
		{
			Native.GetDelegateFor<glUniform2i64NVDelegate>()(location, x, y);
		}
		
		public static void glUniform3i64NV(int location, Int64 x, Int64 y, Int64 z)
		{
			Native.GetDelegateFor<glUniform3i64NVDelegate>()(location, x, y, z);
		}
		
		public static void glUniform4i64NV(int location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Native.GetDelegateFor<glUniform4i64NVDelegate>()(location, x, y, z, w);
		}
		
		public static void glUniform1i64vNV(int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glUniform1i64vNVDelegate>()(location, count, value);
		}
		
		public static void glUniform2i64vNV(int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glUniform2i64vNVDelegate>()(location, count, value);
		}
		
		public static void glUniform3i64vNV(int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glUniform3i64vNVDelegate>()(location, count, value);
		}
		
		public static void glUniform4i64vNV(int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glUniform4i64vNVDelegate>()(location, count, value);
		}
		
		public static void glUniform1ui64NV(int location, UInt64 x)
		{
			Native.GetDelegateFor<glUniform1ui64NVDelegate>()(location, x);
		}
		
		public static void glUniform2ui64NV(int location, UInt64 x, UInt64 y)
		{
			Native.GetDelegateFor<glUniform2ui64NVDelegate>()(location, x, y);
		}
		
		public static void glUniform3ui64NV(int location, UInt64 x, UInt64 y, UInt64 z)
		{
			Native.GetDelegateFor<glUniform3ui64NVDelegate>()(location, x, y, z);
		}
		
		public static void glUniform4ui64NV(int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Native.GetDelegateFor<glUniform4ui64NVDelegate>()(location, x, y, z, w);
		}
		
		public static void glUniform1ui64vNV(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniform1ui64vNVDelegate>()(location, count, value);
		}
		
		public static void glUniform2ui64vNV(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniform2ui64vNVDelegate>()(location, count, value);
		}
		
		public static void glUniform3ui64vNV(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniform3ui64vNVDelegate>()(location, count, value);
		}
		
		public static void glUniform4ui64vNV(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniform4ui64vNVDelegate>()(location, count, value);
		}
		
		public static void glGetUniformi64vNV(uint program, int location, Int64[] @params)
		{
			Native.GetDelegateFor<glGetUniformi64vNVDelegate>()(program, location, @params);
		}
		
		public static void glGetUniformui64vNV(uint program, int location, UInt64[] @params)
		{
			Native.GetDelegateFor<glGetUniformui64vNVDelegate>()(program, location, @params);
		}
		
		public static void glProgramUniform1i64NV(uint program, int location, Int64 x)
		{
			Native.GetDelegateFor<glProgramUniform1i64NVDelegate>()(program, location, x);
		}
		
		public static void glProgramUniform2i64NV(uint program, int location, Int64 x, Int64 y)
		{
			Native.GetDelegateFor<glProgramUniform2i64NVDelegate>()(program, location, x, y);
		}
		
		public static void glProgramUniform3i64NV(uint program, int location, Int64 x, Int64 y, Int64 z)
		{
			Native.GetDelegateFor<glProgramUniform3i64NVDelegate>()(program, location, x, y, z);
		}
		
		public static void glProgramUniform4i64NV(uint program, int location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Native.GetDelegateFor<glProgramUniform4i64NVDelegate>()(program, location, x, y, z, w);
		}
		
		public static void glProgramUniform1i64vNV(uint program, int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glProgramUniform1i64vNVDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2i64vNV(uint program, int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glProgramUniform2i64vNVDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3i64vNV(uint program, int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glProgramUniform3i64vNVDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4i64vNV(uint program, int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glProgramUniform4i64vNVDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1ui64NV(uint program, int location, UInt64 x)
		{
			Native.GetDelegateFor<glProgramUniform1ui64NVDelegate>()(program, location, x);
		}
		
		public static void glProgramUniform2ui64NV(uint program, int location, UInt64 x, UInt64 y)
		{
			Native.GetDelegateFor<glProgramUniform2ui64NVDelegate>()(program, location, x, y);
		}
		
		public static void glProgramUniform3ui64NV(uint program, int location, UInt64 x, UInt64 y, UInt64 z)
		{
			Native.GetDelegateFor<glProgramUniform3ui64NVDelegate>()(program, location, x, y, z);
		}
		
		public static void glProgramUniform4ui64NV(uint program, int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Native.GetDelegateFor<glProgramUniform4ui64NVDelegate>()(program, location, x, y, z, w);
		}
		
		public static void glProgramUniform1ui64vNV(uint program, int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glProgramUniform1ui64vNVDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2ui64vNV(uint program, int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glProgramUniform2ui64vNVDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3ui64vNV(uint program, int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glProgramUniform3ui64vNVDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4ui64vNV(uint program, int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glProgramUniform4ui64vNVDelegate>()(program, location, count, value);
		}
		
		public static void glVertexAttribParameteriAMD(uint index, uint pname, int param)
		{
			Native.GetDelegateFor<glVertexAttribParameteriAMDDelegate>()(index, pname, param);
		}
		
		public static void glMultiDrawArraysIndirectAMD(uint mode, nint indirect, int primcount, int stride)
		{
			Native.GetDelegateFor<glMultiDrawArraysIndirectAMDDelegate>()(mode, indirect, primcount, stride);
		}
		
		public static void glMultiDrawElementsIndirectAMD(uint mode, uint type, nint indirect, int primcount, int stride)
		{
			Native.GetDelegateFor<glMultiDrawElementsIndirectAMDDelegate>()(mode, type, indirect, primcount, stride);
		}
		
		public static void glGenNamesAMD(uint identifier, uint num, uint[] names)
		{
			Native.GetDelegateFor<glGenNamesAMDDelegate>()(identifier, num, names);
		}
		
		public static void glDeleteNamesAMD(uint identifier, uint num, uint[] names)
		{
			Native.GetDelegateFor<glDeleteNamesAMDDelegate>()(identifier, num, names);
		}
		
		public static bool glIsNameAMD(uint identifier, uint name)
		{
			return (bool)Native.GetDelegateFor<glIsNameAMDDelegate>()(identifier, name);
		}
		
		public static void glQueryObjectParameteruiAMD(uint target, uint id, uint pname, uint param)
		{
			Native.GetDelegateFor<glQueryObjectParameteruiAMDDelegate>()(target, id, pname, param);
		}
		
		public static void glGetPerfMonitorGroupsAMD(int[] numGroups, int groupsSize, uint[] groups)
		{
			Native.GetDelegateFor<glGetPerfMonitorGroupsAMDDelegate>()(numGroups, groupsSize, groups);
		}
		
		public static void glGetPerfMonitorCountersAMD(uint group, int[] numCounters, int[] maxActiveCounters, int counterSize, uint[] counters)
		{
			Native.GetDelegateFor<glGetPerfMonitorCountersAMDDelegate>()(group, numCounters, maxActiveCounters, counterSize, counters);
		}
		
		public static void glGetPerfMonitorGroupStringAMD(uint group, int bufSize, int[] length, char[] groupString)
		{
			Native.GetDelegateFor<glGetPerfMonitorGroupStringAMDDelegate>()(group, bufSize, length, groupString);
		}
		
		public static void glGetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int[] length, char[] counterString)
		{
			Native.GetDelegateFor<glGetPerfMonitorCounterStringAMDDelegate>()(group, counter, bufSize, length, counterString);
		}
		
		public static void glGetPerfMonitorCounterInfoAMD(uint group, uint counter, uint pname, nint data)
		{
			Native.GetDelegateFor<glGetPerfMonitorCounterInfoAMDDelegate>()(group, counter, pname, data);
		}
		
		public static void glGenPerfMonitorsAMD(int n, uint[] monitors)
		{
			Native.GetDelegateFor<glGenPerfMonitorsAMDDelegate>()(n, monitors);
		}
		
		public static void glDeletePerfMonitorsAMD(int n, uint[] monitors)
		{
			Native.GetDelegateFor<glDeletePerfMonitorsAMDDelegate>()(n, monitors);
		}
		
		public static void glSelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, uint[] counterList)
		{
			Native.GetDelegateFor<glSelectPerfMonitorCountersAMDDelegate>()(monitor, enable, group, numCounters, counterList);
		}
		
		public static void glBeginPerfMonitorAMD(uint monitor)
		{
			Native.GetDelegateFor<glBeginPerfMonitorAMDDelegate>()(monitor);
		}
		
		public static void glEndPerfMonitorAMD(uint monitor)
		{
			Native.GetDelegateFor<glEndPerfMonitorAMDDelegate>()(monitor);
		}
		
		public static void glGetPerfMonitorCounterDataAMD(uint monitor, uint pname, int dataSize, uint[] data, int[] bytesWritten)
		{
			Native.GetDelegateFor<glGetPerfMonitorCounterDataAMDDelegate>()(monitor, pname, dataSize, data, bytesWritten);
		}
		
		public static void glSetMultisamplefvAMD(uint pname, uint index, float[] val)
		{
			Native.GetDelegateFor<glSetMultisamplefvAMDDelegate>()(pname, index, val);
		}
		
		public static void glTexStorageSparseAMD(uint target, uint internalFormat, int width, int height, int depth, int layers, uint flags)
		{
			Native.GetDelegateFor<glTexStorageSparseAMDDelegate>()(target, internalFormat, width, height, depth, layers, flags);
		}
		
		public static void glTextureStorageSparseAMD(uint texture, uint target, uint internalFormat, int width, int height, int depth, int layers, uint flags)
		{
			Native.GetDelegateFor<glTextureStorageSparseAMDDelegate>()(texture, target, internalFormat, width, height, depth, layers, flags);
		}
		
		public static void glStencilOpValueAMD(uint face, uint value)
		{
			Native.GetDelegateFor<glStencilOpValueAMDDelegate>()(face, value);
		}
		
		public static void glTessellationFactorAMD(float factor)
		{
			Native.GetDelegateFor<glTessellationFactorAMDDelegate>()(factor);
		}
		
		public static void glTessellationModeAMD(uint mode)
		{
			Native.GetDelegateFor<glTessellationModeAMDDelegate>()(mode);
		}
		
		public static void glBlitFramebufferANGLE(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			Native.GetDelegateFor<glBlitFramebufferANGLEDelegate>()(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		public static void glRenderbufferStorageMultisampleANGLE(uint target, int samples, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glRenderbufferStorageMultisampleANGLEDelegate>()(target, samples, internalformat, width, height);
		}
		
		public static void glDrawArraysInstancedANGLE(uint mode, int first, int count, int primcount)
		{
			Native.GetDelegateFor<glDrawArraysInstancedANGLEDelegate>()(mode, first, count, primcount);
		}
		
		public static void glDrawElementsInstancedANGLE(uint mode, int count, uint type, nint indices, int primcount)
		{
			Native.GetDelegateFor<glDrawElementsInstancedANGLEDelegate>()(mode, count, type, indices, primcount);
		}
		
		public static void glVertexAttribDivisorANGLE(uint index, uint divisor)
		{
			Native.GetDelegateFor<glVertexAttribDivisorANGLEDelegate>()(index, divisor);
		}
		
		public static void glGetTranslatedShaderSourceANGLE(uint shader, int bufsize, int[] length, char[] source)
		{
			Native.GetDelegateFor<glGetTranslatedShaderSourceANGLEDelegate>()(shader, bufsize, length, source);
		}
		
		public static void glCopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount)
		{
			Native.GetDelegateFor<glCopyTextureLevelsAPPLEDelegate>()(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
		}
		
		public static void glElementPointerAPPLE(uint type, nint pointer)
		{
			Native.GetDelegateFor<glElementPointerAPPLEDelegate>()(type, pointer);
		}
		
		public static void glDrawElementArrayAPPLE(uint mode, int first, int count)
		{
			Native.GetDelegateFor<glDrawElementArrayAPPLEDelegate>()(mode, first, count);
		}
		
		public static void glDrawRangeElementArrayAPPLE(uint mode, uint start, uint end, int first, int count)
		{
			Native.GetDelegateFor<glDrawRangeElementArrayAPPLEDelegate>()(mode, start, end, first, count);
		}
		
		public static void glMultiDrawElementArrayAPPLE(uint mode, int[] first, int[] count, int primcount)
		{
			Native.GetDelegateFor<glMultiDrawElementArrayAPPLEDelegate>()(mode, first, count, primcount);
		}
		
		public static void glMultiDrawRangeElementArrayAPPLE(uint mode, uint start, uint end, int[] first, int[] count, int primcount)
		{
			Native.GetDelegateFor<glMultiDrawRangeElementArrayAPPLEDelegate>()(mode, start, end, first, count, primcount);
		}
		
		public static void glGenFencesAPPLE(int n, uint[] fences)
		{
			Native.GetDelegateFor<glGenFencesAPPLEDelegate>()(n, fences);
		}
		
		public static void glDeleteFencesAPPLE(int n, uint[] fences)
		{
			Native.GetDelegateFor<glDeleteFencesAPPLEDelegate>()(n, fences);
		}
		
		public static void glSetFenceAPPLE(uint fence)
		{
			Native.GetDelegateFor<glSetFenceAPPLEDelegate>()(fence);
		}
		
		public static bool glIsFenceAPPLE(uint fence)
		{
			return (bool)Native.GetDelegateFor<glIsFenceAPPLEDelegate>()(fence);
		}
		
		public static bool glTestFenceAPPLE(uint fence)
		{
			return (bool)Native.GetDelegateFor<glTestFenceAPPLEDelegate>()(fence);
		}
		
		public static void glFinishFenceAPPLE(uint fence)
		{
			Native.GetDelegateFor<glFinishFenceAPPLEDelegate>()(fence);
		}
		
		public static bool glTestObjectAPPLE(uint @object, uint name)
		{
			return (bool)Native.GetDelegateFor<glTestObjectAPPLEDelegate>()(@object, name);
		}
		
		public static void glFinishObjectAPPLE(uint @object, int name)
		{
			Native.GetDelegateFor<glFinishObjectAPPLEDelegate>()(@object, name);
		}
		
		public static void glBufferParameteriAPPLE(uint target, uint pname, int param)
		{
			Native.GetDelegateFor<glBufferParameteriAPPLEDelegate>()(target, pname, param);
		}
		
		public static void glFlushMappedBufferRangeAPPLE(uint target, nint offset, nint size)
		{
			Native.GetDelegateFor<glFlushMappedBufferRangeAPPLEDelegate>()(target, offset, size);
		}
		
		public static void glRenderbufferStorageMultisampleAPPLE(uint target, int samples, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glRenderbufferStorageMultisampleAPPLEDelegate>()(target, samples, internalformat, width, height);
		}
		
		public static void glResolveMultisampleFramebufferAPPLE()
		{
			Native.GetDelegateFor<glResolveMultisampleFramebufferAPPLEDelegate>()();
		}
		
		public static uint glObjectPurgeableAPPLE(uint objectType, uint name, uint option)
		{
			return (uint)Native.GetDelegateFor<glObjectPurgeableAPPLEDelegate>()(objectType, name, option);
		}
		
		public static uint glObjectUnpurgeableAPPLE(uint objectType, uint name, uint option)
		{
			return (uint)Native.GetDelegateFor<glObjectUnpurgeableAPPLEDelegate>()(objectType, name, option);
		}
		
		public static void glGetObjectParameterivAPPLE(uint objectType, uint name, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetObjectParameterivAPPLEDelegate>()(objectType, name, pname, @params);
		}
		
		public static nint glFenceSyncAPPLE(uint condition, uint flags)
		{
			return (nint)Native.GetDelegateFor<glFenceSyncAPPLEDelegate>()(condition, flags);
		}
		
		public static bool glIsSyncAPPLE(nint sync)
		{
			return (bool)Native.GetDelegateFor<glIsSyncAPPLEDelegate>()(sync);
		}
		
		public static void glDeleteSyncAPPLE(nint sync)
		{
			Native.GetDelegateFor<glDeleteSyncAPPLEDelegate>()(sync);
		}
		
		public static uint glClientWaitSyncAPPLE(nint sync, uint flags, UInt64 timeout)
		{
			return (uint)Native.GetDelegateFor<glClientWaitSyncAPPLEDelegate>()(sync, flags, timeout);
		}
		
		public static void glWaitSyncAPPLE(nint sync, uint flags, UInt64 timeout)
		{
			Native.GetDelegateFor<glWaitSyncAPPLEDelegate>()(sync, flags, timeout);
		}
		
		public static void glGetInteger64vAPPLE(uint pname, Int64[] @params)
		{
			Native.GetDelegateFor<glGetInteger64vAPPLEDelegate>()(pname, @params);
		}
		
		public static void glGetSyncivAPPLE(nint sync, uint pname, int bufSize, int[] length, int[] values)
		{
			Native.GetDelegateFor<glGetSyncivAPPLEDelegate>()(sync, pname, bufSize, length, values);
		}
		
		public static void glTextureRangeAPPLE(uint target, int length, nint pointer)
		{
			Native.GetDelegateFor<glTextureRangeAPPLEDelegate>()(target, length, pointer);
		}
		
		public static void glGetTexParameterPointervAPPLE(uint target, uint pname, nint @params)
		{
			Native.GetDelegateFor<glGetTexParameterPointervAPPLEDelegate>()(target, pname, @params);
		}
		
		public static void glBindVertexArrayAPPLE(uint array)
		{
			Native.GetDelegateFor<glBindVertexArrayAPPLEDelegate>()(array);
		}
		
		public static void glDeleteVertexArraysAPPLE(int n, uint[] arrays)
		{
			Native.GetDelegateFor<glDeleteVertexArraysAPPLEDelegate>()(n, arrays);
		}
		
		public static void glGenVertexArraysAPPLE(int n, uint[] arrays)
		{
			Native.GetDelegateFor<glGenVertexArraysAPPLEDelegate>()(n, arrays);
		}
		
		public static bool glIsVertexArrayAPPLE(uint array)
		{
			return (bool)Native.GetDelegateFor<glIsVertexArrayAPPLEDelegate>()(array);
		}
		
		public static void glVertexArrayRangeAPPLE(int length, nint pointer)
		{
			Native.GetDelegateFor<glVertexArrayRangeAPPLEDelegate>()(length, pointer);
		}
		
		public static void glFlushVertexArrayRangeAPPLE(int length, nint pointer)
		{
			Native.GetDelegateFor<glFlushVertexArrayRangeAPPLEDelegate>()(length, pointer);
		}
		
		public static void glVertexArrayParameteriAPPLE(uint pname, int param)
		{
			Native.GetDelegateFor<glVertexArrayParameteriAPPLEDelegate>()(pname, param);
		}
		
		public static void glEnableVertexAttribAPPLE(uint index, uint pname)
		{
			Native.GetDelegateFor<glEnableVertexAttribAPPLEDelegate>()(index, pname);
		}
		
		public static void glDisableVertexAttribAPPLE(uint index, uint pname)
		{
			Native.GetDelegateFor<glDisableVertexAttribAPPLEDelegate>()(index, pname);
		}
		
		public static bool glIsVertexAttribEnabledAPPLE(uint index, uint pname)
		{
			return (bool)Native.GetDelegateFor<glIsVertexAttribEnabledAPPLEDelegate>()(index, pname);
		}
		
		public static void glMapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, double[] points)
		{
			Native.GetDelegateFor<glMapVertexAttrib1dAPPLEDelegate>()(index, size, u1, u2, stride, order, points);
		}
		
		public static void glMapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, float[] points)
		{
			Native.GetDelegateFor<glMapVertexAttrib1fAPPLEDelegate>()(index, size, u1, u2, stride, order, points);
		}
		
		public static void glMapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points)
		{
			Native.GetDelegateFor<glMapVertexAttrib2dAPPLEDelegate>()(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		}
		
		public static void glMapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points)
		{
			Native.GetDelegateFor<glMapVertexAttrib2fAPPLEDelegate>()(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		}
		
		public static void glReleaseShaderCompiler()
		{
			Native.GetDelegateFor<glReleaseShaderCompilerDelegate>()();
		}
		
		public static void glShaderBinary(int count, uint[] shaders, uint binaryformat, nint binary, int length)
		{
			Native.GetDelegateFor<glShaderBinaryDelegate>()(count, shaders, binaryformat, binary, length);
		}
		
		public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int[] range, int[] precision)
		{
			Native.GetDelegateFor<glGetShaderPrecisionFormatDelegate>()(shadertype, precisiontype, range, precision);
		}
		
		public static void glDepthRangef(float n, float f)
		{
			Native.GetDelegateFor<glDepthRangefDelegate>()(n, f);
		}
		
		public static void glClearDepthf(float d)
		{
			Native.GetDelegateFor<glClearDepthfDelegate>()(d);
		}
		
		public static void glMemoryBarrierByRegion(uint barriers)
		{
			Native.GetDelegateFor<glMemoryBarrierByRegionDelegate>()(barriers);
		}
		
		public static void glPrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
		{
			Native.GetDelegateFor<glPrimitiveBoundingBoxARBDelegate>()(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
		}
		
		public static void glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance)
		{
			Native.GetDelegateFor<glDrawArraysInstancedBaseInstanceDelegate>()(mode, first, count, instancecount, baseinstance);
		}
		
		public static void glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, nint indices, int instancecount, uint baseinstance)
		{
			Native.GetDelegateFor<glDrawElementsInstancedBaseInstanceDelegate>()(mode, count, type, indices, instancecount, baseinstance);
		}
		
		public static void glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, nint indices, int instancecount, int basevertex, uint baseinstance)
		{
			Native.GetDelegateFor<glDrawElementsInstancedBaseVertexBaseInstanceDelegate>()(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}
		
		public static UInt64 glGetTextureHandleARB(uint texture)
		{
			return (UInt64)Native.GetDelegateFor<glGetTextureHandleARBDelegate>()(texture);
		}
		
		public static UInt64 glGetTextureSamplerHandleARB(uint texture, uint sampler)
		{
			return (UInt64)Native.GetDelegateFor<glGetTextureSamplerHandleARBDelegate>()(texture, sampler);
		}
		
		public static void glMakeTextureHandleResidentARB(UInt64 handle)
		{
			Native.GetDelegateFor<glMakeTextureHandleResidentARBDelegate>()(handle);
		}
		
		public static void glMakeTextureHandleNonResidentARB(UInt64 handle)
		{
			Native.GetDelegateFor<glMakeTextureHandleNonResidentARBDelegate>()(handle);
		}
		
		public static UInt64 glGetImageHandleARB(uint texture, int level, bool layered, int layer, uint format)
		{
			return (UInt64)Native.GetDelegateFor<glGetImageHandleARBDelegate>()(texture, level, layered, layer, format);
		}
		
		public static void glMakeImageHandleResidentARB(UInt64 handle, uint access)
		{
			Native.GetDelegateFor<glMakeImageHandleResidentARBDelegate>()(handle, access);
		}
		
		public static void glMakeImageHandleNonResidentARB(UInt64 handle)
		{
			Native.GetDelegateFor<glMakeImageHandleNonResidentARBDelegate>()(handle);
		}
		
		public static void glUniformHandleui64ARB(int location, UInt64 value)
		{
			Native.GetDelegateFor<glUniformHandleui64ARBDelegate>()(location, value);
		}
		
		public static void glUniformHandleui64vARB(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniformHandleui64vARBDelegate>()(location, count, value);
		}
		
		public static void glProgramUniformHandleui64ARB(uint program, int location, UInt64 value)
		{
			Native.GetDelegateFor<glProgramUniformHandleui64ARBDelegate>()(program, location, value);
		}
		
		public static void glProgramUniformHandleui64vARB(uint program, int location, int count, UInt64[] values)
		{
			Native.GetDelegateFor<glProgramUniformHandleui64vARBDelegate>()(program, location, count, values);
		}
		
		public static bool glIsTextureHandleResidentARB(UInt64 handle)
		{
			return (bool)Native.GetDelegateFor<glIsTextureHandleResidentARBDelegate>()(handle);
		}
		
		public static bool glIsImageHandleResidentARB(UInt64 handle)
		{
			return (bool)Native.GetDelegateFor<glIsImageHandleResidentARBDelegate>()(handle);
		}
		
		public static void glVertexAttribL1ui64ARB(uint index, UInt64 x)
		{
			Native.GetDelegateFor<glVertexAttribL1ui64ARBDelegate>()(index, x);
		}
		
		public static void glVertexAttribL1ui64vARB(uint index, UInt64[] v)
		{
			Native.GetDelegateFor<glVertexAttribL1ui64vARBDelegate>()(index, v);
		}
		
		public static void glGetVertexAttribLui64vARB(uint index, uint pname, UInt64[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribLui64vARBDelegate>()(index, pname, @params);
		}
		
		public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char[] name)
		{
			Native.GetDelegateFor<glBindFragDataLocationIndexedDelegate>()(program, colorNumber, index, name);
		}
		
		public static int glGetFragDataIndex(uint program, char[] name)
		{
			return (int)Native.GetDelegateFor<glGetFragDataIndexDelegate>()(program, name);
		}
		
		public static void glBufferStorage(uint target, nint size, nint data, uint flags)
		{
			Native.GetDelegateFor<glBufferStorageDelegate>()(target, size, data, flags);
		}
		
		public static nint glCreateSyncFromCLeventARB(nint context, nint @event, uint flags)
		{
			return (nint)Native.GetDelegateFor<glCreateSyncFromCLeventARBDelegate>()(context, @event, flags);
		}
		
		public static void glClearBufferData(uint target, uint internalformat, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glClearBufferDataDelegate>()(target, internalformat, format, type, data);
		}
		
		public static void glClearBufferSubData(uint target, uint internalformat, nint offset, nint size, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glClearBufferSubDataDelegate>()(target, internalformat, offset, size, format, type, data);
		}
		
		public static void glClearTexImage(uint texture, int level, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glClearTexImageDelegate>()(texture, level, format, type, data);
		}
		
		public static void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glClearTexSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}
		
		public static void glClipControl(uint origin, uint depth)
		{
			Native.GetDelegateFor<glClipControlDelegate>()(origin, depth);
		}
		
		public static void glClampColorARB(uint target, uint clamp)
		{
			Native.GetDelegateFor<glClampColorARBDelegate>()(target, clamp);
		}
		
		public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
		{
			Native.GetDelegateFor<glDispatchComputeDelegate>()(num_groups_x, num_groups_y, num_groups_z);
		}
		
		public static void glDispatchComputeIndirect(nint indirect)
		{
			Native.GetDelegateFor<glDispatchComputeIndirectDelegate>()(indirect);
		}
		
		public static void glDispatchComputeGroupSizeARB(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z)
		{
			Native.GetDelegateFor<glDispatchComputeGroupSizeARBDelegate>()(num_groups_x, num_groups_y, num_groups_z, group_size_x, group_size_y, group_size_z);
		}
		
		public static void glCopyBufferSubData(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size)
		{
			Native.GetDelegateFor<glCopyBufferSubDataDelegate>()(readTarget, writeTarget, readOffset, writeOffset, size);
		}
		
		public static void glCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			Native.GetDelegateFor<glCopyImageSubDataDelegate>()(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}
		
		public static void glDebugMessageControlARB(uint source, uint type, uint severity, int count, uint[] ids, bool enabled)
		{
			Native.GetDelegateFor<glDebugMessageControlARBDelegate>()(source, type, severity, count, ids, enabled);
		}
		
		public static void glDebugMessageInsertARB(uint source, uint type, uint id, uint severity, int length, char[] buf)
		{
			Native.GetDelegateFor<glDebugMessageInsertARBDelegate>()(source, type, id, severity, length, buf);
		}
		
		public static void glDebugMessageCallbackARB(nint callback, nint userParam)
		{
			Native.GetDelegateFor<glDebugMessageCallbackARBDelegate>()(callback, userParam);
		}
		
		public static uint glGetDebugMessageLogARB(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, char[] messageLog)
		{
			return (uint)Native.GetDelegateFor<glGetDebugMessageLogARBDelegate>()(count, bufSize, sources, types, ids, severities, lengths, messageLog);
		}
		
		public static void glCreateTransformFeedbacks(int n, uint[] ids)
		{
			Native.GetDelegateFor<glCreateTransformFeedbacksDelegate>()(n, ids);
		}
		
		public static void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer)
		{
			Native.GetDelegateFor<glTransformFeedbackBufferBaseDelegate>()(xfb, index, buffer);
		}
		
		public static void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, nint offset, nint size)
		{
			Native.GetDelegateFor<glTransformFeedbackBufferRangeDelegate>()(xfb, index, buffer, offset, size);
		}
		
		public static void glGetTransformFeedbackiv(uint xfb, uint pname, int[] param)
		{
			Native.GetDelegateFor<glGetTransformFeedbackivDelegate>()(xfb, pname, param);
		}
		
		public static void glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int[] param)
		{
			Native.GetDelegateFor<glGetTransformFeedbacki_vDelegate>()(xfb, pname, index, param);
		}
		
		public static void glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, Int64[] param)
		{
			Native.GetDelegateFor<glGetTransformFeedbacki64_vDelegate>()(xfb, pname, index, param);
		}
		
		public static void glCreateBuffers(int n, uint[] buffers)
		{
			Native.GetDelegateFor<glCreateBuffersDelegate>()(n, buffers);
		}
		
		public static void glNamedBufferStorage(uint buffer, nint size, nint data, uint flags)
		{
			Native.GetDelegateFor<glNamedBufferStorageDelegate>()(buffer, size, data, flags);
		}
		
		public static void glNamedBufferData(uint buffer, nint size, nint data, uint usage)
		{
			Native.GetDelegateFor<glNamedBufferDataDelegate>()(buffer, size, data, usage);
		}
		
		public static void glNamedBufferSubData(uint buffer, nint offset, nint size, nint data)
		{
			Native.GetDelegateFor<glNamedBufferSubDataDelegate>()(buffer, offset, size, data);
		}
		
		public static void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size)
		{
			Native.GetDelegateFor<glCopyNamedBufferSubDataDelegate>()(readBuffer, writeBuffer, readOffset, writeOffset, size);
		}
		
		public static void glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glClearNamedBufferDataDelegate>()(buffer, internalformat, format, type, data);
		}
		
		public static void glClearNamedBufferSubData(uint buffer, uint internalformat, nint offset, nint size, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glClearNamedBufferSubDataDelegate>()(buffer, internalformat, offset, size, format, type, data);
		}
		
		public static void glMapNamedBuffer(uint buffer, uint access)
		{
			Native.GetDelegateFor<glMapNamedBufferDelegate>()(buffer, access);
		}
		
		public static void glMapNamedBufferRange(uint buffer, nint offset, nint length, uint access)
		{
			Native.GetDelegateFor<glMapNamedBufferRangeDelegate>()(buffer, offset, length, access);
		}
		
		public static bool glUnmapNamedBuffer(uint buffer)
		{
			return (bool)Native.GetDelegateFor<glUnmapNamedBufferDelegate>()(buffer);
		}
		
		public static void glFlushMappedNamedBufferRange(uint buffer, nint offset, nint length)
		{
			Native.GetDelegateFor<glFlushMappedNamedBufferRangeDelegate>()(buffer, offset, length);
		}
		
		public static void glGetNamedBufferParameteriv(uint buffer, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetNamedBufferParameterivDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferParameteri64v(uint buffer, uint pname, Int64[] @params)
		{
			Native.GetDelegateFor<glGetNamedBufferParameteri64vDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferPointerv(uint buffer, uint pname, nint @params)
		{
			Native.GetDelegateFor<glGetNamedBufferPointervDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferSubData(uint buffer, nint offset, nint size, nint data)
		{
			Native.GetDelegateFor<glGetNamedBufferSubDataDelegate>()(buffer, offset, size, data);
		}
		
		public static void glCreateFramebuffers(int n, uint[] framebuffers)
		{
			Native.GetDelegateFor<glCreateFramebuffersDelegate>()(n, framebuffers);
		}
		
		public static void glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			Native.GetDelegateFor<glNamedFramebufferRenderbufferDelegate>()(framebuffer, attachment, renderbuffertarget, renderbuffer);
		}
		
		public static void glNamedFramebufferParameteri(uint framebuffer, uint pname, int param)
		{
			Native.GetDelegateFor<glNamedFramebufferParameteriDelegate>()(framebuffer, pname, param);
		}
		
		public static void glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level)
		{
			Native.GetDelegateFor<glNamedFramebufferTextureDelegate>()(framebuffer, attachment, texture, level);
		}
		
		public static void glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer)
		{
			Native.GetDelegateFor<glNamedFramebufferTextureLayerDelegate>()(framebuffer, attachment, texture, level, layer);
		}
		
		public static void glNamedFramebufferDrawBuffer(uint framebuffer, uint buf)
		{
			Native.GetDelegateFor<glNamedFramebufferDrawBufferDelegate>()(framebuffer, buf);
		}
		
		public static void glNamedFramebufferDrawBuffers(uint framebuffer, int n, uint[] bufs)
		{
			Native.GetDelegateFor<glNamedFramebufferDrawBuffersDelegate>()(framebuffer, n, bufs);
		}
		
		public static void glNamedFramebufferReadBuffer(uint framebuffer, uint src)
		{
			Native.GetDelegateFor<glNamedFramebufferReadBufferDelegate>()(framebuffer, src);
		}
		
		public static void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint[] attachments)
		{
			Native.GetDelegateFor<glInvalidateNamedFramebufferDataDelegate>()(framebuffer, numAttachments, attachments);
		}
		
		public static void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint[] attachments, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glInvalidateNamedFramebufferSubDataDelegate>()(framebuffer, numAttachments, attachments, x, y, width, height);
		}
		
		public static void glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int[] value)
		{
			Native.GetDelegateFor<glClearNamedFramebufferivDelegate>()(framebuffer, buffer, drawbuffer, value);
		}
		
		public static void glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint[] value)
		{
			Native.GetDelegateFor<glClearNamedFramebufferuivDelegate>()(framebuffer, buffer, drawbuffer, value);
		}
		
		public static void glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float[] value)
		{
			Native.GetDelegateFor<glClearNamedFramebufferfvDelegate>()(framebuffer, buffer, drawbuffer, value);
		}
		
		public static void glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil)
		{
			Native.GetDelegateFor<glClearNamedFramebufferfiDelegate>()(framebuffer, buffer, drawbuffer, depth, stencil);
		}
		
		public static void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			Native.GetDelegateFor<glBlitNamedFramebufferDelegate>()(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		public static uint glCheckNamedFramebufferStatus(uint framebuffer, uint target)
		{
			return (uint)Native.GetDelegateFor<glCheckNamedFramebufferStatusDelegate>()(framebuffer, target);
		}
		
		public static void glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int[] param)
		{
			Native.GetDelegateFor<glGetNamedFramebufferParameterivDelegate>()(framebuffer, pname, param);
		}
		
		public static void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetNamedFramebufferAttachmentParameterivDelegate>()(framebuffer, attachment, pname, @params);
		}
		
		public static void glCreateRenderbuffers(int n, uint[] renderbuffers)
		{
			Native.GetDelegateFor<glCreateRenderbuffersDelegate>()(n, renderbuffers);
		}
		
		public static void glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glNamedRenderbufferStorageDelegate>()(renderbuffer, internalformat, width, height);
		}
		
		public static void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glNamedRenderbufferStorageMultisampleDelegate>()(renderbuffer, samples, internalformat, width, height);
		}
		
		public static void glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetNamedRenderbufferParameterivDelegate>()(renderbuffer, pname, @params);
		}
		
		public static void glCreateTextures(uint target, int n, uint[] textures)
		{
			Native.GetDelegateFor<glCreateTexturesDelegate>()(target, n, textures);
		}
		
		public static void glTextureBuffer(uint texture, uint internalformat, uint buffer)
		{
			Native.GetDelegateFor<glTextureBufferDelegate>()(texture, internalformat, buffer);
		}
		
		public static void glTextureBufferRange(uint texture, uint internalformat, uint buffer, nint offset, nint size)
		{
			Native.GetDelegateFor<glTextureBufferRangeDelegate>()(texture, internalformat, buffer, offset, size);
		}
		
		public static void glTextureStorage1D(uint texture, int levels, uint internalformat, int width)
		{
			Native.GetDelegateFor<glTextureStorage1DDelegate>()(texture, levels, internalformat, width);
		}
		
		public static void glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glTextureStorage2DDelegate>()(texture, levels, internalformat, width, height);
		}
		
		public static void glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth)
		{
			Native.GetDelegateFor<glTextureStorage3DDelegate>()(texture, levels, internalformat, width, height, depth);
		}
		
		public static void glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			Native.GetDelegateFor<glTextureStorage2DMultisampleDelegate>()(texture, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		public static void glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			Native.GetDelegateFor<glTextureStorage3DMultisampleDelegate>()(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTextureSubImage1DDelegate>()(texture, level, xoffset, width, format, type, pixels);
		}
		
		public static void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTextureSubImage2DDelegate>()(texture, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		
		public static void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTextureSubImage3DDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		public static void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTextureSubImage1DDelegate>()(texture, level, xoffset, width, format, imageSize, data);
		}
		
		public static void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTextureSubImage2DDelegate>()(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		
		public static void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTextureSubImage3DDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		
		public static void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width)
		{
			Native.GetDelegateFor<glCopyTextureSubImage1DDelegate>()(texture, level, xoffset, x, y, width);
		}
		
		public static void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyTextureSubImage2DDelegate>()(texture, level, xoffset, yoffset, x, y, width, height);
		}
		
		public static void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyTextureSubImage3DDelegate>()(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		
		public static void glTextureParameterf(uint texture, uint pname, float param)
		{
			Native.GetDelegateFor<glTextureParameterfDelegate>()(texture, pname, param);
		}
		
		public static void glTextureParameterfv(uint texture, uint pname, float[] param)
		{
			Native.GetDelegateFor<glTextureParameterfvDelegate>()(texture, pname, param);
		}
		
		public static void glTextureParameteri(uint texture, uint pname, int param)
		{
			Native.GetDelegateFor<glTextureParameteriDelegate>()(texture, pname, param);
		}
		
		public static void glTextureParameterIiv(uint texture, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glTextureParameterIivDelegate>()(texture, pname, @params);
		}
		
		public static void glTextureParameterIuiv(uint texture, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glTextureParameterIuivDelegate>()(texture, pname, @params);
		}
		
		public static void glTextureParameteriv(uint texture, uint pname, int[] param)
		{
			Native.GetDelegateFor<glTextureParameterivDelegate>()(texture, pname, param);
		}
		
		public static void glGenerateTextureMipmap(uint texture)
		{
			Native.GetDelegateFor<glGenerateTextureMipmapDelegate>()(texture);
		}
		
		public static void glBindTextureUnit(uint unit, uint texture)
		{
			Native.GetDelegateFor<glBindTextureUnitDelegate>()(unit, texture);
		}
		
		public static void glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, nint pixels)
		{
			Native.GetDelegateFor<glGetTextureImageDelegate>()(texture, level, format, type, bufSize, pixels);
		}
		
		public static void glGetCompressedTextureImage(uint texture, int level, int bufSize, nint pixels)
		{
			Native.GetDelegateFor<glGetCompressedTextureImageDelegate>()(texture, level, bufSize, pixels);
		}
		
		public static void glGetTextureLevelParameterfv(uint texture, int level, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetTextureLevelParameterfvDelegate>()(texture, level, pname, @params);
		}
		
		public static void glGetTextureLevelParameteriv(uint texture, int level, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetTextureLevelParameterivDelegate>()(texture, level, pname, @params);
		}
		
		public static void glGetTextureParameterfv(uint texture, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetTextureParameterfvDelegate>()(texture, pname, @params);
		}
		
		public static void glGetTextureParameterIiv(uint texture, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetTextureParameterIivDelegate>()(texture, pname, @params);
		}
		
		public static void glGetTextureParameterIuiv(uint texture, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetTextureParameterIuivDelegate>()(texture, pname, @params);
		}
		
		public static void glGetTextureParameteriv(uint texture, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetTextureParameterivDelegate>()(texture, pname, @params);
		}
		
		public static void glCreateVertexArrays(int n, uint[] arrays)
		{
			Native.GetDelegateFor<glCreateVertexArraysDelegate>()(n, arrays);
		}
		
		public static void glDisableVertexArrayAttrib(uint vaobj, uint index)
		{
			Native.GetDelegateFor<glDisableVertexArrayAttribDelegate>()(vaobj, index);
		}
		
		public static void glEnableVertexArrayAttrib(uint vaobj, uint index)
		{
			Native.GetDelegateFor<glEnableVertexArrayAttribDelegate>()(vaobj, index);
		}
		
		public static void glVertexArrayElementBuffer(uint vaobj, uint buffer)
		{
			Native.GetDelegateFor<glVertexArrayElementBufferDelegate>()(vaobj, buffer);
		}
		
		public static void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, nint offset, int stride)
		{
			Native.GetDelegateFor<glVertexArrayVertexBufferDelegate>()(vaobj, bindingindex, buffer, offset, stride);
		}
		
		public static void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint[] buffers, nint offsets, int[] strides)
		{
			Native.GetDelegateFor<glVertexArrayVertexBuffersDelegate>()(vaobj, first, count, buffers, offsets, strides);
		}
		
		public static void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex)
		{
			Native.GetDelegateFor<glVertexArrayAttribBindingDelegate>()(vaobj, attribindex, bindingindex);
		}
		
		public static void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			Native.GetDelegateFor<glVertexArrayAttribFormatDelegate>()(vaobj, attribindex, size, type, normalized, relativeoffset);
		}
		
		public static void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			Native.GetDelegateFor<glVertexArrayAttribIFormatDelegate>()(vaobj, attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			Native.GetDelegateFor<glVertexArrayAttribLFormatDelegate>()(vaobj, attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor)
		{
			Native.GetDelegateFor<glVertexArrayBindingDivisorDelegate>()(vaobj, bindingindex, divisor);
		}
		
		public static void glGetVertexArrayiv(uint vaobj, uint pname, int[] param)
		{
			Native.GetDelegateFor<glGetVertexArrayivDelegate>()(vaobj, pname, param);
		}
		
		public static void glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int[] param)
		{
			Native.GetDelegateFor<glGetVertexArrayIndexedivDelegate>()(vaobj, index, pname, param);
		}
		
		public static void glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, Int64[] param)
		{
			Native.GetDelegateFor<glGetVertexArrayIndexed64ivDelegate>()(vaobj, index, pname, param);
		}
		
		public static void glCreateSamplers(int n, uint[] samplers)
		{
			Native.GetDelegateFor<glCreateSamplersDelegate>()(n, samplers);
		}
		
		public static void glCreateProgramPipelines(int n, uint[] pipelines)
		{
			Native.GetDelegateFor<glCreateProgramPipelinesDelegate>()(n, pipelines);
		}
		
		public static void glCreateQueries(uint target, int n, uint[] ids)
		{
			Native.GetDelegateFor<glCreateQueriesDelegate>()(target, n, ids);
		}
		
		public static void glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, nint offset)
		{
			Native.GetDelegateFor<glGetQueryBufferObjecti64vDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, nint offset)
		{
			Native.GetDelegateFor<glGetQueryBufferObjectivDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, nint offset)
		{
			Native.GetDelegateFor<glGetQueryBufferObjectui64vDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, nint offset)
		{
			Native.GetDelegateFor<glGetQueryBufferObjectuivDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glDrawBuffersARB(int n, uint[] bufs)
		{
			Native.GetDelegateFor<glDrawBuffersARBDelegate>()(n, bufs);
		}
		
		public static void glBlendEquationiARB(uint buf, uint mode)
		{
			Native.GetDelegateFor<glBlendEquationiARBDelegate>()(buf, mode);
		}
		
		public static void glBlendEquationSeparateiARB(uint buf, uint modeRGB, uint modeAlpha)
		{
			Native.GetDelegateFor<glBlendEquationSeparateiARBDelegate>()(buf, modeRGB, modeAlpha);
		}
		
		public static void glBlendFunciARB(uint buf, uint src, uint dst)
		{
			Native.GetDelegateFor<glBlendFunciARBDelegate>()(buf, src, dst);
		}
		
		public static void glBlendFuncSeparateiARB(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
		{
			Native.GetDelegateFor<glBlendFuncSeparateiARBDelegate>()(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}
		
		public static void glDrawElementsBaseVertex(uint mode, int count, uint type, nint indices, int basevertex)
		{
			Native.GetDelegateFor<glDrawElementsBaseVertexDelegate>()(mode, count, type, indices, basevertex);
		}
		
		public static void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, nint indices, int basevertex)
		{
			Native.GetDelegateFor<glDrawRangeElementsBaseVertexDelegate>()(mode, start, end, count, type, indices, basevertex);
		}
		
		public static void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, nint indices, int instancecount, int basevertex)
		{
			Native.GetDelegateFor<glDrawElementsInstancedBaseVertexDelegate>()(mode, count, type, indices, instancecount, basevertex);
		}
		
		public static void glMultiDrawElementsBaseVertex(uint mode, int[] count, uint type, nint indices, int drawcount, int[] basevertex)
		{
			Native.GetDelegateFor<glMultiDrawElementsBaseVertexDelegate>()(mode, count, type, indices, drawcount, basevertex);
		}
		
		public static void glDrawArraysIndirect(uint mode, nint indirect)
		{
			Native.GetDelegateFor<glDrawArraysIndirectDelegate>()(mode, indirect);
		}
		
		public static void glDrawElementsIndirect(uint mode, uint type, nint indirect)
		{
			Native.GetDelegateFor<glDrawElementsIndirectDelegate>()(mode, type, indirect);
		}
		
		public static void glDrawArraysInstancedARB(uint mode, int first, int count, int primcount)
		{
			Native.GetDelegateFor<glDrawArraysInstancedARBDelegate>()(mode, first, count, primcount);
		}
		
		public static void glDrawElementsInstancedARB(uint mode, int count, uint type, nint indices, int primcount)
		{
			Native.GetDelegateFor<glDrawElementsInstancedARBDelegate>()(mode, count, type, indices, primcount);
		}
		
		public static void glProgramStringARB(uint target, uint format, int len, nint @string)
		{
			Native.GetDelegateFor<glProgramStringARBDelegate>()(target, format, len, @string);
		}
		
		public static void glBindProgramARB(uint target, uint program)
		{
			Native.GetDelegateFor<glBindProgramARBDelegate>()(target, program);
		}
		
		public static void glDeleteProgramsARB(int n, uint[] programs)
		{
			Native.GetDelegateFor<glDeleteProgramsARBDelegate>()(n, programs);
		}
		
		public static void glGenProgramsARB(int n, uint[] programs)
		{
			Native.GetDelegateFor<glGenProgramsARBDelegate>()(n, programs);
		}
		
		public static void glProgramEnvParameter4dARB(uint target, uint index, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glProgramEnvParameter4dARBDelegate>()(target, index, x, y, z, w);
		}
		
		public static void glProgramEnvParameter4dvARB(uint target, uint index, double[] @params)
		{
			Native.GetDelegateFor<glProgramEnvParameter4dvARBDelegate>()(target, index, @params);
		}
		
		public static void glProgramEnvParameter4fARB(uint target, uint index, float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glProgramEnvParameter4fARBDelegate>()(target, index, x, y, z, w);
		}
		
		public static void glProgramEnvParameter4fvARB(uint target, uint index, float[] @params)
		{
			Native.GetDelegateFor<glProgramEnvParameter4fvARBDelegate>()(target, index, @params);
		}
		
		public static void glProgramLocalParameter4dARB(uint target, uint index, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glProgramLocalParameter4dARBDelegate>()(target, index, x, y, z, w);
		}
		
		public static void glProgramLocalParameter4dvARB(uint target, uint index, double[] @params)
		{
			Native.GetDelegateFor<glProgramLocalParameter4dvARBDelegate>()(target, index, @params);
		}
		
		public static void glProgramLocalParameter4fARB(uint target, uint index, float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glProgramLocalParameter4fARBDelegate>()(target, index, x, y, z, w);
		}
		
		public static void glProgramLocalParameter4fvARB(uint target, uint index, float[] @params)
		{
			Native.GetDelegateFor<glProgramLocalParameter4fvARBDelegate>()(target, index, @params);
		}
		
		public static void glGetProgramEnvParameterdvARB(uint target, uint index, double[] @params)
		{
			Native.GetDelegateFor<glGetProgramEnvParameterdvARBDelegate>()(target, index, @params);
		}
		
		public static void glGetProgramEnvParameterfvARB(uint target, uint index, float[] @params)
		{
			Native.GetDelegateFor<glGetProgramEnvParameterfvARBDelegate>()(target, index, @params);
		}
		
		public static void glGetProgramLocalParameterdvARB(uint target, uint index, double[] @params)
		{
			Native.GetDelegateFor<glGetProgramLocalParameterdvARBDelegate>()(target, index, @params);
		}
		
		public static void glGetProgramLocalParameterfvARB(uint target, uint index, float[] @params)
		{
			Native.GetDelegateFor<glGetProgramLocalParameterfvARBDelegate>()(target, index, @params);
		}
		
		public static void glGetProgramivARB(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetProgramivARBDelegate>()(target, pname, @params);
		}
		
		public static void glGetProgramStringARB(uint target, uint pname, nint @string)
		{
			Native.GetDelegateFor<glGetProgramStringARBDelegate>()(target, pname, @string);
		}
		
		public static bool glIsProgramARB(uint program)
		{
			return (bool)Native.GetDelegateFor<glIsProgramARBDelegate>()(program);
		}
		
		public static void glFramebufferParameteri(uint target, uint pname, int param)
		{
			Native.GetDelegateFor<glFramebufferParameteriDelegate>()(target, pname, param);
		}
		
		public static void glGetFramebufferParameteriv(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetFramebufferParameterivDelegate>()(target, pname, @params);
		}
		
		public static bool glIsRenderbuffer(uint renderbuffer)
		{
			return (bool)Native.GetDelegateFor<glIsRenderbufferDelegate>()(renderbuffer);
		}
		
		public static void glBindRenderbuffer(uint target, uint renderbuffer)
		{
			Native.GetDelegateFor<glBindRenderbufferDelegate>()(target, renderbuffer);
		}
		
		public static void glDeleteRenderbuffers(int n, uint[] renderbuffers)
		{
			Native.GetDelegateFor<glDeleteRenderbuffersDelegate>()(n, renderbuffers);
		}
		
		public static void glGenRenderbuffers(int n, uint[] renderbuffers)
		{
			Native.GetDelegateFor<glGenRenderbuffersDelegate>()(n, renderbuffers);
		}
		
		public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glRenderbufferStorageDelegate>()(target, internalformat, width, height);
		}
		
		public static void glGetRenderbufferParameteriv(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetRenderbufferParameterivDelegate>()(target, pname, @params);
		}
		
		public static bool glIsFramebuffer(uint framebuffer)
		{
			return (bool)Native.GetDelegateFor<glIsFramebufferDelegate>()(framebuffer);
		}
		
		public static void glBindFramebuffer(uint target, uint framebuffer)
		{
			Native.GetDelegateFor<glBindFramebufferDelegate>()(target, framebuffer);
		}
		
		public static void glDeleteFramebuffers(int n, uint[] framebuffers)
		{
			Native.GetDelegateFor<glDeleteFramebuffersDelegate>()(n, framebuffers);
		}
		
		public static void glGenFramebuffers(int n, uint[] framebuffers)
		{
			Native.GetDelegateFor<glGenFramebuffersDelegate>()(n, framebuffers);
		}
		
		public static uint glCheckFramebufferStatus(uint target)
		{
			return (uint)Native.GetDelegateFor<glCheckFramebufferStatusDelegate>()(target);
		}
		
		public static void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			Native.GetDelegateFor<glFramebufferTexture1DDelegate>()(target, attachment, textarget, texture, level);
		}
		
		public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			Native.GetDelegateFor<glFramebufferTexture2DDelegate>()(target, attachment, textarget, texture, level);
		}
		
		public static void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
			Native.GetDelegateFor<glFramebufferTexture3DDelegate>()(target, attachment, textarget, texture, level, zoffset);
		}
		
		public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			Native.GetDelegateFor<glFramebufferRenderbufferDelegate>()(target, attachment, renderbuffertarget, renderbuffer);
		}
		
		public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetFramebufferAttachmentParameterivDelegate>()(target, attachment, pname, @params);
		}
		
		public static void glGenerateMipmap(uint target)
		{
			Native.GetDelegateFor<glGenerateMipmapDelegate>()(target);
		}
		
		public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			Native.GetDelegateFor<glBlitFramebufferDelegate>()(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		public static void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glRenderbufferStorageMultisampleDelegate>()(target, samples, internalformat, width, height);
		}
		
		public static void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer)
		{
			Native.GetDelegateFor<glFramebufferTextureLayerDelegate>()(target, attachment, texture, level, layer);
		}
		
		public static void glProgramParameteriARB(uint program, uint pname, int value)
		{
			Native.GetDelegateFor<glProgramParameteriARBDelegate>()(program, pname, value);
		}
		
		public static void glFramebufferTextureARB(uint target, uint attachment, uint texture, int level)
		{
			Native.GetDelegateFor<glFramebufferTextureARBDelegate>()(target, attachment, texture, level);
		}
		
		public static void glFramebufferTextureLayerARB(uint target, uint attachment, uint texture, int level, int layer)
		{
			Native.GetDelegateFor<glFramebufferTextureLayerARBDelegate>()(target, attachment, texture, level, layer);
		}
		
		public static void glFramebufferTextureFaceARB(uint target, uint attachment, uint texture, int level, uint face)
		{
			Native.GetDelegateFor<glFramebufferTextureFaceARBDelegate>()(target, attachment, texture, level, face);
		}
		
		public static void glGetProgramBinary(uint program, int bufSize, int[] length, uint[] binaryFormat, nint binary)
		{
			Native.GetDelegateFor<glGetProgramBinaryDelegate>()(program, bufSize, length, binaryFormat, binary);
		}
		
		public static void glProgramBinary(uint program, uint binaryFormat, nint binary, int length)
		{
			Native.GetDelegateFor<glProgramBinaryDelegate>()(program, binaryFormat, binary, length);
		}
		
		public static void glProgramParameteri(uint program, uint pname, int value)
		{
			Native.GetDelegateFor<glProgramParameteriDelegate>()(program, pname, value);
		}
		
		public static void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, nint pixels)
		{
			Native.GetDelegateFor<glGetTextureSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
		}
		
		public static void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, nint pixels)
		{
			Native.GetDelegateFor<glGetCompressedTextureSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
		}
		
		public static void glUniform1d(int location, double x)
		{
			Native.GetDelegateFor<glUniform1dDelegate>()(location, x);
		}
		
		public static void glUniform2d(int location, double x, double y)
		{
			Native.GetDelegateFor<glUniform2dDelegate>()(location, x, y);
		}
		
		public static void glUniform3d(int location, double x, double y, double z)
		{
			Native.GetDelegateFor<glUniform3dDelegate>()(location, x, y, z);
		}
		
		public static void glUniform4d(int location, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glUniform4dDelegate>()(location, x, y, z, w);
		}
		
		public static void glUniform1dv(int location, int count, double[] value)
		{
			Native.GetDelegateFor<glUniform1dvDelegate>()(location, count, value);
		}
		
		public static void glUniform2dv(int location, int count, double[] value)
		{
			Native.GetDelegateFor<glUniform2dvDelegate>()(location, count, value);
		}
		
		public static void glUniform3dv(int location, int count, double[] value)
		{
			Native.GetDelegateFor<glUniform3dvDelegate>()(location, count, value);
		}
		
		public static void glUniform4dv(int location, int count, double[] value)
		{
			Native.GetDelegateFor<glUniform4dvDelegate>()(location, count, value);
		}
		
		public static void glUniformMatrix2dv(int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glUniformMatrix2dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3dv(int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glUniformMatrix3dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4dv(int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glUniformMatrix4dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix2x3dv(int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glUniformMatrix2x3dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix2x4dv(int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glUniformMatrix2x4dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x2dv(int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glUniformMatrix3x2dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x4dv(int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glUniformMatrix3x4dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x2dv(int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glUniformMatrix4x2dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x3dv(int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glUniformMatrix4x3dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glGetUniformdv(uint program, int location, double[] @params)
		{
			Native.GetDelegateFor<glGetUniformdvDelegate>()(program, location, @params);
		}
		
		public static void glUniform1i64ARB(int location, Int64 x)
		{
			Native.GetDelegateFor<glUniform1i64ARBDelegate>()(location, x);
		}
		
		public static void glUniform2i64ARB(int location, Int64 x, Int64 y)
		{
			Native.GetDelegateFor<glUniform2i64ARBDelegate>()(location, x, y);
		}
		
		public static void glUniform3i64ARB(int location, Int64 x, Int64 y, Int64 z)
		{
			Native.GetDelegateFor<glUniform3i64ARBDelegate>()(location, x, y, z);
		}
		
		public static void glUniform4i64ARB(int location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Native.GetDelegateFor<glUniform4i64ARBDelegate>()(location, x, y, z, w);
		}
		
		public static void glUniform1i64vARB(int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glUniform1i64vARBDelegate>()(location, count, value);
		}
		
		public static void glUniform2i64vARB(int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glUniform2i64vARBDelegate>()(location, count, value);
		}
		
		public static void glUniform3i64vARB(int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glUniform3i64vARBDelegate>()(location, count, value);
		}
		
		public static void glUniform4i64vARB(int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glUniform4i64vARBDelegate>()(location, count, value);
		}
		
		public static void glUniform1ui64ARB(int location, UInt64 x)
		{
			Native.GetDelegateFor<glUniform1ui64ARBDelegate>()(location, x);
		}
		
		public static void glUniform2ui64ARB(int location, UInt64 x, UInt64 y)
		{
			Native.GetDelegateFor<glUniform2ui64ARBDelegate>()(location, x, y);
		}
		
		public static void glUniform3ui64ARB(int location, UInt64 x, UInt64 y, UInt64 z)
		{
			Native.GetDelegateFor<glUniform3ui64ARBDelegate>()(location, x, y, z);
		}
		
		public static void glUniform4ui64ARB(int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Native.GetDelegateFor<glUniform4ui64ARBDelegate>()(location, x, y, z, w);
		}
		
		public static void glUniform1ui64vARB(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniform1ui64vARBDelegate>()(location, count, value);
		}
		
		public static void glUniform2ui64vARB(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniform2ui64vARBDelegate>()(location, count, value);
		}
		
		public static void glUniform3ui64vARB(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniform3ui64vARBDelegate>()(location, count, value);
		}
		
		public static void glUniform4ui64vARB(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniform4ui64vARBDelegate>()(location, count, value);
		}
		
		public static void glGetUniformi64vARB(uint program, int location, Int64[] @params)
		{
			Native.GetDelegateFor<glGetUniformi64vARBDelegate>()(program, location, @params);
		}
		
		public static void glGetUniformui64vARB(uint program, int location, UInt64[] @params)
		{
			Native.GetDelegateFor<glGetUniformui64vARBDelegate>()(program, location, @params);
		}
		
		public static void glGetnUniformi64vARB(uint program, int location, int bufSize, Int64[] @params)
		{
			Native.GetDelegateFor<glGetnUniformi64vARBDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformui64vARB(uint program, int location, int bufSize, UInt64[] @params)
		{
			Native.GetDelegateFor<glGetnUniformui64vARBDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glProgramUniform1i64ARB(uint program, int location, Int64 x)
		{
			Native.GetDelegateFor<glProgramUniform1i64ARBDelegate>()(program, location, x);
		}
		
		public static void glProgramUniform2i64ARB(uint program, int location, Int64 x, Int64 y)
		{
			Native.GetDelegateFor<glProgramUniform2i64ARBDelegate>()(program, location, x, y);
		}
		
		public static void glProgramUniform3i64ARB(uint program, int location, Int64 x, Int64 y, Int64 z)
		{
			Native.GetDelegateFor<glProgramUniform3i64ARBDelegate>()(program, location, x, y, z);
		}
		
		public static void glProgramUniform4i64ARB(uint program, int location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Native.GetDelegateFor<glProgramUniform4i64ARBDelegate>()(program, location, x, y, z, w);
		}
		
		public static void glProgramUniform1i64vARB(uint program, int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glProgramUniform1i64vARBDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2i64vARB(uint program, int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glProgramUniform2i64vARBDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3i64vARB(uint program, int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glProgramUniform3i64vARBDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4i64vARB(uint program, int location, int count, Int64[] value)
		{
			Native.GetDelegateFor<glProgramUniform4i64vARBDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1ui64ARB(uint program, int location, UInt64 x)
		{
			Native.GetDelegateFor<glProgramUniform1ui64ARBDelegate>()(program, location, x);
		}
		
		public static void glProgramUniform2ui64ARB(uint program, int location, UInt64 x, UInt64 y)
		{
			Native.GetDelegateFor<glProgramUniform2ui64ARBDelegate>()(program, location, x, y);
		}
		
		public static void glProgramUniform3ui64ARB(uint program, int location, UInt64 x, UInt64 y, UInt64 z)
		{
			Native.GetDelegateFor<glProgramUniform3ui64ARBDelegate>()(program, location, x, y, z);
		}
		
		public static void glProgramUniform4ui64ARB(uint program, int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Native.GetDelegateFor<glProgramUniform4ui64ARBDelegate>()(program, location, x, y, z, w);
		}
		
		public static void glProgramUniform1ui64vARB(uint program, int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glProgramUniform1ui64vARBDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2ui64vARB(uint program, int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glProgramUniform2ui64vARBDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3ui64vARB(uint program, int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glProgramUniform3ui64vARBDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4ui64vARB(uint program, int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glProgramUniform4ui64vARBDelegate>()(program, location, count, value);
		}
		
		public static void glBlendColor(float red, float green, float blue, float alpha)
		{
			Native.GetDelegateFor<glBlendColorDelegate>()(red, green, blue, alpha);
		}
		
		public static void glBlendEquation(uint mode)
		{
			Native.GetDelegateFor<glBlendEquationDelegate>()(mode);
		}
		
		public static void glColorTable(uint target, uint internalformat, int width, uint format, uint type, nint table)
		{
			Native.GetDelegateFor<glColorTableDelegate>()(target, internalformat, width, format, type, table);
		}
		
		public static void glColorTableParameterfv(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glColorTableParameterfvDelegate>()(target, pname, @params);
		}
		
		public static void glColorTableParameteriv(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glColorTableParameterivDelegate>()(target, pname, @params);
		}
		
		public static void glCopyColorTable(uint target, uint internalformat, int x, int y, int width)
		{
			Native.GetDelegateFor<glCopyColorTableDelegate>()(target, internalformat, x, y, width);
		}
		
		public static void glGetColorTable(uint target, uint format, uint type, nint table)
		{
			Native.GetDelegateFor<glGetColorTableDelegate>()(target, format, type, table);
		}
		
		public static void glGetColorTableParameterfv(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetColorTableParameterfvDelegate>()(target, pname, @params);
		}
		
		public static void glGetColorTableParameteriv(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetColorTableParameterivDelegate>()(target, pname, @params);
		}
		
		public static void glColorSubTable(uint target, int start, int count, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glColorSubTableDelegate>()(target, start, count, format, type, data);
		}
		
		public static void glCopyColorSubTable(uint target, int start, int x, int y, int width)
		{
			Native.GetDelegateFor<glCopyColorSubTableDelegate>()(target, start, x, y, width);
		}
		
		public static void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, nint image)
		{
			Native.GetDelegateFor<glConvolutionFilter1DDelegate>()(target, internalformat, width, format, type, image);
		}
		
		public static void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, nint image)
		{
			Native.GetDelegateFor<glConvolutionFilter2DDelegate>()(target, internalformat, width, height, format, type, image);
		}
		
		public static void glConvolutionParameterf(uint target, uint pname, float @params)
		{
			Native.GetDelegateFor<glConvolutionParameterfDelegate>()(target, pname, @params);
		}
		
		public static void glConvolutionParameterfv(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glConvolutionParameterfvDelegate>()(target, pname, @params);
		}
		
		public static void glConvolutionParameteri(uint target, uint pname, int @params)
		{
			Native.GetDelegateFor<glConvolutionParameteriDelegate>()(target, pname, @params);
		}
		
		public static void glConvolutionParameteriv(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glConvolutionParameterivDelegate>()(target, pname, @params);
		}
		
		public static void glCopyConvolutionFilter1D(uint target, uint internalformat, int x, int y, int width)
		{
			Native.GetDelegateFor<glCopyConvolutionFilter1DDelegate>()(target, internalformat, x, y, width);
		}
		
		public static void glCopyConvolutionFilter2D(uint target, uint internalformat, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyConvolutionFilter2DDelegate>()(target, internalformat, x, y, width, height);
		}
		
		public static void glGetConvolutionFilter(uint target, uint format, uint type, nint image)
		{
			Native.GetDelegateFor<glGetConvolutionFilterDelegate>()(target, format, type, image);
		}
		
		public static void glGetConvolutionParameterfv(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetConvolutionParameterfvDelegate>()(target, pname, @params);
		}
		
		public static void glGetConvolutionParameteriv(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetConvolutionParameterivDelegate>()(target, pname, @params);
		}
		
		public static void glGetSeparableFilter(uint target, uint format, uint type, nint row, nint column, nint span)
		{
			Native.GetDelegateFor<glGetSeparableFilterDelegate>()(target, format, type, row, column, span);
		}
		
		public static void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, nint row, nint column)
		{
			Native.GetDelegateFor<glSeparableFilter2DDelegate>()(target, internalformat, width, height, format, type, row, column);
		}
		
		public static void glGetHistogram(uint target, bool reset, uint format, uint type, nint values)
		{
			Native.GetDelegateFor<glGetHistogramDelegate>()(target, reset, format, type, values);
		}
		
		public static void glGetHistogramParameterfv(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetHistogramParameterfvDelegate>()(target, pname, @params);
		}
		
		public static void glGetHistogramParameteriv(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetHistogramParameterivDelegate>()(target, pname, @params);
		}
		
		public static void glGetMinmax(uint target, bool reset, uint format, uint type, nint values)
		{
			Native.GetDelegateFor<glGetMinmaxDelegate>()(target, reset, format, type, values);
		}
		
		public static void glGetMinmaxParameterfv(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetMinmaxParameterfvDelegate>()(target, pname, @params);
		}
		
		public static void glGetMinmaxParameteriv(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetMinmaxParameterivDelegate>()(target, pname, @params);
		}
		
		public static void glHistogram(uint target, int width, uint internalformat, bool sink)
		{
			Native.GetDelegateFor<glHistogramDelegate>()(target, width, internalformat, sink);
		}
		
		public static void glMinmax(uint target, uint internalformat, bool sink)
		{
			Native.GetDelegateFor<glMinmaxDelegate>()(target, internalformat, sink);
		}
		
		public static void glResetHistogram(uint target)
		{
			Native.GetDelegateFor<glResetHistogramDelegate>()(target);
		}
		
		public static void glResetMinmax(uint target)
		{
			Native.GetDelegateFor<glResetMinmaxDelegate>()(target);
		}
		
		public static void glMultiDrawArraysIndirectCountARB(uint mode, nint indirect, nint drawcount, int maxdrawcount, int stride)
		{
			Native.GetDelegateFor<glMultiDrawArraysIndirectCountARBDelegate>()(mode, indirect, drawcount, maxdrawcount, stride);
		}
		
		public static void glMultiDrawElementsIndirectCountARB(uint mode, uint type, nint indirect, nint drawcount, int maxdrawcount, int stride)
		{
			Native.GetDelegateFor<glMultiDrawElementsIndirectCountARBDelegate>()(mode, type, indirect, drawcount, maxdrawcount, stride);
		}
		
		public static void glVertexAttribDivisorARB(uint index, uint divisor)
		{
			Native.GetDelegateFor<glVertexAttribDivisorARBDelegate>()(index, divisor);
		}
		
		public static void glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int[] @params)
		{
			Native.GetDelegateFor<glGetInternalformativDelegate>()(target, internalformat, pname, bufSize, @params);
		}
		
		public static void glGetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, Int64[] @params)
		{
			Native.GetDelegateFor<glGetInternalformati64vDelegate>()(target, internalformat, pname, bufSize, @params);
		}
		
		public static void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
		{
			Native.GetDelegateFor<glInvalidateTexSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth);
		}
		
		public static void glInvalidateTexImage(uint texture, int level)
		{
			Native.GetDelegateFor<glInvalidateTexImageDelegate>()(texture, level);
		}
		
		public static void glInvalidateBufferSubData(uint buffer, nint offset, nint length)
		{
			Native.GetDelegateFor<glInvalidateBufferSubDataDelegate>()(buffer, offset, length);
		}
		
		public static void glInvalidateBufferData(uint buffer)
		{
			Native.GetDelegateFor<glInvalidateBufferDataDelegate>()(buffer);
		}
		
		public static void glInvalidateFramebuffer(uint target, int numAttachments, uint[] attachments)
		{
			Native.GetDelegateFor<glInvalidateFramebufferDelegate>()(target, numAttachments, attachments);
		}
		
		public static void glInvalidateSubFramebuffer(uint target, int numAttachments, uint[] attachments, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glInvalidateSubFramebufferDelegate>()(target, numAttachments, attachments, x, y, width, height);
		}
		
		public static void glMapBufferRange(uint target, nint offset, nint length, uint access)
		{
			Native.GetDelegateFor<glMapBufferRangeDelegate>()(target, offset, length, access);
		}
		
		public static void glFlushMappedBufferRange(uint target, nint offset, nint length)
		{
			Native.GetDelegateFor<glFlushMappedBufferRangeDelegate>()(target, offset, length);
		}
		
		public static void glCurrentPaletteMatrixARB(int index)
		{
			Native.GetDelegateFor<glCurrentPaletteMatrixARBDelegate>()(index);
		}
		
		public static void glMatrixIndexubvARB(int size, byte[] indices)
		{
			Native.GetDelegateFor<glMatrixIndexubvARBDelegate>()(size, indices);
		}
		
		public static void glMatrixIndexusvARB(int size, ushort[] indices)
		{
			Native.GetDelegateFor<glMatrixIndexusvARBDelegate>()(size, indices);
		}
		
		public static void glMatrixIndexuivARB(int size, uint[] indices)
		{
			Native.GetDelegateFor<glMatrixIndexuivARBDelegate>()(size, indices);
		}
		
		public static void glMatrixIndexPointerARB(int size, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glMatrixIndexPointerARBDelegate>()(size, type, stride, pointer);
		}
		
		public static void glBindBuffersBase(uint target, uint first, int count, uint[] buffers)
		{
			Native.GetDelegateFor<glBindBuffersBaseDelegate>()(target, first, count, buffers);
		}
		
		public static void glBindBuffersRange(uint target, uint first, int count, uint[] buffers, nint offsets, nint sizes)
		{
			Native.GetDelegateFor<glBindBuffersRangeDelegate>()(target, first, count, buffers, offsets, sizes);
		}
		
		public static void glBindTextures(uint first, int count, uint[] textures)
		{
			Native.GetDelegateFor<glBindTexturesDelegate>()(first, count, textures);
		}
		
		public static void glBindSamplers(uint first, int count, uint[] samplers)
		{
			Native.GetDelegateFor<glBindSamplersDelegate>()(first, count, samplers);
		}
		
		public static void glBindImageTextures(uint first, int count, uint[] textures)
		{
			Native.GetDelegateFor<glBindImageTexturesDelegate>()(first, count, textures);
		}
		
		public static void glBindVertexBuffers(uint first, int count, uint[] buffers, nint offsets, int[] strides)
		{
			Native.GetDelegateFor<glBindVertexBuffersDelegate>()(first, count, buffers, offsets, strides);
		}
		
		public static void glMultiDrawArraysIndirect(uint mode, nint indirect, int drawcount, int stride)
		{
			Native.GetDelegateFor<glMultiDrawArraysIndirectDelegate>()(mode, indirect, drawcount, stride);
		}
		
		public static void glMultiDrawElementsIndirect(uint mode, uint type, nint indirect, int drawcount, int stride)
		{
			Native.GetDelegateFor<glMultiDrawElementsIndirectDelegate>()(mode, type, indirect, drawcount, stride);
		}
		
		public static void glSampleCoverageARB(float value, bool invert)
		{
			Native.GetDelegateFor<glSampleCoverageARBDelegate>()(value, invert);
		}
		
		public static void glActiveTextureARB(uint texture)
		{
			Native.GetDelegateFor<glActiveTextureARBDelegate>()(texture);
		}
		
		public static void glClientActiveTextureARB(uint texture)
		{
			Native.GetDelegateFor<glClientActiveTextureARBDelegate>()(texture);
		}
		
		public static void glMultiTexCoord1dARB(uint target, double s)
		{
			Native.GetDelegateFor<glMultiTexCoord1dARBDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1dvARB(uint target, double[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord1dvARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord1fARB(uint target, float s)
		{
			Native.GetDelegateFor<glMultiTexCoord1fARBDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1fvARB(uint target, float[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord1fvARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord1iARB(uint target, int s)
		{
			Native.GetDelegateFor<glMultiTexCoord1iARBDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1ivARB(uint target, int[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord1ivARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord1sARB(uint target, short s)
		{
			Native.GetDelegateFor<glMultiTexCoord1sARBDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1svARB(uint target, short[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord1svARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2dARB(uint target, double s, double t)
		{
			Native.GetDelegateFor<glMultiTexCoord2dARBDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2dvARB(uint target, double[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord2dvARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2fARB(uint target, float s, float t)
		{
			Native.GetDelegateFor<glMultiTexCoord2fARBDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2fvARB(uint target, float[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord2fvARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2iARB(uint target, int s, int t)
		{
			Native.GetDelegateFor<glMultiTexCoord2iARBDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2ivARB(uint target, int[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord2ivARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2sARB(uint target, short s, short t)
		{
			Native.GetDelegateFor<glMultiTexCoord2sARBDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2svARB(uint target, short[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord2svARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3dARB(uint target, double s, double t, double r)
		{
			Native.GetDelegateFor<glMultiTexCoord3dARBDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3dvARB(uint target, double[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord3dvARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3fARB(uint target, float s, float t, float r)
		{
			Native.GetDelegateFor<glMultiTexCoord3fARBDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3fvARB(uint target, float[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord3fvARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3iARB(uint target, int s, int t, int r)
		{
			Native.GetDelegateFor<glMultiTexCoord3iARBDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3ivARB(uint target, int[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord3ivARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3sARB(uint target, short s, short t, short r)
		{
			Native.GetDelegateFor<glMultiTexCoord3sARBDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3svARB(uint target, short[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord3svARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4dARB(uint target, double s, double t, double r, double q)
		{
			Native.GetDelegateFor<glMultiTexCoord4dARBDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4dvARB(uint target, double[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord4dvARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4fARB(uint target, float s, float t, float r, float q)
		{
			Native.GetDelegateFor<glMultiTexCoord4fARBDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4fvARB(uint target, float[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord4fvARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4iARB(uint target, int s, int t, int r, int q)
		{
			Native.GetDelegateFor<glMultiTexCoord4iARBDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4ivARB(uint target, int[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord4ivARBDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4sARB(uint target, short s, short t, short r, short q)
		{
			Native.GetDelegateFor<glMultiTexCoord4sARBDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4svARB(uint target, short[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord4svARBDelegate>()(target, v);
		}
		
		public static void glGenQueriesARB(int n, uint[] ids)
		{
			Native.GetDelegateFor<glGenQueriesARBDelegate>()(n, ids);
		}
		
		public static void glDeleteQueriesARB(int n, uint[] ids)
		{
			Native.GetDelegateFor<glDeleteQueriesARBDelegate>()(n, ids);
		}
		
		public static bool glIsQueryARB(uint id)
		{
			return (bool)Native.GetDelegateFor<glIsQueryARBDelegate>()(id);
		}
		
		public static void glBeginQueryARB(uint target, uint id)
		{
			Native.GetDelegateFor<glBeginQueryARBDelegate>()(target, id);
		}
		
		public static void glEndQueryARB(uint target)
		{
			Native.GetDelegateFor<glEndQueryARBDelegate>()(target);
		}
		
		public static void glGetQueryivARB(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetQueryivARBDelegate>()(target, pname, @params);
		}
		
		public static void glGetQueryObjectivARB(uint id, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetQueryObjectivARBDelegate>()(id, pname, @params);
		}
		
		public static void glGetQueryObjectuivARB(uint id, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetQueryObjectuivARBDelegate>()(id, pname, @params);
		}
		
		public static void glMaxShaderCompilerThreadsARB(uint count)
		{
			Native.GetDelegateFor<glMaxShaderCompilerThreadsARBDelegate>()(count);
		}
		
		public static void glPointParameterfARB(uint pname, float param)
		{
			Native.GetDelegateFor<glPointParameterfARBDelegate>()(pname, param);
		}
		
		public static void glPointParameterfvARB(uint pname, float[] @params)
		{
			Native.GetDelegateFor<glPointParameterfvARBDelegate>()(pname, @params);
		}
		
		public static void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetProgramInterfaceivDelegate>()(program, programInterface, pname, @params);
		}
		
		public static uint glGetProgramResourceIndex(uint program, uint programInterface, char[] name)
		{
			return (uint)Native.GetDelegateFor<glGetProgramResourceIndexDelegate>()(program, programInterface, name);
		}
		
		public static void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int[] length, char[] name)
		{
			Native.GetDelegateFor<glGetProgramResourceNameDelegate>()(program, programInterface, index, bufSize, length, name);
		}
		
		public static void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, int[] @params)
		{
			Native.GetDelegateFor<glGetProgramResourceivDelegate>()(program, programInterface, index, propCount, props, bufSize, length, @params);
		}
		
		public static int glGetProgramResourceLocation(uint program, uint programInterface, char[] name)
		{
			return (int)Native.GetDelegateFor<glGetProgramResourceLocationDelegate>()(program, programInterface, name);
		}
		
		public static int glGetProgramResourceLocationIndex(uint program, uint programInterface, char[] name)
		{
			return (int)Native.GetDelegateFor<glGetProgramResourceLocationIndexDelegate>()(program, programInterface, name);
		}
		
		public static void glProvokingVertex(uint mode)
		{
			Native.GetDelegateFor<glProvokingVertexDelegate>()(mode);
		}
		
		public static uint glGetGraphicsResetStatusARB()
		{
			return (uint)Native.GetDelegateFor<glGetGraphicsResetStatusARBDelegate>()();
		}
		
		public static void glGetnTexImageARB(uint target, int level, uint format, uint type, int bufSize, nint img)
		{
			Native.GetDelegateFor<glGetnTexImageARBDelegate>()(target, level, format, type, bufSize, img);
		}
		
		public static void glReadnPixelsARB(int x, int y, int width, int height, uint format, uint type, int bufSize, nint data)
		{
			Native.GetDelegateFor<glReadnPixelsARBDelegate>()(x, y, width, height, format, type, bufSize, data);
		}
		
		public static void glGetnCompressedTexImageARB(uint target, int lod, int bufSize, nint img)
		{
			Native.GetDelegateFor<glGetnCompressedTexImageARBDelegate>()(target, lod, bufSize, img);
		}
		
		public static void glGetnUniformfvARB(uint program, int location, int bufSize, float[] @params)
		{
			Native.GetDelegateFor<glGetnUniformfvARBDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformivARB(uint program, int location, int bufSize, int[] @params)
		{
			Native.GetDelegateFor<glGetnUniformivARBDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformuivARB(uint program, int location, int bufSize, uint[] @params)
		{
			Native.GetDelegateFor<glGetnUniformuivARBDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformdvARB(uint program, int location, int bufSize, double[] @params)
		{
			Native.GetDelegateFor<glGetnUniformdvARBDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnMapdvARB(uint target, uint query, int bufSize, double[] v)
		{
			Native.GetDelegateFor<glGetnMapdvARBDelegate>()(target, query, bufSize, v);
		}
		
		public static void glGetnMapfvARB(uint target, uint query, int bufSize, float[] v)
		{
			Native.GetDelegateFor<glGetnMapfvARBDelegate>()(target, query, bufSize, v);
		}
		
		public static void glGetnMapivARB(uint target, uint query, int bufSize, int[] v)
		{
			Native.GetDelegateFor<glGetnMapivARBDelegate>()(target, query, bufSize, v);
		}
		
		public static void glGetnPixelMapfvARB(uint map, int bufSize, float[] values)
		{
			Native.GetDelegateFor<glGetnPixelMapfvARBDelegate>()(map, bufSize, values);
		}
		
		public static void glGetnPixelMapuivARB(uint map, int bufSize, uint[] values)
		{
			Native.GetDelegateFor<glGetnPixelMapuivARBDelegate>()(map, bufSize, values);
		}
		
		public static void glGetnPixelMapusvARB(uint map, int bufSize, ushort[] values)
		{
			Native.GetDelegateFor<glGetnPixelMapusvARBDelegate>()(map, bufSize, values);
		}
		
		public static void glGetnPolygonStippleARB(int bufSize, byte[] pattern)
		{
			Native.GetDelegateFor<glGetnPolygonStippleARBDelegate>()(bufSize, pattern);
		}
		
		public static void glGetnColorTableARB(uint target, uint format, uint type, int bufSize, nint table)
		{
			Native.GetDelegateFor<glGetnColorTableARBDelegate>()(target, format, type, bufSize, table);
		}
		
		public static void glGetnConvolutionFilterARB(uint target, uint format, uint type, int bufSize, nint image)
		{
			Native.GetDelegateFor<glGetnConvolutionFilterARBDelegate>()(target, format, type, bufSize, image);
		}
		
		public static void glGetnSeparableFilterARB(uint target, uint format, uint type, int rowBufSize, nint row, int columnBufSize, nint column, nint span)
		{
			Native.GetDelegateFor<glGetnSeparableFilterARBDelegate>()(target, format, type, rowBufSize, row, columnBufSize, column, span);
		}
		
		public static void glGetnHistogramARB(uint target, bool reset, uint format, uint type, int bufSize, nint values)
		{
			Native.GetDelegateFor<glGetnHistogramARBDelegate>()(target, reset, format, type, bufSize, values);
		}
		
		public static void glGetnMinmaxARB(uint target, bool reset, uint format, uint type, int bufSize, nint values)
		{
			Native.GetDelegateFor<glGetnMinmaxARBDelegate>()(target, reset, format, type, bufSize, values);
		}
		
		public static void glFramebufferSampleLocationsfvARB(uint target, uint start, int count, float[] v)
		{
			Native.GetDelegateFor<glFramebufferSampleLocationsfvARBDelegate>()(target, start, count, v);
		}
		
		public static void glNamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, float[] v)
		{
			Native.GetDelegateFor<glNamedFramebufferSampleLocationsfvARBDelegate>()(framebuffer, start, count, v);
		}
		
		public static void glEvaluateDepthValuesARB()
		{
			Native.GetDelegateFor<glEvaluateDepthValuesARBDelegate>()();
		}
		
		public static void glMinSampleShadingARB(float value)
		{
			Native.GetDelegateFor<glMinSampleShadingARBDelegate>()(value);
		}
		
		public static void glGenSamplers(int count, uint[] samplers)
		{
			Native.GetDelegateFor<glGenSamplersDelegate>()(count, samplers);
		}
		
		public static void glDeleteSamplers(int count, uint[] samplers)
		{
			Native.GetDelegateFor<glDeleteSamplersDelegate>()(count, samplers);
		}
		
		public static bool glIsSampler(uint sampler)
		{
			return (bool)Native.GetDelegateFor<glIsSamplerDelegate>()(sampler);
		}
		
		public static void glBindSampler(uint unit, uint sampler)
		{
			Native.GetDelegateFor<glBindSamplerDelegate>()(unit, sampler);
		}
		
		public static void glSamplerParameteri(uint sampler, uint pname, int param)
		{
			Native.GetDelegateFor<glSamplerParameteriDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameteriv(uint sampler, uint pname, int[] param)
		{
			Native.GetDelegateFor<glSamplerParameterivDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterf(uint sampler, uint pname, float param)
		{
			Native.GetDelegateFor<glSamplerParameterfDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterfv(uint sampler, uint pname, float[] param)
		{
			Native.GetDelegateFor<glSamplerParameterfvDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterIiv(uint sampler, uint pname, int[] param)
		{
			Native.GetDelegateFor<glSamplerParameterIivDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterIuiv(uint sampler, uint pname, uint[] param)
		{
			Native.GetDelegateFor<glSamplerParameterIuivDelegate>()(sampler, pname, param);
		}
		
		public static void glGetSamplerParameteriv(uint sampler, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetSamplerParameterivDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterIiv(uint sampler, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetSamplerParameterIivDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterfv(uint sampler, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetSamplerParameterfvDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterIuiv(uint sampler, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetSamplerParameterIuivDelegate>()(sampler, pname, @params);
		}
		
		public static void glUseProgramStages(uint pipeline, uint stages, uint program)
		{
			Native.GetDelegateFor<glUseProgramStagesDelegate>()(pipeline, stages, program);
		}
		
		public static void glActiveShaderProgram(uint pipeline, uint program)
		{
			Native.GetDelegateFor<glActiveShaderProgramDelegate>()(pipeline, program);
		}
		
		public static uint glCreateShaderProgramv(uint type, int count, char[] strings)
		{
			return (uint)Native.GetDelegateFor<glCreateShaderProgramvDelegate>()(type, count, strings);
		}
		
		public static void glBindProgramPipeline(uint pipeline)
		{
			Native.GetDelegateFor<glBindProgramPipelineDelegate>()(pipeline);
		}
		
		public static void glDeleteProgramPipelines(int n, uint[] pipelines)
		{
			Native.GetDelegateFor<glDeleteProgramPipelinesDelegate>()(n, pipelines);
		}
		
		public static void glGenProgramPipelines(int n, uint[] pipelines)
		{
			Native.GetDelegateFor<glGenProgramPipelinesDelegate>()(n, pipelines);
		}
		
		public static bool glIsProgramPipeline(uint pipeline)
		{
			return (bool)Native.GetDelegateFor<glIsProgramPipelineDelegate>()(pipeline);
		}
		
		public static void glGetProgramPipelineiv(uint pipeline, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetProgramPipelineivDelegate>()(pipeline, pname, @params);
		}
		
		public static void glProgramUniform1i(uint program, int location, int v0)
		{
			Native.GetDelegateFor<glProgramUniform1iDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1iv(uint program, int location, int count, int[] value)
		{
			Native.GetDelegateFor<glProgramUniform1ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1f(uint program, int location, float v0)
		{
			Native.GetDelegateFor<glProgramUniform1fDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1fv(uint program, int location, int count, float[] value)
		{
			Native.GetDelegateFor<glProgramUniform1fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1d(uint program, int location, double v0)
		{
			Native.GetDelegateFor<glProgramUniform1dDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1dv(uint program, int location, int count, double[] value)
		{
			Native.GetDelegateFor<glProgramUniform1dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1ui(uint program, int location, uint v0)
		{
			Native.GetDelegateFor<glProgramUniform1uiDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1uiv(uint program, int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glProgramUniform1uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2i(uint program, int location, int v0, int v1)
		{
			Native.GetDelegateFor<glProgramUniform2iDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2iv(uint program, int location, int count, int[] value)
		{
			Native.GetDelegateFor<glProgramUniform2ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2f(uint program, int location, float v0, float v1)
		{
			Native.GetDelegateFor<glProgramUniform2fDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2fv(uint program, int location, int count, float[] value)
		{
			Native.GetDelegateFor<glProgramUniform2fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2d(uint program, int location, double v0, double v1)
		{
			Native.GetDelegateFor<glProgramUniform2dDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2dv(uint program, int location, int count, double[] value)
		{
			Native.GetDelegateFor<glProgramUniform2dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1)
		{
			Native.GetDelegateFor<glProgramUniform2uiDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2uiv(uint program, int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glProgramUniform2uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2)
		{
			Native.GetDelegateFor<glProgramUniform3iDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3iv(uint program, int location, int count, int[] value)
		{
			Native.GetDelegateFor<glProgramUniform3ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2)
		{
			Native.GetDelegateFor<glProgramUniform3fDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3fv(uint program, int location, int count, float[] value)
		{
			Native.GetDelegateFor<glProgramUniform3fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3d(uint program, int location, double v0, double v1, double v2)
		{
			Native.GetDelegateFor<glProgramUniform3dDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3dv(uint program, int location, int count, double[] value)
		{
			Native.GetDelegateFor<glProgramUniform3dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2)
		{
			Native.GetDelegateFor<glProgramUniform3uiDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3uiv(uint program, int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glProgramUniform3uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3)
		{
			Native.GetDelegateFor<glProgramUniform4iDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4iv(uint program, int location, int count, int[] value)
		{
			Native.GetDelegateFor<glProgramUniform4ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3)
		{
			Native.GetDelegateFor<glProgramUniform4fDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4fv(uint program, int location, int count, float[] value)
		{
			Native.GetDelegateFor<glProgramUniform4fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3)
		{
			Native.GetDelegateFor<glProgramUniform4dDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4dv(uint program, int location, int count, double[] value)
		{
			Native.GetDelegateFor<glProgramUniform4dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			Native.GetDelegateFor<glProgramUniform4uiDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4uiv(uint program, int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glProgramUniform4uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2x3fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3x2fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2x4fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4x2fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3x4fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4x3fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2x3dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3x2dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2x4dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4x2dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3x4dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4x3dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glValidateProgramPipeline(uint pipeline)
		{
			Native.GetDelegateFor<glValidateProgramPipelineDelegate>()(pipeline);
		}
		
		public static void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int[] length, char[] infoLog)
		{
			Native.GetDelegateFor<glGetProgramPipelineInfoLogDelegate>()(pipeline, bufSize, length, infoLog);
		}
		
		public static void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetActiveAtomicCounterBufferivDelegate>()(program, bufferIndex, pname, @params);
		}
		
		public static void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format)
		{
			Native.GetDelegateFor<glBindImageTextureDelegate>()(unit, texture, level, layered, layer, access, format);
		}
		
		public static void glMemoryBarrier(uint barriers)
		{
			Native.GetDelegateFor<glMemoryBarrierDelegate>()(barriers);
		}
		
		public static void glDeleteObjectARB(nint obj)
		{
			Native.GetDelegateFor<glDeleteObjectARBDelegate>()(obj);
		}
		
		public static nint glGetHandleARB(uint pname)
		{
			return (nint)Native.GetDelegateFor<glGetHandleARBDelegate>()(pname);
		}
		
		public static void glDetachObjectARB(nint containerObj, nint attachedObj)
		{
			Native.GetDelegateFor<glDetachObjectARBDelegate>()(containerObj, attachedObj);
		}
		
		public static nint glCreateShaderObjectARB(uint shaderType)
		{
			return (nint)Native.GetDelegateFor<glCreateShaderObjectARBDelegate>()(shaderType);
		}
		
		public static void glShaderSourceARB(nint shaderObj, int count, char[] @string, int[] length)
		{
			Native.GetDelegateFor<glShaderSourceARBDelegate>()(shaderObj, count, @string, length);
		}
		
		public static void glCompileShaderARB(nint shaderObj)
		{
			Native.GetDelegateFor<glCompileShaderARBDelegate>()(shaderObj);
		}
		
		public static nint glCreateProgramObjectARB()
		{
			return (nint)Native.GetDelegateFor<glCreateProgramObjectARBDelegate>()();
		}
		
		public static void glAttachObjectARB(nint containerObj, nint obj)
		{
			Native.GetDelegateFor<glAttachObjectARBDelegate>()(containerObj, obj);
		}
		
		public static void glLinkProgramARB(nint programObj)
		{
			Native.GetDelegateFor<glLinkProgramARBDelegate>()(programObj);
		}
		
		public static void glUseProgramObjectARB(nint programObj)
		{
			Native.GetDelegateFor<glUseProgramObjectARBDelegate>()(programObj);
		}
		
		public static void glValidateProgramARB(nint programObj)
		{
			Native.GetDelegateFor<glValidateProgramARBDelegate>()(programObj);
		}
		
		public static void glUniform1fARB(int location, float v0)
		{
			Native.GetDelegateFor<glUniform1fARBDelegate>()(location, v0);
		}
		
		public static void glUniform2fARB(int location, float v0, float v1)
		{
			Native.GetDelegateFor<glUniform2fARBDelegate>()(location, v0, v1);
		}
		
		public static void glUniform3fARB(int location, float v0, float v1, float v2)
		{
			Native.GetDelegateFor<glUniform3fARBDelegate>()(location, v0, v1, v2);
		}
		
		public static void glUniform4fARB(int location, float v0, float v1, float v2, float v3)
		{
			Native.GetDelegateFor<glUniform4fARBDelegate>()(location, v0, v1, v2, v3);
		}
		
		public static void glUniform1iARB(int location, int v0)
		{
			Native.GetDelegateFor<glUniform1iARBDelegate>()(location, v0);
		}
		
		public static void glUniform2iARB(int location, int v0, int v1)
		{
			Native.GetDelegateFor<glUniform2iARBDelegate>()(location, v0, v1);
		}
		
		public static void glUniform3iARB(int location, int v0, int v1, int v2)
		{
			Native.GetDelegateFor<glUniform3iARBDelegate>()(location, v0, v1, v2);
		}
		
		public static void glUniform4iARB(int location, int v0, int v1, int v2, int v3)
		{
			Native.GetDelegateFor<glUniform4iARBDelegate>()(location, v0, v1, v2, v3);
		}
		
		public static void glUniform1fvARB(int location, int count, float[] value)
		{
			Native.GetDelegateFor<glUniform1fvARBDelegate>()(location, count, value);
		}
		
		public static void glUniform2fvARB(int location, int count, float[] value)
		{
			Native.GetDelegateFor<glUniform2fvARBDelegate>()(location, count, value);
		}
		
		public static void glUniform3fvARB(int location, int count, float[] value)
		{
			Native.GetDelegateFor<glUniform3fvARBDelegate>()(location, count, value);
		}
		
		public static void glUniform4fvARB(int location, int count, float[] value)
		{
			Native.GetDelegateFor<glUniform4fvARBDelegate>()(location, count, value);
		}
		
		public static void glUniform1ivARB(int location, int count, int[] value)
		{
			Native.GetDelegateFor<glUniform1ivARBDelegate>()(location, count, value);
		}
		
		public static void glUniform2ivARB(int location, int count, int[] value)
		{
			Native.GetDelegateFor<glUniform2ivARBDelegate>()(location, count, value);
		}
		
		public static void glUniform3ivARB(int location, int count, int[] value)
		{
			Native.GetDelegateFor<glUniform3ivARBDelegate>()(location, count, value);
		}
		
		public static void glUniform4ivARB(int location, int count, int[] value)
		{
			Native.GetDelegateFor<glUniform4ivARBDelegate>()(location, count, value);
		}
		
		public static void glUniformMatrix2fvARB(int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glUniformMatrix2fvARBDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3fvARB(int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glUniformMatrix3fvARBDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4fvARB(int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glUniformMatrix4fvARBDelegate>()(location, count, transpose, value);
		}
		
		public static void glGetObjectParameterfvARB(nint obj, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetObjectParameterfvARBDelegate>()(obj, pname, @params);
		}
		
		public static void glGetObjectParameterivARB(nint obj, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetObjectParameterivARBDelegate>()(obj, pname, @params);
		}
		
		public static void glGetInfoLogARB(nint obj, int maxLength, int[] length, char[] infoLog)
		{
			Native.GetDelegateFor<glGetInfoLogARBDelegate>()(obj, maxLength, length, infoLog);
		}
		
		public static void glGetAttachedObjectsARB(nint containerObj, int maxCount, int[] count, nint obj)
		{
			Native.GetDelegateFor<glGetAttachedObjectsARBDelegate>()(containerObj, maxCount, count, obj);
		}
		
		public static int glGetUniformLocationARB(nint programObj, char[] name)
		{
			return (int)Native.GetDelegateFor<glGetUniformLocationARBDelegate>()(programObj, name);
		}
		
		public static void glGetActiveUniformARB(nint programObj, uint index, int maxLength, int[] length, int[] size, uint[] type, char[] name)
		{
			Native.GetDelegateFor<glGetActiveUniformARBDelegate>()(programObj, index, maxLength, length, size, type, name);
		}
		
		public static void glGetUniformfvARB(nint programObj, int location, float[] @params)
		{
			Native.GetDelegateFor<glGetUniformfvARBDelegate>()(programObj, location, @params);
		}
		
		public static void glGetUniformivARB(nint programObj, int location, int[] @params)
		{
			Native.GetDelegateFor<glGetUniformivARBDelegate>()(programObj, location, @params);
		}
		
		public static void glGetShaderSourceARB(nint obj, int maxLength, int[] length, char[] source)
		{
			Native.GetDelegateFor<glGetShaderSourceARBDelegate>()(obj, maxLength, length, source);
		}
		
		public static void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
		{
			Native.GetDelegateFor<glShaderStorageBlockBindingDelegate>()(program, storageBlockIndex, storageBlockBinding);
		}
		
		public static int glGetSubroutineUniformLocation(uint program, uint shadertype, char[] name)
		{
			return (int)Native.GetDelegateFor<glGetSubroutineUniformLocationDelegate>()(program, shadertype, name);
		}
		
		public static uint glGetSubroutineIndex(uint program, uint shadertype, char[] name)
		{
			return (uint)Native.GetDelegateFor<glGetSubroutineIndexDelegate>()(program, shadertype, name);
		}
		
		public static void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int[] values)
		{
			Native.GetDelegateFor<glGetActiveSubroutineUniformivDelegate>()(program, shadertype, index, pname, values);
		}
		
		public static void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name)
		{
			Native.GetDelegateFor<glGetActiveSubroutineUniformNameDelegate>()(program, shadertype, index, bufsize, length, name);
		}
		
		public static void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name)
		{
			Native.GetDelegateFor<glGetActiveSubroutineNameDelegate>()(program, shadertype, index, bufsize, length, name);
		}
		
		public static void glUniformSubroutinesuiv(uint shadertype, int count, uint[] indices)
		{
			Native.GetDelegateFor<glUniformSubroutinesuivDelegate>()(shadertype, count, indices);
		}
		
		public static void glGetUniformSubroutineuiv(uint shadertype, int location, uint[] @params)
		{
			Native.GetDelegateFor<glGetUniformSubroutineuivDelegate>()(shadertype, location, @params);
		}
		
		public static void glGetProgramStageiv(uint program, uint shadertype, uint pname, int[] values)
		{
			Native.GetDelegateFor<glGetProgramStageivDelegate>()(program, shadertype, pname, values);
		}
		
		public static void glNamedStringARB(uint type, int namelen, char[] name, int stringlen, char[] @string)
		{
			Native.GetDelegateFor<glNamedStringARBDelegate>()(type, namelen, name, stringlen, @string);
		}
		
		public static void glDeleteNamedStringARB(int namelen, char[] name)
		{
			Native.GetDelegateFor<glDeleteNamedStringARBDelegate>()(namelen, name);
		}
		
		public static void glCompileShaderIncludeARB(uint shader, int count, char[] path, int[] length)
		{
			Native.GetDelegateFor<glCompileShaderIncludeARBDelegate>()(shader, count, path, length);
		}
		
		public static bool glIsNamedStringARB(int namelen, char[] name)
		{
			return (bool)Native.GetDelegateFor<glIsNamedStringARBDelegate>()(namelen, name);
		}
		
		public static void glGetNamedStringARB(int namelen, char[] name, int bufSize, int[] stringlen, char[] @string)
		{
			Native.GetDelegateFor<glGetNamedStringARBDelegate>()(namelen, name, bufSize, stringlen, @string);
		}
		
		public static void glGetNamedStringivARB(int namelen, char[] name, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetNamedStringivARBDelegate>()(namelen, name, pname, @params);
		}
		
		public static void glBufferPageCommitmentARB(uint target, nint offset, nint size, bool commit)
		{
			Native.GetDelegateFor<glBufferPageCommitmentARBDelegate>()(target, offset, size, commit);
		}
		
		public static void glNamedBufferPageCommitmentEXT(uint buffer, nint offset, nint size, bool commit)
		{
			Native.GetDelegateFor<glNamedBufferPageCommitmentEXTDelegate>()(buffer, offset, size, commit);
		}
		
		public static void glNamedBufferPageCommitmentARB(uint buffer, nint offset, nint size, bool commit)
		{
			Native.GetDelegateFor<glNamedBufferPageCommitmentARBDelegate>()(buffer, offset, size, commit);
		}
		
		public static void glTexPageCommitmentARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit)
		{
			Native.GetDelegateFor<glTexPageCommitmentARBDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, commit);
		}
		
		public static nint glFenceSync(uint condition, uint flags)
		{
			return (nint)Native.GetDelegateFor<glFenceSyncDelegate>()(condition, flags);
		}
		
		public static bool glIsSync(nint sync)
		{
			return (bool)Native.GetDelegateFor<glIsSyncDelegate>()(sync);
		}
		
		public static void glDeleteSync(nint sync)
		{
			Native.GetDelegateFor<glDeleteSyncDelegate>()(sync);
		}
		
		public static uint glClientWaitSync(nint sync, uint flags, UInt64 timeout)
		{
			return (uint)Native.GetDelegateFor<glClientWaitSyncDelegate>()(sync, flags, timeout);
		}
		
		public static void glWaitSync(nint sync, uint flags, UInt64 timeout)
		{
			Native.GetDelegateFor<glWaitSyncDelegate>()(sync, flags, timeout);
		}
		
		public static void glGetInteger64v(uint pname, Int64[] data)
		{
			Native.GetDelegateFor<glGetInteger64vDelegate>()(pname, data);
		}
		
		public static void glGetSynciv(nint sync, uint pname, int bufSize, int[] length, int[] values)
		{
			Native.GetDelegateFor<glGetSyncivDelegate>()(sync, pname, bufSize, length, values);
		}
		
		public static void glPatchParameteri(uint pname, int value)
		{
			Native.GetDelegateFor<glPatchParameteriDelegate>()(pname, value);
		}
		
		public static void glPatchParameterfv(uint pname, float[] values)
		{
			Native.GetDelegateFor<glPatchParameterfvDelegate>()(pname, values);
		}
		
		public static void glTextureBarrier()
		{
			Native.GetDelegateFor<glTextureBarrierDelegate>()();
		}
		
		public static void glTexBufferARB(uint target, uint internalformat, uint buffer)
		{
			Native.GetDelegateFor<glTexBufferARBDelegate>()(target, internalformat, buffer);
		}
		
		public static void glTexBufferRange(uint target, uint internalformat, uint buffer, nint offset, nint size)
		{
			Native.GetDelegateFor<glTexBufferRangeDelegate>()(target, internalformat, buffer, offset, size);
		}
		
		public static void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTexImage3DARBDelegate>()(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		
		public static void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTexImage2DARBDelegate>()(target, level, internalformat, width, height, border, imageSize, data);
		}
		
		public static void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTexImage1DARBDelegate>()(target, level, internalformat, width, border, imageSize, data);
		}
		
		public static void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTexSubImage3DARBDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		
		public static void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTexSubImage2DARBDelegate>()(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		
		public static void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTexSubImage1DARBDelegate>()(target, level, xoffset, width, format, imageSize, data);
		}
		
		public static void glGetCompressedTexImageARB(uint target, int level, nint img)
		{
			Native.GetDelegateFor<glGetCompressedTexImageARBDelegate>()(target, level, img);
		}
		
		public static void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			Native.GetDelegateFor<glTexImage2DMultisampleDelegate>()(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		public static void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			Native.GetDelegateFor<glTexImage3DMultisampleDelegate>()(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glGetMultisamplefv(uint pname, uint index, float[] val)
		{
			Native.GetDelegateFor<glGetMultisamplefvDelegate>()(pname, index, val);
		}
		
		public static void glSampleMaski(uint maskNumber, uint mask)
		{
			Native.GetDelegateFor<glSampleMaskiDelegate>()(maskNumber, mask);
		}
		
		public static void glTexStorage1D(uint target, int levels, uint internalformat, int width)
		{
			Native.GetDelegateFor<glTexStorage1DDelegate>()(target, levels, internalformat, width);
		}
		
		public static void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glTexStorage2DDelegate>()(target, levels, internalformat, width, height);
		}
		
		public static void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth)
		{
			Native.GetDelegateFor<glTexStorage3DDelegate>()(target, levels, internalformat, width, height, depth);
		}
		
		public static void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			Native.GetDelegateFor<glTexStorage2DMultisampleDelegate>()(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		public static void glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			Native.GetDelegateFor<glTexStorage3DMultisampleDelegate>()(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			Native.GetDelegateFor<glTextureViewDelegate>()(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}
		
		public static void glQueryCounter(uint id, uint target)
		{
			Native.GetDelegateFor<glQueryCounterDelegate>()(id, target);
		}
		
		public static void glGetQueryObjecti64v(uint id, uint pname, Int64[] @params)
		{
			Native.GetDelegateFor<glGetQueryObjecti64vDelegate>()(id, pname, @params);
		}
		
		public static void glGetQueryObjectui64v(uint id, uint pname, UInt64[] @params)
		{
			Native.GetDelegateFor<glGetQueryObjectui64vDelegate>()(id, pname, @params);
		}
		
		public static void glBindTransformFeedback(uint target, uint id)
		{
			Native.GetDelegateFor<glBindTransformFeedbackDelegate>()(target, id);
		}
		
		public static void glDeleteTransformFeedbacks(int n, uint[] ids)
		{
			Native.GetDelegateFor<glDeleteTransformFeedbacksDelegate>()(n, ids);
		}
		
		public static void glGenTransformFeedbacks(int n, uint[] ids)
		{
			Native.GetDelegateFor<glGenTransformFeedbacksDelegate>()(n, ids);
		}
		
		public static bool glIsTransformFeedback(uint id)
		{
			return (bool)Native.GetDelegateFor<glIsTransformFeedbackDelegate>()(id);
		}
		
		public static void glPauseTransformFeedback()
		{
			Native.GetDelegateFor<glPauseTransformFeedbackDelegate>()();
		}
		
		public static void glResumeTransformFeedback()
		{
			Native.GetDelegateFor<glResumeTransformFeedbackDelegate>()();
		}
		
		public static void glDrawTransformFeedback(uint mode, uint id)
		{
			Native.GetDelegateFor<glDrawTransformFeedbackDelegate>()(mode, id);
		}
		
		public static void glDrawTransformFeedbackStream(uint mode, uint id, uint stream)
		{
			Native.GetDelegateFor<glDrawTransformFeedbackStreamDelegate>()(mode, id, stream);
		}
		
		public static void glBeginQueryIndexed(uint target, uint index, uint id)
		{
			Native.GetDelegateFor<glBeginQueryIndexedDelegate>()(target, index, id);
		}
		
		public static void glEndQueryIndexed(uint target, uint index)
		{
			Native.GetDelegateFor<glEndQueryIndexedDelegate>()(target, index);
		}
		
		public static void glGetQueryIndexediv(uint target, uint index, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetQueryIndexedivDelegate>()(target, index, pname, @params);
		}
		
		public static void glDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount)
		{
			Native.GetDelegateFor<glDrawTransformFeedbackInstancedDelegate>()(mode, id, instancecount);
		}
		
		public static void glDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount)
		{
			Native.GetDelegateFor<glDrawTransformFeedbackStreamInstancedDelegate>()(mode, id, stream, instancecount);
		}
		
		public static void glLoadTransposeMatrixfARB(float[] m)
		{
			Native.GetDelegateFor<glLoadTransposeMatrixfARBDelegate>()(m);
		}
		
		public static void glLoadTransposeMatrixdARB(double[] m)
		{
			Native.GetDelegateFor<glLoadTransposeMatrixdARBDelegate>()(m);
		}
		
		public static void glMultTransposeMatrixfARB(float[] m)
		{
			Native.GetDelegateFor<glMultTransposeMatrixfARBDelegate>()(m);
		}
		
		public static void glMultTransposeMatrixdARB(double[] m)
		{
			Native.GetDelegateFor<glMultTransposeMatrixdARBDelegate>()(m);
		}
		
		public static void glGetUniformIndices(uint program, int uniformCount, char[] uniformNames, uint[] uniformIndices)
		{
			Native.GetDelegateFor<glGetUniformIndicesDelegate>()(program, uniformCount, uniformNames, uniformIndices);
		}
		
		public static void glGetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetActiveUniformsivDelegate>()(program, uniformCount, uniformIndices, pname, @params);
		}
		
		public static void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int[] length, char[] uniformName)
		{
			Native.GetDelegateFor<glGetActiveUniformNameDelegate>()(program, uniformIndex, bufSize, length, uniformName);
		}
		
		public static uint glGetUniformBlockIndex(uint program, char[] uniformBlockName)
		{
			return (uint)Native.GetDelegateFor<glGetUniformBlockIndexDelegate>()(program, uniformBlockName);
		}
		
		public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetActiveUniformBlockivDelegate>()(program, uniformBlockIndex, pname, @params);
		}
		
		public static void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int[] length, char[] uniformBlockName)
		{
			Native.GetDelegateFor<glGetActiveUniformBlockNameDelegate>()(program, uniformBlockIndex, bufSize, length, uniformBlockName);
		}
		
		public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
			Native.GetDelegateFor<glUniformBlockBindingDelegate>()(program, uniformBlockIndex, uniformBlockBinding);
		}
		
		public static void glBindBufferRange(uint target, uint index, uint buffer, nint offset, nint size)
		{
			Native.GetDelegateFor<glBindBufferRangeDelegate>()(target, index, buffer, offset, size);
		}
		
		public static void glBindBufferBase(uint target, uint index, uint buffer)
		{
			Native.GetDelegateFor<glBindBufferBaseDelegate>()(target, index, buffer);
		}
		
		public static void glGetIntegeri_v(uint target, uint index, int[] data)
		{
			Native.GetDelegateFor<glGetIntegeri_vDelegate>()(target, index, data);
		}
		
		public static void glBindVertexArray(uint array)
		{
			Native.GetDelegateFor<glBindVertexArrayDelegate>()(array);
		}
		
		public static void glDeleteVertexArrays(int n, uint[] arrays)
		{
			Native.GetDelegateFor<glDeleteVertexArraysDelegate>()(n, arrays);
		}
		
		public static void glGenVertexArrays(int n, uint[] arrays)
		{
			Native.GetDelegateFor<glGenVertexArraysDelegate>()(n, arrays);
		}
		
		public static bool glIsVertexArray(uint array)
		{
			return (bool)Native.GetDelegateFor<glIsVertexArrayDelegate>()(array);
		}
		
		public static void glVertexAttribL1d(uint index, double x)
		{
			Native.GetDelegateFor<glVertexAttribL1dDelegate>()(index, x);
		}
		
		public static void glVertexAttribL2d(uint index, double x, double y)
		{
			Native.GetDelegateFor<glVertexAttribL2dDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribL3d(uint index, double x, double y, double z)
		{
			Native.GetDelegateFor<glVertexAttribL3dDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribL4d(uint index, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glVertexAttribL4dDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribL1dv(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribL1dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribL2dv(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribL2dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribL3dv(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribL3dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribL4dv(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribL4dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribLPointer(uint index, int size, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glVertexAttribLPointerDelegate>()(index, size, type, stride, pointer);
		}
		
		public static void glGetVertexAttribLdv(uint index, uint pname, double[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribLdvDelegate>()(index, pname, @params);
		}
		
		public static void glBindVertexBuffer(uint bindingindex, uint buffer, nint offset, int stride)
		{
			Native.GetDelegateFor<glBindVertexBufferDelegate>()(bindingindex, buffer, offset, stride);
		}
		
		public static void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			Native.GetDelegateFor<glVertexAttribFormatDelegate>()(attribindex, size, type, normalized, relativeoffset);
		}
		
		public static void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			Native.GetDelegateFor<glVertexAttribIFormatDelegate>()(attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			Native.GetDelegateFor<glVertexAttribLFormatDelegate>()(attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexAttribBinding(uint attribindex, uint bindingindex)
		{
			Native.GetDelegateFor<glVertexAttribBindingDelegate>()(attribindex, bindingindex);
		}
		
		public static void glVertexBindingDivisor(uint bindingindex, uint divisor)
		{
			Native.GetDelegateFor<glVertexBindingDivisorDelegate>()(bindingindex, divisor);
		}
		
		public static void glWeightbvARB(int size, byte[] weights)
		{
			Native.GetDelegateFor<glWeightbvARBDelegate>()(size, weights);
		}
		
		public static void glWeightsvARB(int size, short[] weights)
		{
			Native.GetDelegateFor<glWeightsvARBDelegate>()(size, weights);
		}
		
		public static void glWeightivARB(int size, int[] weights)
		{
			Native.GetDelegateFor<glWeightivARBDelegate>()(size, weights);
		}
		
		public static void glWeightfvARB(int size, float[] weights)
		{
			Native.GetDelegateFor<glWeightfvARBDelegate>()(size, weights);
		}
		
		public static void glWeightdvARB(int size, double[] weights)
		{
			Native.GetDelegateFor<glWeightdvARBDelegate>()(size, weights);
		}
		
		public static void glWeightubvARB(int size, byte[] weights)
		{
			Native.GetDelegateFor<glWeightubvARBDelegate>()(size, weights);
		}
		
		public static void glWeightusvARB(int size, ushort[] weights)
		{
			Native.GetDelegateFor<glWeightusvARBDelegate>()(size, weights);
		}
		
		public static void glWeightuivARB(int size, uint[] weights)
		{
			Native.GetDelegateFor<glWeightuivARBDelegate>()(size, weights);
		}
		
		public static void glWeightPointerARB(int size, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glWeightPointerARBDelegate>()(size, type, stride, pointer);
		}
		
		public static void glVertexBlendARB(int count)
		{
			Native.GetDelegateFor<glVertexBlendARBDelegate>()(count);
		}
		
		public static void glBindBufferARB(uint target, uint buffer)
		{
			Native.GetDelegateFor<glBindBufferARBDelegate>()(target, buffer);
		}
		
		public static void glDeleteBuffersARB(int n, uint[] buffers)
		{
			Native.GetDelegateFor<glDeleteBuffersARBDelegate>()(n, buffers);
		}
		
		public static void glGenBuffersARB(int n, uint[] buffers)
		{
			Native.GetDelegateFor<glGenBuffersARBDelegate>()(n, buffers);
		}
		
		public static bool glIsBufferARB(uint buffer)
		{
			return (bool)Native.GetDelegateFor<glIsBufferARBDelegate>()(buffer);
		}
		
		public static void glBufferDataARB(uint target, nint size, nint data, uint usage)
		{
			Native.GetDelegateFor<glBufferDataARBDelegate>()(target, size, data, usage);
		}
		
		public static void glBufferSubDataARB(uint target, nint offset, nint size, nint data)
		{
			Native.GetDelegateFor<glBufferSubDataARBDelegate>()(target, offset, size, data);
		}
		
		public static void glGetBufferSubDataARB(uint target, nint offset, nint size, nint data)
		{
			Native.GetDelegateFor<glGetBufferSubDataARBDelegate>()(target, offset, size, data);
		}
		
		public static void glMapBufferARB(uint target, uint access)
		{
			Native.GetDelegateFor<glMapBufferARBDelegate>()(target, access);
		}
		
		public static bool glUnmapBufferARB(uint target)
		{
			return (bool)Native.GetDelegateFor<glUnmapBufferARBDelegate>()(target);
		}
		
		public static void glGetBufferParameterivARB(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetBufferParameterivARBDelegate>()(target, pname, @params);
		}
		
		public static void glGetBufferPointervARB(uint target, uint pname, nint @params)
		{
			Native.GetDelegateFor<glGetBufferPointervARBDelegate>()(target, pname, @params);
		}
		
		public static void glVertexAttrib1dARB(uint index, double x)
		{
			Native.GetDelegateFor<glVertexAttrib1dARBDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1dvARB(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttrib1dvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib1fARB(uint index, float x)
		{
			Native.GetDelegateFor<glVertexAttrib1fARBDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1fvARB(uint index, float[] v)
		{
			Native.GetDelegateFor<glVertexAttrib1fvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib1sARB(uint index, short x)
		{
			Native.GetDelegateFor<glVertexAttrib1sARBDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1svARB(uint index, short[] v)
		{
			Native.GetDelegateFor<glVertexAttrib1svARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2dARB(uint index, double x, double y)
		{
			Native.GetDelegateFor<glVertexAttrib2dARBDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2dvARB(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttrib2dvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2fARB(uint index, float x, float y)
		{
			Native.GetDelegateFor<glVertexAttrib2fARBDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2fvARB(uint index, float[] v)
		{
			Native.GetDelegateFor<glVertexAttrib2fvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2sARB(uint index, short x, short y)
		{
			Native.GetDelegateFor<glVertexAttrib2sARBDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2svARB(uint index, short[] v)
		{
			Native.GetDelegateFor<glVertexAttrib2svARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3dARB(uint index, double x, double y, double z)
		{
			Native.GetDelegateFor<glVertexAttrib3dARBDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3dvARB(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttrib3dvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3fARB(uint index, float x, float y, float z)
		{
			Native.GetDelegateFor<glVertexAttrib3fARBDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3fvARB(uint index, float[] v)
		{
			Native.GetDelegateFor<glVertexAttrib3fvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3sARB(uint index, short x, short y, short z)
		{
			Native.GetDelegateFor<glVertexAttrib3sARBDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3svARB(uint index, short[] v)
		{
			Native.GetDelegateFor<glVertexAttrib3svARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4NbvARB(uint index, byte[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4NbvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4NivARB(uint index, int[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4NivARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4NsvARB(uint index, short[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4NsvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w)
		{
			Native.GetDelegateFor<glVertexAttrib4NubARBDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4NubvARB(uint index, byte[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4NubvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4NuivARB(uint index, uint[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4NuivARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4NusvARB(uint index, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4NusvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4bvARB(uint index, byte[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4bvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4dARB(uint index, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glVertexAttrib4dARBDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4dvARB(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4dvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4fARB(uint index, float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glVertexAttrib4fARBDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4fvARB(uint index, float[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4fvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4ivARB(uint index, int[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4ivARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4sARB(uint index, short x, short y, short z, short w)
		{
			Native.GetDelegateFor<glVertexAttrib4sARBDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4svARB(uint index, short[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4svARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4ubvARB(uint index, byte[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4ubvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4uivARB(uint index, uint[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4uivARBDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4usvARB(uint index, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4usvARBDelegate>()(index, v);
		}
		
		public static void glVertexAttribPointerARB(uint index, int size, uint type, bool normalized, int stride, nint pointer)
		{
			Native.GetDelegateFor<glVertexAttribPointerARBDelegate>()(index, size, type, normalized, stride, pointer);
		}
		
		public static void glEnableVertexAttribArrayARB(uint index)
		{
			Native.GetDelegateFor<glEnableVertexAttribArrayARBDelegate>()(index);
		}
		
		public static void glDisableVertexAttribArrayARB(uint index)
		{
			Native.GetDelegateFor<glDisableVertexAttribArrayARBDelegate>()(index);
		}
		
		public static void glGetVertexAttribdvARB(uint index, uint pname, double[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribdvARBDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribfvARB(uint index, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribfvARBDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribivARB(uint index, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribivARBDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribPointervARB(uint index, uint pname, nint pointer)
		{
			Native.GetDelegateFor<glGetVertexAttribPointervARBDelegate>()(index, pname, pointer);
		}
		
		public static void glBindAttribLocationARB(nint programObj, uint index, char[] name)
		{
			Native.GetDelegateFor<glBindAttribLocationARBDelegate>()(programObj, index, name);
		}
		
		public static void glGetActiveAttribARB(nint programObj, uint index, int maxLength, int[] length, int[] size, uint[] type, char[] name)
		{
			Native.GetDelegateFor<glGetActiveAttribARBDelegate>()(programObj, index, maxLength, length, size, type, name);
		}
		
		public static int glGetAttribLocationARB(nint programObj, char[] name)
		{
			return (int)Native.GetDelegateFor<glGetAttribLocationARBDelegate>()(programObj, name);
		}
		
		public static void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value)
		{
			Native.GetDelegateFor<glVertexAttribP1uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint[] value)
		{
			Native.GetDelegateFor<glVertexAttribP1uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value)
		{
			Native.GetDelegateFor<glVertexAttribP2uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint[] value)
		{
			Native.GetDelegateFor<glVertexAttribP2uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value)
		{
			Native.GetDelegateFor<glVertexAttribP3uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint[] value)
		{
			Native.GetDelegateFor<glVertexAttribP3uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value)
		{
			Native.GetDelegateFor<glVertexAttribP4uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint[] value)
		{
			Native.GetDelegateFor<glVertexAttribP4uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexP2ui(uint type, uint value)
		{
			Native.GetDelegateFor<glVertexP2uiDelegate>()(type, value);
		}
		
		public static void glVertexP2uiv(uint type, uint[] value)
		{
			Native.GetDelegateFor<glVertexP2uivDelegate>()(type, value);
		}
		
		public static void glVertexP3ui(uint type, uint value)
		{
			Native.GetDelegateFor<glVertexP3uiDelegate>()(type, value);
		}
		
		public static void glVertexP3uiv(uint type, uint[] value)
		{
			Native.GetDelegateFor<glVertexP3uivDelegate>()(type, value);
		}
		
		public static void glVertexP4ui(uint type, uint value)
		{
			Native.GetDelegateFor<glVertexP4uiDelegate>()(type, value);
		}
		
		public static void glVertexP4uiv(uint type, uint[] value)
		{
			Native.GetDelegateFor<glVertexP4uivDelegate>()(type, value);
		}
		
		public static void glTexCoordP1ui(uint type, uint coords)
		{
			Native.GetDelegateFor<glTexCoordP1uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP1uiv(uint type, uint[] coords)
		{
			Native.GetDelegateFor<glTexCoordP1uivDelegate>()(type, coords);
		}
		
		public static void glTexCoordP2ui(uint type, uint coords)
		{
			Native.GetDelegateFor<glTexCoordP2uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP2uiv(uint type, uint[] coords)
		{
			Native.GetDelegateFor<glTexCoordP2uivDelegate>()(type, coords);
		}
		
		public static void glTexCoordP3ui(uint type, uint coords)
		{
			Native.GetDelegateFor<glTexCoordP3uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP3uiv(uint type, uint[] coords)
		{
			Native.GetDelegateFor<glTexCoordP3uivDelegate>()(type, coords);
		}
		
		public static void glTexCoordP4ui(uint type, uint coords)
		{
			Native.GetDelegateFor<glTexCoordP4uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP4uiv(uint type, uint[] coords)
		{
			Native.GetDelegateFor<glTexCoordP4uivDelegate>()(type, coords);
		}
		
		public static void glMultiTexCoordP1ui(uint texture, uint type, uint coords)
		{
			Native.GetDelegateFor<glMultiTexCoordP1uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP1uiv(uint texture, uint type, uint[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoordP1uivDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP2ui(uint texture, uint type, uint coords)
		{
			Native.GetDelegateFor<glMultiTexCoordP2uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP2uiv(uint texture, uint type, uint[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoordP2uivDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP3ui(uint texture, uint type, uint coords)
		{
			Native.GetDelegateFor<glMultiTexCoordP3uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP3uiv(uint texture, uint type, uint[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoordP3uivDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP4ui(uint texture, uint type, uint coords)
		{
			Native.GetDelegateFor<glMultiTexCoordP4uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP4uiv(uint texture, uint type, uint[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoordP4uivDelegate>()(texture, type, coords);
		}
		
		public static void glNormalP3ui(uint type, uint coords)
		{
			Native.GetDelegateFor<glNormalP3uiDelegate>()(type, coords);
		}
		
		public static void glNormalP3uiv(uint type, uint[] coords)
		{
			Native.GetDelegateFor<glNormalP3uivDelegate>()(type, coords);
		}
		
		public static void glColorP3ui(uint type, uint color)
		{
			Native.GetDelegateFor<glColorP3uiDelegate>()(type, color);
		}
		
		public static void glColorP3uiv(uint type, uint[] color)
		{
			Native.GetDelegateFor<glColorP3uivDelegate>()(type, color);
		}
		
		public static void glColorP4ui(uint type, uint color)
		{
			Native.GetDelegateFor<glColorP4uiDelegate>()(type, color);
		}
		
		public static void glColorP4uiv(uint type, uint[] color)
		{
			Native.GetDelegateFor<glColorP4uivDelegate>()(type, color);
		}
		
		public static void glSecondaryColorP3ui(uint type, uint color)
		{
			Native.GetDelegateFor<glSecondaryColorP3uiDelegate>()(type, color);
		}
		
		public static void glSecondaryColorP3uiv(uint type, uint[] color)
		{
			Native.GetDelegateFor<glSecondaryColorP3uivDelegate>()(type, color);
		}
		
		public static void glViewportArrayv(uint first, int count, float[] v)
		{
			Native.GetDelegateFor<glViewportArrayvDelegate>()(first, count, v);
		}
		
		public static void glViewportIndexedf(uint index, float x, float y, float w, float h)
		{
			Native.GetDelegateFor<glViewportIndexedfDelegate>()(index, x, y, w, h);
		}
		
		public static void glViewportIndexedfv(uint index, float[] v)
		{
			Native.GetDelegateFor<glViewportIndexedfvDelegate>()(index, v);
		}
		
		public static void glScissorArrayv(uint first, int count, int[] v)
		{
			Native.GetDelegateFor<glScissorArrayvDelegate>()(first, count, v);
		}
		
		public static void glScissorIndexed(uint index, int left, int bottom, int width, int height)
		{
			Native.GetDelegateFor<glScissorIndexedDelegate>()(index, left, bottom, width, height);
		}
		
		public static void glScissorIndexedv(uint index, int[] v)
		{
			Native.GetDelegateFor<glScissorIndexedvDelegate>()(index, v);
		}
		
		public static void glDepthRangeArrayv(uint first, int count, double[] v)
		{
			Native.GetDelegateFor<glDepthRangeArrayvDelegate>()(first, count, v);
		}
		
		public static void glDepthRangeIndexed(uint index, double n, double f)
		{
			Native.GetDelegateFor<glDepthRangeIndexedDelegate>()(index, n, f);
		}
		
		public static void glGetFloati_v(uint target, uint index, float[] data)
		{
			Native.GetDelegateFor<glGetFloati_vDelegate>()(target, index, data);
		}
		
		public static void glGetDoublei_v(uint target, uint index, double[] data)
		{
			Native.GetDelegateFor<glGetDoublei_vDelegate>()(target, index, data);
		}
		
		public static void glWindowPos2dARB(double x, double y)
		{
			Native.GetDelegateFor<glWindowPos2dARBDelegate>()(x, y);
		}
		
		public static void glWindowPos2dvARB(double[] v)
		{
			Native.GetDelegateFor<glWindowPos2dvARBDelegate>()(v);
		}
		
		public static void glWindowPos2fARB(float x, float y)
		{
			Native.GetDelegateFor<glWindowPos2fARBDelegate>()(x, y);
		}
		
		public static void glWindowPos2fvARB(float[] v)
		{
			Native.GetDelegateFor<glWindowPos2fvARBDelegate>()(v);
		}
		
		public static void glWindowPos2iARB(int x, int y)
		{
			Native.GetDelegateFor<glWindowPos2iARBDelegate>()(x, y);
		}
		
		public static void glWindowPos2ivARB(int[] v)
		{
			Native.GetDelegateFor<glWindowPos2ivARBDelegate>()(v);
		}
		
		public static void glWindowPos2sARB(short x, short y)
		{
			Native.GetDelegateFor<glWindowPos2sARBDelegate>()(x, y);
		}
		
		public static void glWindowPos2svARB(short[] v)
		{
			Native.GetDelegateFor<glWindowPos2svARBDelegate>()(v);
		}
		
		public static void glWindowPos3dARB(double x, double y, double z)
		{
			Native.GetDelegateFor<glWindowPos3dARBDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3dvARB(double[] v)
		{
			Native.GetDelegateFor<glWindowPos3dvARBDelegate>()(v);
		}
		
		public static void glWindowPos3fARB(float x, float y, float z)
		{
			Native.GetDelegateFor<glWindowPos3fARBDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3fvARB(float[] v)
		{
			Native.GetDelegateFor<glWindowPos3fvARBDelegate>()(v);
		}
		
		public static void glWindowPos3iARB(int x, int y, int z)
		{
			Native.GetDelegateFor<glWindowPos3iARBDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3ivARB(int[] v)
		{
			Native.GetDelegateFor<glWindowPos3ivARBDelegate>()(v);
		}
		
		public static void glWindowPos3sARB(short x, short y, short z)
		{
			Native.GetDelegateFor<glWindowPos3sARBDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3svARB(short[] v)
		{
			Native.GetDelegateFor<glWindowPos3svARBDelegate>()(v);
		}
		
		public static void glDrawBuffersATI(int n, uint[] bufs)
		{
			Native.GetDelegateFor<glDrawBuffersATIDelegate>()(n, bufs);
		}
		
		public static void glElementPointerATI(uint type, nint pointer)
		{
			Native.GetDelegateFor<glElementPointerATIDelegate>()(type, pointer);
		}
		
		public static void glDrawElementArrayATI(uint mode, int count)
		{
			Native.GetDelegateFor<glDrawElementArrayATIDelegate>()(mode, count);
		}
		
		public static void glDrawRangeElementArrayATI(uint mode, uint start, uint end, int count)
		{
			Native.GetDelegateFor<glDrawRangeElementArrayATIDelegate>()(mode, start, end, count);
		}
		
		public static void glTexBumpParameterivATI(uint pname, int[] param)
		{
			Native.GetDelegateFor<glTexBumpParameterivATIDelegate>()(pname, param);
		}
		
		public static void glTexBumpParameterfvATI(uint pname, float[] param)
		{
			Native.GetDelegateFor<glTexBumpParameterfvATIDelegate>()(pname, param);
		}
		
		public static void glGetTexBumpParameterivATI(uint pname, int[] param)
		{
			Native.GetDelegateFor<glGetTexBumpParameterivATIDelegate>()(pname, param);
		}
		
		public static void glGetTexBumpParameterfvATI(uint pname, float[] param)
		{
			Native.GetDelegateFor<glGetTexBumpParameterfvATIDelegate>()(pname, param);
		}
		
		public static uint glGenFragmentShadersATI(uint range)
		{
			return (uint)Native.GetDelegateFor<glGenFragmentShadersATIDelegate>()(range);
		}
		
		public static void glBindFragmentShaderATI(uint id)
		{
			Native.GetDelegateFor<glBindFragmentShaderATIDelegate>()(id);
		}
		
		public static void glDeleteFragmentShaderATI(uint id)
		{
			Native.GetDelegateFor<glDeleteFragmentShaderATIDelegate>()(id);
		}
		
		public static void glBeginFragmentShaderATI()
		{
			Native.GetDelegateFor<glBeginFragmentShaderATIDelegate>()();
		}
		
		public static void glEndFragmentShaderATI()
		{
			Native.GetDelegateFor<glEndFragmentShaderATIDelegate>()();
		}
		
		public static void glPassTexCoordATI(uint dst, uint coord, uint swizzle)
		{
			Native.GetDelegateFor<glPassTexCoordATIDelegate>()(dst, coord, swizzle);
		}
		
		public static void glSampleMapATI(uint dst, uint interp, uint swizzle)
		{
			Native.GetDelegateFor<glSampleMapATIDelegate>()(dst, interp, swizzle);
		}
		
		public static void glColorFragmentOp1ATI(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod)
		{
			Native.GetDelegateFor<glColorFragmentOp1ATIDelegate>()(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);
		}
		
		public static void glColorFragmentOp2ATI(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod)
		{
			Native.GetDelegateFor<glColorFragmentOp2ATIDelegate>()(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
		}
		
		public static void glColorFragmentOp3ATI(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod)
		{
			Native.GetDelegateFor<glColorFragmentOp3ATIDelegate>()(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
		}
		
		public static void glAlphaFragmentOp1ATI(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod)
		{
			Native.GetDelegateFor<glAlphaFragmentOp1ATIDelegate>()(op, dst, dstMod, arg1, arg1Rep, arg1Mod);
		}
		
		public static void glAlphaFragmentOp2ATI(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod)
		{
			Native.GetDelegateFor<glAlphaFragmentOp2ATIDelegate>()(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
		}
		
		public static void glAlphaFragmentOp3ATI(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod)
		{
			Native.GetDelegateFor<glAlphaFragmentOp3ATIDelegate>()(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
		}
		
		public static void glSetFragmentShaderConstantATI(uint dst, float[] value)
		{
			Native.GetDelegateFor<glSetFragmentShaderConstantATIDelegate>()(dst, value);
		}
		
		public static void glMapObjectBufferATI(uint buffer)
		{
			Native.GetDelegateFor<glMapObjectBufferATIDelegate>()(buffer);
		}
		
		public static void glUnmapObjectBufferATI(uint buffer)
		{
			Native.GetDelegateFor<glUnmapObjectBufferATIDelegate>()(buffer);
		}
		
		public static void glPNTrianglesiATI(uint pname, int param)
		{
			Native.GetDelegateFor<glPNTrianglesiATIDelegate>()(pname, param);
		}
		
		public static void glPNTrianglesfATI(uint pname, float param)
		{
			Native.GetDelegateFor<glPNTrianglesfATIDelegate>()(pname, param);
		}
		
		public static void glStencilOpSeparateATI(uint face, uint sfail, uint dpfail, uint dppass)
		{
			Native.GetDelegateFor<glStencilOpSeparateATIDelegate>()(face, sfail, dpfail, dppass);
		}
		
		public static void glStencilFuncSeparateATI(uint frontfunc, uint backfunc, int @ref, uint mask)
		{
			Native.GetDelegateFor<glStencilFuncSeparateATIDelegate>()(frontfunc, backfunc, @ref, mask);
		}
		
		public static uint glNewObjectBufferATI(int size, nint pointer, uint usage)
		{
			return (uint)Native.GetDelegateFor<glNewObjectBufferATIDelegate>()(size, pointer, usage);
		}
		
		public static bool glIsObjectBufferATI(uint buffer)
		{
			return (bool)Native.GetDelegateFor<glIsObjectBufferATIDelegate>()(buffer);
		}
		
		public static void glUpdateObjectBufferATI(uint buffer, uint offset, int size, nint pointer, uint preserve)
		{
			Native.GetDelegateFor<glUpdateObjectBufferATIDelegate>()(buffer, offset, size, pointer, preserve);
		}
		
		public static void glGetObjectBufferfvATI(uint buffer, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetObjectBufferfvATIDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetObjectBufferivATI(uint buffer, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetObjectBufferivATIDelegate>()(buffer, pname, @params);
		}
		
		public static void glFreeObjectBufferATI(uint buffer)
		{
			Native.GetDelegateFor<glFreeObjectBufferATIDelegate>()(buffer);
		}
		
		public static void glArrayObjectATI(uint array, int size, uint type, int stride, uint buffer, uint offset)
		{
			Native.GetDelegateFor<glArrayObjectATIDelegate>()(array, size, type, stride, buffer, offset);
		}
		
		public static void glGetArrayObjectfvATI(uint array, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetArrayObjectfvATIDelegate>()(array, pname, @params);
		}
		
		public static void glGetArrayObjectivATI(uint array, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetArrayObjectivATIDelegate>()(array, pname, @params);
		}
		
		public static void glVariantArrayObjectATI(uint id, uint type, int stride, uint buffer, uint offset)
		{
			Native.GetDelegateFor<glVariantArrayObjectATIDelegate>()(id, type, stride, buffer, offset);
		}
		
		public static void glGetVariantArrayObjectfvATI(uint id, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetVariantArrayObjectfvATIDelegate>()(id, pname, @params);
		}
		
		public static void glGetVariantArrayObjectivATI(uint id, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetVariantArrayObjectivATIDelegate>()(id, pname, @params);
		}
		
		public static void glVertexAttribArrayObjectATI(uint index, int size, uint type, bool normalized, int stride, uint buffer, uint offset)
		{
			Native.GetDelegateFor<glVertexAttribArrayObjectATIDelegate>()(index, size, type, normalized, stride, buffer, offset);
		}
		
		public static void glGetVertexAttribArrayObjectfvATI(uint index, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribArrayObjectfvATIDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribArrayObjectivATI(uint index, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribArrayObjectivATIDelegate>()(index, pname, @params);
		}
		
		public static void glVertexStream1sATI(uint stream, short x)
		{
			Native.GetDelegateFor<glVertexStream1sATIDelegate>()(stream, x);
		}
		
		public static void glVertexStream1svATI(uint stream, short[] coords)
		{
			Native.GetDelegateFor<glVertexStream1svATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream1iATI(uint stream, int x)
		{
			Native.GetDelegateFor<glVertexStream1iATIDelegate>()(stream, x);
		}
		
		public static void glVertexStream1ivATI(uint stream, int[] coords)
		{
			Native.GetDelegateFor<glVertexStream1ivATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream1fATI(uint stream, float x)
		{
			Native.GetDelegateFor<glVertexStream1fATIDelegate>()(stream, x);
		}
		
		public static void glVertexStream1fvATI(uint stream, float[] coords)
		{
			Native.GetDelegateFor<glVertexStream1fvATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream1dATI(uint stream, double x)
		{
			Native.GetDelegateFor<glVertexStream1dATIDelegate>()(stream, x);
		}
		
		public static void glVertexStream1dvATI(uint stream, double[] coords)
		{
			Native.GetDelegateFor<glVertexStream1dvATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream2sATI(uint stream, short x, short y)
		{
			Native.GetDelegateFor<glVertexStream2sATIDelegate>()(stream, x, y);
		}
		
		public static void glVertexStream2svATI(uint stream, short[] coords)
		{
			Native.GetDelegateFor<glVertexStream2svATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream2iATI(uint stream, int x, int y)
		{
			Native.GetDelegateFor<glVertexStream2iATIDelegate>()(stream, x, y);
		}
		
		public static void glVertexStream2ivATI(uint stream, int[] coords)
		{
			Native.GetDelegateFor<glVertexStream2ivATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream2fATI(uint stream, float x, float y)
		{
			Native.GetDelegateFor<glVertexStream2fATIDelegate>()(stream, x, y);
		}
		
		public static void glVertexStream2fvATI(uint stream, float[] coords)
		{
			Native.GetDelegateFor<glVertexStream2fvATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream2dATI(uint stream, double x, double y)
		{
			Native.GetDelegateFor<glVertexStream2dATIDelegate>()(stream, x, y);
		}
		
		public static void glVertexStream2dvATI(uint stream, double[] coords)
		{
			Native.GetDelegateFor<glVertexStream2dvATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream3sATI(uint stream, short x, short y, short z)
		{
			Native.GetDelegateFor<glVertexStream3sATIDelegate>()(stream, x, y, z);
		}
		
		public static void glVertexStream3svATI(uint stream, short[] coords)
		{
			Native.GetDelegateFor<glVertexStream3svATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream3iATI(uint stream, int x, int y, int z)
		{
			Native.GetDelegateFor<glVertexStream3iATIDelegate>()(stream, x, y, z);
		}
		
		public static void glVertexStream3ivATI(uint stream, int[] coords)
		{
			Native.GetDelegateFor<glVertexStream3ivATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream3fATI(uint stream, float x, float y, float z)
		{
			Native.GetDelegateFor<glVertexStream3fATIDelegate>()(stream, x, y, z);
		}
		
		public static void glVertexStream3fvATI(uint stream, float[] coords)
		{
			Native.GetDelegateFor<glVertexStream3fvATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream3dATI(uint stream, double x, double y, double z)
		{
			Native.GetDelegateFor<glVertexStream3dATIDelegate>()(stream, x, y, z);
		}
		
		public static void glVertexStream3dvATI(uint stream, double[] coords)
		{
			Native.GetDelegateFor<glVertexStream3dvATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream4sATI(uint stream, short x, short y, short z, short w)
		{
			Native.GetDelegateFor<glVertexStream4sATIDelegate>()(stream, x, y, z, w);
		}
		
		public static void glVertexStream4svATI(uint stream, short[] coords)
		{
			Native.GetDelegateFor<glVertexStream4svATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream4iATI(uint stream, int x, int y, int z, int w)
		{
			Native.GetDelegateFor<glVertexStream4iATIDelegate>()(stream, x, y, z, w);
		}
		
		public static void glVertexStream4ivATI(uint stream, int[] coords)
		{
			Native.GetDelegateFor<glVertexStream4ivATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream4fATI(uint stream, float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glVertexStream4fATIDelegate>()(stream, x, y, z, w);
		}
		
		public static void glVertexStream4fvATI(uint stream, float[] coords)
		{
			Native.GetDelegateFor<glVertexStream4fvATIDelegate>()(stream, coords);
		}
		
		public static void glVertexStream4dATI(uint stream, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glVertexStream4dATIDelegate>()(stream, x, y, z, w);
		}
		
		public static void glVertexStream4dvATI(uint stream, double[] coords)
		{
			Native.GetDelegateFor<glVertexStream4dvATIDelegate>()(stream, coords);
		}
		
		public static void glNormalStream3bATI(uint stream, byte nx, byte ny, byte nz)
		{
			Native.GetDelegateFor<glNormalStream3bATIDelegate>()(stream, nx, ny, nz);
		}
		
		public static void glNormalStream3bvATI(uint stream, byte[] coords)
		{
			Native.GetDelegateFor<glNormalStream3bvATIDelegate>()(stream, coords);
		}
		
		public static void glNormalStream3sATI(uint stream, short nx, short ny, short nz)
		{
			Native.GetDelegateFor<glNormalStream3sATIDelegate>()(stream, nx, ny, nz);
		}
		
		public static void glNormalStream3svATI(uint stream, short[] coords)
		{
			Native.GetDelegateFor<glNormalStream3svATIDelegate>()(stream, coords);
		}
		
		public static void glNormalStream3iATI(uint stream, int nx, int ny, int nz)
		{
			Native.GetDelegateFor<glNormalStream3iATIDelegate>()(stream, nx, ny, nz);
		}
		
		public static void glNormalStream3ivATI(uint stream, int[] coords)
		{
			Native.GetDelegateFor<glNormalStream3ivATIDelegate>()(stream, coords);
		}
		
		public static void glNormalStream3fATI(uint stream, float nx, float ny, float nz)
		{
			Native.GetDelegateFor<glNormalStream3fATIDelegate>()(stream, nx, ny, nz);
		}
		
		public static void glNormalStream3fvATI(uint stream, float[] coords)
		{
			Native.GetDelegateFor<glNormalStream3fvATIDelegate>()(stream, coords);
		}
		
		public static void glNormalStream3dATI(uint stream, double nx, double ny, double nz)
		{
			Native.GetDelegateFor<glNormalStream3dATIDelegate>()(stream, nx, ny, nz);
		}
		
		public static void glNormalStream3dvATI(uint stream, double[] coords)
		{
			Native.GetDelegateFor<glNormalStream3dvATIDelegate>()(stream, coords);
		}
		
		public static void glClientActiveVertexStreamATI(uint stream)
		{
			Native.GetDelegateFor<glClientActiveVertexStreamATIDelegate>()(stream);
		}
		
		public static void glVertexBlendEnviATI(uint pname, int param)
		{
			Native.GetDelegateFor<glVertexBlendEnviATIDelegate>()(pname, param);
		}
		
		public static void glVertexBlendEnvfATI(uint pname, float param)
		{
			Native.GetDelegateFor<glVertexBlendEnvfATIDelegate>()(pname, param);
		}
		
		public static void glDrawArraysInstancedBaseInstanceEXT(uint mode, int first, int count, int instancecount, uint baseinstance)
		{
			Native.GetDelegateFor<glDrawArraysInstancedBaseInstanceEXTDelegate>()(mode, first, count, instancecount, baseinstance);
		}
		
		public static void glDrawElementsInstancedBaseInstanceEXT(uint mode, int count, uint type, nint indices, int instancecount, uint baseinstance)
		{
			Native.GetDelegateFor<glDrawElementsInstancedBaseInstanceEXTDelegate>()(mode, count, type, indices, instancecount, baseinstance);
		}
		
		public static void glDrawElementsInstancedBaseVertexBaseInstanceEXT(uint mode, int count, uint type, nint indices, int instancecount, int basevertex, uint baseinstance)
		{
			Native.GetDelegateFor<glDrawElementsInstancedBaseVertexBaseInstanceEXTDelegate>()(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}
		
		public static void glUniformBufferEXT(uint program, int location, uint buffer)
		{
			Native.GetDelegateFor<glUniformBufferEXTDelegate>()(program, location, buffer);
		}
		
		public static int glGetUniformBufferSizeEXT(uint program, int location)
		{
			return (int)Native.GetDelegateFor<glGetUniformBufferSizeEXTDelegate>()(program, location);
		}
		
		public static nint glGetUniformOffsetEXT(uint program, int location)
		{
			return (nint)Native.GetDelegateFor<glGetUniformOffsetEXTDelegate>()(program, location);
		}
		
		public static void glBlendColorEXT(float red, float green, float blue, float alpha)
		{
			Native.GetDelegateFor<glBlendColorEXTDelegate>()(red, green, blue, alpha);
		}
		
		public static void glBlendEquationSeparateEXT(uint modeRGB, uint modeAlpha)
		{
			Native.GetDelegateFor<glBlendEquationSeparateEXTDelegate>()(modeRGB, modeAlpha);
		}
		
		public static void glBindFragDataLocationIndexedEXT(uint program, uint colorNumber, uint index, char[] name)
		{
			Native.GetDelegateFor<glBindFragDataLocationIndexedEXTDelegate>()(program, colorNumber, index, name);
		}
		
		public static void glBindFragDataLocationEXT(uint program, uint color, char[] name)
		{
			Native.GetDelegateFor<glBindFragDataLocationEXTDelegate>()(program, color, name);
		}
		
		public static int glGetProgramResourceLocationIndexEXT(uint program, uint programInterface, char[] name)
		{
			return (int)Native.GetDelegateFor<glGetProgramResourceLocationIndexEXTDelegate>()(program, programInterface, name);
		}
		
		public static int glGetFragDataIndexEXT(uint program, char[] name)
		{
			return (int)Native.GetDelegateFor<glGetFragDataIndexEXTDelegate>()(program, name);
		}
		
		public static void glBlendFuncSeparateEXT(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
			Native.GetDelegateFor<glBlendFuncSeparateEXTDelegate>()(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}
		
		public static void glBlendEquationEXT(uint mode)
		{
			Native.GetDelegateFor<glBlendEquationEXTDelegate>()(mode);
		}
		
		public static void glBufferStorageEXT(uint target, nint size, nint data, uint flags)
		{
			Native.GetDelegateFor<glBufferStorageEXTDelegate>()(target, size, data, flags);
		}
		
		public static void glColorSubTableEXT(uint target, int start, int count, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glColorSubTableEXTDelegate>()(target, start, count, format, type, data);
		}
		
		public static void glCopyColorSubTableEXT(uint target, int start, int x, int y, int width)
		{
			Native.GetDelegateFor<glCopyColorSubTableEXTDelegate>()(target, start, x, y, width);
		}
		
		public static void glLockArraysEXT(int first, int count)
		{
			Native.GetDelegateFor<glLockArraysEXTDelegate>()(first, count);
		}
		
		public static void glUnlockArraysEXT()
		{
			Native.GetDelegateFor<glUnlockArraysEXTDelegate>()();
		}
		
		public static void glConvolutionFilter1DEXT(uint target, uint internalformat, int width, uint format, uint type, nint image)
		{
			Native.GetDelegateFor<glConvolutionFilter1DEXTDelegate>()(target, internalformat, width, format, type, image);
		}
		
		public static void glConvolutionFilter2DEXT(uint target, uint internalformat, int width, int height, uint format, uint type, nint image)
		{
			Native.GetDelegateFor<glConvolutionFilter2DEXTDelegate>()(target, internalformat, width, height, format, type, image);
		}
		
		public static void glConvolutionParameterfEXT(uint target, uint pname, float @params)
		{
			Native.GetDelegateFor<glConvolutionParameterfEXTDelegate>()(target, pname, @params);
		}
		
		public static void glConvolutionParameterfvEXT(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glConvolutionParameterfvEXTDelegate>()(target, pname, @params);
		}
		
		public static void glConvolutionParameteriEXT(uint target, uint pname, int @params)
		{
			Native.GetDelegateFor<glConvolutionParameteriEXTDelegate>()(target, pname, @params);
		}
		
		public static void glConvolutionParameterivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glConvolutionParameterivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glCopyConvolutionFilter1DEXT(uint target, uint internalformat, int x, int y, int width)
		{
			Native.GetDelegateFor<glCopyConvolutionFilter1DEXTDelegate>()(target, internalformat, x, y, width);
		}
		
		public static void glCopyConvolutionFilter2DEXT(uint target, uint internalformat, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyConvolutionFilter2DEXTDelegate>()(target, internalformat, x, y, width, height);
		}
		
		public static void glGetConvolutionFilterEXT(uint target, uint format, uint type, nint image)
		{
			Native.GetDelegateFor<glGetConvolutionFilterEXTDelegate>()(target, format, type, image);
		}
		
		public static void glGetConvolutionParameterfvEXT(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetConvolutionParameterfvEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetConvolutionParameterivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetConvolutionParameterivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetSeparableFilterEXT(uint target, uint format, uint type, nint row, nint column, nint span)
		{
			Native.GetDelegateFor<glGetSeparableFilterEXTDelegate>()(target, format, type, row, column, span);
		}
		
		public static void glSeparableFilter2DEXT(uint target, uint internalformat, int width, int height, uint format, uint type, nint row, nint column)
		{
			Native.GetDelegateFor<glSeparableFilter2DEXTDelegate>()(target, internalformat, width, height, format, type, row, column);
		}
		
		public static void glTangent3bEXT(byte tx, byte ty, byte tz)
		{
			Native.GetDelegateFor<glTangent3bEXTDelegate>()(tx, ty, tz);
		}
		
		public static void glTangent3bvEXT(byte[] v)
		{
			Native.GetDelegateFor<glTangent3bvEXTDelegate>()(v);
		}
		
		public static void glTangent3dEXT(double tx, double ty, double tz)
		{
			Native.GetDelegateFor<glTangent3dEXTDelegate>()(tx, ty, tz);
		}
		
		public static void glTangent3dvEXT(double[] v)
		{
			Native.GetDelegateFor<glTangent3dvEXTDelegate>()(v);
		}
		
		public static void glTangent3fEXT(float tx, float ty, float tz)
		{
			Native.GetDelegateFor<glTangent3fEXTDelegate>()(tx, ty, tz);
		}
		
		public static void glTangent3fvEXT(float[] v)
		{
			Native.GetDelegateFor<glTangent3fvEXTDelegate>()(v);
		}
		
		public static void glTangent3iEXT(int tx, int ty, int tz)
		{
			Native.GetDelegateFor<glTangent3iEXTDelegate>()(tx, ty, tz);
		}
		
		public static void glTangent3ivEXT(int[] v)
		{
			Native.GetDelegateFor<glTangent3ivEXTDelegate>()(v);
		}
		
		public static void glTangent3sEXT(short tx, short ty, short tz)
		{
			Native.GetDelegateFor<glTangent3sEXTDelegate>()(tx, ty, tz);
		}
		
		public static void glTangent3svEXT(short[] v)
		{
			Native.GetDelegateFor<glTangent3svEXTDelegate>()(v);
		}
		
		public static void glBinormal3bEXT(byte bx, byte by, byte bz)
		{
			Native.GetDelegateFor<glBinormal3bEXTDelegate>()(bx, by, bz);
		}
		
		public static void glBinormal3bvEXT(byte[] v)
		{
			Native.GetDelegateFor<glBinormal3bvEXTDelegate>()(v);
		}
		
		public static void glBinormal3dEXT(double bx, double by, double bz)
		{
			Native.GetDelegateFor<glBinormal3dEXTDelegate>()(bx, by, bz);
		}
		
		public static void glBinormal3dvEXT(double[] v)
		{
			Native.GetDelegateFor<glBinormal3dvEXTDelegate>()(v);
		}
		
		public static void glBinormal3fEXT(float bx, float by, float bz)
		{
			Native.GetDelegateFor<glBinormal3fEXTDelegate>()(bx, by, bz);
		}
		
		public static void glBinormal3fvEXT(float[] v)
		{
			Native.GetDelegateFor<glBinormal3fvEXTDelegate>()(v);
		}
		
		public static void glBinormal3iEXT(int bx, int by, int bz)
		{
			Native.GetDelegateFor<glBinormal3iEXTDelegate>()(bx, by, bz);
		}
		
		public static void glBinormal3ivEXT(int[] v)
		{
			Native.GetDelegateFor<glBinormal3ivEXTDelegate>()(v);
		}
		
		public static void glBinormal3sEXT(short bx, short by, short bz)
		{
			Native.GetDelegateFor<glBinormal3sEXTDelegate>()(bx, by, bz);
		}
		
		public static void glBinormal3svEXT(short[] v)
		{
			Native.GetDelegateFor<glBinormal3svEXTDelegate>()(v);
		}
		
		public static void glTangentPointerEXT(uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glTangentPointerEXTDelegate>()(type, stride, pointer);
		}
		
		public static void glBinormalPointerEXT(uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glBinormalPointerEXTDelegate>()(type, stride, pointer);
		}
		
		public static void glCopyImageSubDataEXT(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			Native.GetDelegateFor<glCopyImageSubDataEXTDelegate>()(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}
		
		public static void glCopyTexImage1DEXT(uint target, int level, uint internalformat, int x, int y, int width, int border)
		{
			Native.GetDelegateFor<glCopyTexImage1DEXTDelegate>()(target, level, internalformat, x, y, width, border);
		}
		
		public static void glCopyTexImage2DEXT(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
			Native.GetDelegateFor<glCopyTexImage2DEXTDelegate>()(target, level, internalformat, x, y, width, height, border);
		}
		
		public static void glCopyTexSubImage1DEXT(uint target, int level, int xoffset, int x, int y, int width)
		{
			Native.GetDelegateFor<glCopyTexSubImage1DEXTDelegate>()(target, level, xoffset, x, y, width);
		}
		
		public static void glCopyTexSubImage2DEXT(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyTexSubImage2DEXTDelegate>()(target, level, xoffset, yoffset, x, y, width, height);
		}
		
		public static void glCopyTexSubImage3DEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyTexSubImage3DEXTDelegate>()(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		
		public static void glCullParameterdvEXT(uint pname, double[] @params)
		{
			Native.GetDelegateFor<glCullParameterdvEXTDelegate>()(pname, @params);
		}
		
		public static void glCullParameterfvEXT(uint pname, float[] @params)
		{
			Native.GetDelegateFor<glCullParameterfvEXTDelegate>()(pname, @params);
		}
		
		public static void glLabelObjectEXT(uint type, uint @object, int length, char[] label)
		{
			Native.GetDelegateFor<glLabelObjectEXTDelegate>()(type, @object, length, label);
		}
		
		public static void glGetObjectLabelEXT(uint type, uint @object, int bufSize, int[] length, char[] label)
		{
			Native.GetDelegateFor<glGetObjectLabelEXTDelegate>()(type, @object, bufSize, length, label);
		}
		
		public static void glInsertEventMarkerEXT(int length, char[] marker)
		{
			Native.GetDelegateFor<glInsertEventMarkerEXTDelegate>()(length, marker);
		}
		
		public static void glPushGroupMarkerEXT(int length, char[] marker)
		{
			Native.GetDelegateFor<glPushGroupMarkerEXTDelegate>()(length, marker);
		}
		
		public static void glPopGroupMarkerEXT()
		{
			Native.GetDelegateFor<glPopGroupMarkerEXTDelegate>()();
		}
		
		public static void glDepthBoundsEXT(double zmin, double zmax)
		{
			Native.GetDelegateFor<glDepthBoundsEXTDelegate>()(zmin, zmax);
		}
		
		public static void glMatrixLoadfEXT(uint mode, float[] m)
		{
			Native.GetDelegateFor<glMatrixLoadfEXTDelegate>()(mode, m);
		}
		
		public static void glMatrixLoaddEXT(uint mode, double[] m)
		{
			Native.GetDelegateFor<glMatrixLoaddEXTDelegate>()(mode, m);
		}
		
		public static void glMatrixMultfEXT(uint mode, float[] m)
		{
			Native.GetDelegateFor<glMatrixMultfEXTDelegate>()(mode, m);
		}
		
		public static void glMatrixMultdEXT(uint mode, double[] m)
		{
			Native.GetDelegateFor<glMatrixMultdEXTDelegate>()(mode, m);
		}
		
		public static void glMatrixLoadIdentityEXT(uint mode)
		{
			Native.GetDelegateFor<glMatrixLoadIdentityEXTDelegate>()(mode);
		}
		
		public static void glMatrixRotatefEXT(uint mode, float angle, float x, float y, float z)
		{
			Native.GetDelegateFor<glMatrixRotatefEXTDelegate>()(mode, angle, x, y, z);
		}
		
		public static void glMatrixRotatedEXT(uint mode, double angle, double x, double y, double z)
		{
			Native.GetDelegateFor<glMatrixRotatedEXTDelegate>()(mode, angle, x, y, z);
		}
		
		public static void glMatrixScalefEXT(uint mode, float x, float y, float z)
		{
			Native.GetDelegateFor<glMatrixScalefEXTDelegate>()(mode, x, y, z);
		}
		
		public static void glMatrixScaledEXT(uint mode, double x, double y, double z)
		{
			Native.GetDelegateFor<glMatrixScaledEXTDelegate>()(mode, x, y, z);
		}
		
		public static void glMatrixTranslatefEXT(uint mode, float x, float y, float z)
		{
			Native.GetDelegateFor<glMatrixTranslatefEXTDelegate>()(mode, x, y, z);
		}
		
		public static void glMatrixTranslatedEXT(uint mode, double x, double y, double z)
		{
			Native.GetDelegateFor<glMatrixTranslatedEXTDelegate>()(mode, x, y, z);
		}
		
		public static void glMatrixFrustumEXT(uint mode, double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Native.GetDelegateFor<glMatrixFrustumEXTDelegate>()(mode, left, right, bottom, top, zNear, zFar);
		}
		
		public static void glMatrixOrthoEXT(uint mode, double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Native.GetDelegateFor<glMatrixOrthoEXTDelegate>()(mode, left, right, bottom, top, zNear, zFar);
		}
		
		public static void glMatrixPopEXT(uint mode)
		{
			Native.GetDelegateFor<glMatrixPopEXTDelegate>()(mode);
		}
		
		public static void glMatrixPushEXT(uint mode)
		{
			Native.GetDelegateFor<glMatrixPushEXTDelegate>()(mode);
		}
		
		public static void glClientAttribDefaultEXT(uint mask)
		{
			Native.GetDelegateFor<glClientAttribDefaultEXTDelegate>()(mask);
		}
		
		public static void glPushClientAttribDefaultEXT(uint mask)
		{
			Native.GetDelegateFor<glPushClientAttribDefaultEXTDelegate>()(mask);
		}
		
		public static void glTextureParameterfEXT(uint texture, uint target, uint pname, float param)
		{
			Native.GetDelegateFor<glTextureParameterfEXTDelegate>()(texture, target, pname, param);
		}
		
		public static void glTextureParameterfvEXT(uint texture, uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glTextureParameterfvEXTDelegate>()(texture, target, pname, @params);
		}
		
		public static void glTextureParameteriEXT(uint texture, uint target, uint pname, int param)
		{
			Native.GetDelegateFor<glTextureParameteriEXTDelegate>()(texture, target, pname, param);
		}
		
		public static void glTextureParameterivEXT(uint texture, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glTextureParameterivEXTDelegate>()(texture, target, pname, @params);
		}
		
		public static void glTextureImage1DEXT(uint texture, uint target, int level, int internalformat, int width, int border, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTextureImage1DEXTDelegate>()(texture, target, level, internalformat, width, border, format, type, pixels);
		}
		
		public static void glTextureImage2DEXT(uint texture, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTextureImage2DEXTDelegate>()(texture, target, level, internalformat, width, height, border, format, type, pixels);
		}
		
		public static void glTextureSubImage1DEXT(uint texture, uint target, int level, int xoffset, int width, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTextureSubImage1DEXTDelegate>()(texture, target, level, xoffset, width, format, type, pixels);
		}
		
		public static void glTextureSubImage2DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTextureSubImage2DEXTDelegate>()(texture, target, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		
		public static void glCopyTextureImage1DEXT(uint texture, uint target, int level, uint internalformat, int x, int y, int width, int border)
		{
			Native.GetDelegateFor<glCopyTextureImage1DEXTDelegate>()(texture, target, level, internalformat, x, y, width, border);
		}
		
		public static void glCopyTextureImage2DEXT(uint texture, uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
			Native.GetDelegateFor<glCopyTextureImage2DEXTDelegate>()(texture, target, level, internalformat, x, y, width, height, border);
		}
		
		public static void glCopyTextureSubImage1DEXT(uint texture, uint target, int level, int xoffset, int x, int y, int width)
		{
			Native.GetDelegateFor<glCopyTextureSubImage1DEXTDelegate>()(texture, target, level, xoffset, x, y, width);
		}
		
		public static void glCopyTextureSubImage2DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyTextureSubImage2DEXTDelegate>()(texture, target, level, xoffset, yoffset, x, y, width, height);
		}
		
		public static void glGetTextureImageEXT(uint texture, uint target, int level, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glGetTextureImageEXTDelegate>()(texture, target, level, format, type, pixels);
		}
		
		public static void glGetTextureParameterfvEXT(uint texture, uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetTextureParameterfvEXTDelegate>()(texture, target, pname, @params);
		}
		
		public static void glGetTextureParameterivEXT(uint texture, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetTextureParameterivEXTDelegate>()(texture, target, pname, @params);
		}
		
		public static void glGetTextureLevelParameterfvEXT(uint texture, uint target, int level, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetTextureLevelParameterfvEXTDelegate>()(texture, target, level, pname, @params);
		}
		
		public static void glGetTextureLevelParameterivEXT(uint texture, uint target, int level, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetTextureLevelParameterivEXTDelegate>()(texture, target, level, pname, @params);
		}
		
		public static void glTextureImage3DEXT(uint texture, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTextureImage3DEXTDelegate>()(texture, target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		
		public static void glTextureSubImage3DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTextureSubImage3DEXTDelegate>()(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		public static void glCopyTextureSubImage3DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyTextureSubImage3DEXTDelegate>()(texture, target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		
		public static void glBindMultiTextureEXT(uint texunit, uint target, uint texture)
		{
			Native.GetDelegateFor<glBindMultiTextureEXTDelegate>()(texunit, target, texture);
		}
		
		public static void glMultiTexCoordPointerEXT(uint texunit, int size, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glMultiTexCoordPointerEXTDelegate>()(texunit, size, type, stride, pointer);
		}
		
		public static void glMultiTexEnvfEXT(uint texunit, uint target, uint pname, float param)
		{
			Native.GetDelegateFor<glMultiTexEnvfEXTDelegate>()(texunit, target, pname, param);
		}
		
		public static void glMultiTexEnvfvEXT(uint texunit, uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glMultiTexEnvfvEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glMultiTexEnviEXT(uint texunit, uint target, uint pname, int param)
		{
			Native.GetDelegateFor<glMultiTexEnviEXTDelegate>()(texunit, target, pname, param);
		}
		
		public static void glMultiTexEnvivEXT(uint texunit, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glMultiTexEnvivEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glMultiTexGendEXT(uint texunit, uint coord, uint pname, double param)
		{
			Native.GetDelegateFor<glMultiTexGendEXTDelegate>()(texunit, coord, pname, param);
		}
		
		public static void glMultiTexGendvEXT(uint texunit, uint coord, uint pname, double[] @params)
		{
			Native.GetDelegateFor<glMultiTexGendvEXTDelegate>()(texunit, coord, pname, @params);
		}
		
		public static void glMultiTexGenfEXT(uint texunit, uint coord, uint pname, float param)
		{
			Native.GetDelegateFor<glMultiTexGenfEXTDelegate>()(texunit, coord, pname, param);
		}
		
		public static void glMultiTexGenfvEXT(uint texunit, uint coord, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glMultiTexGenfvEXTDelegate>()(texunit, coord, pname, @params);
		}
		
		public static void glMultiTexGeniEXT(uint texunit, uint coord, uint pname, int param)
		{
			Native.GetDelegateFor<glMultiTexGeniEXTDelegate>()(texunit, coord, pname, param);
		}
		
		public static void glMultiTexGenivEXT(uint texunit, uint coord, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glMultiTexGenivEXTDelegate>()(texunit, coord, pname, @params);
		}
		
		public static void glGetMultiTexEnvfvEXT(uint texunit, uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexEnvfvEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glGetMultiTexEnvivEXT(uint texunit, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexEnvivEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glGetMultiTexGendvEXT(uint texunit, uint coord, uint pname, double[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexGendvEXTDelegate>()(texunit, coord, pname, @params);
		}
		
		public static void glGetMultiTexGenfvEXT(uint texunit, uint coord, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexGenfvEXTDelegate>()(texunit, coord, pname, @params);
		}
		
		public static void glGetMultiTexGenivEXT(uint texunit, uint coord, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexGenivEXTDelegate>()(texunit, coord, pname, @params);
		}
		
		public static void glMultiTexParameteriEXT(uint texunit, uint target, uint pname, int param)
		{
			Native.GetDelegateFor<glMultiTexParameteriEXTDelegate>()(texunit, target, pname, param);
		}
		
		public static void glMultiTexParameterivEXT(uint texunit, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glMultiTexParameterivEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glMultiTexParameterfEXT(uint texunit, uint target, uint pname, float param)
		{
			Native.GetDelegateFor<glMultiTexParameterfEXTDelegate>()(texunit, target, pname, param);
		}
		
		public static void glMultiTexParameterfvEXT(uint texunit, uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glMultiTexParameterfvEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glMultiTexImage1DEXT(uint texunit, uint target, int level, int internalformat, int width, int border, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glMultiTexImage1DEXTDelegate>()(texunit, target, level, internalformat, width, border, format, type, pixels);
		}
		
		public static void glMultiTexImage2DEXT(uint texunit, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glMultiTexImage2DEXTDelegate>()(texunit, target, level, internalformat, width, height, border, format, type, pixels);
		}
		
		public static void glMultiTexSubImage1DEXT(uint texunit, uint target, int level, int xoffset, int width, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glMultiTexSubImage1DEXTDelegate>()(texunit, target, level, xoffset, width, format, type, pixels);
		}
		
		public static void glMultiTexSubImage2DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glMultiTexSubImage2DEXTDelegate>()(texunit, target, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		
		public static void glCopyMultiTexImage1DEXT(uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int border)
		{
			Native.GetDelegateFor<glCopyMultiTexImage1DEXTDelegate>()(texunit, target, level, internalformat, x, y, width, border);
		}
		
		public static void glCopyMultiTexImage2DEXT(uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
			Native.GetDelegateFor<glCopyMultiTexImage2DEXTDelegate>()(texunit, target, level, internalformat, x, y, width, height, border);
		}
		
		public static void glCopyMultiTexSubImage1DEXT(uint texunit, uint target, int level, int xoffset, int x, int y, int width)
		{
			Native.GetDelegateFor<glCopyMultiTexSubImage1DEXTDelegate>()(texunit, target, level, xoffset, x, y, width);
		}
		
		public static void glCopyMultiTexSubImage2DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyMultiTexSubImage2DEXTDelegate>()(texunit, target, level, xoffset, yoffset, x, y, width, height);
		}
		
		public static void glGetMultiTexImageEXT(uint texunit, uint target, int level, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glGetMultiTexImageEXTDelegate>()(texunit, target, level, format, type, pixels);
		}
		
		public static void glGetMultiTexParameterfvEXT(uint texunit, uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexParameterfvEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glGetMultiTexParameterivEXT(uint texunit, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexParameterivEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glGetMultiTexLevelParameterfvEXT(uint texunit, uint target, int level, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexLevelParameterfvEXTDelegate>()(texunit, target, level, pname, @params);
		}
		
		public static void glGetMultiTexLevelParameterivEXT(uint texunit, uint target, int level, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexLevelParameterivEXTDelegate>()(texunit, target, level, pname, @params);
		}
		
		public static void glMultiTexImage3DEXT(uint texunit, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glMultiTexImage3DEXTDelegate>()(texunit, target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		
		public static void glMultiTexSubImage3DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glMultiTexSubImage3DEXTDelegate>()(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		public static void glCopyMultiTexSubImage3DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyMultiTexSubImage3DEXTDelegate>()(texunit, target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		
		public static void glEnableClientStateIndexedEXT(uint array, uint index)
		{
			Native.GetDelegateFor<glEnableClientStateIndexedEXTDelegate>()(array, index);
		}
		
		public static void glDisableClientStateIndexedEXT(uint array, uint index)
		{
			Native.GetDelegateFor<glDisableClientStateIndexedEXTDelegate>()(array, index);
		}
		
		public static void glGetFloatIndexedvEXT(uint target, uint index, float[] data)
		{
			Native.GetDelegateFor<glGetFloatIndexedvEXTDelegate>()(target, index, data);
		}
		
		public static void glGetDoubleIndexedvEXT(uint target, uint index, double[] data)
		{
			Native.GetDelegateFor<glGetDoubleIndexedvEXTDelegate>()(target, index, data);
		}
		
		public static void glGetPointerIndexedvEXT(uint target, uint index, nint data)
		{
			Native.GetDelegateFor<glGetPointerIndexedvEXTDelegate>()(target, index, data);
		}
		
		public static void glEnableIndexedEXT(uint target, uint index)
		{
			Native.GetDelegateFor<glEnableIndexedEXTDelegate>()(target, index);
		}
		
		public static void glDisableIndexedEXT(uint target, uint index)
		{
			Native.GetDelegateFor<glDisableIndexedEXTDelegate>()(target, index);
		}
		
		public static bool glIsEnabledIndexedEXT(uint target, uint index)
		{
			return (bool)Native.GetDelegateFor<glIsEnabledIndexedEXTDelegate>()(target, index);
		}
		
		public static void glGetIntegerIndexedvEXT(uint target, uint index, int[] data)
		{
			Native.GetDelegateFor<glGetIntegerIndexedvEXTDelegate>()(target, index, data);
		}
		
		public static void glGetBooleanIndexedvEXT(uint target, uint index, bool[] data)
		{
			Native.GetDelegateFor<glGetBooleanIndexedvEXTDelegate>()(target, index, data);
		}
		
		public static void glCompressedTextureImage3DEXT(uint texture, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedTextureImage3DEXTDelegate>()(texture, target, level, internalformat, width, height, depth, border, imageSize, bits);
		}
		
		public static void glCompressedTextureImage2DEXT(uint texture, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedTextureImage2DEXTDelegate>()(texture, target, level, internalformat, width, height, border, imageSize, bits);
		}
		
		public static void glCompressedTextureImage1DEXT(uint texture, uint target, int level, uint internalformat, int width, int border, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedTextureImage1DEXTDelegate>()(texture, target, level, internalformat, width, border, imageSize, bits);
		}
		
		public static void glCompressedTextureSubImage3DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedTextureSubImage3DEXTDelegate>()(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);
		}
		
		public static void glCompressedTextureSubImage2DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedTextureSubImage2DEXTDelegate>()(texture, target, level, xoffset, yoffset, width, height, format, imageSize, bits);
		}
		
		public static void glCompressedTextureSubImage1DEXT(uint texture, uint target, int level, int xoffset, int width, uint format, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedTextureSubImage1DEXTDelegate>()(texture, target, level, xoffset, width, format, imageSize, bits);
		}
		
		public static void glGetCompressedTextureImageEXT(uint texture, uint target, int lod, nint img)
		{
			Native.GetDelegateFor<glGetCompressedTextureImageEXTDelegate>()(texture, target, lod, img);
		}
		
		public static void glCompressedMultiTexImage3DEXT(uint texunit, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedMultiTexImage3DEXTDelegate>()(texunit, target, level, internalformat, width, height, depth, border, imageSize, bits);
		}
		
		public static void glCompressedMultiTexImage2DEXT(uint texunit, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedMultiTexImage2DEXTDelegate>()(texunit, target, level, internalformat, width, height, border, imageSize, bits);
		}
		
		public static void glCompressedMultiTexImage1DEXT(uint texunit, uint target, int level, uint internalformat, int width, int border, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedMultiTexImage1DEXTDelegate>()(texunit, target, level, internalformat, width, border, imageSize, bits);
		}
		
		public static void glCompressedMultiTexSubImage3DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedMultiTexSubImage3DEXTDelegate>()(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);
		}
		
		public static void glCompressedMultiTexSubImage2DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedMultiTexSubImage2DEXTDelegate>()(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, bits);
		}
		
		public static void glCompressedMultiTexSubImage1DEXT(uint texunit, uint target, int level, int xoffset, int width, uint format, int imageSize, nint bits)
		{
			Native.GetDelegateFor<glCompressedMultiTexSubImage1DEXTDelegate>()(texunit, target, level, xoffset, width, format, imageSize, bits);
		}
		
		public static void glGetCompressedMultiTexImageEXT(uint texunit, uint target, int lod, nint img)
		{
			Native.GetDelegateFor<glGetCompressedMultiTexImageEXTDelegate>()(texunit, target, lod, img);
		}
		
		public static void glMatrixLoadTransposefEXT(uint mode, float[] m)
		{
			Native.GetDelegateFor<glMatrixLoadTransposefEXTDelegate>()(mode, m);
		}
		
		public static void glMatrixLoadTransposedEXT(uint mode, double[] m)
		{
			Native.GetDelegateFor<glMatrixLoadTransposedEXTDelegate>()(mode, m);
		}
		
		public static void glMatrixMultTransposefEXT(uint mode, float[] m)
		{
			Native.GetDelegateFor<glMatrixMultTransposefEXTDelegate>()(mode, m);
		}
		
		public static void glMatrixMultTransposedEXT(uint mode, double[] m)
		{
			Native.GetDelegateFor<glMatrixMultTransposedEXTDelegate>()(mode, m);
		}
		
		public static void glNamedBufferDataEXT(uint buffer, nint size, nint data, uint usage)
		{
			Native.GetDelegateFor<glNamedBufferDataEXTDelegate>()(buffer, size, data, usage);
		}
		
		public static void glNamedBufferSubDataEXT(uint buffer, nint offset, nint size, nint data)
		{
			Native.GetDelegateFor<glNamedBufferSubDataEXTDelegate>()(buffer, offset, size, data);
		}
		
		public static void glMapNamedBufferEXT(uint buffer, uint access)
		{
			Native.GetDelegateFor<glMapNamedBufferEXTDelegate>()(buffer, access);
		}
		
		public static bool glUnmapNamedBufferEXT(uint buffer)
		{
			return (bool)Native.GetDelegateFor<glUnmapNamedBufferEXTDelegate>()(buffer);
		}
		
		public static void glGetNamedBufferParameterivEXT(uint buffer, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetNamedBufferParameterivEXTDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferPointervEXT(uint buffer, uint pname, nint @params)
		{
			Native.GetDelegateFor<glGetNamedBufferPointervEXTDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferSubDataEXT(uint buffer, nint offset, nint size, nint data)
		{
			Native.GetDelegateFor<glGetNamedBufferSubDataEXTDelegate>()(buffer, offset, size, data);
		}
		
		public static void glProgramUniform1fEXT(uint program, int location, float v0)
		{
			Native.GetDelegateFor<glProgramUniform1fEXTDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform2fEXT(uint program, int location, float v0, float v1)
		{
			Native.GetDelegateFor<glProgramUniform2fEXTDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform3fEXT(uint program, int location, float v0, float v1, float v2)
		{
			Native.GetDelegateFor<glProgramUniform3fEXTDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform4fEXT(uint program, int location, float v0, float v1, float v2, float v3)
		{
			Native.GetDelegateFor<glProgramUniform4fEXTDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform1iEXT(uint program, int location, int v0)
		{
			Native.GetDelegateFor<glProgramUniform1iEXTDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform2iEXT(uint program, int location, int v0, int v1)
		{
			Native.GetDelegateFor<glProgramUniform2iEXTDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform3iEXT(uint program, int location, int v0, int v1, int v2)
		{
			Native.GetDelegateFor<glProgramUniform3iEXTDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform4iEXT(uint program, int location, int v0, int v1, int v2, int v3)
		{
			Native.GetDelegateFor<glProgramUniform4iEXTDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform1fvEXT(uint program, int location, int count, float[] value)
		{
			Native.GetDelegateFor<glProgramUniform1fvEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2fvEXT(uint program, int location, int count, float[] value)
		{
			Native.GetDelegateFor<glProgramUniform2fvEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3fvEXT(uint program, int location, int count, float[] value)
		{
			Native.GetDelegateFor<glProgramUniform3fvEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4fvEXT(uint program, int location, int count, float[] value)
		{
			Native.GetDelegateFor<glProgramUniform4fvEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1ivEXT(uint program, int location, int count, int[] value)
		{
			Native.GetDelegateFor<glProgramUniform1ivEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2ivEXT(uint program, int location, int count, int[] value)
		{
			Native.GetDelegateFor<glProgramUniform2ivEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3ivEXT(uint program, int location, int count, int[] value)
		{
			Native.GetDelegateFor<glProgramUniform3ivEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4ivEXT(uint program, int location, int count, int[] value)
		{
			Native.GetDelegateFor<glProgramUniform4ivEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniformMatrix2fvEXT(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2fvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3fvEXT(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3fvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4fvEXT(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4fvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x3fvEXT(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2x3fvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x2fvEXT(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3x2fvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x4fvEXT(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2x4fvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x2fvEXT(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4x2fvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x4fvEXT(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3x4fvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x3fvEXT(uint program, int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4x3fvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glTextureBufferEXT(uint texture, uint target, uint internalformat, uint buffer)
		{
			Native.GetDelegateFor<glTextureBufferEXTDelegate>()(texture, target, internalformat, buffer);
		}
		
		public static void glMultiTexBufferEXT(uint texunit, uint target, uint internalformat, uint buffer)
		{
			Native.GetDelegateFor<glMultiTexBufferEXTDelegate>()(texunit, target, internalformat, buffer);
		}
		
		public static void glTextureParameterIivEXT(uint texture, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glTextureParameterIivEXTDelegate>()(texture, target, pname, @params);
		}
		
		public static void glTextureParameterIuivEXT(uint texture, uint target, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glTextureParameterIuivEXTDelegate>()(texture, target, pname, @params);
		}
		
		public static void glGetTextureParameterIivEXT(uint texture, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetTextureParameterIivEXTDelegate>()(texture, target, pname, @params);
		}
		
		public static void glGetTextureParameterIuivEXT(uint texture, uint target, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetTextureParameterIuivEXTDelegate>()(texture, target, pname, @params);
		}
		
		public static void glMultiTexParameterIivEXT(uint texunit, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glMultiTexParameterIivEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glMultiTexParameterIuivEXT(uint texunit, uint target, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glMultiTexParameterIuivEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glGetMultiTexParameterIivEXT(uint texunit, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexParameterIivEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glGetMultiTexParameterIuivEXT(uint texunit, uint target, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetMultiTexParameterIuivEXTDelegate>()(texunit, target, pname, @params);
		}
		
		public static void glProgramUniform1uiEXT(uint program, int location, uint v0)
		{
			Native.GetDelegateFor<glProgramUniform1uiEXTDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform2uiEXT(uint program, int location, uint v0, uint v1)
		{
			Native.GetDelegateFor<glProgramUniform2uiEXTDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform3uiEXT(uint program, int location, uint v0, uint v1, uint v2)
		{
			Native.GetDelegateFor<glProgramUniform3uiEXTDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform4uiEXT(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			Native.GetDelegateFor<glProgramUniform4uiEXTDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform1uivEXT(uint program, int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glProgramUniform1uivEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2uivEXT(uint program, int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glProgramUniform2uivEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3uivEXT(uint program, int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glProgramUniform3uivEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4uivEXT(uint program, int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glProgramUniform4uivEXTDelegate>()(program, location, count, value);
		}
		
		public static void glNamedProgramLocalParameters4fvEXT(uint program, uint target, uint index, int count, float[] @params)
		{
			Native.GetDelegateFor<glNamedProgramLocalParameters4fvEXTDelegate>()(program, target, index, count, @params);
		}
		
		public static void glNamedProgramLocalParameterI4iEXT(uint program, uint target, uint index, int x, int y, int z, int w)
		{
			Native.GetDelegateFor<glNamedProgramLocalParameterI4iEXTDelegate>()(program, target, index, x, y, z, w);
		}
		
		public static void glNamedProgramLocalParameterI4ivEXT(uint program, uint target, uint index, int[] @params)
		{
			Native.GetDelegateFor<glNamedProgramLocalParameterI4ivEXTDelegate>()(program, target, index, @params);
		}
		
		public static void glNamedProgramLocalParametersI4ivEXT(uint program, uint target, uint index, int count, int[] @params)
		{
			Native.GetDelegateFor<glNamedProgramLocalParametersI4ivEXTDelegate>()(program, target, index, count, @params);
		}
		
		public static void glNamedProgramLocalParameterI4uiEXT(uint program, uint target, uint index, uint x, uint y, uint z, uint w)
		{
			Native.GetDelegateFor<glNamedProgramLocalParameterI4uiEXTDelegate>()(program, target, index, x, y, z, w);
		}
		
		public static void glNamedProgramLocalParameterI4uivEXT(uint program, uint target, uint index, uint[] @params)
		{
			Native.GetDelegateFor<glNamedProgramLocalParameterI4uivEXTDelegate>()(program, target, index, @params);
		}
		
		public static void glNamedProgramLocalParametersI4uivEXT(uint program, uint target, uint index, int count, uint[] @params)
		{
			Native.GetDelegateFor<glNamedProgramLocalParametersI4uivEXTDelegate>()(program, target, index, count, @params);
		}
		
		public static void glGetNamedProgramLocalParameterIivEXT(uint program, uint target, uint index, int[] @params)
		{
			Native.GetDelegateFor<glGetNamedProgramLocalParameterIivEXTDelegate>()(program, target, index, @params);
		}
		
		public static void glGetNamedProgramLocalParameterIuivEXT(uint program, uint target, uint index, uint[] @params)
		{
			Native.GetDelegateFor<glGetNamedProgramLocalParameterIuivEXTDelegate>()(program, target, index, @params);
		}
		
		public static void glEnableClientStateiEXT(uint array, uint index)
		{
			Native.GetDelegateFor<glEnableClientStateiEXTDelegate>()(array, index);
		}
		
		public static void glDisableClientStateiEXT(uint array, uint index)
		{
			Native.GetDelegateFor<glDisableClientStateiEXTDelegate>()(array, index);
		}
		
		public static void glGetFloati_vEXT(uint pname, uint index, float[] @params)
		{
			Native.GetDelegateFor<glGetFloati_vEXTDelegate>()(pname, index, @params);
		}
		
		public static void glGetDoublei_vEXT(uint pname, uint index, double[] @params)
		{
			Native.GetDelegateFor<glGetDoublei_vEXTDelegate>()(pname, index, @params);
		}
		
		public static void glGetPointeri_vEXT(uint pname, uint index, nint @params)
		{
			Native.GetDelegateFor<glGetPointeri_vEXTDelegate>()(pname, index, @params);
		}
		
		public static void glNamedProgramStringEXT(uint program, uint target, uint format, int len, nint @string)
		{
			Native.GetDelegateFor<glNamedProgramStringEXTDelegate>()(program, target, format, len, @string);
		}
		
		public static void glNamedProgramLocalParameter4dEXT(uint program, uint target, uint index, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glNamedProgramLocalParameter4dEXTDelegate>()(program, target, index, x, y, z, w);
		}
		
		public static void glNamedProgramLocalParameter4dvEXT(uint program, uint target, uint index, double[] @params)
		{
			Native.GetDelegateFor<glNamedProgramLocalParameter4dvEXTDelegate>()(program, target, index, @params);
		}
		
		public static void glNamedProgramLocalParameter4fEXT(uint program, uint target, uint index, float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glNamedProgramLocalParameter4fEXTDelegate>()(program, target, index, x, y, z, w);
		}
		
		public static void glNamedProgramLocalParameter4fvEXT(uint program, uint target, uint index, float[] @params)
		{
			Native.GetDelegateFor<glNamedProgramLocalParameter4fvEXTDelegate>()(program, target, index, @params);
		}
		
		public static void glGetNamedProgramLocalParameterdvEXT(uint program, uint target, uint index, double[] @params)
		{
			Native.GetDelegateFor<glGetNamedProgramLocalParameterdvEXTDelegate>()(program, target, index, @params);
		}
		
		public static void glGetNamedProgramLocalParameterfvEXT(uint program, uint target, uint index, float[] @params)
		{
			Native.GetDelegateFor<glGetNamedProgramLocalParameterfvEXTDelegate>()(program, target, index, @params);
		}
		
		public static void glGetNamedProgramivEXT(uint program, uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetNamedProgramivEXTDelegate>()(program, target, pname, @params);
		}
		
		public static void glGetNamedProgramStringEXT(uint program, uint target, uint pname, nint @string)
		{
			Native.GetDelegateFor<glGetNamedProgramStringEXTDelegate>()(program, target, pname, @string);
		}
		
		public static void glNamedRenderbufferStorageEXT(uint renderbuffer, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glNamedRenderbufferStorageEXTDelegate>()(renderbuffer, internalformat, width, height);
		}
		
		public static void glGetNamedRenderbufferParameterivEXT(uint renderbuffer, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetNamedRenderbufferParameterivEXTDelegate>()(renderbuffer, pname, @params);
		}
		
		public static void glNamedRenderbufferStorageMultisampleEXT(uint renderbuffer, int samples, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glNamedRenderbufferStorageMultisampleEXTDelegate>()(renderbuffer, samples, internalformat, width, height);
		}
		
		public static void glNamedRenderbufferStorageMultisampleCoverageEXT(uint renderbuffer, int coverageSamples, int colorSamples, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glNamedRenderbufferStorageMultisampleCoverageEXTDelegate>()(renderbuffer, coverageSamples, colorSamples, internalformat, width, height);
		}
		
		public static uint glCheckNamedFramebufferStatusEXT(uint framebuffer, uint target)
		{
			return (uint)Native.GetDelegateFor<glCheckNamedFramebufferStatusEXTDelegate>()(framebuffer, target);
		}
		
		public static void glNamedFramebufferTexture1DEXT(uint framebuffer, uint attachment, uint textarget, uint texture, int level)
		{
			Native.GetDelegateFor<glNamedFramebufferTexture1DEXTDelegate>()(framebuffer, attachment, textarget, texture, level);
		}
		
		public static void glNamedFramebufferTexture2DEXT(uint framebuffer, uint attachment, uint textarget, uint texture, int level)
		{
			Native.GetDelegateFor<glNamedFramebufferTexture2DEXTDelegate>()(framebuffer, attachment, textarget, texture, level);
		}
		
		public static void glNamedFramebufferTexture3DEXT(uint framebuffer, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
			Native.GetDelegateFor<glNamedFramebufferTexture3DEXTDelegate>()(framebuffer, attachment, textarget, texture, level, zoffset);
		}
		
		public static void glNamedFramebufferRenderbufferEXT(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			Native.GetDelegateFor<glNamedFramebufferRenderbufferEXTDelegate>()(framebuffer, attachment, renderbuffertarget, renderbuffer);
		}
		
		public static void glGetNamedFramebufferAttachmentParameterivEXT(uint framebuffer, uint attachment, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetNamedFramebufferAttachmentParameterivEXTDelegate>()(framebuffer, attachment, pname, @params);
		}
		
		public static void glGenerateTextureMipmapEXT(uint texture, uint target)
		{
			Native.GetDelegateFor<glGenerateTextureMipmapEXTDelegate>()(texture, target);
		}
		
		public static void glGenerateMultiTexMipmapEXT(uint texunit, uint target)
		{
			Native.GetDelegateFor<glGenerateMultiTexMipmapEXTDelegate>()(texunit, target);
		}
		
		public static void glFramebufferDrawBufferEXT(uint framebuffer, uint mode)
		{
			Native.GetDelegateFor<glFramebufferDrawBufferEXTDelegate>()(framebuffer, mode);
		}
		
		public static void glFramebufferDrawBuffersEXT(uint framebuffer, int n, uint[] bufs)
		{
			Native.GetDelegateFor<glFramebufferDrawBuffersEXTDelegate>()(framebuffer, n, bufs);
		}
		
		public static void glFramebufferReadBufferEXT(uint framebuffer, uint mode)
		{
			Native.GetDelegateFor<glFramebufferReadBufferEXTDelegate>()(framebuffer, mode);
		}
		
		public static void glGetFramebufferParameterivEXT(uint framebuffer, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetFramebufferParameterivEXTDelegate>()(framebuffer, pname, @params);
		}
		
		public static void glNamedCopyBufferSubDataEXT(uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size)
		{
			Native.GetDelegateFor<glNamedCopyBufferSubDataEXTDelegate>()(readBuffer, writeBuffer, readOffset, writeOffset, size);
		}
		
		public static void glNamedFramebufferTextureEXT(uint framebuffer, uint attachment, uint texture, int level)
		{
			Native.GetDelegateFor<glNamedFramebufferTextureEXTDelegate>()(framebuffer, attachment, texture, level);
		}
		
		public static void glNamedFramebufferTextureLayerEXT(uint framebuffer, uint attachment, uint texture, int level, int layer)
		{
			Native.GetDelegateFor<glNamedFramebufferTextureLayerEXTDelegate>()(framebuffer, attachment, texture, level, layer);
		}
		
		public static void glNamedFramebufferTextureFaceEXT(uint framebuffer, uint attachment, uint texture, int level, uint face)
		{
			Native.GetDelegateFor<glNamedFramebufferTextureFaceEXTDelegate>()(framebuffer, attachment, texture, level, face);
		}
		
		public static void glTextureRenderbufferEXT(uint texture, uint target, uint renderbuffer)
		{
			Native.GetDelegateFor<glTextureRenderbufferEXTDelegate>()(texture, target, renderbuffer);
		}
		
		public static void glMultiTexRenderbufferEXT(uint texunit, uint target, uint renderbuffer)
		{
			Native.GetDelegateFor<glMultiTexRenderbufferEXTDelegate>()(texunit, target, renderbuffer);
		}
		
		public static void glVertexArrayVertexOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayVertexOffsetEXTDelegate>()(vaobj, buffer, size, type, stride, offset);
		}
		
		public static void glVertexArrayColorOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayColorOffsetEXTDelegate>()(vaobj, buffer, size, type, stride, offset);
		}
		
		public static void glVertexArrayEdgeFlagOffsetEXT(uint vaobj, uint buffer, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayEdgeFlagOffsetEXTDelegate>()(vaobj, buffer, stride, offset);
		}
		
		public static void glVertexArrayIndexOffsetEXT(uint vaobj, uint buffer, uint type, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayIndexOffsetEXTDelegate>()(vaobj, buffer, type, stride, offset);
		}
		
		public static void glVertexArrayNormalOffsetEXT(uint vaobj, uint buffer, uint type, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayNormalOffsetEXTDelegate>()(vaobj, buffer, type, stride, offset);
		}
		
		public static void glVertexArrayTexCoordOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayTexCoordOffsetEXTDelegate>()(vaobj, buffer, size, type, stride, offset);
		}
		
		public static void glVertexArrayMultiTexCoordOffsetEXT(uint vaobj, uint buffer, uint texunit, int size, uint type, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayMultiTexCoordOffsetEXTDelegate>()(vaobj, buffer, texunit, size, type, stride, offset);
		}
		
		public static void glVertexArrayFogCoordOffsetEXT(uint vaobj, uint buffer, uint type, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayFogCoordOffsetEXTDelegate>()(vaobj, buffer, type, stride, offset);
		}
		
		public static void glVertexArraySecondaryColorOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArraySecondaryColorOffsetEXTDelegate>()(vaobj, buffer, size, type, stride, offset);
		}
		
		public static void glVertexArrayVertexAttribOffsetEXT(uint vaobj, uint buffer, uint index, int size, uint type, bool normalized, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayVertexAttribOffsetEXTDelegate>()(vaobj, buffer, index, size, type, normalized, stride, offset);
		}
		
		public static void glVertexArrayVertexAttribIOffsetEXT(uint vaobj, uint buffer, uint index, int size, uint type, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayVertexAttribIOffsetEXTDelegate>()(vaobj, buffer, index, size, type, stride, offset);
		}
		
		public static void glEnableVertexArrayEXT(uint vaobj, uint array)
		{
			Native.GetDelegateFor<glEnableVertexArrayEXTDelegate>()(vaobj, array);
		}
		
		public static void glDisableVertexArrayEXT(uint vaobj, uint array)
		{
			Native.GetDelegateFor<glDisableVertexArrayEXTDelegate>()(vaobj, array);
		}
		
		public static void glEnableVertexArrayAttribEXT(uint vaobj, uint index)
		{
			Native.GetDelegateFor<glEnableVertexArrayAttribEXTDelegate>()(vaobj, index);
		}
		
		public static void glDisableVertexArrayAttribEXT(uint vaobj, uint index)
		{
			Native.GetDelegateFor<glDisableVertexArrayAttribEXTDelegate>()(vaobj, index);
		}
		
		public static void glGetVertexArrayIntegervEXT(uint vaobj, uint pname, int[] param)
		{
			Native.GetDelegateFor<glGetVertexArrayIntegervEXTDelegate>()(vaobj, pname, param);
		}
		
		public static void glGetVertexArrayPointervEXT(uint vaobj, uint pname, nint param)
		{
			Native.GetDelegateFor<glGetVertexArrayPointervEXTDelegate>()(vaobj, pname, param);
		}
		
		public static void glGetVertexArrayIntegeri_vEXT(uint vaobj, uint index, uint pname, int[] param)
		{
			Native.GetDelegateFor<glGetVertexArrayIntegeri_vEXTDelegate>()(vaobj, index, pname, param);
		}
		
		public static void glGetVertexArrayPointeri_vEXT(uint vaobj, uint index, uint pname, nint param)
		{
			Native.GetDelegateFor<glGetVertexArrayPointeri_vEXTDelegate>()(vaobj, index, pname, param);
		}
		
		public static void glMapNamedBufferRangeEXT(uint buffer, nint offset, nint length, uint access)
		{
			Native.GetDelegateFor<glMapNamedBufferRangeEXTDelegate>()(buffer, offset, length, access);
		}
		
		public static void glFlushMappedNamedBufferRangeEXT(uint buffer, nint offset, nint length)
		{
			Native.GetDelegateFor<glFlushMappedNamedBufferRangeEXTDelegate>()(buffer, offset, length);
		}
		
		public static void glNamedBufferStorageEXT(uint buffer, nint size, nint data, uint flags)
		{
			Native.GetDelegateFor<glNamedBufferStorageEXTDelegate>()(buffer, size, data, flags);
		}
		
		public static void glClearNamedBufferDataEXT(uint buffer, uint internalformat, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glClearNamedBufferDataEXTDelegate>()(buffer, internalformat, format, type, data);
		}
		
		public static void glClearNamedBufferSubDataEXT(uint buffer, uint internalformat, nint offset, nint size, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glClearNamedBufferSubDataEXTDelegate>()(buffer, internalformat, offset, size, format, type, data);
		}
		
		public static void glNamedFramebufferParameteriEXT(uint framebuffer, uint pname, int param)
		{
			Native.GetDelegateFor<glNamedFramebufferParameteriEXTDelegate>()(framebuffer, pname, param);
		}
		
		public static void glGetNamedFramebufferParameterivEXT(uint framebuffer, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetNamedFramebufferParameterivEXTDelegate>()(framebuffer, pname, @params);
		}
		
		public static void glProgramUniform1dEXT(uint program, int location, double x)
		{
			Native.GetDelegateFor<glProgramUniform1dEXTDelegate>()(program, location, x);
		}
		
		public static void glProgramUniform2dEXT(uint program, int location, double x, double y)
		{
			Native.GetDelegateFor<glProgramUniform2dEXTDelegate>()(program, location, x, y);
		}
		
		public static void glProgramUniform3dEXT(uint program, int location, double x, double y, double z)
		{
			Native.GetDelegateFor<glProgramUniform3dEXTDelegate>()(program, location, x, y, z);
		}
		
		public static void glProgramUniform4dEXT(uint program, int location, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glProgramUniform4dEXTDelegate>()(program, location, x, y, z, w);
		}
		
		public static void glProgramUniform1dvEXT(uint program, int location, int count, double[] value)
		{
			Native.GetDelegateFor<glProgramUniform1dvEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2dvEXT(uint program, int location, int count, double[] value)
		{
			Native.GetDelegateFor<glProgramUniform2dvEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3dvEXT(uint program, int location, int count, double[] value)
		{
			Native.GetDelegateFor<glProgramUniform3dvEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4dvEXT(uint program, int location, int count, double[] value)
		{
			Native.GetDelegateFor<glProgramUniform4dvEXTDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniformMatrix2dvEXT(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2dvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3dvEXT(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3dvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4dvEXT(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4dvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x3dvEXT(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2x3dvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x4dvEXT(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix2x4dvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x2dvEXT(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3x2dvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x4dvEXT(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix3x4dvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x2dvEXT(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4x2dvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x3dvEXT(uint program, int location, int count, bool transpose, double[] value)
		{
			Native.GetDelegateFor<glProgramUniformMatrix4x3dvEXTDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glTextureBufferRangeEXT(uint texture, uint target, uint internalformat, uint buffer, nint offset, nint size)
		{
			Native.GetDelegateFor<glTextureBufferRangeEXTDelegate>()(texture, target, internalformat, buffer, offset, size);
		}
		
		public static void glTextureStorage1DEXT(uint texture, uint target, int levels, uint internalformat, int width)
		{
			Native.GetDelegateFor<glTextureStorage1DEXTDelegate>()(texture, target, levels, internalformat, width);
		}
		
		public static void glTextureStorage2DEXT(uint texture, uint target, int levels, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glTextureStorage2DEXTDelegate>()(texture, target, levels, internalformat, width, height);
		}
		
		public static void glTextureStorage3DEXT(uint texture, uint target, int levels, uint internalformat, int width, int height, int depth)
		{
			Native.GetDelegateFor<glTextureStorage3DEXTDelegate>()(texture, target, levels, internalformat, width, height, depth);
		}
		
		public static void glTextureStorage2DMultisampleEXT(uint texture, uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			Native.GetDelegateFor<glTextureStorage2DMultisampleEXTDelegate>()(texture, target, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		public static void glTextureStorage3DMultisampleEXT(uint texture, uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			Native.GetDelegateFor<glTextureStorage3DMultisampleEXTDelegate>()(texture, target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glVertexArrayBindVertexBufferEXT(uint vaobj, uint bindingindex, uint buffer, nint offset, int stride)
		{
			Native.GetDelegateFor<glVertexArrayBindVertexBufferEXTDelegate>()(vaobj, bindingindex, buffer, offset, stride);
		}
		
		public static void glVertexArrayVertexAttribFormatEXT(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			Native.GetDelegateFor<glVertexArrayVertexAttribFormatEXTDelegate>()(vaobj, attribindex, size, type, normalized, relativeoffset);
		}
		
		public static void glVertexArrayVertexAttribIFormatEXT(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			Native.GetDelegateFor<glVertexArrayVertexAttribIFormatEXTDelegate>()(vaobj, attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexArrayVertexAttribLFormatEXT(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			Native.GetDelegateFor<glVertexArrayVertexAttribLFormatEXTDelegate>()(vaobj, attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexArrayVertexAttribBindingEXT(uint vaobj, uint attribindex, uint bindingindex)
		{
			Native.GetDelegateFor<glVertexArrayVertexAttribBindingEXTDelegate>()(vaobj, attribindex, bindingindex);
		}
		
		public static void glVertexArrayVertexBindingDivisorEXT(uint vaobj, uint bindingindex, uint divisor)
		{
			Native.GetDelegateFor<glVertexArrayVertexBindingDivisorEXTDelegate>()(vaobj, bindingindex, divisor);
		}
		
		public static void glVertexArrayVertexAttribLOffsetEXT(uint vaobj, uint buffer, uint index, int size, uint type, int stride, nint offset)
		{
			Native.GetDelegateFor<glVertexArrayVertexAttribLOffsetEXTDelegate>()(vaobj, buffer, index, size, type, stride, offset);
		}
		
		public static void glTexturePageCommitmentEXT(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit)
		{
			Native.GetDelegateFor<glTexturePageCommitmentEXTDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, commit);
		}
		
		public static void glVertexArrayVertexAttribDivisorEXT(uint vaobj, uint index, uint divisor)
		{
			Native.GetDelegateFor<glVertexArrayVertexAttribDivisorEXTDelegate>()(vaobj, index, divisor);
		}
		
		public static void glDiscardFramebufferEXT(uint target, int numAttachments, uint[] attachments)
		{
			Native.GetDelegateFor<glDiscardFramebufferEXTDelegate>()(target, numAttachments, attachments);
		}
		
		public static void glGenQueriesEXT(int n, uint[] ids)
		{
			Native.GetDelegateFor<glGenQueriesEXTDelegate>()(n, ids);
		}
		
		public static void glDeleteQueriesEXT(int n, uint[] ids)
		{
			Native.GetDelegateFor<glDeleteQueriesEXTDelegate>()(n, ids);
		}
		
		public static bool glIsQueryEXT(uint id)
		{
			return (bool)Native.GetDelegateFor<glIsQueryEXTDelegate>()(id);
		}
		
		public static void glBeginQueryEXT(uint target, uint id)
		{
			Native.GetDelegateFor<glBeginQueryEXTDelegate>()(target, id);
		}
		
		public static void glEndQueryEXT(uint target)
		{
			Native.GetDelegateFor<glEndQueryEXTDelegate>()(target);
		}
		
		public static void glQueryCounterEXT(uint id, uint target)
		{
			Native.GetDelegateFor<glQueryCounterEXTDelegate>()(id, target);
		}
		
		public static void glGetQueryivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetQueryivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetQueryObjectivEXT(uint id, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetQueryObjectivEXTDelegate>()(id, pname, @params);
		}
		
		public static void glGetQueryObjectuivEXT(uint id, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetQueryObjectuivEXTDelegate>()(id, pname, @params);
		}
		
		public static void glGetQueryObjecti64vEXT(uint id, uint pname, Int64[] @params)
		{
			Native.GetDelegateFor<glGetQueryObjecti64vEXTDelegate>()(id, pname, @params);
		}
		
		public static void glGetQueryObjectui64vEXT(uint id, uint pname, UInt64[] @params)
		{
			Native.GetDelegateFor<glGetQueryObjectui64vEXTDelegate>()(id, pname, @params);
		}
		
		public static void glDrawBuffersEXT(int n, uint[] bufs)
		{
			Native.GetDelegateFor<glDrawBuffersEXTDelegate>()(n, bufs);
		}
		
		public static void glColorMaskIndexedEXT(uint index, bool r, bool g, bool b, bool a)
		{
			Native.GetDelegateFor<glColorMaskIndexedEXTDelegate>()(index, r, g, b, a);
		}
		
		public static void glEnableiEXT(uint target, uint index)
		{
			Native.GetDelegateFor<glEnableiEXTDelegate>()(target, index);
		}
		
		public static void glDisableiEXT(uint target, uint index)
		{
			Native.GetDelegateFor<glDisableiEXTDelegate>()(target, index);
		}
		
		public static void glBlendEquationiEXT(uint buf, uint mode)
		{
			Native.GetDelegateFor<glBlendEquationiEXTDelegate>()(buf, mode);
		}
		
		public static void glBlendEquationSeparateiEXT(uint buf, uint modeRGB, uint modeAlpha)
		{
			Native.GetDelegateFor<glBlendEquationSeparateiEXTDelegate>()(buf, modeRGB, modeAlpha);
		}
		
		public static void glBlendFunciEXT(uint buf, uint src, uint dst)
		{
			Native.GetDelegateFor<glBlendFunciEXTDelegate>()(buf, src, dst);
		}
		
		public static void glBlendFuncSeparateiEXT(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
		{
			Native.GetDelegateFor<glBlendFuncSeparateiEXTDelegate>()(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}
		
		public static void glColorMaskiEXT(uint index, bool r, bool g, bool b, bool a)
		{
			Native.GetDelegateFor<glColorMaskiEXTDelegate>()(index, r, g, b, a);
		}
		
		public static bool glIsEnablediEXT(uint target, uint index)
		{
			return (bool)Native.GetDelegateFor<glIsEnablediEXTDelegate>()(target, index);
		}
		
		public static void glDrawElementsBaseVertexEXT(uint mode, int count, uint type, nint indices, int basevertex)
		{
			Native.GetDelegateFor<glDrawElementsBaseVertexEXTDelegate>()(mode, count, type, indices, basevertex);
		}
		
		public static void glDrawRangeElementsBaseVertexEXT(uint mode, uint start, uint end, int count, uint type, nint indices, int basevertex)
		{
			Native.GetDelegateFor<glDrawRangeElementsBaseVertexEXTDelegate>()(mode, start, end, count, type, indices, basevertex);
		}
		
		public static void glDrawElementsInstancedBaseVertexEXT(uint mode, int count, uint type, nint indices, int instancecount, int basevertex)
		{
			Native.GetDelegateFor<glDrawElementsInstancedBaseVertexEXTDelegate>()(mode, count, type, indices, instancecount, basevertex);
		}
		
		public static void glMultiDrawElementsBaseVertexEXT(uint mode, int[] count, uint type, nint indices, int primcount, int[] basevertex)
		{
			Native.GetDelegateFor<glMultiDrawElementsBaseVertexEXTDelegate>()(mode, count, type, indices, primcount, basevertex);
		}
		
		public static void glDrawArraysInstancedEXT(uint mode, int start, int count, int primcount)
		{
			Native.GetDelegateFor<glDrawArraysInstancedEXTDelegate>()(mode, start, count, primcount);
		}
		
		public static void glDrawElementsInstancedEXT(uint mode, int count, uint type, nint indices, int primcount)
		{
			Native.GetDelegateFor<glDrawElementsInstancedEXTDelegate>()(mode, count, type, indices, primcount);
		}
		
		public static void glDrawRangeElementsEXT(uint mode, uint start, uint end, int count, uint type, nint indices)
		{
			Native.GetDelegateFor<glDrawRangeElementsEXTDelegate>()(mode, start, end, count, type, indices);
		}
		
		public static void glFogCoordfEXT(float coord)
		{
			Native.GetDelegateFor<glFogCoordfEXTDelegate>()(coord);
		}
		
		public static void glFogCoordfvEXT(float[] coord)
		{
			Native.GetDelegateFor<glFogCoordfvEXTDelegate>()(coord);
		}
		
		public static void glFogCoorddEXT(double coord)
		{
			Native.GetDelegateFor<glFogCoorddEXTDelegate>()(coord);
		}
		
		public static void glFogCoorddvEXT(double[] coord)
		{
			Native.GetDelegateFor<glFogCoorddvEXTDelegate>()(coord);
		}
		
		public static void glFogCoordPointerEXT(uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glFogCoordPointerEXTDelegate>()(type, stride, pointer);
		}
		
		public static void glBlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			Native.GetDelegateFor<glBlitFramebufferEXTDelegate>()(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		public static void glRenderbufferStorageMultisampleEXT(uint target, int samples, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glRenderbufferStorageMultisampleEXTDelegate>()(target, samples, internalformat, width, height);
		}
		
		public static bool glIsRenderbufferEXT(uint renderbuffer)
		{
			return (bool)Native.GetDelegateFor<glIsRenderbufferEXTDelegate>()(renderbuffer);
		}
		
		public static void glBindRenderbufferEXT(uint target, uint renderbuffer)
		{
			Native.GetDelegateFor<glBindRenderbufferEXTDelegate>()(target, renderbuffer);
		}
		
		public static void glDeleteRenderbuffersEXT(int n, uint[] renderbuffers)
		{
			Native.GetDelegateFor<glDeleteRenderbuffersEXTDelegate>()(n, renderbuffers);
		}
		
		public static void glGenRenderbuffersEXT(int n, uint[] renderbuffers)
		{
			Native.GetDelegateFor<glGenRenderbuffersEXTDelegate>()(n, renderbuffers);
		}
		
		public static void glRenderbufferStorageEXT(uint target, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glRenderbufferStorageEXTDelegate>()(target, internalformat, width, height);
		}
		
		public static void glGetRenderbufferParameterivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetRenderbufferParameterivEXTDelegate>()(target, pname, @params);
		}
		
		public static bool glIsFramebufferEXT(uint framebuffer)
		{
			return (bool)Native.GetDelegateFor<glIsFramebufferEXTDelegate>()(framebuffer);
		}
		
		public static void glBindFramebufferEXT(uint target, uint framebuffer)
		{
			Native.GetDelegateFor<glBindFramebufferEXTDelegate>()(target, framebuffer);
		}
		
		public static void glDeleteFramebuffersEXT(int n, uint[] framebuffers)
		{
			Native.GetDelegateFor<glDeleteFramebuffersEXTDelegate>()(n, framebuffers);
		}
		
		public static void glGenFramebuffersEXT(int n, uint[] framebuffers)
		{
			Native.GetDelegateFor<glGenFramebuffersEXTDelegate>()(n, framebuffers);
		}
		
		public static uint glCheckFramebufferStatusEXT(uint target)
		{
			return (uint)Native.GetDelegateFor<glCheckFramebufferStatusEXTDelegate>()(target);
		}
		
		public static void glFramebufferTexture1DEXT(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			Native.GetDelegateFor<glFramebufferTexture1DEXTDelegate>()(target, attachment, textarget, texture, level);
		}
		
		public static void glFramebufferTexture2DEXT(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			Native.GetDelegateFor<glFramebufferTexture2DEXTDelegate>()(target, attachment, textarget, texture, level);
		}
		
		public static void glFramebufferTexture3DEXT(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
			Native.GetDelegateFor<glFramebufferTexture3DEXTDelegate>()(target, attachment, textarget, texture, level, zoffset);
		}
		
		public static void glFramebufferRenderbufferEXT(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			Native.GetDelegateFor<glFramebufferRenderbufferEXTDelegate>()(target, attachment, renderbuffertarget, renderbuffer);
		}
		
		public static void glGetFramebufferAttachmentParameterivEXT(uint target, uint attachment, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetFramebufferAttachmentParameterivEXTDelegate>()(target, attachment, pname, @params);
		}
		
		public static void glGenerateMipmapEXT(uint target)
		{
			Native.GetDelegateFor<glGenerateMipmapEXTDelegate>()(target);
		}
		
		public static void glFramebufferTextureEXT(uint target, uint attachment, uint texture, int level)
		{
			Native.GetDelegateFor<glFramebufferTextureEXTDelegate>()(target, attachment, texture, level);
		}
		
		public static void glProgramParameteriEXT(uint program, uint pname, int value)
		{
			Native.GetDelegateFor<glProgramParameteriEXTDelegate>()(program, pname, value);
		}
		
		public static void glProgramEnvParameters4fvEXT(uint target, uint index, int count, float[] @params)
		{
			Native.GetDelegateFor<glProgramEnvParameters4fvEXTDelegate>()(target, index, count, @params);
		}
		
		public static void glProgramLocalParameters4fvEXT(uint target, uint index, int count, float[] @params)
		{
			Native.GetDelegateFor<glProgramLocalParameters4fvEXTDelegate>()(target, index, count, @params);
		}
		
		public static void glGetUniformuivEXT(uint program, int location, uint[] @params)
		{
			Native.GetDelegateFor<glGetUniformuivEXTDelegate>()(program, location, @params);
		}
		
		public static int glGetFragDataLocationEXT(uint program, char[] name)
		{
			return (int)Native.GetDelegateFor<glGetFragDataLocationEXTDelegate>()(program, name);
		}
		
		public static void glUniform1uiEXT(int location, uint v0)
		{
			Native.GetDelegateFor<glUniform1uiEXTDelegate>()(location, v0);
		}
		
		public static void glUniform2uiEXT(int location, uint v0, uint v1)
		{
			Native.GetDelegateFor<glUniform2uiEXTDelegate>()(location, v0, v1);
		}
		
		public static void glUniform3uiEXT(int location, uint v0, uint v1, uint v2)
		{
			Native.GetDelegateFor<glUniform3uiEXTDelegate>()(location, v0, v1, v2);
		}
		
		public static void glUniform4uiEXT(int location, uint v0, uint v1, uint v2, uint v3)
		{
			Native.GetDelegateFor<glUniform4uiEXTDelegate>()(location, v0, v1, v2, v3);
		}
		
		public static void glUniform1uivEXT(int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glUniform1uivEXTDelegate>()(location, count, value);
		}
		
		public static void glUniform2uivEXT(int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glUniform2uivEXTDelegate>()(location, count, value);
		}
		
		public static void glUniform3uivEXT(int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glUniform3uivEXTDelegate>()(location, count, value);
		}
		
		public static void glUniform4uivEXT(int location, int count, uint[] value)
		{
			Native.GetDelegateFor<glUniform4uivEXTDelegate>()(location, count, value);
		}
		
		public static void glGetHistogramEXT(uint target, bool reset, uint format, uint type, nint values)
		{
			Native.GetDelegateFor<glGetHistogramEXTDelegate>()(target, reset, format, type, values);
		}
		
		public static void glGetHistogramParameterfvEXT(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetHistogramParameterfvEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetHistogramParameterivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetHistogramParameterivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetMinmaxEXT(uint target, bool reset, uint format, uint type, nint values)
		{
			Native.GetDelegateFor<glGetMinmaxEXTDelegate>()(target, reset, format, type, values);
		}
		
		public static void glGetMinmaxParameterfvEXT(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetMinmaxParameterfvEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetMinmaxParameterivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetMinmaxParameterivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glHistogramEXT(uint target, int width, uint internalformat, bool sink)
		{
			Native.GetDelegateFor<glHistogramEXTDelegate>()(target, width, internalformat, sink);
		}
		
		public static void glMinmaxEXT(uint target, uint internalformat, bool sink)
		{
			Native.GetDelegateFor<glMinmaxEXTDelegate>()(target, internalformat, sink);
		}
		
		public static void glResetHistogramEXT(uint target)
		{
			Native.GetDelegateFor<glResetHistogramEXTDelegate>()(target);
		}
		
		public static void glResetMinmaxEXT(uint target)
		{
			Native.GetDelegateFor<glResetMinmaxEXTDelegate>()(target);
		}
		
		public static void glIndexFuncEXT(uint func, float @ref)
		{
			Native.GetDelegateFor<glIndexFuncEXTDelegate>()(func, @ref);
		}
		
		public static void glIndexMaterialEXT(uint face, uint mode)
		{
			Native.GetDelegateFor<glIndexMaterialEXTDelegate>()(face, mode);
		}
		
		public static void glVertexAttribDivisorEXT(uint index, uint divisor)
		{
			Native.GetDelegateFor<glVertexAttribDivisorEXTDelegate>()(index, divisor);
		}
		
		public static void glApplyTextureEXT(uint mode)
		{
			Native.GetDelegateFor<glApplyTextureEXTDelegate>()(mode);
		}
		
		public static void glTextureLightEXT(uint pname)
		{
			Native.GetDelegateFor<glTextureLightEXTDelegate>()(pname);
		}
		
		public static void glTextureMaterialEXT(uint face, uint mode)
		{
			Native.GetDelegateFor<glTextureMaterialEXTDelegate>()(face, mode);
		}
		
		public static void glMapBufferRangeEXT(uint target, nint offset, nint length, uint access)
		{
			Native.GetDelegateFor<glMapBufferRangeEXTDelegate>()(target, offset, length, access);
		}
		
		public static void glFlushMappedBufferRangeEXT(uint target, nint offset, nint length)
		{
			Native.GetDelegateFor<glFlushMappedBufferRangeEXTDelegate>()(target, offset, length);
		}
		
		public static void glMultiDrawArraysEXT(uint mode, int[] first, int[] count, int primcount)
		{
			Native.GetDelegateFor<glMultiDrawArraysEXTDelegate>()(mode, first, count, primcount);
		}
		
		public static void glMultiDrawElementsEXT(uint mode, int[] count, uint type, nint indices, int primcount)
		{
			Native.GetDelegateFor<glMultiDrawElementsEXTDelegate>()(mode, count, type, indices, primcount);
		}
		
		public static void glMultiDrawArraysIndirectEXT(uint mode, nint indirect, int drawcount, int stride)
		{
			Native.GetDelegateFor<glMultiDrawArraysIndirectEXTDelegate>()(mode, indirect, drawcount, stride);
		}
		
		public static void glMultiDrawElementsIndirectEXT(uint mode, uint type, nint indirect, int drawcount, int stride)
		{
			Native.GetDelegateFor<glMultiDrawElementsIndirectEXTDelegate>()(mode, type, indirect, drawcount, stride);
		}
		
		public static void glSampleMaskEXT(float value, bool invert)
		{
			Native.GetDelegateFor<glSampleMaskEXTDelegate>()(value, invert);
		}
		
		public static void glSamplePatternEXT(uint pattern)
		{
			Native.GetDelegateFor<glSamplePatternEXTDelegate>()(pattern);
		}
		
		public static void glFramebufferTexture2DMultisampleEXT(uint target, uint attachment, uint textarget, uint texture, int level, int samples)
		{
			Native.GetDelegateFor<glFramebufferTexture2DMultisampleEXTDelegate>()(target, attachment, textarget, texture, level, samples);
		}
		
		public static void glReadBufferIndexedEXT(uint src, int index)
		{
			Native.GetDelegateFor<glReadBufferIndexedEXTDelegate>()(src, index);
		}
		
		public static void glDrawBuffersIndexedEXT(int n, uint[] location, int[] indices)
		{
			Native.GetDelegateFor<glDrawBuffersIndexedEXTDelegate>()(n, location, indices);
		}
		
		public static void glGetIntegeri_vEXT(uint target, uint index, int[] data)
		{
			Native.GetDelegateFor<glGetIntegeri_vEXTDelegate>()(target, index, data);
		}
		
		public static void glColorTableEXT(uint target, uint internalFormat, int width, uint format, uint type, nint table)
		{
			Native.GetDelegateFor<glColorTableEXTDelegate>()(target, internalFormat, width, format, type, table);
		}
		
		public static void glGetColorTableEXT(uint target, uint format, uint type, nint data)
		{
			Native.GetDelegateFor<glGetColorTableEXTDelegate>()(target, format, type, data);
		}
		
		public static void glGetColorTableParameterivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetColorTableParameterivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetColorTableParameterfvEXT(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetColorTableParameterfvEXTDelegate>()(target, pname, @params);
		}
		
		public static void glPixelTransformParameteriEXT(uint target, uint pname, int param)
		{
			Native.GetDelegateFor<glPixelTransformParameteriEXTDelegate>()(target, pname, param);
		}
		
		public static void glPixelTransformParameterfEXT(uint target, uint pname, float param)
		{
			Native.GetDelegateFor<glPixelTransformParameterfEXTDelegate>()(target, pname, param);
		}
		
		public static void glPixelTransformParameterivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glPixelTransformParameterivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glPixelTransformParameterfvEXT(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glPixelTransformParameterfvEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetPixelTransformParameterivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetPixelTransformParameterivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetPixelTransformParameterfvEXT(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetPixelTransformParameterfvEXTDelegate>()(target, pname, @params);
		}
		
		public static void glPointParameterfEXT(uint pname, float param)
		{
			Native.GetDelegateFor<glPointParameterfEXTDelegate>()(pname, param);
		}
		
		public static void glPointParameterfvEXT(uint pname, float[] @params)
		{
			Native.GetDelegateFor<glPointParameterfvEXTDelegate>()(pname, @params);
		}
		
		public static void glPolygonOffsetEXT(float factor, float bias)
		{
			Native.GetDelegateFor<glPolygonOffsetEXTDelegate>()(factor, bias);
		}
		
		public static void glPolygonOffsetClampEXT(float factor, float units, float clamp)
		{
			Native.GetDelegateFor<glPolygonOffsetClampEXTDelegate>()(factor, units, clamp);
		}
		
		public static void glPrimitiveBoundingBoxEXT(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
		{
			Native.GetDelegateFor<glPrimitiveBoundingBoxEXTDelegate>()(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
		}
		
		public static void glProvokingVertexEXT(uint mode)
		{
			Native.GetDelegateFor<glProvokingVertexEXTDelegate>()(mode);
		}
		
		public static void glRasterSamplesEXT(uint samples, bool fixedsamplelocations)
		{
			Native.GetDelegateFor<glRasterSamplesEXTDelegate>()(samples, fixedsamplelocations);
		}
		
		public static uint glGetGraphicsResetStatusEXT()
		{
			return (uint)Native.GetDelegateFor<glGetGraphicsResetStatusEXTDelegate>()();
		}
		
		public static void glReadnPixelsEXT(int x, int y, int width, int height, uint format, uint type, int bufSize, nint data)
		{
			Native.GetDelegateFor<glReadnPixelsEXTDelegate>()(x, y, width, height, format, type, bufSize, data);
		}
		
		public static void glGetnUniformfvEXT(uint program, int location, int bufSize, float[] @params)
		{
			Native.GetDelegateFor<glGetnUniformfvEXTDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformivEXT(uint program, int location, int bufSize, int[] @params)
		{
			Native.GetDelegateFor<glGetnUniformivEXTDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glSecondaryColor3bEXT(byte red, byte green, byte blue)
		{
			Native.GetDelegateFor<glSecondaryColor3bEXTDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3bvEXT(byte[] v)
		{
			Native.GetDelegateFor<glSecondaryColor3bvEXTDelegate>()(v);
		}
		
		public static void glSecondaryColor3dEXT(double red, double green, double blue)
		{
			Native.GetDelegateFor<glSecondaryColor3dEXTDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3dvEXT(double[] v)
		{
			Native.GetDelegateFor<glSecondaryColor3dvEXTDelegate>()(v);
		}
		
		public static void glSecondaryColor3fEXT(float red, float green, float blue)
		{
			Native.GetDelegateFor<glSecondaryColor3fEXTDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3fvEXT(float[] v)
		{
			Native.GetDelegateFor<glSecondaryColor3fvEXTDelegate>()(v);
		}
		
		public static void glSecondaryColor3iEXT(int red, int green, int blue)
		{
			Native.GetDelegateFor<glSecondaryColor3iEXTDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3ivEXT(int[] v)
		{
			Native.GetDelegateFor<glSecondaryColor3ivEXTDelegate>()(v);
		}
		
		public static void glSecondaryColor3sEXT(short red, short green, short blue)
		{
			Native.GetDelegateFor<glSecondaryColor3sEXTDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3svEXT(short[] v)
		{
			Native.GetDelegateFor<glSecondaryColor3svEXTDelegate>()(v);
		}
		
		public static void glSecondaryColor3ubEXT(byte red, byte green, byte blue)
		{
			Native.GetDelegateFor<glSecondaryColor3ubEXTDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3ubvEXT(byte[] v)
		{
			Native.GetDelegateFor<glSecondaryColor3ubvEXTDelegate>()(v);
		}
		
		public static void glSecondaryColor3uiEXT(uint red, uint green, uint blue)
		{
			Native.GetDelegateFor<glSecondaryColor3uiEXTDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3uivEXT(uint[] v)
		{
			Native.GetDelegateFor<glSecondaryColor3uivEXTDelegate>()(v);
		}
		
		public static void glSecondaryColor3usEXT(ushort red, ushort green, ushort blue)
		{
			Native.GetDelegateFor<glSecondaryColor3usEXTDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3usvEXT(ushort[] v)
		{
			Native.GetDelegateFor<glSecondaryColor3usvEXTDelegate>()(v);
		}
		
		public static void glSecondaryColorPointerEXT(int size, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glSecondaryColorPointerEXTDelegate>()(size, type, stride, pointer);
		}
		
		public static void glUseShaderProgramEXT(uint type, uint program)
		{
			Native.GetDelegateFor<glUseShaderProgramEXTDelegate>()(type, program);
		}
		
		public static void glActiveProgramEXT(uint program)
		{
			Native.GetDelegateFor<glActiveProgramEXTDelegate>()(program);
		}
		
		public static uint glCreateShaderProgramEXT(uint type, char[] @string)
		{
			return (uint)Native.GetDelegateFor<glCreateShaderProgramEXTDelegate>()(type, @string);
		}
		
		public static void glActiveShaderProgramEXT(uint pipeline, uint program)
		{
			Native.GetDelegateFor<glActiveShaderProgramEXTDelegate>()(pipeline, program);
		}
		
		public static void glBindProgramPipelineEXT(uint pipeline)
		{
			Native.GetDelegateFor<glBindProgramPipelineEXTDelegate>()(pipeline);
		}
		
		public static uint glCreateShaderProgramvEXT(uint type, int count, char[] strings)
		{
			return (uint)Native.GetDelegateFor<glCreateShaderProgramvEXTDelegate>()(type, count, strings);
		}
		
		public static void glDeleteProgramPipelinesEXT(int n, uint[] pipelines)
		{
			Native.GetDelegateFor<glDeleteProgramPipelinesEXTDelegate>()(n, pipelines);
		}
		
		public static void glGenProgramPipelinesEXT(int n, uint[] pipelines)
		{
			Native.GetDelegateFor<glGenProgramPipelinesEXTDelegate>()(n, pipelines);
		}
		
		public static void glGetProgramPipelineInfoLogEXT(uint pipeline, int bufSize, int[] length, char[] infoLog)
		{
			Native.GetDelegateFor<glGetProgramPipelineInfoLogEXTDelegate>()(pipeline, bufSize, length, infoLog);
		}
		
		public static void glGetProgramPipelineivEXT(uint pipeline, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetProgramPipelineivEXTDelegate>()(pipeline, pname, @params);
		}
		
		public static bool glIsProgramPipelineEXT(uint pipeline)
		{
			return (bool)Native.GetDelegateFor<glIsProgramPipelineEXTDelegate>()(pipeline);
		}
		
		public static void glUseProgramStagesEXT(uint pipeline, uint stages, uint program)
		{
			Native.GetDelegateFor<glUseProgramStagesEXTDelegate>()(pipeline, stages, program);
		}
		
		public static void glValidateProgramPipelineEXT(uint pipeline)
		{
			Native.GetDelegateFor<glValidateProgramPipelineEXTDelegate>()(pipeline);
		}
		
		public static void glBindImageTextureEXT(uint index, uint texture, int level, bool layered, int layer, uint access, int format)
		{
			Native.GetDelegateFor<glBindImageTextureEXTDelegate>()(index, texture, level, layered, layer, access, format);
		}
		
		public static void glMemoryBarrierEXT(uint barriers)
		{
			Native.GetDelegateFor<glMemoryBarrierEXTDelegate>()(barriers);
		}
		
		public static void glFramebufferPixelLocalStorageSizeEXT(uint target, int size)
		{
			Native.GetDelegateFor<glFramebufferPixelLocalStorageSizeEXTDelegate>()(target, size);
		}
		
		public static int glGetFramebufferPixelLocalStorageSizeEXT(uint target)
		{
			return (int)Native.GetDelegateFor<glGetFramebufferPixelLocalStorageSizeEXTDelegate>()(target);
		}
		
		public static void glClearPixelLocalStorageuiEXT(int offset, int n, uint[] values)
		{
			Native.GetDelegateFor<glClearPixelLocalStorageuiEXTDelegate>()(offset, n, values);
		}
		
		public static void glTexPageCommitmentEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit)
		{
			Native.GetDelegateFor<glTexPageCommitmentEXTDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, commit);
		}
		
		public static void glStencilClearTagEXT(int stencilTagBits, uint stencilClearTag)
		{
			Native.GetDelegateFor<glStencilClearTagEXTDelegate>()(stencilTagBits, stencilClearTag);
		}
		
		public static void glActiveStencilFaceEXT(uint face)
		{
			Native.GetDelegateFor<glActiveStencilFaceEXTDelegate>()(face);
		}
		
		public static void glTexSubImage1DEXT(uint target, int level, int xoffset, int width, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTexSubImage1DEXTDelegate>()(target, level, xoffset, width, format, type, pixels);
		}
		
		public static void glTexSubImage2DEXT(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTexSubImage2DEXTDelegate>()(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		
		public static void glPatchParameteriEXT(uint pname, int value)
		{
			Native.GetDelegateFor<glPatchParameteriEXTDelegate>()(pname, value);
		}
		
		public static void glTexImage3DEXT(uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTexImage3DEXTDelegate>()(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		
		public static void glTexSubImage3DEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTexSubImage3DEXTDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		public static void glFramebufferTextureLayerEXT(uint target, uint attachment, uint texture, int level, int layer)
		{
			Native.GetDelegateFor<glFramebufferTextureLayerEXTDelegate>()(target, attachment, texture, level, layer);
		}
		
		public static void glTexParameterIivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glTexParameterIivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glTexParameterIuivEXT(uint target, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glTexParameterIuivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetTexParameterIivEXT(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetTexParameterIivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glGetTexParameterIuivEXT(uint target, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetTexParameterIuivEXTDelegate>()(target, pname, @params);
		}
		
		public static void glSamplerParameterIivEXT(uint sampler, uint pname, int[] param)
		{
			Native.GetDelegateFor<glSamplerParameterIivEXTDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterIuivEXT(uint sampler, uint pname, uint[] param)
		{
			Native.GetDelegateFor<glSamplerParameterIuivEXTDelegate>()(sampler, pname, param);
		}
		
		public static void glGetSamplerParameterIivEXT(uint sampler, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetSamplerParameterIivEXTDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterIuivEXT(uint sampler, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetSamplerParameterIuivEXTDelegate>()(sampler, pname, @params);
		}
		
		public static void glTexBufferEXT(uint target, uint internalformat, uint buffer)
		{
			Native.GetDelegateFor<glTexBufferEXTDelegate>()(target, internalformat, buffer);
		}
		
		public static void glTexBufferRangeEXT(uint target, uint internalformat, uint buffer, nint offset, nint size)
		{
			Native.GetDelegateFor<glTexBufferRangeEXTDelegate>()(target, internalformat, buffer, offset, size);
		}
		
		public static void glClearColorIiEXT(int red, int green, int blue, int alpha)
		{
			Native.GetDelegateFor<glClearColorIiEXTDelegate>()(red, green, blue, alpha);
		}
		
		public static void glClearColorIuiEXT(uint red, uint green, uint blue, uint alpha)
		{
			Native.GetDelegateFor<glClearColorIuiEXTDelegate>()(red, green, blue, alpha);
		}
		
		public static bool glAreTexturesResidentEXT(int n, uint[] textures, bool[] residences)
		{
			return (bool)Native.GetDelegateFor<glAreTexturesResidentEXTDelegate>()(n, textures, residences);
		}
		
		public static void glBindTextureEXT(uint target, uint texture)
		{
			Native.GetDelegateFor<glBindTextureEXTDelegate>()(target, texture);
		}
		
		public static void glDeleteTexturesEXT(int n, uint[] textures)
		{
			Native.GetDelegateFor<glDeleteTexturesEXTDelegate>()(n, textures);
		}
		
		public static void glGenTexturesEXT(int n, uint[] textures)
		{
			Native.GetDelegateFor<glGenTexturesEXTDelegate>()(n, textures);
		}
		
		public static bool glIsTextureEXT(uint texture)
		{
			return (bool)Native.GetDelegateFor<glIsTextureEXTDelegate>()(texture);
		}
		
		public static void glPrioritizeTexturesEXT(int n, uint[] textures, float[] priorities)
		{
			Native.GetDelegateFor<glPrioritizeTexturesEXTDelegate>()(n, textures, priorities);
		}
		
		public static void glTextureNormalEXT(uint mode)
		{
			Native.GetDelegateFor<glTextureNormalEXTDelegate>()(mode);
		}
		
		public static void glTexStorage1DEXT(uint target, int levels, uint internalformat, int width)
		{
			Native.GetDelegateFor<glTexStorage1DEXTDelegate>()(target, levels, internalformat, width);
		}
		
		public static void glTexStorage2DEXT(uint target, int levels, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glTexStorage2DEXTDelegate>()(target, levels, internalformat, width, height);
		}
		
		public static void glTexStorage3DEXT(uint target, int levels, uint internalformat, int width, int height, int depth)
		{
			Native.GetDelegateFor<glTexStorage3DEXTDelegate>()(target, levels, internalformat, width, height, depth);
		}
		
		public static void glTextureViewEXT(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			Native.GetDelegateFor<glTextureViewEXTDelegate>()(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}
		
		public static void glBeginTransformFeedbackEXT(uint primitiveMode)
		{
			Native.GetDelegateFor<glBeginTransformFeedbackEXTDelegate>()(primitiveMode);
		}
		
		public static void glEndTransformFeedbackEXT()
		{
			Native.GetDelegateFor<glEndTransformFeedbackEXTDelegate>()();
		}
		
		public static void glBindBufferRangeEXT(uint target, uint index, uint buffer, nint offset, nint size)
		{
			Native.GetDelegateFor<glBindBufferRangeEXTDelegate>()(target, index, buffer, offset, size);
		}
		
		public static void glBindBufferOffsetEXT(uint target, uint index, uint buffer, nint offset)
		{
			Native.GetDelegateFor<glBindBufferOffsetEXTDelegate>()(target, index, buffer, offset);
		}
		
		public static void glBindBufferBaseEXT(uint target, uint index, uint buffer)
		{
			Native.GetDelegateFor<glBindBufferBaseEXTDelegate>()(target, index, buffer);
		}
		
		public static void glTransformFeedbackVaryingsEXT(uint program, int count, char[] varyings, uint bufferMode)
		{
			Native.GetDelegateFor<glTransformFeedbackVaryingsEXTDelegate>()(program, count, varyings, bufferMode);
		}
		
		public static void glGetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, char[] name)
		{
			Native.GetDelegateFor<glGetTransformFeedbackVaryingEXTDelegate>()(program, index, bufSize, length, size, type, name);
		}
		
		public static void glArrayElementEXT(int i)
		{
			Native.GetDelegateFor<glArrayElementEXTDelegate>()(i);
		}
		
		public static void glColorPointerEXT(int size, uint type, int stride, int count, nint pointer)
		{
			Native.GetDelegateFor<glColorPointerEXTDelegate>()(size, type, stride, count, pointer);
		}
		
		public static void glDrawArraysEXT(uint mode, int first, int count)
		{
			Native.GetDelegateFor<glDrawArraysEXTDelegate>()(mode, first, count);
		}
		
		public static void glEdgeFlagPointerEXT(int stride, int count, bool[] pointer)
		{
			Native.GetDelegateFor<glEdgeFlagPointerEXTDelegate>()(stride, count, pointer);
		}
		
		public static void glGetPointervEXT(uint pname, nint @params)
		{
			Native.GetDelegateFor<glGetPointervEXTDelegate>()(pname, @params);
		}
		
		public static void glIndexPointerEXT(uint type, int stride, int count, nint pointer)
		{
			Native.GetDelegateFor<glIndexPointerEXTDelegate>()(type, stride, count, pointer);
		}
		
		public static void glNormalPointerEXT(uint type, int stride, int count, nint pointer)
		{
			Native.GetDelegateFor<glNormalPointerEXTDelegate>()(type, stride, count, pointer);
		}
		
		public static void glTexCoordPointerEXT(int size, uint type, int stride, int count, nint pointer)
		{
			Native.GetDelegateFor<glTexCoordPointerEXTDelegate>()(size, type, stride, count, pointer);
		}
		
		public static void glVertexPointerEXT(int size, uint type, int stride, int count, nint pointer)
		{
			Native.GetDelegateFor<glVertexPointerEXTDelegate>()(size, type, stride, count, pointer);
		}
		
		public static void glVertexAttribL1dEXT(uint index, double x)
		{
			Native.GetDelegateFor<glVertexAttribL1dEXTDelegate>()(index, x);
		}
		
		public static void glVertexAttribL2dEXT(uint index, double x, double y)
		{
			Native.GetDelegateFor<glVertexAttribL2dEXTDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribL3dEXT(uint index, double x, double y, double z)
		{
			Native.GetDelegateFor<glVertexAttribL3dEXTDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribL4dEXT(uint index, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glVertexAttribL4dEXTDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribL1dvEXT(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribL1dvEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribL2dvEXT(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribL2dvEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribL3dvEXT(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribL3dvEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribL4dvEXT(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribL4dvEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribLPointerEXT(uint index, int size, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glVertexAttribLPointerEXTDelegate>()(index, size, type, stride, pointer);
		}
		
		public static void glGetVertexAttribLdvEXT(uint index, uint pname, double[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribLdvEXTDelegate>()(index, pname, @params);
		}
		
		public static void glBeginVertexShaderEXT()
		{
			Native.GetDelegateFor<glBeginVertexShaderEXTDelegate>()();
		}
		
		public static void glEndVertexShaderEXT()
		{
			Native.GetDelegateFor<glEndVertexShaderEXTDelegate>()();
		}
		
		public static void glBindVertexShaderEXT(uint id)
		{
			Native.GetDelegateFor<glBindVertexShaderEXTDelegate>()(id);
		}
		
		public static uint glGenVertexShadersEXT(uint range)
		{
			return (uint)Native.GetDelegateFor<glGenVertexShadersEXTDelegate>()(range);
		}
		
		public static void glDeleteVertexShaderEXT(uint id)
		{
			Native.GetDelegateFor<glDeleteVertexShaderEXTDelegate>()(id);
		}
		
		public static void glShaderOp1EXT(uint op, uint res, uint arg1)
		{
			Native.GetDelegateFor<glShaderOp1EXTDelegate>()(op, res, arg1);
		}
		
		public static void glShaderOp2EXT(uint op, uint res, uint arg1, uint arg2)
		{
			Native.GetDelegateFor<glShaderOp2EXTDelegate>()(op, res, arg1, arg2);
		}
		
		public static void glShaderOp3EXT(uint op, uint res, uint arg1, uint arg2, uint arg3)
		{
			Native.GetDelegateFor<glShaderOp3EXTDelegate>()(op, res, arg1, arg2, arg3);
		}
		
		public static void glSwizzleEXT(uint res, uint @in, uint outX, uint outY, uint outZ, uint outW)
		{
			Native.GetDelegateFor<glSwizzleEXTDelegate>()(res, @in, outX, outY, outZ, outW);
		}
		
		public static void glWriteMaskEXT(uint res, uint @in, uint outX, uint outY, uint outZ, uint outW)
		{
			Native.GetDelegateFor<glWriteMaskEXTDelegate>()(res, @in, outX, outY, outZ, outW);
		}
		
		public static void glInsertComponentEXT(uint res, uint src, uint num)
		{
			Native.GetDelegateFor<glInsertComponentEXTDelegate>()(res, src, num);
		}
		
		public static void glExtractComponentEXT(uint res, uint src, uint num)
		{
			Native.GetDelegateFor<glExtractComponentEXTDelegate>()(res, src, num);
		}
		
		public static uint glGenSymbolsEXT(uint datatype, uint storagetype, uint range, uint components)
		{
			return (uint)Native.GetDelegateFor<glGenSymbolsEXTDelegate>()(datatype, storagetype, range, components);
		}
		
		public static void glSetInvariantEXT(uint id, uint type, nint addr)
		{
			Native.GetDelegateFor<glSetInvariantEXTDelegate>()(id, type, addr);
		}
		
		public static void glSetLocalConstantEXT(uint id, uint type, nint addr)
		{
			Native.GetDelegateFor<glSetLocalConstantEXTDelegate>()(id, type, addr);
		}
		
		public static void glVariantbvEXT(uint id, byte[] addr)
		{
			Native.GetDelegateFor<glVariantbvEXTDelegate>()(id, addr);
		}
		
		public static void glVariantsvEXT(uint id, short[] addr)
		{
			Native.GetDelegateFor<glVariantsvEXTDelegate>()(id, addr);
		}
		
		public static void glVariantivEXT(uint id, int[] addr)
		{
			Native.GetDelegateFor<glVariantivEXTDelegate>()(id, addr);
		}
		
		public static void glVariantfvEXT(uint id, float[] addr)
		{
			Native.GetDelegateFor<glVariantfvEXTDelegate>()(id, addr);
		}
		
		public static void glVariantdvEXT(uint id, double[] addr)
		{
			Native.GetDelegateFor<glVariantdvEXTDelegate>()(id, addr);
		}
		
		public static void glVariantubvEXT(uint id, byte[] addr)
		{
			Native.GetDelegateFor<glVariantubvEXTDelegate>()(id, addr);
		}
		
		public static void glVariantusvEXT(uint id, ushort[] addr)
		{
			Native.GetDelegateFor<glVariantusvEXTDelegate>()(id, addr);
		}
		
		public static void glVariantuivEXT(uint id, uint[] addr)
		{
			Native.GetDelegateFor<glVariantuivEXTDelegate>()(id, addr);
		}
		
		public static void glVariantPointerEXT(uint id, uint type, uint stride, nint addr)
		{
			Native.GetDelegateFor<glVariantPointerEXTDelegate>()(id, type, stride, addr);
		}
		
		public static void glEnableVariantClientStateEXT(uint id)
		{
			Native.GetDelegateFor<glEnableVariantClientStateEXTDelegate>()(id);
		}
		
		public static void glDisableVariantClientStateEXT(uint id)
		{
			Native.GetDelegateFor<glDisableVariantClientStateEXTDelegate>()(id);
		}
		
		public static uint glBindLightParameterEXT(uint light, uint value)
		{
			return (uint)Native.GetDelegateFor<glBindLightParameterEXTDelegate>()(light, value);
		}
		
		public static uint glBindMaterialParameterEXT(uint face, uint value)
		{
			return (uint)Native.GetDelegateFor<glBindMaterialParameterEXTDelegate>()(face, value);
		}
		
		public static uint glBindTexGenParameterEXT(uint unit, uint coord, uint value)
		{
			return (uint)Native.GetDelegateFor<glBindTexGenParameterEXTDelegate>()(unit, coord, value);
		}
		
		public static uint glBindTextureUnitParameterEXT(uint unit, uint value)
		{
			return (uint)Native.GetDelegateFor<glBindTextureUnitParameterEXTDelegate>()(unit, value);
		}
		
		public static uint glBindParameterEXT(uint value)
		{
			return (uint)Native.GetDelegateFor<glBindParameterEXTDelegate>()(value);
		}
		
		public static bool glIsVariantEnabledEXT(uint id, uint cap)
		{
			return (bool)Native.GetDelegateFor<glIsVariantEnabledEXTDelegate>()(id, cap);
		}
		
		public static void glGetVariantBooleanvEXT(uint id, uint value, bool[] data)
		{
			Native.GetDelegateFor<glGetVariantBooleanvEXTDelegate>()(id, value, data);
		}
		
		public static void glGetVariantIntegervEXT(uint id, uint value, int[] data)
		{
			Native.GetDelegateFor<glGetVariantIntegervEXTDelegate>()(id, value, data);
		}
		
		public static void glGetVariantFloatvEXT(uint id, uint value, float[] data)
		{
			Native.GetDelegateFor<glGetVariantFloatvEXTDelegate>()(id, value, data);
		}
		
		public static void glGetVariantPointervEXT(uint id, uint value, nint data)
		{
			Native.GetDelegateFor<glGetVariantPointervEXTDelegate>()(id, value, data);
		}
		
		public static void glGetInvariantBooleanvEXT(uint id, uint value, bool[] data)
		{
			Native.GetDelegateFor<glGetInvariantBooleanvEXTDelegate>()(id, value, data);
		}
		
		public static void glGetInvariantIntegervEXT(uint id, uint value, int[] data)
		{
			Native.GetDelegateFor<glGetInvariantIntegervEXTDelegate>()(id, value, data);
		}
		
		public static void glGetInvariantFloatvEXT(uint id, uint value, float[] data)
		{
			Native.GetDelegateFor<glGetInvariantFloatvEXTDelegate>()(id, value, data);
		}
		
		public static void glGetLocalConstantBooleanvEXT(uint id, uint value, bool[] data)
		{
			Native.GetDelegateFor<glGetLocalConstantBooleanvEXTDelegate>()(id, value, data);
		}
		
		public static void glGetLocalConstantIntegervEXT(uint id, uint value, int[] data)
		{
			Native.GetDelegateFor<glGetLocalConstantIntegervEXTDelegate>()(id, value, data);
		}
		
		public static void glGetLocalConstantFloatvEXT(uint id, uint value, float[] data)
		{
			Native.GetDelegateFor<glGetLocalConstantFloatvEXTDelegate>()(id, value, data);
		}
		
		public static void glVertexWeightfEXT(float weight)
		{
			Native.GetDelegateFor<glVertexWeightfEXTDelegate>()(weight);
		}
		
		public static void glVertexWeightfvEXT(float[] weight)
		{
			Native.GetDelegateFor<glVertexWeightfvEXTDelegate>()(weight);
		}
		
		public static void glVertexWeightPointerEXT(int size, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glVertexWeightPointerEXTDelegate>()(size, type, stride, pointer);
		}
		
		public static nint glImportSyncEXT(uint external_sync_type, nint external_sync, uint flags)
		{
			return (nint)Native.GetDelegateFor<glImportSyncEXTDelegate>()(external_sync_type, external_sync, flags);
		}
		
		public static void glFrameTerminatorGREMEDY()
		{
			Native.GetDelegateFor<glFrameTerminatorGREMEDYDelegate>()();
		}
		
		public static void glStringMarkerGREMEDY(int len, nint @string)
		{
			Native.GetDelegateFor<glStringMarkerGREMEDYDelegate>()(len, @string);
		}
		
		public static void glImageTransformParameteriHP(uint target, uint pname, int param)
		{
			Native.GetDelegateFor<glImageTransformParameteriHPDelegate>()(target, pname, param);
		}
		
		public static void glImageTransformParameterfHP(uint target, uint pname, float param)
		{
			Native.GetDelegateFor<glImageTransformParameterfHPDelegate>()(target, pname, param);
		}
		
		public static void glImageTransformParameterivHP(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glImageTransformParameterivHPDelegate>()(target, pname, @params);
		}
		
		public static void glImageTransformParameterfvHP(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glImageTransformParameterfvHPDelegate>()(target, pname, @params);
		}
		
		public static void glGetImageTransformParameterivHP(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetImageTransformParameterivHPDelegate>()(target, pname, @params);
		}
		
		public static void glGetImageTransformParameterfvHP(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetImageTransformParameterfvHPDelegate>()(target, pname, @params);
		}
		
		public static void glMultiModeDrawArraysIBM(uint[] mode, int[] first, int[] count, int primcount, int modestride)
		{
			Native.GetDelegateFor<glMultiModeDrawArraysIBMDelegate>()(mode, first, count, primcount, modestride);
		}
		
		public static void glMultiModeDrawElementsIBM(uint[] mode, int[] count, uint type, nint indices, int primcount, int modestride)
		{
			Native.GetDelegateFor<glMultiModeDrawElementsIBMDelegate>()(mode, count, type, indices, primcount, modestride);
		}
		
		public static void glFlushStaticDataIBM(uint target)
		{
			Native.GetDelegateFor<glFlushStaticDataIBMDelegate>()(target);
		}
		
		public static void glColorPointerListIBM(int size, uint type, int stride, nint pointer, int ptrstride)
		{
			Native.GetDelegateFor<glColorPointerListIBMDelegate>()(size, type, stride, pointer, ptrstride);
		}
		
		public static void glSecondaryColorPointerListIBM(int size, uint type, int stride, nint pointer, int ptrstride)
		{
			Native.GetDelegateFor<glSecondaryColorPointerListIBMDelegate>()(size, type, stride, pointer, ptrstride);
		}
		
		public static void glEdgeFlagPointerListIBM(int stride, bool[] pointer, int ptrstride)
		{
			Native.GetDelegateFor<glEdgeFlagPointerListIBMDelegate>()(stride, pointer, ptrstride);
		}
		
		public static void glFogCoordPointerListIBM(uint type, int stride, nint pointer, int ptrstride)
		{
			Native.GetDelegateFor<glFogCoordPointerListIBMDelegate>()(type, stride, pointer, ptrstride);
		}
		
		public static void glIndexPointerListIBM(uint type, int stride, nint pointer, int ptrstride)
		{
			Native.GetDelegateFor<glIndexPointerListIBMDelegate>()(type, stride, pointer, ptrstride);
		}
		
		public static void glNormalPointerListIBM(uint type, int stride, nint pointer, int ptrstride)
		{
			Native.GetDelegateFor<glNormalPointerListIBMDelegate>()(type, stride, pointer, ptrstride);
		}
		
		public static void glTexCoordPointerListIBM(int size, uint type, int stride, nint pointer, int ptrstride)
		{
			Native.GetDelegateFor<glTexCoordPointerListIBMDelegate>()(size, type, stride, pointer, ptrstride);
		}
		
		public static void glVertexPointerListIBM(int size, uint type, int stride, nint pointer, int ptrstride)
		{
			Native.GetDelegateFor<glVertexPointerListIBMDelegate>()(size, type, stride, pointer, ptrstride);
		}
		
		public static void glFramebufferTexture2DDownsampleIMG(uint target, uint attachment, uint textarget, uint texture, int level, int xscale, int yscale)
		{
			Native.GetDelegateFor<glFramebufferTexture2DDownsampleIMGDelegate>()(target, attachment, textarget, texture, level, xscale, yscale);
		}
		
		public static void glFramebufferTextureLayerDownsampleIMG(uint target, uint attachment, uint texture, int level, int layer, int xscale, int yscale)
		{
			Native.GetDelegateFor<glFramebufferTextureLayerDownsampleIMGDelegate>()(target, attachment, texture, level, layer, xscale, yscale);
		}
		
		public static void glRenderbufferStorageMultisampleIMG(uint target, int samples, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glRenderbufferStorageMultisampleIMGDelegate>()(target, samples, internalformat, width, height);
		}
		
		public static void glFramebufferTexture2DMultisampleIMG(uint target, uint attachment, uint textarget, uint texture, int level, int samples)
		{
			Native.GetDelegateFor<glFramebufferTexture2DMultisampleIMGDelegate>()(target, attachment, textarget, texture, level, samples);
		}
		
		public static void glClipPlanefIMG(uint p, float[] eqn)
		{
			Native.GetDelegateFor<glClipPlanefIMGDelegate>()(p, eqn);
		}
		
		public static void glClipPlanexIMG(uint p, Int32[] eqn)
		{
			Native.GetDelegateFor<glClipPlanexIMGDelegate>()(p, eqn);
		}
		
		public static void glBlendFuncSeparateINGR(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
			Native.GetDelegateFor<glBlendFuncSeparateINGRDelegate>()(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}
		
		public static void glApplyFramebufferAttachmentCMAAINTEL()
		{
			Native.GetDelegateFor<glApplyFramebufferAttachmentCMAAINTELDelegate>()();
		}
		
		public static void glSyncTextureINTEL(uint texture)
		{
			Native.GetDelegateFor<glSyncTextureINTELDelegate>()(texture);
		}
		
		public static void glUnmapTexture2DINTEL(uint texture, int level)
		{
			Native.GetDelegateFor<glUnmapTexture2DINTELDelegate>()(texture, level);
		}
		
		public static void glMapTexture2DINTEL(uint texture, int level, uint access, int[] stride, uint[] layout)
		{
			Native.GetDelegateFor<glMapTexture2DINTELDelegate>()(texture, level, access, stride, layout);
		}
		
		public static void glVertexPointervINTEL(int size, uint type, nint pointer)
		{
			Native.GetDelegateFor<glVertexPointervINTELDelegate>()(size, type, pointer);
		}
		
		public static void glNormalPointervINTEL(uint type, nint pointer)
		{
			Native.GetDelegateFor<glNormalPointervINTELDelegate>()(type, pointer);
		}
		
		public static void glColorPointervINTEL(int size, uint type, nint pointer)
		{
			Native.GetDelegateFor<glColorPointervINTELDelegate>()(size, type, pointer);
		}
		
		public static void glTexCoordPointervINTEL(int size, uint type, nint pointer)
		{
			Native.GetDelegateFor<glTexCoordPointervINTELDelegate>()(size, type, pointer);
		}
		
		public static void glBeginPerfQueryINTEL(uint queryHandle)
		{
			Native.GetDelegateFor<glBeginPerfQueryINTELDelegate>()(queryHandle);
		}
		
		public static void glCreatePerfQueryINTEL(uint queryId, uint[] queryHandle)
		{
			Native.GetDelegateFor<glCreatePerfQueryINTELDelegate>()(queryId, queryHandle);
		}
		
		public static void glDeletePerfQueryINTEL(uint queryHandle)
		{
			Native.GetDelegateFor<glDeletePerfQueryINTELDelegate>()(queryHandle);
		}
		
		public static void glEndPerfQueryINTEL(uint queryHandle)
		{
			Native.GetDelegateFor<glEndPerfQueryINTELDelegate>()(queryHandle);
		}
		
		public static void glGetFirstPerfQueryIdINTEL(uint[] queryId)
		{
			Native.GetDelegateFor<glGetFirstPerfQueryIdINTELDelegate>()(queryId);
		}
		
		public static void glGetNextPerfQueryIdINTEL(uint queryId, uint[] nextQueryId)
		{
			Native.GetDelegateFor<glGetNextPerfQueryIdINTELDelegate>()(queryId, nextQueryId);
		}
		
		public static void glGetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, char[] counterName, uint counterDescLength, char[] counterDesc, uint[] counterOffset, uint[] counterDataSize, uint[] counterTypeEnum, uint[] counterDataTypeEnum, UInt64[] rawCounterMaxValue)
		{
			Native.GetDelegateFor<glGetPerfCounterInfoINTELDelegate>()(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
		}
		
		public static void glGetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, nint data, uint[] bytesWritten)
		{
			Native.GetDelegateFor<glGetPerfQueryDataINTELDelegate>()(queryHandle, flags, dataSize, data, bytesWritten);
		}
		
		public static void glGetPerfQueryIdByNameINTEL(char[] queryName, uint[] queryId)
		{
			Native.GetDelegateFor<glGetPerfQueryIdByNameINTELDelegate>()(queryName, queryId);
		}
		
		public static void glGetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, char[] queryName, uint[] dataSize, uint[] noCounters, uint[] noInstances, uint[] capsMask)
		{
			Native.GetDelegateFor<glGetPerfQueryInfoINTELDelegate>()(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask);
		}
		
		public static void glBlendBarrierKHR()
		{
			Native.GetDelegateFor<glBlendBarrierKHRDelegate>()();
		}
		
		public static void glDebugMessageControl(uint source, uint type, uint severity, int count, uint[] ids, bool enabled)
		{
			Native.GetDelegateFor<glDebugMessageControlDelegate>()(source, type, severity, count, ids, enabled);
		}
		
		public static void glDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, char[] buf)
		{
			Native.GetDelegateFor<glDebugMessageInsertDelegate>()(source, type, id, severity, length, buf);
		}
		
		public static void glDebugMessageCallback(nint callback, nint userParam)
		{
			Native.GetDelegateFor<glDebugMessageCallbackDelegate>()(callback, userParam);
		}
		
		public static uint glGetDebugMessageLog(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, char[] messageLog)
		{
			return (uint)Native.GetDelegateFor<glGetDebugMessageLogDelegate>()(count, bufSize, sources, types, ids, severities, lengths, messageLog);
		}
		
		public static void glPushDebugGroup(uint source, uint id, int length, char[] message)
		{
			Native.GetDelegateFor<glPushDebugGroupDelegate>()(source, id, length, message);
		}
		
		public static void glPopDebugGroup()
		{
			Native.GetDelegateFor<glPopDebugGroupDelegate>()();
		}
		
		public static void glObjectLabel(uint identifier, uint name, int length, char[] label)
		{
			Native.GetDelegateFor<glObjectLabelDelegate>()(identifier, name, length, label);
		}
		
		public static void glGetObjectLabel(uint identifier, uint name, int bufSize, int[] length, char[] label)
		{
			Native.GetDelegateFor<glGetObjectLabelDelegate>()(identifier, name, bufSize, length, label);
		}
		
		public static void glObjectPtrLabel(nint ptr, int length, char[] label)
		{
			Native.GetDelegateFor<glObjectPtrLabelDelegate>()(ptr, length, label);
		}
		
		public static void glGetObjectPtrLabel(nint ptr, int bufSize, int[] length, char[] label)
		{
			Native.GetDelegateFor<glGetObjectPtrLabelDelegate>()(ptr, bufSize, length, label);
		}
		
		public static void glGetPointerv(uint pname, nint @params)
		{
			Native.GetDelegateFor<glGetPointervDelegate>()(pname, @params);
		}
		
		public static void glDebugMessageControlKHR(uint source, uint type, uint severity, int count, uint[] ids, bool enabled)
		{
			Native.GetDelegateFor<glDebugMessageControlKHRDelegate>()(source, type, severity, count, ids, enabled);
		}
		
		public static void glDebugMessageInsertKHR(uint source, uint type, uint id, uint severity, int length, char[] buf)
		{
			Native.GetDelegateFor<glDebugMessageInsertKHRDelegate>()(source, type, id, severity, length, buf);
		}
		
		public static void glDebugMessageCallbackKHR(nint callback, nint userParam)
		{
			Native.GetDelegateFor<glDebugMessageCallbackKHRDelegate>()(callback, userParam);
		}
		
		public static uint glGetDebugMessageLogKHR(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, char[] messageLog)
		{
			return (uint)Native.GetDelegateFor<glGetDebugMessageLogKHRDelegate>()(count, bufSize, sources, types, ids, severities, lengths, messageLog);
		}
		
		public static void glPushDebugGroupKHR(uint source, uint id, int length, char[] message)
		{
			Native.GetDelegateFor<glPushDebugGroupKHRDelegate>()(source, id, length, message);
		}
		
		public static void glPopDebugGroupKHR()
		{
			Native.GetDelegateFor<glPopDebugGroupKHRDelegate>()();
		}
		
		public static void glObjectLabelKHR(uint identifier, uint name, int length, char[] label)
		{
			Native.GetDelegateFor<glObjectLabelKHRDelegate>()(identifier, name, length, label);
		}
		
		public static void glGetObjectLabelKHR(uint identifier, uint name, int bufSize, int[] length, char[] label)
		{
			Native.GetDelegateFor<glGetObjectLabelKHRDelegate>()(identifier, name, bufSize, length, label);
		}
		
		public static void glObjectPtrLabelKHR(nint ptr, int length, char[] label)
		{
			Native.GetDelegateFor<glObjectPtrLabelKHRDelegate>()(ptr, length, label);
		}
		
		public static void glGetObjectPtrLabelKHR(nint ptr, int bufSize, int[] length, char[] label)
		{
			Native.GetDelegateFor<glGetObjectPtrLabelKHRDelegate>()(ptr, bufSize, length, label);
		}
		
		public static void glGetPointervKHR(uint pname, nint @params)
		{
			Native.GetDelegateFor<glGetPointervKHRDelegate>()(pname, @params);
		}
		
		public static uint glGetGraphicsResetStatus()
		{
			return (uint)Native.GetDelegateFor<glGetGraphicsResetStatusDelegate>()();
		}
		
		public static void glReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, nint data)
		{
			Native.GetDelegateFor<glReadnPixelsDelegate>()(x, y, width, height, format, type, bufSize, data);
		}
		
		public static void glGetnUniformfv(uint program, int location, int bufSize, float[] @params)
		{
			Native.GetDelegateFor<glGetnUniformfvDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformiv(uint program, int location, int bufSize, int[] @params)
		{
			Native.GetDelegateFor<glGetnUniformivDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformuiv(uint program, int location, int bufSize, uint[] @params)
		{
			Native.GetDelegateFor<glGetnUniformuivDelegate>()(program, location, bufSize, @params);
		}
		
		public static uint glGetGraphicsResetStatusKHR()
		{
			return (uint)Native.GetDelegateFor<glGetGraphicsResetStatusKHRDelegate>()();
		}
		
		public static void glReadnPixelsKHR(int x, int y, int width, int height, uint format, uint type, int bufSize, nint data)
		{
			Native.GetDelegateFor<glReadnPixelsKHRDelegate>()(x, y, width, height, format, type, bufSize, data);
		}
		
		public static void glGetnUniformfvKHR(uint program, int location, int bufSize, float[] @params)
		{
			Native.GetDelegateFor<glGetnUniformfvKHRDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformivKHR(uint program, int location, int bufSize, int[] @params)
		{
			Native.GetDelegateFor<glGetnUniformivKHRDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformuivKHR(uint program, int location, int bufSize, uint[] @params)
		{
			Native.GetDelegateFor<glGetnUniformuivKHRDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glResizeBuffersMESA()
		{
			Native.GetDelegateFor<glResizeBuffersMESADelegate>()();
		}
		
		public static void glWindowPos2dMESA(double x, double y)
		{
			Native.GetDelegateFor<glWindowPos2dMESADelegate>()(x, y);
		}
		
		public static void glWindowPos2dvMESA(double[] v)
		{
			Native.GetDelegateFor<glWindowPos2dvMESADelegate>()(v);
		}
		
		public static void glWindowPos2fMESA(float x, float y)
		{
			Native.GetDelegateFor<glWindowPos2fMESADelegate>()(x, y);
		}
		
		public static void glWindowPos2fvMESA(float[] v)
		{
			Native.GetDelegateFor<glWindowPos2fvMESADelegate>()(v);
		}
		
		public static void glWindowPos2iMESA(int x, int y)
		{
			Native.GetDelegateFor<glWindowPos2iMESADelegate>()(x, y);
		}
		
		public static void glWindowPos2ivMESA(int[] v)
		{
			Native.GetDelegateFor<glWindowPos2ivMESADelegate>()(v);
		}
		
		public static void glWindowPos2sMESA(short x, short y)
		{
			Native.GetDelegateFor<glWindowPos2sMESADelegate>()(x, y);
		}
		
		public static void glWindowPos2svMESA(short[] v)
		{
			Native.GetDelegateFor<glWindowPos2svMESADelegate>()(v);
		}
		
		public static void glWindowPos3dMESA(double x, double y, double z)
		{
			Native.GetDelegateFor<glWindowPos3dMESADelegate>()(x, y, z);
		}
		
		public static void glWindowPos3dvMESA(double[] v)
		{
			Native.GetDelegateFor<glWindowPos3dvMESADelegate>()(v);
		}
		
		public static void glWindowPos3fMESA(float x, float y, float z)
		{
			Native.GetDelegateFor<glWindowPos3fMESADelegate>()(x, y, z);
		}
		
		public static void glWindowPos3fvMESA(float[] v)
		{
			Native.GetDelegateFor<glWindowPos3fvMESADelegate>()(v);
		}
		
		public static void glWindowPos3iMESA(int x, int y, int z)
		{
			Native.GetDelegateFor<glWindowPos3iMESADelegate>()(x, y, z);
		}
		
		public static void glWindowPos3ivMESA(int[] v)
		{
			Native.GetDelegateFor<glWindowPos3ivMESADelegate>()(v);
		}
		
		public static void glWindowPos3sMESA(short x, short y, short z)
		{
			Native.GetDelegateFor<glWindowPos3sMESADelegate>()(x, y, z);
		}
		
		public static void glWindowPos3svMESA(short[] v)
		{
			Native.GetDelegateFor<glWindowPos3svMESADelegate>()(v);
		}
		
		public static void glWindowPos4dMESA(double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glWindowPos4dMESADelegate>()(x, y, z, w);
		}
		
		public static void glWindowPos4dvMESA(double[] v)
		{
			Native.GetDelegateFor<glWindowPos4dvMESADelegate>()(v);
		}
		
		public static void glWindowPos4fMESA(float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glWindowPos4fMESADelegate>()(x, y, z, w);
		}
		
		public static void glWindowPos4fvMESA(float[] v)
		{
			Native.GetDelegateFor<glWindowPos4fvMESADelegate>()(v);
		}
		
		public static void glWindowPos4iMESA(int x, int y, int z, int w)
		{
			Native.GetDelegateFor<glWindowPos4iMESADelegate>()(x, y, z, w);
		}
		
		public static void glWindowPos4ivMESA(int[] v)
		{
			Native.GetDelegateFor<glWindowPos4ivMESADelegate>()(v);
		}
		
		public static void glWindowPos4sMESA(short x, short y, short z, short w)
		{
			Native.GetDelegateFor<glWindowPos4sMESADelegate>()(x, y, z, w);
		}
		
		public static void glWindowPos4svMESA(short[] v)
		{
			Native.GetDelegateFor<glWindowPos4svMESADelegate>()(v);
		}
		
		public static void glBeginConditionalRenderNVX(uint id)
		{
			Native.GetDelegateFor<glBeginConditionalRenderNVXDelegate>()(id);
		}
		
		public static void glEndConditionalRenderNVX()
		{
			Native.GetDelegateFor<glEndConditionalRenderNVXDelegate>()();
		}
		
		public static void glMultiDrawArraysIndirectBindlessNV(uint mode, nint indirect, int drawCount, int stride, int vertexBufferCount)
		{
			Native.GetDelegateFor<glMultiDrawArraysIndirectBindlessNVDelegate>()(mode, indirect, drawCount, stride, vertexBufferCount);
		}
		
		public static void glMultiDrawElementsIndirectBindlessNV(uint mode, uint type, nint indirect, int drawCount, int stride, int vertexBufferCount)
		{
			Native.GetDelegateFor<glMultiDrawElementsIndirectBindlessNVDelegate>()(mode, type, indirect, drawCount, stride, vertexBufferCount);
		}
		
		public static void glMultiDrawArraysIndirectBindlessCountNV(uint mode, nint indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			Native.GetDelegateFor<glMultiDrawArraysIndirectBindlessCountNVDelegate>()(mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
		}
		
		public static void glMultiDrawElementsIndirectBindlessCountNV(uint mode, uint type, nint indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			Native.GetDelegateFor<glMultiDrawElementsIndirectBindlessCountNVDelegate>()(mode, type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
		}
		
		public static UInt64 glGetTextureHandleNV(uint texture)
		{
			return (UInt64)Native.GetDelegateFor<glGetTextureHandleNVDelegate>()(texture);
		}
		
		public static UInt64 glGetTextureSamplerHandleNV(uint texture, uint sampler)
		{
			return (UInt64)Native.GetDelegateFor<glGetTextureSamplerHandleNVDelegate>()(texture, sampler);
		}
		
		public static void glMakeTextureHandleResidentNV(UInt64 handle)
		{
			Native.GetDelegateFor<glMakeTextureHandleResidentNVDelegate>()(handle);
		}
		
		public static void glMakeTextureHandleNonResidentNV(UInt64 handle)
		{
			Native.GetDelegateFor<glMakeTextureHandleNonResidentNVDelegate>()(handle);
		}
		
		public static UInt64 glGetImageHandleNV(uint texture, int level, bool layered, int layer, uint format)
		{
			return (UInt64)Native.GetDelegateFor<glGetImageHandleNVDelegate>()(texture, level, layered, layer, format);
		}
		
		public static void glMakeImageHandleResidentNV(UInt64 handle, uint access)
		{
			Native.GetDelegateFor<glMakeImageHandleResidentNVDelegate>()(handle, access);
		}
		
		public static void glMakeImageHandleNonResidentNV(UInt64 handle)
		{
			Native.GetDelegateFor<glMakeImageHandleNonResidentNVDelegate>()(handle);
		}
		
		public static void glUniformHandleui64NV(int location, UInt64 value)
		{
			Native.GetDelegateFor<glUniformHandleui64NVDelegate>()(location, value);
		}
		
		public static void glUniformHandleui64vNV(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniformHandleui64vNVDelegate>()(location, count, value);
		}
		
		public static void glProgramUniformHandleui64NV(uint program, int location, UInt64 value)
		{
			Native.GetDelegateFor<glProgramUniformHandleui64NVDelegate>()(program, location, value);
		}
		
		public static void glProgramUniformHandleui64vNV(uint program, int location, int count, UInt64[] values)
		{
			Native.GetDelegateFor<glProgramUniformHandleui64vNVDelegate>()(program, location, count, values);
		}
		
		public static bool glIsTextureHandleResidentNV(UInt64 handle)
		{
			return (bool)Native.GetDelegateFor<glIsTextureHandleResidentNVDelegate>()(handle);
		}
		
		public static bool glIsImageHandleResidentNV(UInt64 handle)
		{
			return (bool)Native.GetDelegateFor<glIsImageHandleResidentNVDelegate>()(handle);
		}
		
		public static void glBlendParameteriNV(uint pname, int value)
		{
			Native.GetDelegateFor<glBlendParameteriNVDelegate>()(pname, value);
		}
		
		public static void glBlendBarrierNV()
		{
			Native.GetDelegateFor<glBlendBarrierNVDelegate>()();
		}
		
		public static void glCreateStatesNV(int n, uint[] states)
		{
			Native.GetDelegateFor<glCreateStatesNVDelegate>()(n, states);
		}
		
		public static void glDeleteStatesNV(int n, uint[] states)
		{
			Native.GetDelegateFor<glDeleteStatesNVDelegate>()(n, states);
		}
		
		public static bool glIsStateNV(uint state)
		{
			return (bool)Native.GetDelegateFor<glIsStateNVDelegate>()(state);
		}
		
		public static void glStateCaptureNV(uint state, uint mode)
		{
			Native.GetDelegateFor<glStateCaptureNVDelegate>()(state, mode);
		}
		
		public static uint glGetCommandHeaderNV(uint tokenID, uint size)
		{
			return (uint)Native.GetDelegateFor<glGetCommandHeaderNVDelegate>()(tokenID, size);
		}
		
		public static ushort glGetStageIndexNV(uint shadertype)
		{
			return (ushort)Native.GetDelegateFor<glGetStageIndexNVDelegate>()(shadertype);
		}
		
		public static void glDrawCommandsNV(uint primitiveMode, uint buffer, nint indirects, int[] sizes, uint count)
		{
			Native.GetDelegateFor<glDrawCommandsNVDelegate>()(primitiveMode, buffer, indirects, sizes, count);
		}
		
		public static void glDrawCommandsAddressNV(uint primitiveMode, UInt64[] indirects, int[] sizes, uint count)
		{
			Native.GetDelegateFor<glDrawCommandsAddressNVDelegate>()(primitiveMode, indirects, sizes, count);
		}
		
		public static void glDrawCommandsStatesNV(uint buffer, nint indirects, int[] sizes, uint[] states, uint[] fbos, uint count)
		{
			Native.GetDelegateFor<glDrawCommandsStatesNVDelegate>()(buffer, indirects, sizes, states, fbos, count);
		}
		
		public static void glDrawCommandsStatesAddressNV(UInt64[] indirects, int[] sizes, uint[] states, uint[] fbos, uint count)
		{
			Native.GetDelegateFor<glDrawCommandsStatesAddressNVDelegate>()(indirects, sizes, states, fbos, count);
		}
		
		public static void glCreateCommandListsNV(int n, uint[] lists)
		{
			Native.GetDelegateFor<glCreateCommandListsNVDelegate>()(n, lists);
		}
		
		public static void glDeleteCommandListsNV(int n, uint[] lists)
		{
			Native.GetDelegateFor<glDeleteCommandListsNVDelegate>()(n, lists);
		}
		
		public static bool glIsCommandListNV(uint list)
		{
			return (bool)Native.GetDelegateFor<glIsCommandListNVDelegate>()(list);
		}
		
		public static void glListDrawCommandsStatesClientNV(uint list, uint segment, nint indirects, int[] sizes, uint[] states, uint[] fbos, uint count)
		{
			Native.GetDelegateFor<glListDrawCommandsStatesClientNVDelegate>()(list, segment, indirects, sizes, states, fbos, count);
		}
		
		public static void glCommandListSegmentsNV(uint list, uint segments)
		{
			Native.GetDelegateFor<glCommandListSegmentsNVDelegate>()(list, segments);
		}
		
		public static void glCompileCommandListNV(uint list)
		{
			Native.GetDelegateFor<glCompileCommandListNVDelegate>()(list);
		}
		
		public static void glCallCommandListNV(uint list)
		{
			Native.GetDelegateFor<glCallCommandListNVDelegate>()(list);
		}
		
		public static void glBeginConditionalRenderNV(uint id, uint mode)
		{
			Native.GetDelegateFor<glBeginConditionalRenderNVDelegate>()(id, mode);
		}
		
		public static void glEndConditionalRenderNV()
		{
			Native.GetDelegateFor<glEndConditionalRenderNVDelegate>()();
		}
		
		public static void glSubpixelPrecisionBiasNV(uint xbits, uint ybits)
		{
			Native.GetDelegateFor<glSubpixelPrecisionBiasNVDelegate>()(xbits, ybits);
		}
		
		public static void glConservativeRasterParameterfNV(uint pname, float value)
		{
			Native.GetDelegateFor<glConservativeRasterParameterfNVDelegate>()(pname, value);
		}
		
		public static void glCopyBufferSubDataNV(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size)
		{
			Native.GetDelegateFor<glCopyBufferSubDataNVDelegate>()(readTarget, writeTarget, readOffset, writeOffset, size);
		}
		
		public static void glCopyImageSubDataNV(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
		{
			Native.GetDelegateFor<glCopyImageSubDataNVDelegate>()(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
		}
		
		public static void glCoverageMaskNV(bool mask)
		{
			Native.GetDelegateFor<glCoverageMaskNVDelegate>()(mask);
		}
		
		public static void glCoverageOperationNV(uint operation)
		{
			Native.GetDelegateFor<glCoverageOperationNVDelegate>()(operation);
		}
		
		public static void glDepthRangedNV(double zNear, double zFar)
		{
			Native.GetDelegateFor<glDepthRangedNVDelegate>()(zNear, zFar);
		}
		
		public static void glClearDepthdNV(double depth)
		{
			Native.GetDelegateFor<glClearDepthdNVDelegate>()(depth);
		}
		
		public static void glDepthBoundsdNV(double zmin, double zmax)
		{
			Native.GetDelegateFor<glDepthBoundsdNVDelegate>()(zmin, zmax);
		}
		
		public static void glDrawBuffersNV(int n, uint[] bufs)
		{
			Native.GetDelegateFor<glDrawBuffersNVDelegate>()(n, bufs);
		}
		
		public static void glDrawArraysInstancedNV(uint mode, int first, int count, int primcount)
		{
			Native.GetDelegateFor<glDrawArraysInstancedNVDelegate>()(mode, first, count, primcount);
		}
		
		public static void glDrawElementsInstancedNV(uint mode, int count, uint type, nint indices, int primcount)
		{
			Native.GetDelegateFor<glDrawElementsInstancedNVDelegate>()(mode, count, type, indices, primcount);
		}
		
		public static void glDrawTextureNV(uint texture, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1)
		{
			Native.GetDelegateFor<glDrawTextureNVDelegate>()(texture, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
		}
		
		public static void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, bool packed, nint points)
		{
			Native.GetDelegateFor<glMapControlPointsNVDelegate>()(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		
		public static void glMapParameterivNV(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glMapParameterivNVDelegate>()(target, pname, @params);
		}
		
		public static void glMapParameterfvNV(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glMapParameterfvNVDelegate>()(target, pname, @params);
		}
		
		public static void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, bool packed, nint points)
		{
			Native.GetDelegateFor<glGetMapControlPointsNVDelegate>()(target, index, type, ustride, vstride, packed, points);
		}
		
		public static void glGetMapParameterivNV(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetMapParameterivNVDelegate>()(target, pname, @params);
		}
		
		public static void glGetMapParameterfvNV(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetMapParameterfvNVDelegate>()(target, pname, @params);
		}
		
		public static void glGetMapAttribParameterivNV(uint target, uint index, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetMapAttribParameterivNVDelegate>()(target, index, pname, @params);
		}
		
		public static void glGetMapAttribParameterfvNV(uint target, uint index, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetMapAttribParameterfvNVDelegate>()(target, index, pname, @params);
		}
		
		public static void glEvalMapsNV(uint target, uint mode)
		{
			Native.GetDelegateFor<glEvalMapsNVDelegate>()(target, mode);
		}
		
		public static void glGetMultisamplefvNV(uint pname, uint index, float[] val)
		{
			Native.GetDelegateFor<glGetMultisamplefvNVDelegate>()(pname, index, val);
		}
		
		public static void glSampleMaskIndexedNV(uint index, uint mask)
		{
			Native.GetDelegateFor<glSampleMaskIndexedNVDelegate>()(index, mask);
		}
		
		public static void glTexRenderbufferNV(uint target, uint renderbuffer)
		{
			Native.GetDelegateFor<glTexRenderbufferNVDelegate>()(target, renderbuffer);
		}
		
		public static void glDeleteFencesNV(int n, uint[] fences)
		{
			Native.GetDelegateFor<glDeleteFencesNVDelegate>()(n, fences);
		}
		
		public static void glGenFencesNV(int n, uint[] fences)
		{
			Native.GetDelegateFor<glGenFencesNVDelegate>()(n, fences);
		}
		
		public static bool glIsFenceNV(uint fence)
		{
			return (bool)Native.GetDelegateFor<glIsFenceNVDelegate>()(fence);
		}
		
		public static bool glTestFenceNV(uint fence)
		{
			return (bool)Native.GetDelegateFor<glTestFenceNVDelegate>()(fence);
		}
		
		public static void glGetFenceivNV(uint fence, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetFenceivNVDelegate>()(fence, pname, @params);
		}
		
		public static void glFinishFenceNV(uint fence)
		{
			Native.GetDelegateFor<glFinishFenceNVDelegate>()(fence);
		}
		
		public static void glSetFenceNV(uint fence, uint condition)
		{
			Native.GetDelegateFor<glSetFenceNVDelegate>()(fence, condition);
		}
		
		public static void glFragmentCoverageColorNV(uint color)
		{
			Native.GetDelegateFor<glFragmentCoverageColorNVDelegate>()(color);
		}
		
		public static void glProgramNamedParameter4fNV(uint id, int len, byte[] name, float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glProgramNamedParameter4fNVDelegate>()(id, len, name, x, y, z, w);
		}
		
		public static void glProgramNamedParameter4fvNV(uint id, int len, byte[] name, float[] v)
		{
			Native.GetDelegateFor<glProgramNamedParameter4fvNVDelegate>()(id, len, name, v);
		}
		
		public static void glProgramNamedParameter4dNV(uint id, int len, byte[] name, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glProgramNamedParameter4dNVDelegate>()(id, len, name, x, y, z, w);
		}
		
		public static void glProgramNamedParameter4dvNV(uint id, int len, byte[] name, double[] v)
		{
			Native.GetDelegateFor<glProgramNamedParameter4dvNVDelegate>()(id, len, name, v);
		}
		
		public static void glGetProgramNamedParameterfvNV(uint id, int len, byte[] name, float[] @params)
		{
			Native.GetDelegateFor<glGetProgramNamedParameterfvNVDelegate>()(id, len, name, @params);
		}
		
		public static void glGetProgramNamedParameterdvNV(uint id, int len, byte[] name, double[] @params)
		{
			Native.GetDelegateFor<glGetProgramNamedParameterdvNVDelegate>()(id, len, name, @params);
		}
		
		public static void glBlitFramebufferNV(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			Native.GetDelegateFor<glBlitFramebufferNVDelegate>()(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		public static void glCoverageModulationTableNV(int n, float[] v)
		{
			Native.GetDelegateFor<glCoverageModulationTableNVDelegate>()(n, v);
		}
		
		public static void glGetCoverageModulationTableNV(int bufsize, float[] v)
		{
			Native.GetDelegateFor<glGetCoverageModulationTableNVDelegate>()(bufsize, v);
		}
		
		public static void glCoverageModulationNV(uint components)
		{
			Native.GetDelegateFor<glCoverageModulationNVDelegate>()(components);
		}
		
		public static void glRenderbufferStorageMultisampleNV(uint target, int samples, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glRenderbufferStorageMultisampleNVDelegate>()(target, samples, internalformat, width, height);
		}
		
		public static void glRenderbufferStorageMultisampleCoverageNV(uint target, int coverageSamples, int colorSamples, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glRenderbufferStorageMultisampleCoverageNVDelegate>()(target, coverageSamples, colorSamples, internalformat, width, height);
		}
		
		public static void glProgramVertexLimitNV(uint target, int limit)
		{
			Native.GetDelegateFor<glProgramVertexLimitNVDelegate>()(target, limit);
		}
		
		public static void glFramebufferTextureFaceEXT(uint target, uint attachment, uint texture, int level, uint face)
		{
			Native.GetDelegateFor<glFramebufferTextureFaceEXTDelegate>()(target, attachment, texture, level, face);
		}
		
		public static void glProgramLocalParameterI4iNV(uint target, uint index, int x, int y, int z, int w)
		{
			Native.GetDelegateFor<glProgramLocalParameterI4iNVDelegate>()(target, index, x, y, z, w);
		}
		
		public static void glProgramLocalParameterI4ivNV(uint target, uint index, int[] @params)
		{
			Native.GetDelegateFor<glProgramLocalParameterI4ivNVDelegate>()(target, index, @params);
		}
		
		public static void glProgramLocalParametersI4ivNV(uint target, uint index, int count, int[] @params)
		{
			Native.GetDelegateFor<glProgramLocalParametersI4ivNVDelegate>()(target, index, count, @params);
		}
		
		public static void glProgramLocalParameterI4uiNV(uint target, uint index, uint x, uint y, uint z, uint w)
		{
			Native.GetDelegateFor<glProgramLocalParameterI4uiNVDelegate>()(target, index, x, y, z, w);
		}
		
		public static void glProgramLocalParameterI4uivNV(uint target, uint index, uint[] @params)
		{
			Native.GetDelegateFor<glProgramLocalParameterI4uivNVDelegate>()(target, index, @params);
		}
		
		public static void glProgramLocalParametersI4uivNV(uint target, uint index, int count, uint[] @params)
		{
			Native.GetDelegateFor<glProgramLocalParametersI4uivNVDelegate>()(target, index, count, @params);
		}
		
		public static void glProgramEnvParameterI4iNV(uint target, uint index, int x, int y, int z, int w)
		{
			Native.GetDelegateFor<glProgramEnvParameterI4iNVDelegate>()(target, index, x, y, z, w);
		}
		
		public static void glProgramEnvParameterI4ivNV(uint target, uint index, int[] @params)
		{
			Native.GetDelegateFor<glProgramEnvParameterI4ivNVDelegate>()(target, index, @params);
		}
		
		public static void glProgramEnvParametersI4ivNV(uint target, uint index, int count, int[] @params)
		{
			Native.GetDelegateFor<glProgramEnvParametersI4ivNVDelegate>()(target, index, count, @params);
		}
		
		public static void glProgramEnvParameterI4uiNV(uint target, uint index, uint x, uint y, uint z, uint w)
		{
			Native.GetDelegateFor<glProgramEnvParameterI4uiNVDelegate>()(target, index, x, y, z, w);
		}
		
		public static void glProgramEnvParameterI4uivNV(uint target, uint index, uint[] @params)
		{
			Native.GetDelegateFor<glProgramEnvParameterI4uivNVDelegate>()(target, index, @params);
		}
		
		public static void glProgramEnvParametersI4uivNV(uint target, uint index, int count, uint[] @params)
		{
			Native.GetDelegateFor<glProgramEnvParametersI4uivNVDelegate>()(target, index, count, @params);
		}
		
		public static void glGetProgramLocalParameterIivNV(uint target, uint index, int[] @params)
		{
			Native.GetDelegateFor<glGetProgramLocalParameterIivNVDelegate>()(target, index, @params);
		}
		
		public static void glGetProgramLocalParameterIuivNV(uint target, uint index, uint[] @params)
		{
			Native.GetDelegateFor<glGetProgramLocalParameterIuivNVDelegate>()(target, index, @params);
		}
		
		public static void glGetProgramEnvParameterIivNV(uint target, uint index, int[] @params)
		{
			Native.GetDelegateFor<glGetProgramEnvParameterIivNVDelegate>()(target, index, @params);
		}
		
		public static void glGetProgramEnvParameterIuivNV(uint target, uint index, uint[] @params)
		{
			Native.GetDelegateFor<glGetProgramEnvParameterIuivNVDelegate>()(target, index, @params);
		}
		
		public static void glProgramSubroutineParametersuivNV(uint target, int count, uint[] @params)
		{
			Native.GetDelegateFor<glProgramSubroutineParametersuivNVDelegate>()(target, count, @params);
		}
		
		public static void glGetProgramSubroutineParameteruivNV(uint target, uint index, uint[] param)
		{
			Native.GetDelegateFor<glGetProgramSubroutineParameteruivNVDelegate>()(target, index, param);
		}
		
		public static void glVertex2hNV(ushort x, ushort y)
		{
			Native.GetDelegateFor<glVertex2hNVDelegate>()(x, y);
		}
		
		public static void glVertex2hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glVertex2hvNVDelegate>()(v);
		}
		
		public static void glVertex3hNV(ushort x, ushort y, ushort z)
		{
			Native.GetDelegateFor<glVertex3hNVDelegate>()(x, y, z);
		}
		
		public static void glVertex3hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glVertex3hvNVDelegate>()(v);
		}
		
		public static void glVertex4hNV(ushort x, ushort y, ushort z, ushort w)
		{
			Native.GetDelegateFor<glVertex4hNVDelegate>()(x, y, z, w);
		}
		
		public static void glVertex4hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glVertex4hvNVDelegate>()(v);
		}
		
		public static void glNormal3hNV(ushort nx, ushort ny, ushort nz)
		{
			Native.GetDelegateFor<glNormal3hNVDelegate>()(nx, ny, nz);
		}
		
		public static void glNormal3hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glNormal3hvNVDelegate>()(v);
		}
		
		public static void glColor3hNV(ushort red, ushort green, ushort blue)
		{
			Native.GetDelegateFor<glColor3hNVDelegate>()(red, green, blue);
		}
		
		public static void glColor3hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glColor3hvNVDelegate>()(v);
		}
		
		public static void glColor4hNV(ushort red, ushort green, ushort blue, ushort alpha)
		{
			Native.GetDelegateFor<glColor4hNVDelegate>()(red, green, blue, alpha);
		}
		
		public static void glColor4hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glColor4hvNVDelegate>()(v);
		}
		
		public static void glTexCoord1hNV(ushort s)
		{
			Native.GetDelegateFor<glTexCoord1hNVDelegate>()(s);
		}
		
		public static void glTexCoord1hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glTexCoord1hvNVDelegate>()(v);
		}
		
		public static void glTexCoord2hNV(ushort s, ushort t)
		{
			Native.GetDelegateFor<glTexCoord2hNVDelegate>()(s, t);
		}
		
		public static void glTexCoord2hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glTexCoord2hvNVDelegate>()(v);
		}
		
		public static void glTexCoord3hNV(ushort s, ushort t, ushort r)
		{
			Native.GetDelegateFor<glTexCoord3hNVDelegate>()(s, t, r);
		}
		
		public static void glTexCoord3hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glTexCoord3hvNVDelegate>()(v);
		}
		
		public static void glTexCoord4hNV(ushort s, ushort t, ushort r, ushort q)
		{
			Native.GetDelegateFor<glTexCoord4hNVDelegate>()(s, t, r, q);
		}
		
		public static void glTexCoord4hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glTexCoord4hvNVDelegate>()(v);
		}
		
		public static void glMultiTexCoord1hNV(uint target, ushort s)
		{
			Native.GetDelegateFor<glMultiTexCoord1hNVDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1hvNV(uint target, ushort[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord1hvNVDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2hNV(uint target, ushort s, ushort t)
		{
			Native.GetDelegateFor<glMultiTexCoord2hNVDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2hvNV(uint target, ushort[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord2hvNVDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3hNV(uint target, ushort s, ushort t, ushort r)
		{
			Native.GetDelegateFor<glMultiTexCoord3hNVDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3hvNV(uint target, ushort[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord3hvNVDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4hNV(uint target, ushort s, ushort t, ushort r, ushort q)
		{
			Native.GetDelegateFor<glMultiTexCoord4hNVDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4hvNV(uint target, ushort[] v)
		{
			Native.GetDelegateFor<glMultiTexCoord4hvNVDelegate>()(target, v);
		}
		
		public static void glFogCoordhNV(ushort fog)
		{
			Native.GetDelegateFor<glFogCoordhNVDelegate>()(fog);
		}
		
		public static void glFogCoordhvNV(ushort[] fog)
		{
			Native.GetDelegateFor<glFogCoordhvNVDelegate>()(fog);
		}
		
		public static void glSecondaryColor3hNV(ushort red, ushort green, ushort blue)
		{
			Native.GetDelegateFor<glSecondaryColor3hNVDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3hvNV(ushort[] v)
		{
			Native.GetDelegateFor<glSecondaryColor3hvNVDelegate>()(v);
		}
		
		public static void glVertexWeighthNV(ushort weight)
		{
			Native.GetDelegateFor<glVertexWeighthNVDelegate>()(weight);
		}
		
		public static void glVertexWeighthvNV(ushort[] weight)
		{
			Native.GetDelegateFor<glVertexWeighthvNVDelegate>()(weight);
		}
		
		public static void glVertexAttrib1hNV(uint index, ushort x)
		{
			Native.GetDelegateFor<glVertexAttrib1hNVDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1hvNV(uint index, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttrib1hvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2hNV(uint index, ushort x, ushort y)
		{
			Native.GetDelegateFor<glVertexAttrib2hNVDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2hvNV(uint index, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttrib2hvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3hNV(uint index, ushort x, ushort y, ushort z)
		{
			Native.GetDelegateFor<glVertexAttrib3hNVDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3hvNV(uint index, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttrib3hvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4hNV(uint index, ushort x, ushort y, ushort z, ushort w)
		{
			Native.GetDelegateFor<glVertexAttrib4hNVDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4hvNV(uint index, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4hvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttribs1hvNV(uint index, int n, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttribs1hvNVDelegate>()(index, n, v);
		}
		
		public static void glVertexAttribs2hvNV(uint index, int n, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttribs2hvNVDelegate>()(index, n, v);
		}
		
		public static void glVertexAttribs3hvNV(uint index, int n, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttribs3hvNVDelegate>()(index, n, v);
		}
		
		public static void glVertexAttribs4hvNV(uint index, int n, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttribs4hvNVDelegate>()(index, n, v);
		}
		
		public static void glVertexAttribDivisorNV(uint index, uint divisor)
		{
			Native.GetDelegateFor<glVertexAttribDivisorNVDelegate>()(index, divisor);
		}
		
		public static void glGetInternalformatSampleivNV(uint target, uint internalformat, int samples, uint pname, int bufSize, int[] @params)
		{
			Native.GetDelegateFor<glGetInternalformatSampleivNVDelegate>()(target, internalformat, samples, pname, bufSize, @params);
		}
		
		public static void glUniformMatrix2x3fvNV(int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glUniformMatrix2x3fvNVDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x2fvNV(int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glUniformMatrix3x2fvNVDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix2x4fvNV(int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glUniformMatrix2x4fvNVDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x2fvNV(int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glUniformMatrix4x2fvNVDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x4fvNV(int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glUniformMatrix3x4fvNVDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x3fvNV(int location, int count, bool transpose, float[] value)
		{
			Native.GetDelegateFor<glUniformMatrix4x3fvNVDelegate>()(location, count, transpose, value);
		}
		
		public static void glGenOcclusionQueriesNV(int n, uint[] ids)
		{
			Native.GetDelegateFor<glGenOcclusionQueriesNVDelegate>()(n, ids);
		}
		
		public static void glDeleteOcclusionQueriesNV(int n, uint[] ids)
		{
			Native.GetDelegateFor<glDeleteOcclusionQueriesNVDelegate>()(n, ids);
		}
		
		public static bool glIsOcclusionQueryNV(uint id)
		{
			return (bool)Native.GetDelegateFor<glIsOcclusionQueryNVDelegate>()(id);
		}
		
		public static void glBeginOcclusionQueryNV(uint id)
		{
			Native.GetDelegateFor<glBeginOcclusionQueryNVDelegate>()(id);
		}
		
		public static void glEndOcclusionQueryNV()
		{
			Native.GetDelegateFor<glEndOcclusionQueryNVDelegate>()();
		}
		
		public static void glGetOcclusionQueryivNV(uint id, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetOcclusionQueryivNVDelegate>()(id, pname, @params);
		}
		
		public static void glGetOcclusionQueryuivNV(uint id, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetOcclusionQueryuivNVDelegate>()(id, pname, @params);
		}
		
		public static void glProgramBufferParametersfvNV(uint target, uint bindingIndex, uint wordIndex, int count, float[] @params)
		{
			Native.GetDelegateFor<glProgramBufferParametersfvNVDelegate>()(target, bindingIndex, wordIndex, count, @params);
		}
		
		public static void glProgramBufferParametersIivNV(uint target, uint bindingIndex, uint wordIndex, int count, int[] @params)
		{
			Native.GetDelegateFor<glProgramBufferParametersIivNVDelegate>()(target, bindingIndex, wordIndex, count, @params);
		}
		
		public static void glProgramBufferParametersIuivNV(uint target, uint bindingIndex, uint wordIndex, int count, uint[] @params)
		{
			Native.GetDelegateFor<glProgramBufferParametersIuivNVDelegate>()(target, bindingIndex, wordIndex, count, @params);
		}
		
		public static uint glGenPathsNV(int range)
		{
			return (uint)Native.GetDelegateFor<glGenPathsNVDelegate>()(range);
		}
		
		public static void glDeletePathsNV(uint path, int range)
		{
			Native.GetDelegateFor<glDeletePathsNVDelegate>()(path, range);
		}
		
		public static bool glIsPathNV(uint path)
		{
			return (bool)Native.GetDelegateFor<glIsPathNVDelegate>()(path);
		}
		
		public static void glPathCommandsNV(uint path, int numCommands, byte[] commands, int numCoords, uint coordType, nint coords)
		{
			Native.GetDelegateFor<glPathCommandsNVDelegate>()(path, numCommands, commands, numCoords, coordType, coords);
		}
		
		public static void glPathCoordsNV(uint path, int numCoords, uint coordType, nint coords)
		{
			Native.GetDelegateFor<glPathCoordsNVDelegate>()(path, numCoords, coordType, coords);
		}
		
		public static void glPathSubCommandsNV(uint path, int commandStart, int commandsToDelete, int numCommands, byte[] commands, int numCoords, uint coordType, nint coords)
		{
			Native.GetDelegateFor<glPathSubCommandsNVDelegate>()(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, coords);
		}
		
		public static void glPathSubCoordsNV(uint path, int coordStart, int numCoords, uint coordType, nint coords)
		{
			Native.GetDelegateFor<glPathSubCoordsNVDelegate>()(path, coordStart, numCoords, coordType, coords);
		}
		
		public static void glPathStringNV(uint path, uint format, int length, nint pathString)
		{
			Native.GetDelegateFor<glPathStringNVDelegate>()(path, format, length, pathString);
		}
		
		public static void glPathGlyphsNV(uint firstPathName, uint fontTarget, nint fontName, uint fontStyle, int numGlyphs, uint type, nint charcodes, uint handleMissingGlyphs, uint pathParameterTemplate, float emScale)
		{
			Native.GetDelegateFor<glPathGlyphsNVDelegate>()(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
		}
		
		public static void glPathGlyphRangeNV(uint firstPathName, uint fontTarget, nint fontName, uint fontStyle, uint firstGlyph, int numGlyphs, uint handleMissingGlyphs, uint pathParameterTemplate, float emScale)
		{
			Native.GetDelegateFor<glPathGlyphRangeNVDelegate>()(firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
		}
		
		public static void glWeightPathsNV(uint resultPath, int numPaths, uint[] paths, float[] weights)
		{
			Native.GetDelegateFor<glWeightPathsNVDelegate>()(resultPath, numPaths, paths, weights);
		}
		
		public static void glCopyPathNV(uint resultPath, uint srcPath)
		{
			Native.GetDelegateFor<glCopyPathNVDelegate>()(resultPath, srcPath);
		}
		
		public static void glInterpolatePathsNV(uint resultPath, uint pathA, uint pathB, float weight)
		{
			Native.GetDelegateFor<glInterpolatePathsNVDelegate>()(resultPath, pathA, pathB, weight);
		}
		
		public static void glTransformPathNV(uint resultPath, uint srcPath, uint transformType, float[] transformValues)
		{
			Native.GetDelegateFor<glTransformPathNVDelegate>()(resultPath, srcPath, transformType, transformValues);
		}
		
		public static void glPathParameterivNV(uint path, uint pname, int[] value)
		{
			Native.GetDelegateFor<glPathParameterivNVDelegate>()(path, pname, value);
		}
		
		public static void glPathParameteriNV(uint path, uint pname, int value)
		{
			Native.GetDelegateFor<glPathParameteriNVDelegate>()(path, pname, value);
		}
		
		public static void glPathParameterfvNV(uint path, uint pname, float[] value)
		{
			Native.GetDelegateFor<glPathParameterfvNVDelegate>()(path, pname, value);
		}
		
		public static void glPathParameterfNV(uint path, uint pname, float value)
		{
			Native.GetDelegateFor<glPathParameterfNVDelegate>()(path, pname, value);
		}
		
		public static void glPathDashArrayNV(uint path, int dashCount, float[] dashArray)
		{
			Native.GetDelegateFor<glPathDashArrayNVDelegate>()(path, dashCount, dashArray);
		}
		
		public static void glPathStencilFuncNV(uint func, int @ref, uint mask)
		{
			Native.GetDelegateFor<glPathStencilFuncNVDelegate>()(func, @ref, mask);
		}
		
		public static void glPathStencilDepthOffsetNV(float factor, float units)
		{
			Native.GetDelegateFor<glPathStencilDepthOffsetNVDelegate>()(factor, units);
		}
		
		public static void glStencilFillPathNV(uint path, uint fillMode, uint mask)
		{
			Native.GetDelegateFor<glStencilFillPathNVDelegate>()(path, fillMode, mask);
		}
		
		public static void glStencilStrokePathNV(uint path, int reference, uint mask)
		{
			Native.GetDelegateFor<glStencilStrokePathNVDelegate>()(path, reference, mask);
		}
		
		public static void glStencilFillPathInstancedNV(int numPaths, uint pathNameType, nint paths, uint pathBase, uint fillMode, uint mask, uint transformType, float[] transformValues)
		{
			Native.GetDelegateFor<glStencilFillPathInstancedNVDelegate>()(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, transformValues);
		}
		
		public static void glStencilStrokePathInstancedNV(int numPaths, uint pathNameType, nint paths, uint pathBase, int reference, uint mask, uint transformType, float[] transformValues)
		{
			Native.GetDelegateFor<glStencilStrokePathInstancedNVDelegate>()(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, transformValues);
		}
		
		public static void glPathCoverDepthFuncNV(uint func)
		{
			Native.GetDelegateFor<glPathCoverDepthFuncNVDelegate>()(func);
		}
		
		public static void glCoverFillPathNV(uint path, uint coverMode)
		{
			Native.GetDelegateFor<glCoverFillPathNVDelegate>()(path, coverMode);
		}
		
		public static void glCoverStrokePathNV(uint path, uint coverMode)
		{
			Native.GetDelegateFor<glCoverStrokePathNVDelegate>()(path, coverMode);
		}
		
		public static void glCoverFillPathInstancedNV(int numPaths, uint pathNameType, nint paths, uint pathBase, uint coverMode, uint transformType, float[] transformValues)
		{
			Native.GetDelegateFor<glCoverFillPathInstancedNVDelegate>()(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);
		}
		
		public static void glCoverStrokePathInstancedNV(int numPaths, uint pathNameType, nint paths, uint pathBase, uint coverMode, uint transformType, float[] transformValues)
		{
			Native.GetDelegateFor<glCoverStrokePathInstancedNVDelegate>()(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);
		}
		
		public static void glGetPathParameterivNV(uint path, uint pname, int[] value)
		{
			Native.GetDelegateFor<glGetPathParameterivNVDelegate>()(path, pname, value);
		}
		
		public static void glGetPathParameterfvNV(uint path, uint pname, float[] value)
		{
			Native.GetDelegateFor<glGetPathParameterfvNVDelegate>()(path, pname, value);
		}
		
		public static void glGetPathCommandsNV(uint path, byte[] commands)
		{
			Native.GetDelegateFor<glGetPathCommandsNVDelegate>()(path, commands);
		}
		
		public static void glGetPathCoordsNV(uint path, float[] coords)
		{
			Native.GetDelegateFor<glGetPathCoordsNVDelegate>()(path, coords);
		}
		
		public static void glGetPathDashArrayNV(uint path, float[] dashArray)
		{
			Native.GetDelegateFor<glGetPathDashArrayNVDelegate>()(path, dashArray);
		}
		
		public static void glGetPathMetricsNV(uint metricQueryMask, int numPaths, uint pathNameType, nint paths, uint pathBase, int stride, float[] metrics)
		{
			Native.GetDelegateFor<glGetPathMetricsNVDelegate>()(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, metrics);
		}
		
		public static void glGetPathMetricRangeNV(uint metricQueryMask, uint firstPathName, int numPaths, int stride, float[] metrics)
		{
			Native.GetDelegateFor<glGetPathMetricRangeNVDelegate>()(metricQueryMask, firstPathName, numPaths, stride, metrics);
		}
		
		public static void glGetPathSpacingNV(uint pathListMode, int numPaths, uint pathNameType, nint paths, uint pathBase, float advanceScale, float kerningScale, uint transformType, float[] returnedSpacing)
		{
			Native.GetDelegateFor<glGetPathSpacingNVDelegate>()(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
		}
		
		public static bool glIsPointInFillPathNV(uint path, uint mask, float x, float y)
		{
			return (bool)Native.GetDelegateFor<glIsPointInFillPathNVDelegate>()(path, mask, x, y);
		}
		
		public static bool glIsPointInStrokePathNV(uint path, float x, float y)
		{
			return (bool)Native.GetDelegateFor<glIsPointInStrokePathNVDelegate>()(path, x, y);
		}
		
		public static float glGetPathLengthNV(uint path, int startSegment, int numSegments)
		{
			return (float)Native.GetDelegateFor<glGetPathLengthNVDelegate>()(path, startSegment, numSegments);
		}
		
		public static bool glPointAlongPathNV(uint path, int startSegment, int numSegments, float distance, float[] x, float[] y, float[] tangentX, float[] tangentY)
		{
			return (bool)Native.GetDelegateFor<glPointAlongPathNVDelegate>()(path, startSegment, numSegments, distance, x, y, tangentX, tangentY);
		}
		
		public static void glMatrixLoad3x2fNV(uint matrixMode, float[] m)
		{
			Native.GetDelegateFor<glMatrixLoad3x2fNVDelegate>()(matrixMode, m);
		}
		
		public static void glMatrixLoad3x3fNV(uint matrixMode, float[] m)
		{
			Native.GetDelegateFor<glMatrixLoad3x3fNVDelegate>()(matrixMode, m);
		}
		
		public static void glMatrixLoadTranspose3x3fNV(uint matrixMode, float[] m)
		{
			Native.GetDelegateFor<glMatrixLoadTranspose3x3fNVDelegate>()(matrixMode, m);
		}
		
		public static void glMatrixMult3x2fNV(uint matrixMode, float[] m)
		{
			Native.GetDelegateFor<glMatrixMult3x2fNVDelegate>()(matrixMode, m);
		}
		
		public static void glMatrixMult3x3fNV(uint matrixMode, float[] m)
		{
			Native.GetDelegateFor<glMatrixMult3x3fNVDelegate>()(matrixMode, m);
		}
		
		public static void glMatrixMultTranspose3x3fNV(uint matrixMode, float[] m)
		{
			Native.GetDelegateFor<glMatrixMultTranspose3x3fNVDelegate>()(matrixMode, m);
		}
		
		public static void glStencilThenCoverFillPathNV(uint path, uint fillMode, uint mask, uint coverMode)
		{
			Native.GetDelegateFor<glStencilThenCoverFillPathNVDelegate>()(path, fillMode, mask, coverMode);
		}
		
		public static void glStencilThenCoverStrokePathNV(uint path, int reference, uint mask, uint coverMode)
		{
			Native.GetDelegateFor<glStencilThenCoverStrokePathNVDelegate>()(path, reference, mask, coverMode);
		}
		
		public static void glStencilThenCoverFillPathInstancedNV(int numPaths, uint pathNameType, nint paths, uint pathBase, uint fillMode, uint mask, uint coverMode, uint transformType, float[] transformValues)
		{
			Native.GetDelegateFor<glStencilThenCoverFillPathInstancedNVDelegate>()(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, transformValues);
		}
		
		public static void glStencilThenCoverStrokePathInstancedNV(int numPaths, uint pathNameType, nint paths, uint pathBase, int reference, uint mask, uint coverMode, uint transformType, float[] transformValues)
		{
			Native.GetDelegateFor<glStencilThenCoverStrokePathInstancedNVDelegate>()(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, transformValues);
		}
		
		public static uint glPathGlyphIndexRangeNV(uint fontTarget, nint fontName, uint fontStyle, uint pathParameterTemplate, float emScale, uint baseAndCount)
		{
			return (uint)Native.GetDelegateFor<glPathGlyphIndexRangeNVDelegate>()(fontTarget, fontName, fontStyle, pathParameterTemplate, emScale, baseAndCount);
		}
		
		public static uint glPathGlyphIndexArrayNV(uint firstPathName, uint fontTarget, nint fontName, uint fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
		{
			return (uint)Native.GetDelegateFor<glPathGlyphIndexArrayNVDelegate>()(firstPathName, fontTarget, fontName, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
		}
		
		public static uint glPathMemoryGlyphIndexArrayNV(uint firstPathName, uint fontTarget, nint fontSize, nint fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
		{
			return (uint)Native.GetDelegateFor<glPathMemoryGlyphIndexArrayNVDelegate>()(firstPathName, fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
		}
		
		public static void glProgramPathFragmentInputGenNV(uint program, int location, uint genMode, int components, float[] coeffs)
		{
			Native.GetDelegateFor<glProgramPathFragmentInputGenNVDelegate>()(program, location, genMode, components, coeffs);
		}
		
		public static void glGetProgramResourcefvNV(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, float[] @params)
		{
			Native.GetDelegateFor<glGetProgramResourcefvNVDelegate>()(program, programInterface, index, propCount, props, bufSize, length, @params);
		}
		
		public static void glPathColorGenNV(uint color, uint genMode, uint colorFormat, float[] coeffs)
		{
			Native.GetDelegateFor<glPathColorGenNVDelegate>()(color, genMode, colorFormat, coeffs);
		}
		
		public static void glPathTexGenNV(uint texCoordSet, uint genMode, int components, float[] coeffs)
		{
			Native.GetDelegateFor<glPathTexGenNVDelegate>()(texCoordSet, genMode, components, coeffs);
		}
		
		public static void glPathFogGenNV(uint genMode)
		{
			Native.GetDelegateFor<glPathFogGenNVDelegate>()(genMode);
		}
		
		public static void glGetPathColorGenivNV(uint color, uint pname, int[] value)
		{
			Native.GetDelegateFor<glGetPathColorGenivNVDelegate>()(color, pname, value);
		}
		
		public static void glGetPathColorGenfvNV(uint color, uint pname, float[] value)
		{
			Native.GetDelegateFor<glGetPathColorGenfvNVDelegate>()(color, pname, value);
		}
		
		public static void glGetPathTexGenivNV(uint texCoordSet, uint pname, int[] value)
		{
			Native.GetDelegateFor<glGetPathTexGenivNVDelegate>()(texCoordSet, pname, value);
		}
		
		public static void glGetPathTexGenfvNV(uint texCoordSet, uint pname, float[] value)
		{
			Native.GetDelegateFor<glGetPathTexGenfvNVDelegate>()(texCoordSet, pname, value);
		}
		
		public static void glPixelDataRangeNV(uint target, int length, nint pointer)
		{
			Native.GetDelegateFor<glPixelDataRangeNVDelegate>()(target, length, pointer);
		}
		
		public static void glFlushPixelDataRangeNV(uint target)
		{
			Native.GetDelegateFor<glFlushPixelDataRangeNVDelegate>()(target);
		}
		
		public static void glPointParameteriNV(uint pname, int param)
		{
			Native.GetDelegateFor<glPointParameteriNVDelegate>()(pname, param);
		}
		
		public static void glPointParameterivNV(uint pname, int[] @params)
		{
			Native.GetDelegateFor<glPointParameterivNVDelegate>()(pname, @params);
		}
		
		public static void glPolygonModeNV(uint face, uint mode)
		{
			Native.GetDelegateFor<glPolygonModeNVDelegate>()(face, mode);
		}
		
		public static void glPresentFrameKeyedNV(uint video_slot, UInt64 minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint key0, uint target1, uint fill1, uint key1)
		{
			Native.GetDelegateFor<glPresentFrameKeyedNVDelegate>()(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, key0, target1, fill1, key1);
		}
		
		public static void glPresentFrameDualFillNV(uint video_slot, UInt64 minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint target1, uint fill1, uint target2, uint fill2, uint target3, uint fill3)
		{
			Native.GetDelegateFor<glPresentFrameDualFillNVDelegate>()(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, target1, fill1, target2, fill2, target3, fill3);
		}
		
		public static void glGetVideoivNV(uint video_slot, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetVideoivNVDelegate>()(video_slot, pname, @params);
		}
		
		public static void glGetVideouivNV(uint video_slot, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetVideouivNVDelegate>()(video_slot, pname, @params);
		}
		
		public static void glGetVideoi64vNV(uint video_slot, uint pname, Int64[] @params)
		{
			Native.GetDelegateFor<glGetVideoi64vNVDelegate>()(video_slot, pname, @params);
		}
		
		public static void glGetVideoui64vNV(uint video_slot, uint pname, UInt64[] @params)
		{
			Native.GetDelegateFor<glGetVideoui64vNVDelegate>()(video_slot, pname, @params);
		}
		
		public static void glPrimitiveRestartNV()
		{
			Native.GetDelegateFor<glPrimitiveRestartNVDelegate>()();
		}
		
		public static void glPrimitiveRestartIndexNV(uint index)
		{
			Native.GetDelegateFor<glPrimitiveRestartIndexNVDelegate>()(index);
		}
		
		public static void glReadBufferNV(uint mode)
		{
			Native.GetDelegateFor<glReadBufferNVDelegate>()(mode);
		}
		
		public static void glCombinerParameterfvNV(uint pname, float[] @params)
		{
			Native.GetDelegateFor<glCombinerParameterfvNVDelegate>()(pname, @params);
		}
		
		public static void glCombinerParameterfNV(uint pname, float param)
		{
			Native.GetDelegateFor<glCombinerParameterfNVDelegate>()(pname, param);
		}
		
		public static void glCombinerParameterivNV(uint pname, int[] @params)
		{
			Native.GetDelegateFor<glCombinerParameterivNVDelegate>()(pname, @params);
		}
		
		public static void glCombinerParameteriNV(uint pname, int param)
		{
			Native.GetDelegateFor<glCombinerParameteriNVDelegate>()(pname, param);
		}
		
		public static void glCombinerInputNV(uint stage, uint portion, uint variable, uint input, uint mapping, uint componentUsage)
		{
			Native.GetDelegateFor<glCombinerInputNVDelegate>()(stage, portion, variable, input, mapping, componentUsage);
		}
		
		public static void glCombinerOutputNV(uint stage, uint portion, uint abOutput, uint cdOutput, uint sumOutput, uint scale, uint bias, bool abDotProduct, bool cdDotProduct, bool muxSum)
		{
			Native.GetDelegateFor<glCombinerOutputNVDelegate>()(stage, portion, abOutput, cdOutput, sumOutput, scale, bias, abDotProduct, cdDotProduct, muxSum);
		}
		
		public static void glFinalCombinerInputNV(uint variable, uint input, uint mapping, uint componentUsage)
		{
			Native.GetDelegateFor<glFinalCombinerInputNVDelegate>()(variable, input, mapping, componentUsage);
		}
		
		public static void glGetCombinerInputParameterfvNV(uint stage, uint portion, uint variable, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetCombinerInputParameterfvNVDelegate>()(stage, portion, variable, pname, @params);
		}
		
		public static void glGetCombinerInputParameterivNV(uint stage, uint portion, uint variable, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetCombinerInputParameterivNVDelegate>()(stage, portion, variable, pname, @params);
		}
		
		public static void glGetCombinerOutputParameterfvNV(uint stage, uint portion, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetCombinerOutputParameterfvNVDelegate>()(stage, portion, pname, @params);
		}
		
		public static void glGetCombinerOutputParameterivNV(uint stage, uint portion, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetCombinerOutputParameterivNVDelegate>()(stage, portion, pname, @params);
		}
		
		public static void glGetFinalCombinerInputParameterfvNV(uint variable, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetFinalCombinerInputParameterfvNVDelegate>()(variable, pname, @params);
		}
		
		public static void glGetFinalCombinerInputParameterivNV(uint variable, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetFinalCombinerInputParameterivNVDelegate>()(variable, pname, @params);
		}
		
		public static void glCombinerStageParameterfvNV(uint stage, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glCombinerStageParameterfvNVDelegate>()(stage, pname, @params);
		}
		
		public static void glGetCombinerStageParameterfvNV(uint stage, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetCombinerStageParameterfvNVDelegate>()(stage, pname, @params);
		}
		
		public static void glFramebufferSampleLocationsfvNV(uint target, uint start, int count, float[] v)
		{
			Native.GetDelegateFor<glFramebufferSampleLocationsfvNVDelegate>()(target, start, count, v);
		}
		
		public static void glNamedFramebufferSampleLocationsfvNV(uint framebuffer, uint start, int count, float[] v)
		{
			Native.GetDelegateFor<glNamedFramebufferSampleLocationsfvNVDelegate>()(framebuffer, start, count, v);
		}
		
		public static void glResolveDepthValuesNV()
		{
			Native.GetDelegateFor<glResolveDepthValuesNVDelegate>()();
		}
		
		public static void glMakeBufferResidentNV(uint target, uint access)
		{
			Native.GetDelegateFor<glMakeBufferResidentNVDelegate>()(target, access);
		}
		
		public static void glMakeBufferNonResidentNV(uint target)
		{
			Native.GetDelegateFor<glMakeBufferNonResidentNVDelegate>()(target);
		}
		
		public static bool glIsBufferResidentNV(uint target)
		{
			return (bool)Native.GetDelegateFor<glIsBufferResidentNVDelegate>()(target);
		}
		
		public static void glMakeNamedBufferResidentNV(uint buffer, uint access)
		{
			Native.GetDelegateFor<glMakeNamedBufferResidentNVDelegate>()(buffer, access);
		}
		
		public static void glMakeNamedBufferNonResidentNV(uint buffer)
		{
			Native.GetDelegateFor<glMakeNamedBufferNonResidentNVDelegate>()(buffer);
		}
		
		public static bool glIsNamedBufferResidentNV(uint buffer)
		{
			return (bool)Native.GetDelegateFor<glIsNamedBufferResidentNVDelegate>()(buffer);
		}
		
		public static void glGetBufferParameterui64vNV(uint target, uint pname, UInt64[] @params)
		{
			Native.GetDelegateFor<glGetBufferParameterui64vNVDelegate>()(target, pname, @params);
		}
		
		public static void glGetNamedBufferParameterui64vNV(uint buffer, uint pname, UInt64[] @params)
		{
			Native.GetDelegateFor<glGetNamedBufferParameterui64vNVDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetIntegerui64vNV(uint value, UInt64[] result)
		{
			Native.GetDelegateFor<glGetIntegerui64vNVDelegate>()(value, result);
		}
		
		public static void glUniformui64NV(int location, UInt64 value)
		{
			Native.GetDelegateFor<glUniformui64NVDelegate>()(location, value);
		}
		
		public static void glUniformui64vNV(int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glUniformui64vNVDelegate>()(location, count, value);
		}
		
		public static void glProgramUniformui64NV(uint program, int location, UInt64 value)
		{
			Native.GetDelegateFor<glProgramUniformui64NVDelegate>()(program, location, value);
		}
		
		public static void glProgramUniformui64vNV(uint program, int location, int count, UInt64[] value)
		{
			Native.GetDelegateFor<glProgramUniformui64vNVDelegate>()(program, location, count, value);
		}
		
		public static void glTextureBarrierNV()
		{
			Native.GetDelegateFor<glTextureBarrierNVDelegate>()();
		}
		
		public static void glTexImage2DMultisampleCoverageNV(uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, bool fixedSampleLocations)
		{
			Native.GetDelegateFor<glTexImage2DMultisampleCoverageNVDelegate>()(target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
		}
		
		public static void glTexImage3DMultisampleCoverageNV(uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations)
		{
			Native.GetDelegateFor<glTexImage3DMultisampleCoverageNVDelegate>()(target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
		}
		
		public static void glTextureImage2DMultisampleNV(uint texture, uint target, int samples, int internalFormat, int width, int height, bool fixedSampleLocations)
		{
			Native.GetDelegateFor<glTextureImage2DMultisampleNVDelegate>()(texture, target, samples, internalFormat, width, height, fixedSampleLocations);
		}
		
		public static void glTextureImage3DMultisampleNV(uint texture, uint target, int samples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations)
		{
			Native.GetDelegateFor<glTextureImage3DMultisampleNVDelegate>()(texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations);
		}
		
		public static void glTextureImage2DMultisampleCoverageNV(uint texture, uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, bool fixedSampleLocations)
		{
			Native.GetDelegateFor<glTextureImage2DMultisampleCoverageNVDelegate>()(texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
		}
		
		public static void glTextureImage3DMultisampleCoverageNV(uint texture, uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations)
		{
			Native.GetDelegateFor<glTextureImage3DMultisampleCoverageNVDelegate>()(texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
		}
		
		public static void glBeginTransformFeedbackNV(uint primitiveMode)
		{
			Native.GetDelegateFor<glBeginTransformFeedbackNVDelegate>()(primitiveMode);
		}
		
		public static void glEndTransformFeedbackNV()
		{
			Native.GetDelegateFor<glEndTransformFeedbackNVDelegate>()();
		}
		
		public static void glTransformFeedbackAttribsNV(int count, int[] attribs, uint bufferMode)
		{
			Native.GetDelegateFor<glTransformFeedbackAttribsNVDelegate>()(count, attribs, bufferMode);
		}
		
		public static void glBindBufferRangeNV(uint target, uint index, uint buffer, nint offset, nint size)
		{
			Native.GetDelegateFor<glBindBufferRangeNVDelegate>()(target, index, buffer, offset, size);
		}
		
		public static void glBindBufferOffsetNV(uint target, uint index, uint buffer, nint offset)
		{
			Native.GetDelegateFor<glBindBufferOffsetNVDelegate>()(target, index, buffer, offset);
		}
		
		public static void glBindBufferBaseNV(uint target, uint index, uint buffer)
		{
			Native.GetDelegateFor<glBindBufferBaseNVDelegate>()(target, index, buffer);
		}
		
		public static void glTransformFeedbackVaryingsNV(uint program, int count, int[] locations, uint bufferMode)
		{
			Native.GetDelegateFor<glTransformFeedbackVaryingsNVDelegate>()(program, count, locations, bufferMode);
		}
		
		public static void glActiveVaryingNV(uint program, char[] name)
		{
			Native.GetDelegateFor<glActiveVaryingNVDelegate>()(program, name);
		}
		
		public static int glGetVaryingLocationNV(uint program, char[] name)
		{
			return (int)Native.GetDelegateFor<glGetVaryingLocationNVDelegate>()(program, name);
		}
		
		public static void glGetActiveVaryingNV(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, char[] name)
		{
			Native.GetDelegateFor<glGetActiveVaryingNVDelegate>()(program, index, bufSize, length, size, type, name);
		}
		
		public static void glGetTransformFeedbackVaryingNV(uint program, uint index, int[] location)
		{
			Native.GetDelegateFor<glGetTransformFeedbackVaryingNVDelegate>()(program, index, location);
		}
		
		public static void glTransformFeedbackStreamAttribsNV(int count, int[] attribs, int nbuffers, int[] bufstreams, uint bufferMode)
		{
			Native.GetDelegateFor<glTransformFeedbackStreamAttribsNVDelegate>()(count, attribs, nbuffers, bufstreams, bufferMode);
		}
		
		public static void glBindTransformFeedbackNV(uint target, uint id)
		{
			Native.GetDelegateFor<glBindTransformFeedbackNVDelegate>()(target, id);
		}
		
		public static void glDeleteTransformFeedbacksNV(int n, uint[] ids)
		{
			Native.GetDelegateFor<glDeleteTransformFeedbacksNVDelegate>()(n, ids);
		}
		
		public static void glGenTransformFeedbacksNV(int n, uint[] ids)
		{
			Native.GetDelegateFor<glGenTransformFeedbacksNVDelegate>()(n, ids);
		}
		
		public static bool glIsTransformFeedbackNV(uint id)
		{
			return (bool)Native.GetDelegateFor<glIsTransformFeedbackNVDelegate>()(id);
		}
		
		public static void glPauseTransformFeedbackNV()
		{
			Native.GetDelegateFor<glPauseTransformFeedbackNVDelegate>()();
		}
		
		public static void glResumeTransformFeedbackNV()
		{
			Native.GetDelegateFor<glResumeTransformFeedbackNVDelegate>()();
		}
		
		public static void glDrawTransformFeedbackNV(uint mode, uint id)
		{
			Native.GetDelegateFor<glDrawTransformFeedbackNVDelegate>()(mode, id);
		}
		
		public static void glVDPAUInitNV(nint vdpDevice, nint getProcAddress)
		{
			Native.GetDelegateFor<glVDPAUInitNVDelegate>()(vdpDevice, getProcAddress);
		}
		
		public static void glVDPAUFiniNV()
		{
			Native.GetDelegateFor<glVDPAUFiniNVDelegate>()();
		}
		
		public static nint glVDPAURegisterVideoSurfaceNV(nint vdpSurface, uint target, int numTextureNames, uint[] textureNames)
		{
			return (nint)Native.GetDelegateFor<glVDPAURegisterVideoSurfaceNVDelegate>()(vdpSurface, target, numTextureNames, textureNames);
		}
		
		public static nint glVDPAURegisterOutputSurfaceNV(nint vdpSurface, uint target, int numTextureNames, uint[] textureNames)
		{
			return (nint)Native.GetDelegateFor<glVDPAURegisterOutputSurfaceNVDelegate>()(vdpSurface, target, numTextureNames, textureNames);
		}
		
		public static bool glVDPAUIsSurfaceNV(nint surface)
		{
			return (bool)Native.GetDelegateFor<glVDPAUIsSurfaceNVDelegate>()(surface);
		}
		
		public static void glVDPAUUnregisterSurfaceNV(nint surface)
		{
			Native.GetDelegateFor<glVDPAUUnregisterSurfaceNVDelegate>()(surface);
		}
		
		public static void glVDPAUGetSurfaceivNV(nint surface, uint pname, int bufSize, int[] length, int[] values)
		{
			Native.GetDelegateFor<glVDPAUGetSurfaceivNVDelegate>()(surface, pname, bufSize, length, values);
		}
		
		public static void glVDPAUSurfaceAccessNV(nint surface, uint access)
		{
			Native.GetDelegateFor<glVDPAUSurfaceAccessNVDelegate>()(surface, access);
		}
		
		public static void glVDPAUMapSurfacesNV(int numSurfaces, nint surfaces)
		{
			Native.GetDelegateFor<glVDPAUMapSurfacesNVDelegate>()(numSurfaces, surfaces);
		}
		
		public static void glVDPAUUnmapSurfacesNV(int numSurface, nint surfaces)
		{
			Native.GetDelegateFor<glVDPAUUnmapSurfacesNVDelegate>()(numSurface, surfaces);
		}
		
		public static void glFlushVertexArrayRangeNV()
		{
			Native.GetDelegateFor<glFlushVertexArrayRangeNVDelegate>()();
		}
		
		public static void glVertexArrayRangeNV(int length, nint pointer)
		{
			Native.GetDelegateFor<glVertexArrayRangeNVDelegate>()(length, pointer);
		}
		
		public static void glVertexAttribL1i64NV(uint index, Int64 x)
		{
			Native.GetDelegateFor<glVertexAttribL1i64NVDelegate>()(index, x);
		}
		
		public static void glVertexAttribL2i64NV(uint index, Int64 x, Int64 y)
		{
			Native.GetDelegateFor<glVertexAttribL2i64NVDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribL3i64NV(uint index, Int64 x, Int64 y, Int64 z)
		{
			Native.GetDelegateFor<glVertexAttribL3i64NVDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribL4i64NV(uint index, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Native.GetDelegateFor<glVertexAttribL4i64NVDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribL1i64vNV(uint index, Int64[] v)
		{
			Native.GetDelegateFor<glVertexAttribL1i64vNVDelegate>()(index, v);
		}
		
		public static void glVertexAttribL2i64vNV(uint index, Int64[] v)
		{
			Native.GetDelegateFor<glVertexAttribL2i64vNVDelegate>()(index, v);
		}
		
		public static void glVertexAttribL3i64vNV(uint index, Int64[] v)
		{
			Native.GetDelegateFor<glVertexAttribL3i64vNVDelegate>()(index, v);
		}
		
		public static void glVertexAttribL4i64vNV(uint index, Int64[] v)
		{
			Native.GetDelegateFor<glVertexAttribL4i64vNVDelegate>()(index, v);
		}
		
		public static void glVertexAttribL1ui64NV(uint index, UInt64 x)
		{
			Native.GetDelegateFor<glVertexAttribL1ui64NVDelegate>()(index, x);
		}
		
		public static void glVertexAttribL2ui64NV(uint index, UInt64 x, UInt64 y)
		{
			Native.GetDelegateFor<glVertexAttribL2ui64NVDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribL3ui64NV(uint index, UInt64 x, UInt64 y, UInt64 z)
		{
			Native.GetDelegateFor<glVertexAttribL3ui64NVDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribL4ui64NV(uint index, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Native.GetDelegateFor<glVertexAttribL4ui64NVDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribL1ui64vNV(uint index, UInt64[] v)
		{
			Native.GetDelegateFor<glVertexAttribL1ui64vNVDelegate>()(index, v);
		}
		
		public static void glVertexAttribL2ui64vNV(uint index, UInt64[] v)
		{
			Native.GetDelegateFor<glVertexAttribL2ui64vNVDelegate>()(index, v);
		}
		
		public static void glVertexAttribL3ui64vNV(uint index, UInt64[] v)
		{
			Native.GetDelegateFor<glVertexAttribL3ui64vNVDelegate>()(index, v);
		}
		
		public static void glVertexAttribL4ui64vNV(uint index, UInt64[] v)
		{
			Native.GetDelegateFor<glVertexAttribL4ui64vNVDelegate>()(index, v);
		}
		
		public static void glGetVertexAttribLi64vNV(uint index, uint pname, Int64[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribLi64vNVDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribLui64vNV(uint index, uint pname, UInt64[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribLui64vNVDelegate>()(index, pname, @params);
		}
		
		public static void glVertexAttribLFormatNV(uint index, int size, uint type, int stride)
		{
			Native.GetDelegateFor<glVertexAttribLFormatNVDelegate>()(index, size, type, stride);
		}
		
		public static void glBufferAddressRangeNV(uint pname, uint index, UInt64 address, nint length)
		{
			Native.GetDelegateFor<glBufferAddressRangeNVDelegate>()(pname, index, address, length);
		}
		
		public static void glVertexFormatNV(int size, uint type, int stride)
		{
			Native.GetDelegateFor<glVertexFormatNVDelegate>()(size, type, stride);
		}
		
		public static void glNormalFormatNV(uint type, int stride)
		{
			Native.GetDelegateFor<glNormalFormatNVDelegate>()(type, stride);
		}
		
		public static void glColorFormatNV(int size, uint type, int stride)
		{
			Native.GetDelegateFor<glColorFormatNVDelegate>()(size, type, stride);
		}
		
		public static void glIndexFormatNV(uint type, int stride)
		{
			Native.GetDelegateFor<glIndexFormatNVDelegate>()(type, stride);
		}
		
		public static void glTexCoordFormatNV(int size, uint type, int stride)
		{
			Native.GetDelegateFor<glTexCoordFormatNVDelegate>()(size, type, stride);
		}
		
		public static void glEdgeFlagFormatNV(int stride)
		{
			Native.GetDelegateFor<glEdgeFlagFormatNVDelegate>()(stride);
		}
		
		public static void glSecondaryColorFormatNV(int size, uint type, int stride)
		{
			Native.GetDelegateFor<glSecondaryColorFormatNVDelegate>()(size, type, stride);
		}
		
		public static void glFogCoordFormatNV(uint type, int stride)
		{
			Native.GetDelegateFor<glFogCoordFormatNVDelegate>()(type, stride);
		}
		
		public static void glVertexAttribFormatNV(uint index, int size, uint type, bool normalized, int stride)
		{
			Native.GetDelegateFor<glVertexAttribFormatNVDelegate>()(index, size, type, normalized, stride);
		}
		
		public static void glVertexAttribIFormatNV(uint index, int size, uint type, int stride)
		{
			Native.GetDelegateFor<glVertexAttribIFormatNVDelegate>()(index, size, type, stride);
		}
		
		public static void glGetIntegerui64i_vNV(uint value, uint index, UInt64[] result)
		{
			Native.GetDelegateFor<glGetIntegerui64i_vNVDelegate>()(value, index, result);
		}
		
		public static bool glAreProgramsResidentNV(int n, uint[] programs, bool[] residences)
		{
			return (bool)Native.GetDelegateFor<glAreProgramsResidentNVDelegate>()(n, programs, residences);
		}
		
		public static void glBindProgramNV(uint target, uint id)
		{
			Native.GetDelegateFor<glBindProgramNVDelegate>()(target, id);
		}
		
		public static void glDeleteProgramsNV(int n, uint[] programs)
		{
			Native.GetDelegateFor<glDeleteProgramsNVDelegate>()(n, programs);
		}
		
		public static void glExecuteProgramNV(uint target, uint id, float[] @params)
		{
			Native.GetDelegateFor<glExecuteProgramNVDelegate>()(target, id, @params);
		}
		
		public static void glGenProgramsNV(int n, uint[] programs)
		{
			Native.GetDelegateFor<glGenProgramsNVDelegate>()(n, programs);
		}
		
		public static void glGetProgramParameterdvNV(uint target, uint index, uint pname, double[] @params)
		{
			Native.GetDelegateFor<glGetProgramParameterdvNVDelegate>()(target, index, pname, @params);
		}
		
		public static void glGetProgramParameterfvNV(uint target, uint index, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetProgramParameterfvNVDelegate>()(target, index, pname, @params);
		}
		
		public static void glGetProgramivNV(uint id, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetProgramivNVDelegate>()(id, pname, @params);
		}
		
		public static void glGetProgramStringNV(uint id, uint pname, byte[] program)
		{
			Native.GetDelegateFor<glGetProgramStringNVDelegate>()(id, pname, program);
		}
		
		public static void glGetTrackMatrixivNV(uint target, uint address, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetTrackMatrixivNVDelegate>()(target, address, pname, @params);
		}
		
		public static void glGetVertexAttribdvNV(uint index, uint pname, double[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribdvNVDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribfvNV(uint index, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribfvNVDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribivNV(uint index, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribivNVDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribPointervNV(uint index, uint pname, nint pointer)
		{
			Native.GetDelegateFor<glGetVertexAttribPointervNVDelegate>()(index, pname, pointer);
		}
		
		public static bool glIsProgramNV(uint id)
		{
			return (bool)Native.GetDelegateFor<glIsProgramNVDelegate>()(id);
		}
		
		public static void glLoadProgramNV(uint target, uint id, int len, byte[] program)
		{
			Native.GetDelegateFor<glLoadProgramNVDelegate>()(target, id, len, program);
		}
		
		public static void glProgramParameter4dNV(uint target, uint index, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glProgramParameter4dNVDelegate>()(target, index, x, y, z, w);
		}
		
		public static void glProgramParameter4dvNV(uint target, uint index, double[] v)
		{
			Native.GetDelegateFor<glProgramParameter4dvNVDelegate>()(target, index, v);
		}
		
		public static void glProgramParameter4fNV(uint target, uint index, float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glProgramParameter4fNVDelegate>()(target, index, x, y, z, w);
		}
		
		public static void glProgramParameter4fvNV(uint target, uint index, float[] v)
		{
			Native.GetDelegateFor<glProgramParameter4fvNVDelegate>()(target, index, v);
		}
		
		public static void glProgramParameters4dvNV(uint target, uint index, int count, double[] v)
		{
			Native.GetDelegateFor<glProgramParameters4dvNVDelegate>()(target, index, count, v);
		}
		
		public static void glProgramParameters4fvNV(uint target, uint index, int count, float[] v)
		{
			Native.GetDelegateFor<glProgramParameters4fvNVDelegate>()(target, index, count, v);
		}
		
		public static void glRequestResidentProgramsNV(int n, uint[] programs)
		{
			Native.GetDelegateFor<glRequestResidentProgramsNVDelegate>()(n, programs);
		}
		
		public static void glTrackMatrixNV(uint target, uint address, uint matrix, uint transform)
		{
			Native.GetDelegateFor<glTrackMatrixNVDelegate>()(target, address, matrix, transform);
		}
		
		public static void glVertexAttribPointerNV(uint index, int fsize, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glVertexAttribPointerNVDelegate>()(index, fsize, type, stride, pointer);
		}
		
		public static void glVertexAttrib1dNV(uint index, double x)
		{
			Native.GetDelegateFor<glVertexAttrib1dNVDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1dvNV(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttrib1dvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib1fNV(uint index, float x)
		{
			Native.GetDelegateFor<glVertexAttrib1fNVDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1fvNV(uint index, float[] v)
		{
			Native.GetDelegateFor<glVertexAttrib1fvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib1sNV(uint index, short x)
		{
			Native.GetDelegateFor<glVertexAttrib1sNVDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1svNV(uint index, short[] v)
		{
			Native.GetDelegateFor<glVertexAttrib1svNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2dNV(uint index, double x, double y)
		{
			Native.GetDelegateFor<glVertexAttrib2dNVDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2dvNV(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttrib2dvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2fNV(uint index, float x, float y)
		{
			Native.GetDelegateFor<glVertexAttrib2fNVDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2fvNV(uint index, float[] v)
		{
			Native.GetDelegateFor<glVertexAttrib2fvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2sNV(uint index, short x, short y)
		{
			Native.GetDelegateFor<glVertexAttrib2sNVDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2svNV(uint index, short[] v)
		{
			Native.GetDelegateFor<glVertexAttrib2svNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3dNV(uint index, double x, double y, double z)
		{
			Native.GetDelegateFor<glVertexAttrib3dNVDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3dvNV(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttrib3dvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3fNV(uint index, float x, float y, float z)
		{
			Native.GetDelegateFor<glVertexAttrib3fNVDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3fvNV(uint index, float[] v)
		{
			Native.GetDelegateFor<glVertexAttrib3fvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3sNV(uint index, short x, short y, short z)
		{
			Native.GetDelegateFor<glVertexAttrib3sNVDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3svNV(uint index, short[] v)
		{
			Native.GetDelegateFor<glVertexAttrib3svNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4dNV(uint index, double x, double y, double z, double w)
		{
			Native.GetDelegateFor<glVertexAttrib4dNVDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4dvNV(uint index, double[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4dvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4fNV(uint index, float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glVertexAttrib4fNVDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4fvNV(uint index, float[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4fvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4sNV(uint index, short x, short y, short z, short w)
		{
			Native.GetDelegateFor<glVertexAttrib4sNVDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4svNV(uint index, short[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4svNVDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4ubNV(uint index, byte x, byte y, byte z, byte w)
		{
			Native.GetDelegateFor<glVertexAttrib4ubNVDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4ubvNV(uint index, byte[] v)
		{
			Native.GetDelegateFor<glVertexAttrib4ubvNVDelegate>()(index, v);
		}
		
		public static void glVertexAttribs1dvNV(uint index, int count, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribs1dvNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs1fvNV(uint index, int count, float[] v)
		{
			Native.GetDelegateFor<glVertexAttribs1fvNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs1svNV(uint index, int count, short[] v)
		{
			Native.GetDelegateFor<glVertexAttribs1svNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs2dvNV(uint index, int count, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribs2dvNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs2fvNV(uint index, int count, float[] v)
		{
			Native.GetDelegateFor<glVertexAttribs2fvNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs2svNV(uint index, int count, short[] v)
		{
			Native.GetDelegateFor<glVertexAttribs2svNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs3dvNV(uint index, int count, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribs3dvNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs3fvNV(uint index, int count, float[] v)
		{
			Native.GetDelegateFor<glVertexAttribs3fvNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs3svNV(uint index, int count, short[] v)
		{
			Native.GetDelegateFor<glVertexAttribs3svNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs4dvNV(uint index, int count, double[] v)
		{
			Native.GetDelegateFor<glVertexAttribs4dvNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs4fvNV(uint index, int count, float[] v)
		{
			Native.GetDelegateFor<glVertexAttribs4fvNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs4svNV(uint index, int count, short[] v)
		{
			Native.GetDelegateFor<glVertexAttribs4svNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribs4ubvNV(uint index, int count, byte[] v)
		{
			Native.GetDelegateFor<glVertexAttribs4ubvNVDelegate>()(index, count, v);
		}
		
		public static void glVertexAttribI1iEXT(uint index, int x)
		{
			Native.GetDelegateFor<glVertexAttribI1iEXTDelegate>()(index, x);
		}
		
		public static void glVertexAttribI2iEXT(uint index, int x, int y)
		{
			Native.GetDelegateFor<glVertexAttribI2iEXTDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribI3iEXT(uint index, int x, int y, int z)
		{
			Native.GetDelegateFor<glVertexAttribI3iEXTDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribI4iEXT(uint index, int x, int y, int z, int w)
		{
			Native.GetDelegateFor<glVertexAttribI4iEXTDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribI1uiEXT(uint index, uint x)
		{
			Native.GetDelegateFor<glVertexAttribI1uiEXTDelegate>()(index, x);
		}
		
		public static void glVertexAttribI2uiEXT(uint index, uint x, uint y)
		{
			Native.GetDelegateFor<glVertexAttribI2uiEXTDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribI3uiEXT(uint index, uint x, uint y, uint z)
		{
			Native.GetDelegateFor<glVertexAttribI3uiEXTDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w)
		{
			Native.GetDelegateFor<glVertexAttribI4uiEXTDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribI1ivEXT(uint index, int[] v)
		{
			Native.GetDelegateFor<glVertexAttribI1ivEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI2ivEXT(uint index, int[] v)
		{
			Native.GetDelegateFor<glVertexAttribI2ivEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI3ivEXT(uint index, int[] v)
		{
			Native.GetDelegateFor<glVertexAttribI3ivEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4ivEXT(uint index, int[] v)
		{
			Native.GetDelegateFor<glVertexAttribI4ivEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI1uivEXT(uint index, uint[] v)
		{
			Native.GetDelegateFor<glVertexAttribI1uivEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI2uivEXT(uint index, uint[] v)
		{
			Native.GetDelegateFor<glVertexAttribI2uivEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI3uivEXT(uint index, uint[] v)
		{
			Native.GetDelegateFor<glVertexAttribI3uivEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4uivEXT(uint index, uint[] v)
		{
			Native.GetDelegateFor<glVertexAttribI4uivEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4bvEXT(uint index, byte[] v)
		{
			Native.GetDelegateFor<glVertexAttribI4bvEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4svEXT(uint index, short[] v)
		{
			Native.GetDelegateFor<glVertexAttribI4svEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4ubvEXT(uint index, byte[] v)
		{
			Native.GetDelegateFor<glVertexAttribI4ubvEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4usvEXT(uint index, ushort[] v)
		{
			Native.GetDelegateFor<glVertexAttribI4usvEXTDelegate>()(index, v);
		}
		
		public static void glVertexAttribIPointerEXT(uint index, int size, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glVertexAttribIPointerEXTDelegate>()(index, size, type, stride, pointer);
		}
		
		public static void glGetVertexAttribIivEXT(uint index, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribIivEXTDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribIuivEXT(uint index, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetVertexAttribIuivEXTDelegate>()(index, pname, @params);
		}
		
		public static void glBeginVideoCaptureNV(uint video_capture_slot)
		{
			Native.GetDelegateFor<glBeginVideoCaptureNVDelegate>()(video_capture_slot);
		}
		
		public static void glBindVideoCaptureStreamBufferNV(uint video_capture_slot, uint stream, uint frame_region, nint offset)
		{
			Native.GetDelegateFor<glBindVideoCaptureStreamBufferNVDelegate>()(video_capture_slot, stream, frame_region, offset);
		}
		
		public static void glBindVideoCaptureStreamTextureNV(uint video_capture_slot, uint stream, uint frame_region, uint target, uint texture)
		{
			Native.GetDelegateFor<glBindVideoCaptureStreamTextureNVDelegate>()(video_capture_slot, stream, frame_region, target, texture);
		}
		
		public static void glEndVideoCaptureNV(uint video_capture_slot)
		{
			Native.GetDelegateFor<glEndVideoCaptureNVDelegate>()(video_capture_slot);
		}
		
		public static void glGetVideoCaptureivNV(uint video_capture_slot, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetVideoCaptureivNVDelegate>()(video_capture_slot, pname, @params);
		}
		
		public static void glGetVideoCaptureStreamivNV(uint video_capture_slot, uint stream, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetVideoCaptureStreamivNVDelegate>()(video_capture_slot, stream, pname, @params);
		}
		
		public static void glGetVideoCaptureStreamfvNV(uint video_capture_slot, uint stream, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetVideoCaptureStreamfvNVDelegate>()(video_capture_slot, stream, pname, @params);
		}
		
		public static void glGetVideoCaptureStreamdvNV(uint video_capture_slot, uint stream, uint pname, double[] @params)
		{
			Native.GetDelegateFor<glGetVideoCaptureStreamdvNVDelegate>()(video_capture_slot, stream, pname, @params);
		}
		
		public static uint glVideoCaptureNV(uint video_capture_slot, uint[] sequence_num, UInt64[] capture_time)
		{
			return (uint)Native.GetDelegateFor<glVideoCaptureNVDelegate>()(video_capture_slot, sequence_num, capture_time);
		}
		
		public static void glVideoCaptureStreamParameterivNV(uint video_capture_slot, uint stream, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glVideoCaptureStreamParameterivNVDelegate>()(video_capture_slot, stream, pname, @params);
		}
		
		public static void glVideoCaptureStreamParameterfvNV(uint video_capture_slot, uint stream, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glVideoCaptureStreamParameterfvNVDelegate>()(video_capture_slot, stream, pname, @params);
		}
		
		public static void glVideoCaptureStreamParameterdvNV(uint video_capture_slot, uint stream, uint pname, double[] @params)
		{
			Native.GetDelegateFor<glVideoCaptureStreamParameterdvNVDelegate>()(video_capture_slot, stream, pname, @params);
		}
		
		public static void glViewportArrayvNV(uint first, int count, float[] v)
		{
			Native.GetDelegateFor<glViewportArrayvNVDelegate>()(first, count, v);
		}
		
		public static void glViewportIndexedfNV(uint index, float x, float y, float w, float h)
		{
			Native.GetDelegateFor<glViewportIndexedfNVDelegate>()(index, x, y, w, h);
		}
		
		public static void glViewportIndexedfvNV(uint index, float[] v)
		{
			Native.GetDelegateFor<glViewportIndexedfvNVDelegate>()(index, v);
		}
		
		public static void glScissorArrayvNV(uint first, int count, int[] v)
		{
			Native.GetDelegateFor<glScissorArrayvNVDelegate>()(first, count, v);
		}
		
		public static void glScissorIndexedNV(uint index, int left, int bottom, int width, int height)
		{
			Native.GetDelegateFor<glScissorIndexedNVDelegate>()(index, left, bottom, width, height);
		}
		
		public static void glScissorIndexedvNV(uint index, int[] v)
		{
			Native.GetDelegateFor<glScissorIndexedvNVDelegate>()(index, v);
		}
		
		public static void glDepthRangeArrayfvNV(uint first, int count, float[] v)
		{
			Native.GetDelegateFor<glDepthRangeArrayfvNVDelegate>()(first, count, v);
		}
		
		public static void glDepthRangeIndexedfNV(uint index, float n, float f)
		{
			Native.GetDelegateFor<glDepthRangeIndexedfNVDelegate>()(index, n, f);
		}
		
		public static void glGetFloati_vNV(uint target, uint index, float[] data)
		{
			Native.GetDelegateFor<glGetFloati_vNVDelegate>()(target, index, data);
		}
		
		public static void glEnableiNV(uint target, uint index)
		{
			Native.GetDelegateFor<glEnableiNVDelegate>()(target, index);
		}
		
		public static void glDisableiNV(uint target, uint index)
		{
			Native.GetDelegateFor<glDisableiNVDelegate>()(target, index);
		}
		
		public static bool glIsEnablediNV(uint target, uint index)
		{
			return (bool)Native.GetDelegateFor<glIsEnablediNVDelegate>()(target, index);
		}
		
		public static void glEGLImageTargetTexture2DOES(uint target, nint image)
		{
			Native.GetDelegateFor<glEGLImageTargetTexture2DOESDelegate>()(target, image);
		}
		
		public static void glEGLImageTargetRenderbufferStorageOES(uint target, nint image)
		{
			Native.GetDelegateFor<glEGLImageTargetRenderbufferStorageOESDelegate>()(target, image);
		}
		
		public static void glBlendEquationSeparateOES(uint modeRGB, uint modeAlpha)
		{
			Native.GetDelegateFor<glBlendEquationSeparateOESDelegate>()(modeRGB, modeAlpha);
		}
		
		public static void glBlendFuncSeparateOES(uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
		{
			Native.GetDelegateFor<glBlendFuncSeparateOESDelegate>()(srcRGB, dstRGB, srcAlpha, dstAlpha);
		}
		
		public static void glBlendEquationOES(uint mode)
		{
			Native.GetDelegateFor<glBlendEquationOESDelegate>()(mode);
		}
		
		public static void glMultiTexCoord1bOES(uint texture, byte s)
		{
			Native.GetDelegateFor<glMultiTexCoord1bOESDelegate>()(texture, s);
		}
		
		public static void glMultiTexCoord1bvOES(uint texture, byte[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoord1bvOESDelegate>()(texture, coords);
		}
		
		public static void glMultiTexCoord2bOES(uint texture, byte s, byte t)
		{
			Native.GetDelegateFor<glMultiTexCoord2bOESDelegate>()(texture, s, t);
		}
		
		public static void glMultiTexCoord2bvOES(uint texture, byte[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoord2bvOESDelegate>()(texture, coords);
		}
		
		public static void glMultiTexCoord3bOES(uint texture, byte s, byte t, byte r)
		{
			Native.GetDelegateFor<glMultiTexCoord3bOESDelegate>()(texture, s, t, r);
		}
		
		public static void glMultiTexCoord3bvOES(uint texture, byte[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoord3bvOESDelegate>()(texture, coords);
		}
		
		public static void glMultiTexCoord4bOES(uint texture, byte s, byte t, byte r, byte q)
		{
			Native.GetDelegateFor<glMultiTexCoord4bOESDelegate>()(texture, s, t, r, q);
		}
		
		public static void glMultiTexCoord4bvOES(uint texture, byte[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoord4bvOESDelegate>()(texture, coords);
		}
		
		public static void glTexCoord1bOES(byte s)
		{
			Native.GetDelegateFor<glTexCoord1bOESDelegate>()(s);
		}
		
		public static void glTexCoord1bvOES(byte[] coords)
		{
			Native.GetDelegateFor<glTexCoord1bvOESDelegate>()(coords);
		}
		
		public static void glTexCoord2bOES(byte s, byte t)
		{
			Native.GetDelegateFor<glTexCoord2bOESDelegate>()(s, t);
		}
		
		public static void glTexCoord2bvOES(byte[] coords)
		{
			Native.GetDelegateFor<glTexCoord2bvOESDelegate>()(coords);
		}
		
		public static void glTexCoord3bOES(byte s, byte t, byte r)
		{
			Native.GetDelegateFor<glTexCoord3bOESDelegate>()(s, t, r);
		}
		
		public static void glTexCoord3bvOES(byte[] coords)
		{
			Native.GetDelegateFor<glTexCoord3bvOESDelegate>()(coords);
		}
		
		public static void glTexCoord4bOES(byte s, byte t, byte r, byte q)
		{
			Native.GetDelegateFor<glTexCoord4bOESDelegate>()(s, t, r, q);
		}
		
		public static void glTexCoord4bvOES(byte[] coords)
		{
			Native.GetDelegateFor<glTexCoord4bvOESDelegate>()(coords);
		}
		
		public static void glVertex2bOES(byte x, byte y)
		{
			Native.GetDelegateFor<glVertex2bOESDelegate>()(x, y);
		}
		
		public static void glVertex2bvOES(byte[] coords)
		{
			Native.GetDelegateFor<glVertex2bvOESDelegate>()(coords);
		}
		
		public static void glVertex3bOES(byte x, byte y, byte z)
		{
			Native.GetDelegateFor<glVertex3bOESDelegate>()(x, y, z);
		}
		
		public static void glVertex3bvOES(byte[] coords)
		{
			Native.GetDelegateFor<glVertex3bvOESDelegate>()(coords);
		}
		
		public static void glVertex4bOES(byte x, byte y, byte z, byte w)
		{
			Native.GetDelegateFor<glVertex4bOESDelegate>()(x, y, z, w);
		}
		
		public static void glVertex4bvOES(byte[] coords)
		{
			Native.GetDelegateFor<glVertex4bvOESDelegate>()(coords);
		}
		
		public static void glCopyImageSubDataOES(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			Native.GetDelegateFor<glCopyImageSubDataOESDelegate>()(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}
		
		public static void glEnableiOES(uint target, uint index)
		{
			Native.GetDelegateFor<glEnableiOESDelegate>()(target, index);
		}
		
		public static void glDisableiOES(uint target, uint index)
		{
			Native.GetDelegateFor<glDisableiOESDelegate>()(target, index);
		}
		
		public static void glBlendEquationiOES(uint buf, uint mode)
		{
			Native.GetDelegateFor<glBlendEquationiOESDelegate>()(buf, mode);
		}
		
		public static void glBlendEquationSeparateiOES(uint buf, uint modeRGB, uint modeAlpha)
		{
			Native.GetDelegateFor<glBlendEquationSeparateiOESDelegate>()(buf, modeRGB, modeAlpha);
		}
		
		public static void glBlendFunciOES(uint buf, uint src, uint dst)
		{
			Native.GetDelegateFor<glBlendFunciOESDelegate>()(buf, src, dst);
		}
		
		public static void glBlendFuncSeparateiOES(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
		{
			Native.GetDelegateFor<glBlendFuncSeparateiOESDelegate>()(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}
		
		public static void glColorMaskiOES(uint index, bool r, bool g, bool b, bool a)
		{
			Native.GetDelegateFor<glColorMaskiOESDelegate>()(index, r, g, b, a);
		}
		
		public static bool glIsEnablediOES(uint target, uint index)
		{
			return (bool)Native.GetDelegateFor<glIsEnablediOESDelegate>()(target, index);
		}
		
		public static void glDrawElementsBaseVertexOES(uint mode, int count, uint type, nint indices, int basevertex)
		{
			Native.GetDelegateFor<glDrawElementsBaseVertexOESDelegate>()(mode, count, type, indices, basevertex);
		}
		
		public static void glDrawRangeElementsBaseVertexOES(uint mode, uint start, uint end, int count, uint type, nint indices, int basevertex)
		{
			Native.GetDelegateFor<glDrawRangeElementsBaseVertexOESDelegate>()(mode, start, end, count, type, indices, basevertex);
		}
		
		public static void glDrawElementsInstancedBaseVertexOES(uint mode, int count, uint type, nint indices, int instancecount, int basevertex)
		{
			Native.GetDelegateFor<glDrawElementsInstancedBaseVertexOESDelegate>()(mode, count, type, indices, instancecount, basevertex);
		}
		
		public static void glMultiDrawElementsBaseVertexOES(uint mode, int[] count, uint type, nint indices, int primcount, int[] basevertex)
		{
			Native.GetDelegateFor<glMultiDrawElementsBaseVertexOESDelegate>()(mode, count, type, indices, primcount, basevertex);
		}
		
		public static void glDrawTexsOES(short x, short y, short z, short width, short height)
		{
			Native.GetDelegateFor<glDrawTexsOESDelegate>()(x, y, z, width, height);
		}
		
		public static void glDrawTexiOES(int x, int y, int z, int width, int height)
		{
			Native.GetDelegateFor<glDrawTexiOESDelegate>()(x, y, z, width, height);
		}
		
		public static void glDrawTexxOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height)
		{
			Native.GetDelegateFor<glDrawTexxOESDelegate>()(x, y, z, width, height);
		}
		
		public static void glDrawTexsvOES(short[] coords)
		{
			Native.GetDelegateFor<glDrawTexsvOESDelegate>()(coords);
		}
		
		public static void glDrawTexivOES(int[] coords)
		{
			Native.GetDelegateFor<glDrawTexivOESDelegate>()(coords);
		}
		
		public static void glDrawTexxvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glDrawTexxvOESDelegate>()(coords);
		}
		
		public static void glDrawTexfOES(float x, float y, float z, float width, float height)
		{
			Native.GetDelegateFor<glDrawTexfOESDelegate>()(x, y, z, width, height);
		}
		
		public static void glDrawTexfvOES(float[] coords)
		{
			Native.GetDelegateFor<glDrawTexfvOESDelegate>()(coords);
		}
		
		public static void glAlphaFuncxOES(uint func, Int32 @ref)
		{
			Native.GetDelegateFor<glAlphaFuncxOESDelegate>()(func, @ref);
		}
		
		public static void glClearColorxOES(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			Native.GetDelegateFor<glClearColorxOESDelegate>()(red, green, blue, alpha);
		}
		
		public static void glClearDepthxOES(Int32 depth)
		{
			Native.GetDelegateFor<glClearDepthxOESDelegate>()(depth);
		}
		
		public static void glClipPlanexOES(uint plane, Int32[] equation)
		{
			Native.GetDelegateFor<glClipPlanexOESDelegate>()(plane, equation);
		}
		
		public static void glColor4xOES(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			Native.GetDelegateFor<glColor4xOESDelegate>()(red, green, blue, alpha);
		}
		
		public static void glDepthRangexOES(Int32 n, Int32 f)
		{
			Native.GetDelegateFor<glDepthRangexOESDelegate>()(n, f);
		}
		
		public static void glFogxOES(uint pname, Int32 param)
		{
			Native.GetDelegateFor<glFogxOESDelegate>()(pname, param);
		}
		
		public static void glFogxvOES(uint pname, Int32[] param)
		{
			Native.GetDelegateFor<glFogxvOESDelegate>()(pname, param);
		}
		
		public static void glFrustumxOES(Int32 l, Int32 r, Int32 b, Int32 t, Int32 n, Int32 f)
		{
			Native.GetDelegateFor<glFrustumxOESDelegate>()(l, r, b, t, n, f);
		}
		
		public static void glGetClipPlanexOES(uint plane, Int32[] equation)
		{
			Native.GetDelegateFor<glGetClipPlanexOESDelegate>()(plane, equation);
		}
		
		public static void glGetFixedvOES(uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glGetFixedvOESDelegate>()(pname, @params);
		}
		
		public static void glGetTexEnvxvOES(uint target, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glGetTexEnvxvOESDelegate>()(target, pname, @params);
		}
		
		public static void glGetTexParameterxvOES(uint target, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glGetTexParameterxvOESDelegate>()(target, pname, @params);
		}
		
		public static void glLightModelxOES(uint pname, Int32 param)
		{
			Native.GetDelegateFor<glLightModelxOESDelegate>()(pname, param);
		}
		
		public static void glLightModelxvOES(uint pname, Int32[] param)
		{
			Native.GetDelegateFor<glLightModelxvOESDelegate>()(pname, param);
		}
		
		public static void glLightxOES(uint light, uint pname, Int32 param)
		{
			Native.GetDelegateFor<glLightxOESDelegate>()(light, pname, param);
		}
		
		public static void glLightxvOES(uint light, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glLightxvOESDelegate>()(light, pname, @params);
		}
		
		public static void glLineWidthxOES(Int32 width)
		{
			Native.GetDelegateFor<glLineWidthxOESDelegate>()(width);
		}
		
		public static void glLoadMatrixxOES(Int32[] m)
		{
			Native.GetDelegateFor<glLoadMatrixxOESDelegate>()(m);
		}
		
		public static void glMaterialxOES(uint face, uint pname, Int32 param)
		{
			Native.GetDelegateFor<glMaterialxOESDelegate>()(face, pname, param);
		}
		
		public static void glMaterialxvOES(uint face, uint pname, Int32[] param)
		{
			Native.GetDelegateFor<glMaterialxvOESDelegate>()(face, pname, param);
		}
		
		public static void glMultMatrixxOES(Int32[] m)
		{
			Native.GetDelegateFor<glMultMatrixxOESDelegate>()(m);
		}
		
		public static void glMultiTexCoord4xOES(uint texture, Int32 s, Int32 t, Int32 r, Int32 q)
		{
			Native.GetDelegateFor<glMultiTexCoord4xOESDelegate>()(texture, s, t, r, q);
		}
		
		public static void glNormal3xOES(Int32 nx, Int32 ny, Int32 nz)
		{
			Native.GetDelegateFor<glNormal3xOESDelegate>()(nx, ny, nz);
		}
		
		public static void glOrthoxOES(Int32 l, Int32 r, Int32 b, Int32 t, Int32 n, Int32 f)
		{
			Native.GetDelegateFor<glOrthoxOESDelegate>()(l, r, b, t, n, f);
		}
		
		public static void glPointParameterxvOES(uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glPointParameterxvOESDelegate>()(pname, @params);
		}
		
		public static void glPointSizexOES(Int32 size)
		{
			Native.GetDelegateFor<glPointSizexOESDelegate>()(size);
		}
		
		public static void glPolygonOffsetxOES(Int32 factor, Int32 units)
		{
			Native.GetDelegateFor<glPolygonOffsetxOESDelegate>()(factor, units);
		}
		
		public static void glRotatexOES(Int32 angle, Int32 x, Int32 y, Int32 z)
		{
			Native.GetDelegateFor<glRotatexOESDelegate>()(angle, x, y, z);
		}
		
		public static void glScalexOES(Int32 x, Int32 y, Int32 z)
		{
			Native.GetDelegateFor<glScalexOESDelegate>()(x, y, z);
		}
		
		public static void glTexEnvxOES(uint target, uint pname, Int32 param)
		{
			Native.GetDelegateFor<glTexEnvxOESDelegate>()(target, pname, param);
		}
		
		public static void glTexEnvxvOES(uint target, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glTexEnvxvOESDelegate>()(target, pname, @params);
		}
		
		public static void glTexParameterxOES(uint target, uint pname, Int32 param)
		{
			Native.GetDelegateFor<glTexParameterxOESDelegate>()(target, pname, param);
		}
		
		public static void glTexParameterxvOES(uint target, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glTexParameterxvOESDelegate>()(target, pname, @params);
		}
		
		public static void glTranslatexOES(Int32 x, Int32 y, Int32 z)
		{
			Native.GetDelegateFor<glTranslatexOESDelegate>()(x, y, z);
		}
		
		public static void glGetLightxvOES(uint light, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glGetLightxvOESDelegate>()(light, pname, @params);
		}
		
		public static void glGetMaterialxvOES(uint face, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glGetMaterialxvOESDelegate>()(face, pname, @params);
		}
		
		public static void glPointParameterxOES(uint pname, Int32 param)
		{
			Native.GetDelegateFor<glPointParameterxOESDelegate>()(pname, param);
		}
		
		public static void glSampleCoveragexOES(int value, bool invert)
		{
			Native.GetDelegateFor<glSampleCoveragexOESDelegate>()(value, invert);
		}
		
		public static void glAccumxOES(uint op, Int32 value)
		{
			Native.GetDelegateFor<glAccumxOESDelegate>()(op, value);
		}
		
		public static void glBitmapxOES(int width, int height, Int32 xorig, Int32 yorig, Int32 xmove, Int32 ymove, byte[] bitmap)
		{
			Native.GetDelegateFor<glBitmapxOESDelegate>()(width, height, xorig, yorig, xmove, ymove, bitmap);
		}
		
		public static void glBlendColorxOES(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			Native.GetDelegateFor<glBlendColorxOESDelegate>()(red, green, blue, alpha);
		}
		
		public static void glClearAccumxOES(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			Native.GetDelegateFor<glClearAccumxOESDelegate>()(red, green, blue, alpha);
		}
		
		public static void glColor3xOES(Int32 red, Int32 green, Int32 blue)
		{
			Native.GetDelegateFor<glColor3xOESDelegate>()(red, green, blue);
		}
		
		public static void glColor3xvOES(Int32[] components)
		{
			Native.GetDelegateFor<glColor3xvOESDelegate>()(components);
		}
		
		public static void glColor4xvOES(Int32[] components)
		{
			Native.GetDelegateFor<glColor4xvOESDelegate>()(components);
		}
		
		public static void glConvolutionParameterxOES(uint target, uint pname, Int32 param)
		{
			Native.GetDelegateFor<glConvolutionParameterxOESDelegate>()(target, pname, param);
		}
		
		public static void glConvolutionParameterxvOES(uint target, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glConvolutionParameterxvOESDelegate>()(target, pname, @params);
		}
		
		public static void glEvalCoord1xOES(Int32 u)
		{
			Native.GetDelegateFor<glEvalCoord1xOESDelegate>()(u);
		}
		
		public static void glEvalCoord1xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glEvalCoord1xvOESDelegate>()(coords);
		}
		
		public static void glEvalCoord2xOES(Int32 u, Int32 v)
		{
			Native.GetDelegateFor<glEvalCoord2xOESDelegate>()(u, v);
		}
		
		public static void glEvalCoord2xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glEvalCoord2xvOESDelegate>()(coords);
		}
		
		public static void glFeedbackBufferxOES(int n, uint type, Int32[] buffer)
		{
			Native.GetDelegateFor<glFeedbackBufferxOESDelegate>()(n, type, buffer);
		}
		
		public static void glGetConvolutionParameterxvOES(uint target, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glGetConvolutionParameterxvOESDelegate>()(target, pname, @params);
		}
		
		public static void glGetHistogramParameterxvOES(uint target, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glGetHistogramParameterxvOESDelegate>()(target, pname, @params);
		}
		
		public static void glGetLightxOES(uint light, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glGetLightxOESDelegate>()(light, pname, @params);
		}
		
		public static void glGetMapxvOES(uint target, uint query, Int32[] v)
		{
			Native.GetDelegateFor<glGetMapxvOESDelegate>()(target, query, v);
		}
		
		public static void glGetMaterialxOES(uint face, uint pname, Int32 param)
		{
			Native.GetDelegateFor<glGetMaterialxOESDelegate>()(face, pname, param);
		}
		
		public static void glGetPixelMapxv(uint map, int size, Int32[] values)
		{
			Native.GetDelegateFor<glGetPixelMapxvDelegate>()(map, size, values);
		}
		
		public static void glGetTexGenxvOES(uint coord, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glGetTexGenxvOESDelegate>()(coord, pname, @params);
		}
		
		public static void glGetTexLevelParameterxvOES(uint target, int level, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glGetTexLevelParameterxvOESDelegate>()(target, level, pname, @params);
		}
		
		public static void glIndexxOES(Int32 component)
		{
			Native.GetDelegateFor<glIndexxOESDelegate>()(component);
		}
		
		public static void glIndexxvOES(Int32[] component)
		{
			Native.GetDelegateFor<glIndexxvOESDelegate>()(component);
		}
		
		public static void glLoadTransposeMatrixxOES(Int32[] m)
		{
			Native.GetDelegateFor<glLoadTransposeMatrixxOESDelegate>()(m);
		}
		
		public static void glMap1xOES(uint target, Int32 u1, Int32 u2, int stride, int order, Int32 points)
		{
			Native.GetDelegateFor<glMap1xOESDelegate>()(target, u1, u2, stride, order, points);
		}
		
		public static void glMap2xOES(uint target, Int32 u1, Int32 u2, int ustride, int uorder, Int32 v1, Int32 v2, int vstride, int vorder, Int32 points)
		{
			Native.GetDelegateFor<glMap2xOESDelegate>()(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		}
		
		public static void glMapGrid1xOES(int n, Int32 u1, Int32 u2)
		{
			Native.GetDelegateFor<glMapGrid1xOESDelegate>()(n, u1, u2);
		}
		
		public static void glMapGrid2xOES(int n, Int32 u1, Int32 u2, Int32 v1, Int32 v2)
		{
			Native.GetDelegateFor<glMapGrid2xOESDelegate>()(n, u1, u2, v1, v2);
		}
		
		public static void glMultTransposeMatrixxOES(Int32[] m)
		{
			Native.GetDelegateFor<glMultTransposeMatrixxOESDelegate>()(m);
		}
		
		public static void glMultiTexCoord1xOES(uint texture, Int32 s)
		{
			Native.GetDelegateFor<glMultiTexCoord1xOESDelegate>()(texture, s);
		}
		
		public static void glMultiTexCoord1xvOES(uint texture, Int32[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoord1xvOESDelegate>()(texture, coords);
		}
		
		public static void glMultiTexCoord2xOES(uint texture, Int32 s, Int32 t)
		{
			Native.GetDelegateFor<glMultiTexCoord2xOESDelegate>()(texture, s, t);
		}
		
		public static void glMultiTexCoord2xvOES(uint texture, Int32[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoord2xvOESDelegate>()(texture, coords);
		}
		
		public static void glMultiTexCoord3xOES(uint texture, Int32 s, Int32 t, Int32 r)
		{
			Native.GetDelegateFor<glMultiTexCoord3xOESDelegate>()(texture, s, t, r);
		}
		
		public static void glMultiTexCoord3xvOES(uint texture, Int32[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoord3xvOESDelegate>()(texture, coords);
		}
		
		public static void glMultiTexCoord4xvOES(uint texture, Int32[] coords)
		{
			Native.GetDelegateFor<glMultiTexCoord4xvOESDelegate>()(texture, coords);
		}
		
		public static void glNormal3xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glNormal3xvOESDelegate>()(coords);
		}
		
		public static void glPassThroughxOES(Int32 token)
		{
			Native.GetDelegateFor<glPassThroughxOESDelegate>()(token);
		}
		
		public static void glPixelMapx(uint map, int size, Int32[] values)
		{
			Native.GetDelegateFor<glPixelMapxDelegate>()(map, size, values);
		}
		
		public static void glPixelStorex(uint pname, Int32 param)
		{
			Native.GetDelegateFor<glPixelStorexDelegate>()(pname, param);
		}
		
		public static void glPixelTransferxOES(uint pname, Int32 param)
		{
			Native.GetDelegateFor<glPixelTransferxOESDelegate>()(pname, param);
		}
		
		public static void glPixelZoomxOES(Int32 xfactor, Int32 yfactor)
		{
			Native.GetDelegateFor<glPixelZoomxOESDelegate>()(xfactor, yfactor);
		}
		
		public static void glPrioritizeTexturesxOES(int n, uint[] textures, Int32[] priorities)
		{
			Native.GetDelegateFor<glPrioritizeTexturesxOESDelegate>()(n, textures, priorities);
		}
		
		public static void glRasterPos2xOES(Int32 x, Int32 y)
		{
			Native.GetDelegateFor<glRasterPos2xOESDelegate>()(x, y);
		}
		
		public static void glRasterPos2xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glRasterPos2xvOESDelegate>()(coords);
		}
		
		public static void glRasterPos3xOES(Int32 x, Int32 y, Int32 z)
		{
			Native.GetDelegateFor<glRasterPos3xOESDelegate>()(x, y, z);
		}
		
		public static void glRasterPos3xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glRasterPos3xvOESDelegate>()(coords);
		}
		
		public static void glRasterPos4xOES(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Native.GetDelegateFor<glRasterPos4xOESDelegate>()(x, y, z, w);
		}
		
		public static void glRasterPos4xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glRasterPos4xvOESDelegate>()(coords);
		}
		
		public static void glRectxOES(Int32 x1, Int32 y1, Int32 x2, Int32 y2)
		{
			Native.GetDelegateFor<glRectxOESDelegate>()(x1, y1, x2, y2);
		}
		
		public static void glRectxvOES(Int32[] v1, Int32[] v2)
		{
			Native.GetDelegateFor<glRectxvOESDelegate>()(v1, v2);
		}
		
		public static void glTexCoord1xOES(Int32 s)
		{
			Native.GetDelegateFor<glTexCoord1xOESDelegate>()(s);
		}
		
		public static void glTexCoord1xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glTexCoord1xvOESDelegate>()(coords);
		}
		
		public static void glTexCoord2xOES(Int32 s, Int32 t)
		{
			Native.GetDelegateFor<glTexCoord2xOESDelegate>()(s, t);
		}
		
		public static void glTexCoord2xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glTexCoord2xvOESDelegate>()(coords);
		}
		
		public static void glTexCoord3xOES(Int32 s, Int32 t, Int32 r)
		{
			Native.GetDelegateFor<glTexCoord3xOESDelegate>()(s, t, r);
		}
		
		public static void glTexCoord3xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glTexCoord3xvOESDelegate>()(coords);
		}
		
		public static void glTexCoord4xOES(Int32 s, Int32 t, Int32 r, Int32 q)
		{
			Native.GetDelegateFor<glTexCoord4xOESDelegate>()(s, t, r, q);
		}
		
		public static void glTexCoord4xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glTexCoord4xvOESDelegate>()(coords);
		}
		
		public static void glTexGenxOES(uint coord, uint pname, Int32 param)
		{
			Native.GetDelegateFor<glTexGenxOESDelegate>()(coord, pname, param);
		}
		
		public static void glTexGenxvOES(uint coord, uint pname, Int32[] @params)
		{
			Native.GetDelegateFor<glTexGenxvOESDelegate>()(coord, pname, @params);
		}
		
		public static void glVertex2xOES(Int32 x)
		{
			Native.GetDelegateFor<glVertex2xOESDelegate>()(x);
		}
		
		public static void glVertex2xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glVertex2xvOESDelegate>()(coords);
		}
		
		public static void glVertex3xOES(Int32 x, Int32 y)
		{
			Native.GetDelegateFor<glVertex3xOESDelegate>()(x, y);
		}
		
		public static void glVertex3xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glVertex3xvOESDelegate>()(coords);
		}
		
		public static void glVertex4xOES(Int32 x, Int32 y, Int32 z)
		{
			Native.GetDelegateFor<glVertex4xOESDelegate>()(x, y, z);
		}
		
		public static void glVertex4xvOES(Int32[] coords)
		{
			Native.GetDelegateFor<glVertex4xvOESDelegate>()(coords);
		}
		
		public static bool glIsRenderbufferOES(uint renderbuffer)
		{
			return (bool)Native.GetDelegateFor<glIsRenderbufferOESDelegate>()(renderbuffer);
		}
		
		public static void glBindRenderbufferOES(uint target, uint renderbuffer)
		{
			Native.GetDelegateFor<glBindRenderbufferOESDelegate>()(target, renderbuffer);
		}
		
		public static void glDeleteRenderbuffersOES(int n, uint[] renderbuffers)
		{
			Native.GetDelegateFor<glDeleteRenderbuffersOESDelegate>()(n, renderbuffers);
		}
		
		public static void glGenRenderbuffersOES(int n, uint[] renderbuffers)
		{
			Native.GetDelegateFor<glGenRenderbuffersOESDelegate>()(n, renderbuffers);
		}
		
		public static void glRenderbufferStorageOES(uint target, uint internalformat, int width, int height)
		{
			Native.GetDelegateFor<glRenderbufferStorageOESDelegate>()(target, internalformat, width, height);
		}
		
		public static void glGetRenderbufferParameterivOES(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetRenderbufferParameterivOESDelegate>()(target, pname, @params);
		}
		
		public static bool glIsFramebufferOES(uint framebuffer)
		{
			return (bool)Native.GetDelegateFor<glIsFramebufferOESDelegate>()(framebuffer);
		}
		
		public static void glBindFramebufferOES(uint target, uint framebuffer)
		{
			Native.GetDelegateFor<glBindFramebufferOESDelegate>()(target, framebuffer);
		}
		
		public static void glDeleteFramebuffersOES(int n, uint[] framebuffers)
		{
			Native.GetDelegateFor<glDeleteFramebuffersOESDelegate>()(n, framebuffers);
		}
		
		public static void glGenFramebuffersOES(int n, uint[] framebuffers)
		{
			Native.GetDelegateFor<glGenFramebuffersOESDelegate>()(n, framebuffers);
		}
		
		public static uint glCheckFramebufferStatusOES(uint target)
		{
			return (uint)Native.GetDelegateFor<glCheckFramebufferStatusOESDelegate>()(target);
		}
		
		public static void glFramebufferRenderbufferOES(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			Native.GetDelegateFor<glFramebufferRenderbufferOESDelegate>()(target, attachment, renderbuffertarget, renderbuffer);
		}
		
		public static void glFramebufferTexture2DOES(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			Native.GetDelegateFor<glFramebufferTexture2DOESDelegate>()(target, attachment, textarget, texture, level);
		}
		
		public static void glGetFramebufferAttachmentParameterivOES(uint target, uint attachment, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetFramebufferAttachmentParameterivOESDelegate>()(target, attachment, pname, @params);
		}
		
		public static void glGenerateMipmapOES(uint target)
		{
			Native.GetDelegateFor<glGenerateMipmapOESDelegate>()(target);
		}
		
		public static void glFramebufferTextureOES(uint target, uint attachment, uint texture, int level)
		{
			Native.GetDelegateFor<glFramebufferTextureOESDelegate>()(target, attachment, texture, level);
		}
		
		public static void glGetProgramBinaryOES(uint program, int bufSize, int[] length, uint[] binaryFormat, nint binary)
		{
			Native.GetDelegateFor<glGetProgramBinaryOESDelegate>()(program, bufSize, length, binaryFormat, binary);
		}
		
		public static void glProgramBinaryOES(uint program, uint binaryFormat, nint binary, int length)
		{
			Native.GetDelegateFor<glProgramBinaryOESDelegate>()(program, binaryFormat, binary, length);
		}
		
		public static void glMapBufferOES(uint target, uint access)
		{
			Native.GetDelegateFor<glMapBufferOESDelegate>()(target, access);
		}
		
		public static bool glUnmapBufferOES(uint target)
		{
			return (bool)Native.GetDelegateFor<glUnmapBufferOESDelegate>()(target);
		}
		
		public static void glGetBufferPointervOES(uint target, uint pname, nint @params)
		{
			Native.GetDelegateFor<glGetBufferPointervOESDelegate>()(target, pname, @params);
		}
		
		public static void glCurrentPaletteMatrixOES(uint matrixpaletteindex)
		{
			Native.GetDelegateFor<glCurrentPaletteMatrixOESDelegate>()(matrixpaletteindex);
		}
		
		public static void glLoadPaletteFromModelViewMatrixOES()
		{
			Native.GetDelegateFor<glLoadPaletteFromModelViewMatrixOESDelegate>()();
		}
		
		public static void glMatrixIndexPointerOES(int size, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glMatrixIndexPointerOESDelegate>()(size, type, stride, pointer);
		}
		
		public static void glWeightPointerOES(int size, uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glWeightPointerOESDelegate>()(size, type, stride, pointer);
		}
		
		public static void glPointSizePointerOES(uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glPointSizePointerOESDelegate>()(type, stride, pointer);
		}
		
		public static void glPrimitiveBoundingBoxOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
		{
			Native.GetDelegateFor<glPrimitiveBoundingBoxOESDelegate>()(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
		}
		
		public static uint glQueryMatrixxOES(Int32[] mantissa, int[] exponent)
		{
			return (uint)Native.GetDelegateFor<glQueryMatrixxOESDelegate>()(mantissa, exponent);
		}
		
		public static void glMinSampleShadingOES(float value)
		{
			Native.GetDelegateFor<glMinSampleShadingOESDelegate>()(value);
		}
		
		public static void glClearDepthfOES(float depth)
		{
			Native.GetDelegateFor<glClearDepthfOESDelegate>()(depth);
		}
		
		public static void glClipPlanefOES(uint plane, float[] equation)
		{
			Native.GetDelegateFor<glClipPlanefOESDelegate>()(plane, equation);
		}
		
		public static void glDepthRangefOES(float n, float f)
		{
			Native.GetDelegateFor<glDepthRangefOESDelegate>()(n, f);
		}
		
		public static void glFrustumfOES(float l, float r, float b, float t, float n, float f)
		{
			Native.GetDelegateFor<glFrustumfOESDelegate>()(l, r, b, t, n, f);
		}
		
		public static void glGetClipPlanefOES(uint plane, float[] equation)
		{
			Native.GetDelegateFor<glGetClipPlanefOESDelegate>()(plane, equation);
		}
		
		public static void glOrthofOES(float l, float r, float b, float t, float n, float f)
		{
			Native.GetDelegateFor<glOrthofOESDelegate>()(l, r, b, t, n, f);
		}
		
		public static void glPatchParameteriOES(uint pname, int value)
		{
			Native.GetDelegateFor<glPatchParameteriOESDelegate>()(pname, value);
		}
		
		public static void glTexImage3DOES(uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTexImage3DOESDelegate>()(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		
		public static void glTexSubImage3DOES(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTexSubImage3DOESDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		public static void glCopyTexSubImage3DOES(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			Native.GetDelegateFor<glCopyTexSubImage3DOESDelegate>()(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		
		public static void glCompressedTexImage3DOES(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTexImage3DOESDelegate>()(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		
		public static void glCompressedTexSubImage3DOES(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data)
		{
			Native.GetDelegateFor<glCompressedTexSubImage3DOESDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		
		public static void glFramebufferTexture3DOES(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
			Native.GetDelegateFor<glFramebufferTexture3DOESDelegate>()(target, attachment, textarget, texture, level, zoffset);
		}
		
		public static void glTexParameterIivOES(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glTexParameterIivOESDelegate>()(target, pname, @params);
		}
		
		public static void glTexParameterIuivOES(uint target, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glTexParameterIuivOESDelegate>()(target, pname, @params);
		}
		
		public static void glGetTexParameterIivOES(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetTexParameterIivOESDelegate>()(target, pname, @params);
		}
		
		public static void glGetTexParameterIuivOES(uint target, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetTexParameterIuivOESDelegate>()(target, pname, @params);
		}
		
		public static void glSamplerParameterIivOES(uint sampler, uint pname, int[] param)
		{
			Native.GetDelegateFor<glSamplerParameterIivOESDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterIuivOES(uint sampler, uint pname, uint[] param)
		{
			Native.GetDelegateFor<glSamplerParameterIuivOESDelegate>()(sampler, pname, param);
		}
		
		public static void glGetSamplerParameterIivOES(uint sampler, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetSamplerParameterIivOESDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterIuivOES(uint sampler, uint pname, uint[] @params)
		{
			Native.GetDelegateFor<glGetSamplerParameterIuivOESDelegate>()(sampler, pname, @params);
		}
		
		public static void glTexBufferOES(uint target, uint internalformat, uint buffer)
		{
			Native.GetDelegateFor<glTexBufferOESDelegate>()(target, internalformat, buffer);
		}
		
		public static void glTexBufferRangeOES(uint target, uint internalformat, uint buffer, nint offset, nint size)
		{
			Native.GetDelegateFor<glTexBufferRangeOESDelegate>()(target, internalformat, buffer, offset, size);
		}
		
		public static void glTexGenfOES(uint coord, uint pname, float param)
		{
			Native.GetDelegateFor<glTexGenfOESDelegate>()(coord, pname, param);
		}
		
		public static void glTexGenfvOES(uint coord, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glTexGenfvOESDelegate>()(coord, pname, @params);
		}
		
		public static void glTexGeniOES(uint coord, uint pname, int param)
		{
			Native.GetDelegateFor<glTexGeniOESDelegate>()(coord, pname, param);
		}
		
		public static void glTexGenivOES(uint coord, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glTexGenivOESDelegate>()(coord, pname, @params);
		}
		
		public static void glGetTexGenfvOES(uint coord, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetTexGenfvOESDelegate>()(coord, pname, @params);
		}
		
		public static void glGetTexGenivOES(uint coord, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetTexGenivOESDelegate>()(coord, pname, @params);
		}
		
		public static void glTexStorage3DMultisampleOES(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			Native.GetDelegateFor<glTexStorage3DMultisampleOESDelegate>()(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glTextureViewOES(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			Native.GetDelegateFor<glTextureViewOESDelegate>()(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}
		
		public static void glBindVertexArrayOES(uint array)
		{
			Native.GetDelegateFor<glBindVertexArrayOESDelegate>()(array);
		}
		
		public static void glDeleteVertexArraysOES(int n, uint[] arrays)
		{
			Native.GetDelegateFor<glDeleteVertexArraysOESDelegate>()(n, arrays);
		}
		
		public static void glGenVertexArraysOES(int n, uint[] arrays)
		{
			Native.GetDelegateFor<glGenVertexArraysOESDelegate>()(n, arrays);
		}
		
		public static bool glIsVertexArrayOES(uint array)
		{
			return (bool)Native.GetDelegateFor<glIsVertexArrayOESDelegate>()(array);
		}
		
		public static void glFramebufferTextureMultiviewOVR(uint target, uint attachment, uint texture, int level, int baseViewIndex, int numViews)
		{
			Native.GetDelegateFor<glFramebufferTextureMultiviewOVRDelegate>()(target, attachment, texture, level, baseViewIndex, numViews);
		}
		
		public static void glFramebufferTextureMultisampleMultiviewOVR(uint target, uint attachment, uint texture, int level, int samples, int baseViewIndex, int numViews)
		{
			Native.GetDelegateFor<glFramebufferTextureMultisampleMultiviewOVRDelegate>()(target, attachment, texture, level, samples, baseViewIndex, numViews);
		}
		
		public static void glHintPGI(uint target, int mode)
		{
			Native.GetDelegateFor<glHintPGIDelegate>()(target, mode);
		}
		
		public static void glAlphaFuncQCOM(uint func, float @ref)
		{
			Native.GetDelegateFor<glAlphaFuncQCOMDelegate>()(func, @ref);
		}
		
		public static void glGetDriverControlsQCOM(int[] num, int size, uint[] driverControls)
		{
			Native.GetDelegateFor<glGetDriverControlsQCOMDelegate>()(num, size, driverControls);
		}
		
		public static void glGetDriverControlStringQCOM(uint driverControl, int bufSize, int[] length, char[] driverControlString)
		{
			Native.GetDelegateFor<glGetDriverControlStringQCOMDelegate>()(driverControl, bufSize, length, driverControlString);
		}
		
		public static void glEnableDriverControlQCOM(uint driverControl)
		{
			Native.GetDelegateFor<glEnableDriverControlQCOMDelegate>()(driverControl);
		}
		
		public static void glDisableDriverControlQCOM(uint driverControl)
		{
			Native.GetDelegateFor<glDisableDriverControlQCOMDelegate>()(driverControl);
		}
		
		public static void glExtGetTexturesQCOM(uint[] textures, int maxTextures, int[] numTextures)
		{
			Native.GetDelegateFor<glExtGetTexturesQCOMDelegate>()(textures, maxTextures, numTextures);
		}
		
		public static void glExtGetBuffersQCOM(uint[] buffers, int maxBuffers, int[] numBuffers)
		{
			Native.GetDelegateFor<glExtGetBuffersQCOMDelegate>()(buffers, maxBuffers, numBuffers);
		}
		
		public static void glExtGetRenderbuffersQCOM(uint[] renderbuffers, int maxRenderbuffers, int[] numRenderbuffers)
		{
			Native.GetDelegateFor<glExtGetRenderbuffersQCOMDelegate>()(renderbuffers, maxRenderbuffers, numRenderbuffers);
		}
		
		public static void glExtGetFramebuffersQCOM(uint[] framebuffers, int maxFramebuffers, int[] numFramebuffers)
		{
			Native.GetDelegateFor<glExtGetFramebuffersQCOMDelegate>()(framebuffers, maxFramebuffers, numFramebuffers);
		}
		
		public static void glExtGetTexLevelParameterivQCOM(uint texture, uint face, int level, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glExtGetTexLevelParameterivQCOMDelegate>()(texture, face, level, pname, @params);
		}
		
		public static void glExtTexObjectStateOverrideiQCOM(uint target, uint pname, int param)
		{
			Native.GetDelegateFor<glExtTexObjectStateOverrideiQCOMDelegate>()(target, pname, param);
		}
		
		public static void glExtGetTexSubImageQCOM(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint texels)
		{
			Native.GetDelegateFor<glExtGetTexSubImageQCOMDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
		}
		
		public static void glExtGetBufferPointervQCOM(uint target, nint @params)
		{
			Native.GetDelegateFor<glExtGetBufferPointervQCOMDelegate>()(target, @params);
		}
		
		public static void glExtGetShadersQCOM(uint[] shaders, int maxShaders, int[] numShaders)
		{
			Native.GetDelegateFor<glExtGetShadersQCOMDelegate>()(shaders, maxShaders, numShaders);
		}
		
		public static void glExtGetProgramsQCOM(uint[] programs, int maxPrograms, int[] numPrograms)
		{
			Native.GetDelegateFor<glExtGetProgramsQCOMDelegate>()(programs, maxPrograms, numPrograms);
		}
		
		public static bool glExtIsProgramBinaryQCOM(uint program)
		{
			return (bool)Native.GetDelegateFor<glExtIsProgramBinaryQCOMDelegate>()(program);
		}
		
		public static void glExtGetProgramBinarySourceQCOM(uint program, uint shadertype, char[] source, int[] length)
		{
			Native.GetDelegateFor<glExtGetProgramBinarySourceQCOMDelegate>()(program, shadertype, source, length);
		}
		
		public static void glStartTilingQCOM(uint x, uint y, uint width, uint height, uint preserveMask)
		{
			Native.GetDelegateFor<glStartTilingQCOMDelegate>()(x, y, width, height, preserveMask);
		}
		
		public static void glEndTilingQCOM(uint preserveMask)
		{
			Native.GetDelegateFor<glEndTilingQCOMDelegate>()(preserveMask);
		}
		
		public static void glDetailTexFuncSGIS(uint target, int n, float[] points)
		{
			Native.GetDelegateFor<glDetailTexFuncSGISDelegate>()(target, n, points);
		}
		
		public static void glGetDetailTexFuncSGIS(uint target, float[] points)
		{
			Native.GetDelegateFor<glGetDetailTexFuncSGISDelegate>()(target, points);
		}
		
		public static void glFogFuncSGIS(int n, float[] points)
		{
			Native.GetDelegateFor<glFogFuncSGISDelegate>()(n, points);
		}
		
		public static void glGetFogFuncSGIS(float[] points)
		{
			Native.GetDelegateFor<glGetFogFuncSGISDelegate>()(points);
		}
		
		public static void glSampleMaskSGIS(float value, bool invert)
		{
			Native.GetDelegateFor<glSampleMaskSGISDelegate>()(value, invert);
		}
		
		public static void glSamplePatternSGIS(uint pattern)
		{
			Native.GetDelegateFor<glSamplePatternSGISDelegate>()(pattern);
		}
		
		public static void glPixelTexGenParameteriSGIS(uint pname, int param)
		{
			Native.GetDelegateFor<glPixelTexGenParameteriSGISDelegate>()(pname, param);
		}
		
		public static void glPixelTexGenParameterivSGIS(uint pname, int[] @params)
		{
			Native.GetDelegateFor<glPixelTexGenParameterivSGISDelegate>()(pname, @params);
		}
		
		public static void glPixelTexGenParameterfSGIS(uint pname, float param)
		{
			Native.GetDelegateFor<glPixelTexGenParameterfSGISDelegate>()(pname, param);
		}
		
		public static void glPixelTexGenParameterfvSGIS(uint pname, float[] @params)
		{
			Native.GetDelegateFor<glPixelTexGenParameterfvSGISDelegate>()(pname, @params);
		}
		
		public static void glGetPixelTexGenParameterivSGIS(uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetPixelTexGenParameterivSGISDelegate>()(pname, @params);
		}
		
		public static void glGetPixelTexGenParameterfvSGIS(uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetPixelTexGenParameterfvSGISDelegate>()(pname, @params);
		}
		
		public static void glPointParameterfSGIS(uint pname, float param)
		{
			Native.GetDelegateFor<glPointParameterfSGISDelegate>()(pname, param);
		}
		
		public static void glPointParameterfvSGIS(uint pname, float[] @params)
		{
			Native.GetDelegateFor<glPointParameterfvSGISDelegate>()(pname, @params);
		}
		
		public static void glSharpenTexFuncSGIS(uint target, int n, float[] points)
		{
			Native.GetDelegateFor<glSharpenTexFuncSGISDelegate>()(target, n, points);
		}
		
		public static void glGetSharpenTexFuncSGIS(uint target, float[] points)
		{
			Native.GetDelegateFor<glGetSharpenTexFuncSGISDelegate>()(target, points);
		}
		
		public static void glTexImage4DSGIS(uint target, int level, uint internalformat, int width, int height, int depth, int size4d, int border, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTexImage4DSGISDelegate>()(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels);
		}
		
		public static void glTexSubImage4DSGIS(uint target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, uint format, uint type, nint pixels)
		{
			Native.GetDelegateFor<glTexSubImage4DSGISDelegate>()(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels);
		}
		
		public static void glTextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha)
		{
			Native.GetDelegateFor<glTextureColorMaskSGISDelegate>()(red, green, blue, alpha);
		}
		
		public static void glGetTexFilterFuncSGIS(uint target, uint filter, float[] weights)
		{
			Native.GetDelegateFor<glGetTexFilterFuncSGISDelegate>()(target, filter, weights);
		}
		
		public static void glTexFilterFuncSGIS(uint target, uint filter, int n, float[] weights)
		{
			Native.GetDelegateFor<glTexFilterFuncSGISDelegate>()(target, filter, n, weights);
		}
		
		public static void glAsyncMarkerSGIX(uint marker)
		{
			Native.GetDelegateFor<glAsyncMarkerSGIXDelegate>()(marker);
		}
		
		public static int glFinishAsyncSGIX(uint[] markerp)
		{
			return (int)Native.GetDelegateFor<glFinishAsyncSGIXDelegate>()(markerp);
		}
		
		public static int glPollAsyncSGIX(uint[] markerp)
		{
			return (int)Native.GetDelegateFor<glPollAsyncSGIXDelegate>()(markerp);
		}
		
		public static uint glGenAsyncMarkersSGIX(int range)
		{
			return (uint)Native.GetDelegateFor<glGenAsyncMarkersSGIXDelegate>()(range);
		}
		
		public static void glDeleteAsyncMarkersSGIX(uint marker, int range)
		{
			Native.GetDelegateFor<glDeleteAsyncMarkersSGIXDelegate>()(marker, range);
		}
		
		public static bool glIsAsyncMarkerSGIX(uint marker)
		{
			return (bool)Native.GetDelegateFor<glIsAsyncMarkerSGIXDelegate>()(marker);
		}
		
		public static void glFlushRasterSGIX()
		{
			Native.GetDelegateFor<glFlushRasterSGIXDelegate>()();
		}
		
		public static void glFragmentColorMaterialSGIX(uint face, uint mode)
		{
			Native.GetDelegateFor<glFragmentColorMaterialSGIXDelegate>()(face, mode);
		}
		
		public static void glFragmentLightfSGIX(uint light, uint pname, float param)
		{
			Native.GetDelegateFor<glFragmentLightfSGIXDelegate>()(light, pname, param);
		}
		
		public static void glFragmentLightfvSGIX(uint light, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glFragmentLightfvSGIXDelegate>()(light, pname, @params);
		}
		
		public static void glFragmentLightiSGIX(uint light, uint pname, int param)
		{
			Native.GetDelegateFor<glFragmentLightiSGIXDelegate>()(light, pname, param);
		}
		
		public static void glFragmentLightivSGIX(uint light, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glFragmentLightivSGIXDelegate>()(light, pname, @params);
		}
		
		public static void glFragmentLightModelfSGIX(uint pname, float param)
		{
			Native.GetDelegateFor<glFragmentLightModelfSGIXDelegate>()(pname, param);
		}
		
		public static void glFragmentLightModelfvSGIX(uint pname, float[] @params)
		{
			Native.GetDelegateFor<glFragmentLightModelfvSGIXDelegate>()(pname, @params);
		}
		
		public static void glFragmentLightModeliSGIX(uint pname, int param)
		{
			Native.GetDelegateFor<glFragmentLightModeliSGIXDelegate>()(pname, param);
		}
		
		public static void glFragmentLightModelivSGIX(uint pname, int[] @params)
		{
			Native.GetDelegateFor<glFragmentLightModelivSGIXDelegate>()(pname, @params);
		}
		
		public static void glFragmentMaterialfSGIX(uint face, uint pname, float param)
		{
			Native.GetDelegateFor<glFragmentMaterialfSGIXDelegate>()(face, pname, param);
		}
		
		public static void glFragmentMaterialfvSGIX(uint face, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glFragmentMaterialfvSGIXDelegate>()(face, pname, @params);
		}
		
		public static void glFragmentMaterialiSGIX(uint face, uint pname, int param)
		{
			Native.GetDelegateFor<glFragmentMaterialiSGIXDelegate>()(face, pname, param);
		}
		
		public static void glFragmentMaterialivSGIX(uint face, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glFragmentMaterialivSGIXDelegate>()(face, pname, @params);
		}
		
		public static void glGetFragmentLightfvSGIX(uint light, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetFragmentLightfvSGIXDelegate>()(light, pname, @params);
		}
		
		public static void glGetFragmentLightivSGIX(uint light, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetFragmentLightivSGIXDelegate>()(light, pname, @params);
		}
		
		public static void glGetFragmentMaterialfvSGIX(uint face, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetFragmentMaterialfvSGIXDelegate>()(face, pname, @params);
		}
		
		public static void glGetFragmentMaterialivSGIX(uint face, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetFragmentMaterialivSGIXDelegate>()(face, pname, @params);
		}
		
		public static void glLightEnviSGIX(uint pname, int param)
		{
			Native.GetDelegateFor<glLightEnviSGIXDelegate>()(pname, param);
		}
		
		public static void glFrameZoomSGIX(int factor)
		{
			Native.GetDelegateFor<glFrameZoomSGIXDelegate>()(factor);
		}
		
		public static void glIglooInterfaceSGIX(uint pname, nint @params)
		{
			Native.GetDelegateFor<glIglooInterfaceSGIXDelegate>()(pname, @params);
		}
		
		public static int glGetInstrumentsSGIX()
		{
			return (int)Native.GetDelegateFor<glGetInstrumentsSGIXDelegate>()();
		}
		
		public static void glInstrumentsBufferSGIX(int size, int[] buffer)
		{
			Native.GetDelegateFor<glInstrumentsBufferSGIXDelegate>()(size, buffer);
		}
		
		public static int glPollInstrumentsSGIX(int[] marker_p)
		{
			return (int)Native.GetDelegateFor<glPollInstrumentsSGIXDelegate>()(marker_p);
		}
		
		public static void glReadInstrumentsSGIX(int marker)
		{
			Native.GetDelegateFor<glReadInstrumentsSGIXDelegate>()(marker);
		}
		
		public static void glStartInstrumentsSGIX()
		{
			Native.GetDelegateFor<glStartInstrumentsSGIXDelegate>()();
		}
		
		public static void glStopInstrumentsSGIX(int marker)
		{
			Native.GetDelegateFor<glStopInstrumentsSGIXDelegate>()(marker);
		}
		
		public static void glGetListParameterfvSGIX(uint list, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetListParameterfvSGIXDelegate>()(list, pname, @params);
		}
		
		public static void glGetListParameterivSGIX(uint list, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetListParameterivSGIXDelegate>()(list, pname, @params);
		}
		
		public static void glListParameterfSGIX(uint list, uint pname, float param)
		{
			Native.GetDelegateFor<glListParameterfSGIXDelegate>()(list, pname, param);
		}
		
		public static void glListParameterfvSGIX(uint list, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glListParameterfvSGIXDelegate>()(list, pname, @params);
		}
		
		public static void glListParameteriSGIX(uint list, uint pname, int param)
		{
			Native.GetDelegateFor<glListParameteriSGIXDelegate>()(list, pname, param);
		}
		
		public static void glListParameterivSGIX(uint list, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glListParameterivSGIXDelegate>()(list, pname, @params);
		}
		
		public static void glPixelTexGenSGIX(uint mode)
		{
			Native.GetDelegateFor<glPixelTexGenSGIXDelegate>()(mode);
		}
		
		public static void glDeformationMap3dSGIX(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double[] points)
		{
			Native.GetDelegateFor<glDeformationMap3dSGIXDelegate>()(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
		}
		
		public static void glDeformationMap3fSGIX(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float[] points)
		{
			Native.GetDelegateFor<glDeformationMap3fSGIXDelegate>()(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
		}
		
		public static void glDeformSGIX(uint mask)
		{
			Native.GetDelegateFor<glDeformSGIXDelegate>()(mask);
		}
		
		public static void glLoadIdentityDeformationMapSGIX(uint mask)
		{
			Native.GetDelegateFor<glLoadIdentityDeformationMapSGIXDelegate>()(mask);
		}
		
		public static void glReferencePlaneSGIX(double[] equation)
		{
			Native.GetDelegateFor<glReferencePlaneSGIXDelegate>()(equation);
		}
		
		public static void glSpriteParameterfSGIX(uint pname, float param)
		{
			Native.GetDelegateFor<glSpriteParameterfSGIXDelegate>()(pname, param);
		}
		
		public static void glSpriteParameterfvSGIX(uint pname, float[] @params)
		{
			Native.GetDelegateFor<glSpriteParameterfvSGIXDelegate>()(pname, @params);
		}
		
		public static void glSpriteParameteriSGIX(uint pname, int param)
		{
			Native.GetDelegateFor<glSpriteParameteriSGIXDelegate>()(pname, param);
		}
		
		public static void glSpriteParameterivSGIX(uint pname, int[] @params)
		{
			Native.GetDelegateFor<glSpriteParameterivSGIXDelegate>()(pname, @params);
		}
		
		public static void glTagSampleBufferSGIX()
		{
			Native.GetDelegateFor<glTagSampleBufferSGIXDelegate>()();
		}
		
		public static void glColorTableSGI(uint target, uint internalformat, int width, uint format, uint type, nint table)
		{
			Native.GetDelegateFor<glColorTableSGIDelegate>()(target, internalformat, width, format, type, table);
		}
		
		public static void glColorTableParameterfvSGI(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glColorTableParameterfvSGIDelegate>()(target, pname, @params);
		}
		
		public static void glColorTableParameterivSGI(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glColorTableParameterivSGIDelegate>()(target, pname, @params);
		}
		
		public static void glCopyColorTableSGI(uint target, uint internalformat, int x, int y, int width)
		{
			Native.GetDelegateFor<glCopyColorTableSGIDelegate>()(target, internalformat, x, y, width);
		}
		
		public static void glGetColorTableSGI(uint target, uint format, uint type, nint table)
		{
			Native.GetDelegateFor<glGetColorTableSGIDelegate>()(target, format, type, table);
		}
		
		public static void glGetColorTableParameterfvSGI(uint target, uint pname, float[] @params)
		{
			Native.GetDelegateFor<glGetColorTableParameterfvSGIDelegate>()(target, pname, @params);
		}
		
		public static void glGetColorTableParameterivSGI(uint target, uint pname, int[] @params)
		{
			Native.GetDelegateFor<glGetColorTableParameterivSGIDelegate>()(target, pname, @params);
		}
		
		public static void glFinishTextureSUNX()
		{
			Native.GetDelegateFor<glFinishTextureSUNXDelegate>()();
		}
		
		public static void glGlobalAlphaFactorbSUN(byte factor)
		{
			Native.GetDelegateFor<glGlobalAlphaFactorbSUNDelegate>()(factor);
		}
		
		public static void glGlobalAlphaFactorsSUN(short factor)
		{
			Native.GetDelegateFor<glGlobalAlphaFactorsSUNDelegate>()(factor);
		}
		
		public static void glGlobalAlphaFactoriSUN(int factor)
		{
			Native.GetDelegateFor<glGlobalAlphaFactoriSUNDelegate>()(factor);
		}
		
		public static void glGlobalAlphaFactorfSUN(float factor)
		{
			Native.GetDelegateFor<glGlobalAlphaFactorfSUNDelegate>()(factor);
		}
		
		public static void glGlobalAlphaFactordSUN(double factor)
		{
			Native.GetDelegateFor<glGlobalAlphaFactordSUNDelegate>()(factor);
		}
		
		public static void glGlobalAlphaFactorubSUN(byte factor)
		{
			Native.GetDelegateFor<glGlobalAlphaFactorubSUNDelegate>()(factor);
		}
		
		public static void glGlobalAlphaFactorusSUN(ushort factor)
		{
			Native.GetDelegateFor<glGlobalAlphaFactorusSUNDelegate>()(factor);
		}
		
		public static void glGlobalAlphaFactoruiSUN(uint factor)
		{
			Native.GetDelegateFor<glGlobalAlphaFactoruiSUNDelegate>()(factor);
		}
		
		public static void glDrawMeshArraysSUN(uint mode, int first, int count, int width)
		{
			Native.GetDelegateFor<glDrawMeshArraysSUNDelegate>()(mode, first, count, width);
		}
		
		public static void glReplacementCodeuiSUN(uint code)
		{
			Native.GetDelegateFor<glReplacementCodeuiSUNDelegate>()(code);
		}
		
		public static void glReplacementCodeusSUN(ushort code)
		{
			Native.GetDelegateFor<glReplacementCodeusSUNDelegate>()(code);
		}
		
		public static void glReplacementCodeubSUN(byte code)
		{
			Native.GetDelegateFor<glReplacementCodeubSUNDelegate>()(code);
		}
		
		public static void glReplacementCodeuivSUN(uint[] code)
		{
			Native.GetDelegateFor<glReplacementCodeuivSUNDelegate>()(code);
		}
		
		public static void glReplacementCodeusvSUN(ushort[] code)
		{
			Native.GetDelegateFor<glReplacementCodeusvSUNDelegate>()(code);
		}
		
		public static void glReplacementCodeubvSUN(byte[] code)
		{
			Native.GetDelegateFor<glReplacementCodeubvSUNDelegate>()(code);
		}
		
		public static void glReplacementCodePointerSUN(uint type, int stride, nint pointer)
		{
			Native.GetDelegateFor<glReplacementCodePointerSUNDelegate>()(type, stride, pointer);
		}
		
		public static void glColor4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y)
		{
			Native.GetDelegateFor<glColor4ubVertex2fSUNDelegate>()(r, g, b, a, x, y);
		}
		
		public static void glColor4ubVertex2fvSUN(byte[] c, float[] v)
		{
			Native.GetDelegateFor<glColor4ubVertex2fvSUNDelegate>()(c, v);
		}
		
		public static void glColor4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z)
		{
			Native.GetDelegateFor<glColor4ubVertex3fSUNDelegate>()(r, g, b, a, x, y, z);
		}
		
		public static void glColor4ubVertex3fvSUN(byte[] c, float[] v)
		{
			Native.GetDelegateFor<glColor4ubVertex3fvSUNDelegate>()(c, v);
		}
		
		public static void glColor3fVertex3fSUN(float r, float g, float b, float x, float y, float z)
		{
			Native.GetDelegateFor<glColor3fVertex3fSUNDelegate>()(r, g, b, x, y, z);
		}
		
		public static void glColor3fVertex3fvSUN(float[] c, float[] v)
		{
			Native.GetDelegateFor<glColor3fVertex3fvSUNDelegate>()(c, v);
		}
		
		public static void glNormal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z)
		{
			Native.GetDelegateFor<glNormal3fVertex3fSUNDelegate>()(nx, ny, nz, x, y, z);
		}
		
		public static void glNormal3fVertex3fvSUN(float[] n, float[] v)
		{
			Native.GetDelegateFor<glNormal3fVertex3fvSUNDelegate>()(n, v);
		}
		
		public static void glColor4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
		{
			Native.GetDelegateFor<glColor4fNormal3fVertex3fSUNDelegate>()(r, g, b, a, nx, ny, nz, x, y, z);
		}
		
		public static void glColor4fNormal3fVertex3fvSUN(float[] c, float[] n, float[] v)
		{
			Native.GetDelegateFor<glColor4fNormal3fVertex3fvSUNDelegate>()(c, n, v);
		}
		
		public static void glTexCoord2fVertex3fSUN(float s, float t, float x, float y, float z)
		{
			Native.GetDelegateFor<glTexCoord2fVertex3fSUNDelegate>()(s, t, x, y, z);
		}
		
		public static void glTexCoord2fVertex3fvSUN(float[] tc, float[] v)
		{
			Native.GetDelegateFor<glTexCoord2fVertex3fvSUNDelegate>()(tc, v);
		}
		
		public static void glTexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glTexCoord4fVertex4fSUNDelegate>()(s, t, p, q, x, y, z, w);
		}
		
		public static void glTexCoord4fVertex4fvSUN(float[] tc, float[] v)
		{
			Native.GetDelegateFor<glTexCoord4fVertex4fvSUNDelegate>()(tc, v);
		}
		
		public static void glTexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z)
		{
			Native.GetDelegateFor<glTexCoord2fColor4ubVertex3fSUNDelegate>()(s, t, r, g, b, a, x, y, z);
		}
		
		public static void glTexCoord2fColor4ubVertex3fvSUN(float[] tc, byte[] c, float[] v)
		{
			Native.GetDelegateFor<glTexCoord2fColor4ubVertex3fvSUNDelegate>()(tc, c, v);
		}
		
		public static void glTexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z)
		{
			Native.GetDelegateFor<glTexCoord2fColor3fVertex3fSUNDelegate>()(s, t, r, g, b, x, y, z);
		}
		
		public static void glTexCoord2fColor3fVertex3fvSUN(float[] tc, float[] c, float[] v)
		{
			Native.GetDelegateFor<glTexCoord2fColor3fVertex3fvSUNDelegate>()(tc, c, v);
		}
		
		public static void glTexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z)
		{
			Native.GetDelegateFor<glTexCoord2fNormal3fVertex3fSUNDelegate>()(s, t, nx, ny, nz, x, y, z);
		}
		
		public static void glTexCoord2fNormal3fVertex3fvSUN(float[] tc, float[] n, float[] v)
		{
			Native.GetDelegateFor<glTexCoord2fNormal3fVertex3fvSUNDelegate>()(tc, n, v);
		}
		
		public static void glTexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
		{
			Native.GetDelegateFor<glTexCoord2fColor4fNormal3fVertex3fSUNDelegate>()(s, t, r, g, b, a, nx, ny, nz, x, y, z);
		}
		
		public static void glTexCoord2fColor4fNormal3fVertex3fvSUN(float[] tc, float[] c, float[] n, float[] v)
		{
			Native.GetDelegateFor<glTexCoord2fColor4fNormal3fVertex3fvSUNDelegate>()(tc, c, n, v);
		}
		
		public static void glTexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w)
		{
			Native.GetDelegateFor<glTexCoord4fColor4fNormal3fVertex4fSUNDelegate>()(s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w);
		}
		
		public static void glTexCoord4fColor4fNormal3fVertex4fvSUN(float[] tc, float[] c, float[] n, float[] v)
		{
			Native.GetDelegateFor<glTexCoord4fColor4fNormal3fVertex4fvSUNDelegate>()(tc, c, n, v);
		}
		
		public static void glReplacementCodeuiVertex3fSUN(uint rc, float x, float y, float z)
		{
			Native.GetDelegateFor<glReplacementCodeuiVertex3fSUNDelegate>()(rc, x, y, z);
		}
		
		public static void glReplacementCodeuiVertex3fvSUN(uint[] rc, float[] v)
		{
			Native.GetDelegateFor<glReplacementCodeuiVertex3fvSUNDelegate>()(rc, v);
		}
		
		public static void glReplacementCodeuiColor4ubVertex3fSUN(uint rc, byte r, byte g, byte b, byte a, float x, float y, float z)
		{
			Native.GetDelegateFor<glReplacementCodeuiColor4ubVertex3fSUNDelegate>()(rc, r, g, b, a, x, y, z);
		}
		
		public static void glReplacementCodeuiColor4ubVertex3fvSUN(uint[] rc, byte[] c, float[] v)
		{
			Native.GetDelegateFor<glReplacementCodeuiColor4ubVertex3fvSUNDelegate>()(rc, c, v);
		}
		
		public static void glReplacementCodeuiColor3fVertex3fSUN(uint rc, float r, float g, float b, float x, float y, float z)
		{
			Native.GetDelegateFor<glReplacementCodeuiColor3fVertex3fSUNDelegate>()(rc, r, g, b, x, y, z);
		}
		
		public static void glReplacementCodeuiColor3fVertex3fvSUN(uint[] rc, float[] c, float[] v)
		{
			Native.GetDelegateFor<glReplacementCodeuiColor3fVertex3fvSUNDelegate>()(rc, c, v);
		}
		
		public static void glReplacementCodeuiNormal3fVertex3fSUN(uint rc, float nx, float ny, float nz, float x, float y, float z)
		{
			Native.GetDelegateFor<glReplacementCodeuiNormal3fVertex3fSUNDelegate>()(rc, nx, ny, nz, x, y, z);
		}
		
		public static void glReplacementCodeuiNormal3fVertex3fvSUN(uint[] rc, float[] n, float[] v)
		{
			Native.GetDelegateFor<glReplacementCodeuiNormal3fVertex3fvSUNDelegate>()(rc, n, v);
		}
		
		public static void glReplacementCodeuiColor4fNormal3fVertex3fSUN(uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
		{
			Native.GetDelegateFor<glReplacementCodeuiColor4fNormal3fVertex3fSUNDelegate>()(rc, r, g, b, a, nx, ny, nz, x, y, z);
		}
		
		public static void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(uint[] rc, float[] c, float[] n, float[] v)
		{
			Native.GetDelegateFor<glReplacementCodeuiColor4fNormal3fVertex3fvSUNDelegate>()(rc, c, n, v);
		}
		
		public static void glReplacementCodeuiTexCoord2fVertex3fSUN(uint rc, float s, float t, float x, float y, float z)
		{
			Native.GetDelegateFor<glReplacementCodeuiTexCoord2fVertex3fSUNDelegate>()(rc, s, t, x, y, z);
		}
		
		public static void glReplacementCodeuiTexCoord2fVertex3fvSUN(uint[] rc, float[] tc, float[] v)
		{
			Native.GetDelegateFor<glReplacementCodeuiTexCoord2fVertex3fvSUNDelegate>()(rc, tc, v);
		}
		
		public static void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z)
		{
			Native.GetDelegateFor<glReplacementCodeuiTexCoord2fNormal3fVertex3fSUNDelegate>()(rc, s, t, nx, ny, nz, x, y, z);
		}
		
		public static void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(uint[] rc, float[] tc, float[] n, float[] v)
		{
			Native.GetDelegateFor<glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUNDelegate>()(rc, tc, n, v);
		}
		
		public static void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
		{
			Native.GetDelegateFor<glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUNDelegate>()(rc, s, t, r, g, b, a, nx, ny, nz, x, y, z);
		}
		
		public static void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(uint[] rc, float[] tc, float[] c, float[] n, float[] v)
		{
			Native.GetDelegateFor<glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUNDelegate>()(rc, tc, c, n, v);
		}
		
		#endregion
	}
}
