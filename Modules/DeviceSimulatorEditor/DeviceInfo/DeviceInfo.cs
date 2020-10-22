// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using System.IO;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.DeviceSimulation
{
    [Serializable]
    internal class DeviceInfo
    {
        public string friendlyName;
        public int version;

        public ScreenData[] screens;
        public SystemInfoData systemInfo;

        public override string ToString()
        {
            return friendlyName;
        }

        public string directory;

        public bool IsAndroidDevice()
        {
            return IsGivenDevice("android");
        }

        public bool IsiOSDevice()
        {
            return IsGivenDevice("ios");
        }

        internal bool IsMobileDevice()
        {
            return IsAndroidDevice() || IsiOSDevice();
        }

        internal bool IsConsoleDevice()
        {
            return false; // Return false for now, should revisit when adding console devices.
        }

        private bool IsGivenDevice(string os)
        {
            return systemInfo?.operatingSystem.ToLower().Contains(os) ?? false;
        }

        internal void AddOptionalFields()
        {
            foreach (var screen in screens)
            {
                if (screen.orientations == null || screen.orientations.Length == 0)
                {
                    screen.orientations = new[]
                    {
                        new OrientationData {orientation = ScreenOrientation.Portrait},
                        new OrientationData {orientation = ScreenOrientation.PortraitUpsideDown},
                        new OrientationData {orientation = ScreenOrientation.LandscapeLeft},
                        new OrientationData {orientation = ScreenOrientation.LandscapeRight}
                    };
                }
                foreach (var orientation in screen.orientations)
                {
                    if (orientation.safeArea == Rect.zero)
                        orientation.safeArea = SimulatorUtilities.IsLandscape(orientation.orientation) ? new Rect(0, 0, screen.height, screen.width) : new Rect(0, 0, screen.width, screen.height);
                }
            }
        }

        public bool LoadOverlayImage(int screenIndex)
        {
            var screen = screens[screenIndex];
            var path = screen.presentation.overlayPath;

            if (string.IsNullOrEmpty(path))
                return false;

            // If overlay path starts with Assets or Packages we assume that it is the full path,
            // that way overlays can be stored independently from the device asset. If the path
            // starts with some other symbol we assume that it is relative to the device asset itself.
            if (!path.StartsWith("Assets/") && !path.StartsWith("Packages/"))
                path = Path.Combine(directory, path);

            screen.presentation.overlay = AssetDatabase.LoadAssetAtPath<Texture>(path);
            return screen.presentation.overlay != null;
        }
    }

    [Serializable]
    internal class ScreenPresentation
    {
        public string overlayPath;
        public Vector4 borderSize;
        public float cornerRadius;
        [NonSerialized] public Texture overlay;
    }

    [Serializable]
    internal class ScreenData
    {
        public int width;
        public int height;
        public int navigationBarHeight;
        public float dpi;
        public OrientationData[] orientations;
        public ScreenPresentation presentation;
    }

    [Serializable]
    internal class OrientationData
    {
        public ScreenOrientation orientation;
        public Rect safeArea;
        public Rect[] cutouts;
    }

    [Serializable]
    internal class SystemInfoData
    {
        public string deviceModel;
        public DeviceType deviceType;
        public string operatingSystem;
        public OperatingSystemFamily operatingSystemFamily;
        public int processorCount;
        public int processorFrequency;
        public string processorType;
        public bool supportsAccelerometer;
        public bool supportsAudio;
        public bool supportsGyroscope;
        public bool supportsLocationService;
        public bool supportsVibration;
        public int systemMemorySize;
        public string unsupportedIdentifier;
        public GraphicsSystemInfoData[] graphicsDependentData;
    }

    [Serializable]
    internal class GraphicsSystemInfoData
    {
        public GraphicsDeviceType graphicsDeviceType;
        public int graphicsMemorySize;
        public string graphicsDeviceName;
        public string graphicsDeviceVendor;
        public int graphicsDeviceID;
        public int graphicsDeviceVendorID;
        public bool graphicsUVStartsAtTop;
        public string graphicsDeviceVersion;
        public int graphicsShaderLevel;
        public bool graphicsMultiThreaded;
        public RenderingThreadingMode renderingThreadingMode;
        public bool hasHiddenSurfaceRemovalOnGPU;
        public bool hasDynamicUniformArrayIndexingInFragmentShaders;
        public bool supportsShadows;
        public bool supportsRawShadowDepthSampling;
        public bool supportsMotionVectors;
        public bool supports3DTextures;
        public bool supports2DArrayTextures;
        public bool supports3DRenderTextures;
        public bool supportsCubemapArrayTextures;
        public CopyTextureSupport copyTextureSupport;
        public bool supportsComputeShaders;
        public bool supportsGeometryShaders;
        public bool supportsTessellationShaders;
        public bool supportsInstancing;
        public bool supportsHardwareQuadTopology;
        public bool supports32bitsIndexBuffer;
        public bool supportsSparseTextures;
        public int supportedRenderTargetCount;
        public bool supportsSeparatedRenderTargetsBlend;
        public int supportedRandomWriteTargetCount;
        public int supportsMultisampledTextures;
        public bool supportsMultisampleAutoResolve;
        public int supportsTextureWrapMirrorOnce;
        public bool usesReversedZBuffer;
        public NPOTSupport npotSupport;
        public int maxTextureSize;
        public int maxCubemapSize;
        public int maxComputeBufferInputsVertex;
        public int maxComputeBufferInputsFragment;
        public int maxComputeBufferInputsGeometry;
        public int maxComputeBufferInputsDomain;
        public int maxComputeBufferInputsHull;
        public int maxComputeBufferInputsCompute;
        public int maxComputeWorkGroupSize;
        public int maxComputeWorkGroupSizeX;
        public int maxComputeWorkGroupSizeY;
        public int maxComputeWorkGroupSizeZ;
        public bool supportsAsyncCompute;
        public bool supportsGraphicsFence;
        public bool supportsAsyncGPUReadback;
        public bool supportsRayTracing;
        public bool supportsSetConstantBuffer;
        public bool hasMipMaxLevel;
        public bool supportsMipStreaming;
        public bool usesLoadStoreActions;
    }
}