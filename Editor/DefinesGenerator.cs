namespace ME.ECSEditor.FPMath {
    
    using ME.ECS;

    [UnityEditor.InitializeOnLoadAttribute]
    public static class DefinesGenerator {

        static DefinesGenerator() {

            /*InitializerEditor.buildConfiguration += (configuration) => {
                
                configuration.defines.Add(new ME.ECS.InitializerBase.Configuration.Define() {
                    enabled = true,
                    name = "FIXED_POINT_MATH",
                });
                return configuration;

            };*/
            InitializerEditor.getAdditionalDefines += () => {

                var item = new InitializerBase.DefineInfo(true, "FIXED_POINT_MATH", "Fixed-Point Math.", () => {
                    #if FIXED_POINT_MATH
                    return true;
                    #else
                    return false;
                    #endif
                }, true, InitializerBase.ConfigurationType.DebugAndRelease, InitializerBase.CodeSize.Normal, InitializerBase.RuntimeSpeed.Normal);

                return new InitializerBase.DefineInfo[] { item };
                    
            };

        }
        
    }

}
